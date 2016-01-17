using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using MatrimonyServices.Business;
using MatrimonyServices.Interfaces;

namespace MatrimonyServices.Behaviors
{
    public class TokenValidationInspector : IDispatchMessageInspector
    {
        public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            // Return BadRequest if request is null
            if (WebOperationContext.Current == null) { throw new WebFaultException(HttpStatusCode.BadRequest); }

            // Get Token from header
            var token = WebOperationContext.Current.IncomingRequest.Headers["Token"];

            // Validate the Token
            using (var dbContext = new MatrimonyEntities())
            {
                ITokenValidator validator = new DatabaseTokenValidator(dbContext);
                if (!validator.IsValid(token))
                {
                    throw new WebFaultException(HttpStatusCode.Forbidden);
                }
                // Add User ids to the header so the service has them if needed
                WebOperationContext.Current.IncomingRequest.Headers.Add("User", validator.Token.Id.ToString());
               // WebOperationContext.Current.IncomingRequest.Headers.Add("UserId", validator.Token.user.id.ToString());
            }
            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
        }
    }
}
