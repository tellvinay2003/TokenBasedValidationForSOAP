using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Services.Protocols;
namespace ValidationUtility
{
    public class SecuredToken : SoapHeader
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string AuthenticationToken { get; set; }


        public bool IfUserCredentialIsValid(string userName, string password)
        {
            var result = userName.Equals("admin") && password.Equals("pwd");
            return result;
        }

        public bool IfUserCredentialIsValid(SecuredToken soapHeader)
        {
            if (soapHeader == null)
                return false;
            if (!string.IsNullOrEmpty(soapHeader.AuthenticationToken))
            {
                //return (HttpRuntime.Cache[soapHeader.AuthenticationToken] != null);
                // return (!string.IsNullOrEmpty(soapHeader.AuthenticationToken));
                return (IsValid(soapHeader.AuthenticationToken));
            }

            return false;
        }

        private bool IsValid(string authenticationToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = GetValidationParameters();

            SecurityToken validatedToken;
            var tokenstring = authenticationToken.Substring(7);
            IPrincipal principal = tokenHandler.ValidateToken(tokenstring, validationParameters, out validatedToken);
            return true;
        }

        private static TokenValidationParameters GetValidationParameters()
        {
            string key = "OdlSecretKeyForAuthentication"; // the key used to generate jwt
            return new TokenValidationParameters()
            {
                RequireExpirationTime = true,
                ValidateLifetime = false, // Because there is no expiration in the generated token
                ValidateAudience = false, // Because there is no audiance in the generated token
                ValidateIssuer = false,   // Because there is no issuer in the generated token
                ValidIssuer = "Sample",
                ValidAudience = "Sample",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)) // The same key as the one that generate the token
            };
        }
    }
}