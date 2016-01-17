using System;
using System.Linq;
using MatrimonyServices.Interfaces;

namespace MatrimonyServices.Business
{
    public class DatabaseTokenValidator : ITokenValidator
    {
        // Todo: Set this from a web.config appSettting value
        public static double DefaultSecondsUntilTokenExpires = 1800;

        private readonly MatrimonyEntities _DbContext;

        public DatabaseTokenValidator(MatrimonyEntities dbContext)
        {
            _DbContext = dbContext;
        }

        public bool IsValid(string tokentext)
        {
            var data = _DbContext.Tokens.ToList();
            Token = _DbContext.Tokens.SingleOrDefault(t => t.Tokenn == tokentext);
            return Token != null && !IsExpired(Token);
        }

        internal bool IsExpired(Token token)
        {
            var span = DateTime.Now - token.CreateDate;
            return span.TotalSeconds > DefaultSecondsUntilTokenExpires;
        }

        public Token Token { get; set; }
    }
}