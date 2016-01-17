using System;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Data;
using MatrimonyServices.Interfaces;

namespace MatrimonyServices.Business
{
    public class DatabaseTokenBuilder : ITokenBuilder
    {
        public static int TokenSize = 100;
        private readonly MatrimonyEntities _DbContext;

        public DatabaseTokenBuilder(MatrimonyEntities dbContext)
        {
            _DbContext = dbContext;
        }

        public string Build(user creds)
        {
            if (!new DatabaseCredentialsValidator(_DbContext).IsValid(creds))
            {
                throw new AuthenticationException();
            }
            long ID = _DbContext.users.Where(u => u.username.Equals(creds.username, StringComparison.CurrentCultureIgnoreCase)).ToList()[0].id;
            var UserTokenObj = _DbContext.Tokens.SingleOrDefault(x => x.user.id == ID);
            var token = BuildSecureToken(TokenSize);
            var user = _DbContext.users.SingleOrDefault(u => u.username.Equals(creds.username, StringComparison.CurrentCultureIgnoreCase));
            if (UserTokenObj!=null)
            { 
            //Update if Token Exist
                UserTokenObj.Tokenn = token;
                UserTokenObj.CreateDate = DateTime.Now;
                _DbContext.ObjectStateManager.ChangeObjectState(UserTokenObj, System.Data.EntityState.Modified);
                //_DbContext.Entry(UserTokenObj).State = System.Data.Entity.EntityState.Modified;
                _DbContext.SaveChanges();
            }
            else
            {
               //Insert if Token Not Exist
                _DbContext.Tokens.AddObject(new Token { Tokenn = token, user = user, CreateDate = DateTime.Now });
                _DbContext.SaveChanges();
            }
            
            return token;
        }

        private string BuildSecureToken(int length)
        {
            var buffer = new byte[length];
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetNonZeroBytes(buffer);
            }
            return Convert.ToBase64String(buffer);
        }
    }
}