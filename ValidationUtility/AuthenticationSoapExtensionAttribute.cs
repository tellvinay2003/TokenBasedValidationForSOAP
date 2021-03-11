using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace ValidationUtility
{
   public class AuthenticationSoapExtensionAttribute : SoapExtensionAttribute
    {
        private int priority;

        public AuthenticationSoapExtensionAttribute()
        {
        }

        public override Type ExtensionType
        {
            get
            {
                return typeof(AuthenticationSoapExtension);
            }
        }

        public override int Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }
    }
}

