using System;
using System.Linq;
using MatrimonyServices.Interfaces;

namespace MatrimonyServices.Business
{
    public class DatabaseCredentialsValidator : ICredentialsValidator
    {
        private readonly MatrimonyEntities _DbContext;

        public DatabaseCredentialsValidator(MatrimonyEntities dbContext)
        {
            _DbContext = dbContext;
        }

        public bool IsValid(user userobj)
        {
            var user = _DbContext.users.SingleOrDefault(u => u.username.Equals(userobj.username, StringComparison.CurrentCultureIgnoreCase));
            //return user != null && Hash.Compare(userobj.password, user.Salt, user.Password, Hash.DefaultHashType, Hash.DefaultEncoding);
            return user != null && (userobj.password == user.password);
        }
    }
}