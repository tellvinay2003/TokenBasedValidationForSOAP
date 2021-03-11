using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Services;
using System.Web.Services.Protocols;
using ValidationUtility;

namespace TokenBasedAuthenticationInWebService
{
    /// <summary>
    /// Summary description for AuthToken
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AuthToken : System.Web.Services.WebService
    {
        public SecuredToken soapHeader;

        [WebMethod]
        [SoapHeader("soapHeader", Required =true)]
        [AuthenticationSoapExtension]
        public string AuthenticateUser()
        {
            if (soapHeader == null)
                return "please provide UserName and Password";
            if (string.IsNullOrEmpty(soapHeader.UserName) || string.IsNullOrEmpty(soapHeader.Password))
                return "please provide UserName and Password";

            if (!soapHeader.IfUserCredentialIsValid(soapHeader.UserName, soapHeader.Password))
                return "invalid UserName or Password";

            string token = Guid.NewGuid().ToString();
            HttpRuntime.Cache.Add
                (token, soapHeader,null,Cache.NoAbsoluteExpiration,TimeSpan.FromMinutes(30),
                CacheItemPriority.NotRemovable, null
                );
            return token;
        }


        [WebMethod]
        [SoapHeader("soapHeader")]
        [AuthenticationSoapExtension]
        public string HelloWorld()
        {
            if (soapHeader == null)
                return "Call AuthenticateUser method first";

            if(!soapHeader.IfUserCredentialIsValid(soapHeader))
                return "Call AuthenticateUser method first";

            return "Hello "+ soapHeader.AuthenticationToken;
        }


        [WebMethod]
        [SoapHeader("soapHeader", Required = true)]
        [AuthenticationSoapExtension]
        public string CheckAccess()
        {
            if (soapHeader == null)
                return "Call AuthenticateUser method first";
            if (!soapHeader.IfUserCredentialIsValid(soapHeader))
                return "Call AuthenticateUser method first";
            var headers = HttpContext.Current.Request.Headers;

            return "Hello " + soapHeader.AuthenticationToken;
            // return "Accessible: " + headers["Token"] + ": Value";
        }

        [WebMethod]
        [SoapHeader("soapHeader")]
        [AuthenticationSoapExtension]
        public int Factorial(int input)
        {
          
            if (input == 1)
                return 1;
            else
                return input * Factorial(input - 1);
        }

    }
}
