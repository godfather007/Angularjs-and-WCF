using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MatrimonyServices.Business;
using Newtonsoft.Json;

namespace MatrimonyServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Account" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Account.svc or Account.svc.cs at the Solution Explorer and start debugging.
    public class Account : IAccount
    {
        private MatrimonyEntities Entities = new MatrimonyEntities();
        public string login(string user)
        {
            user userobj = (user)JsonConvert.DeserializeObject(user, typeof(user));
            using (var dbContext = new MatrimonyEntities())
            {
                return new DatabaseTokenBuilder(dbContext).Build(userobj);
            }
        }
    }
}
