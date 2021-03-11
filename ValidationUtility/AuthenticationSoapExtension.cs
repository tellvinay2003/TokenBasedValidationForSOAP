using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace ValidationUtility
{
    public class AuthenticationSoapExtension : SoapExtension
    {
        private SecuredToken authHeader;

        public AuthenticationSoapExtension()
        {
        }

        public override object GetInitializer(Type serviceType)
        {
            return null;
        }

        public override object GetInitializer(LogicalMethodInfo methodInfo, SoapExtensionAttribute attribute)
        {
            return null;
        }

        public override void Initialize(object initializer)
        {
        }

        public override void ProcessMessage(SoapMessage message)
        {
            if (message.Stage == SoapMessageStage.AfterDeserialize)
            {
                foreach (SoapHeader header in message.Headers)
                {
                    if (header is SecuredToken)
                    {
                        authHeader = (SecuredToken)header;

                        // if (authHeader.Password.Equals("pwd"))
                        if (! string.IsNullOrEmpty(authHeader.AuthenticationToken))
                        {
                            if (!string.IsNullOrEmpty(authHeader.AuthenticationToken))
                            {
                                if (authHeader.IfUserCredentialIsValid(authHeader))
                                {
                                    return;
                                }
                            }
                        }
                    }
                }

                throw new SoapException("Unauthorized", SoapException.ClientFaultCode);
            }
        }
    }
}
