using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenBasedAuthenticationInWebService
{
    //public class SecuredToken : System.Web.Services.Protocols.SoapHeader
    //{
    //    public string UserName { get; set; }
    //    public string Password { get; set; }

    //    public string AuthenticationToken { get; set; }


    //    public bool IfUserCredentialIsValid(string userName, string password)
    //    {
    //        var result = userName.Equals("admin") && password.Equals("pwd");
    //        return result;
    //    }

    //    public bool IfUserCredentialIsValid(SecuredToken soapHeader)
    //    {
    //        if (soapHeader == null)
    //            return false;
    //        if (!string.IsNullOrEmpty(soapHeader.AuthenticationToken))
    //        {
    //            //return (HttpRuntime.Cache[soapHeader.AuthenticationToken] != null);
    //            return (!string.IsNullOrEmpty(soapHeader.AuthenticationToken));
    //        }

    //        return false;
    //    }

    //}
}