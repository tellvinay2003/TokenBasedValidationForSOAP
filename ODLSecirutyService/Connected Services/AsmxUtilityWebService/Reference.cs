﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsmxUtilityWebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AsmxUtilityWebService.AuthTokenSoap")]
    public interface AuthTokenSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthenticateUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<AsmxUtilityWebService.AuthenticateUserResponse> AuthenticateUserAsync(AsmxUtilityWebService.AuthenticateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<AsmxUtilityWebService.HelloWorldResponse> HelloWorldAsync(AsmxUtilityWebService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckAccess", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<AsmxUtilityWebService.CheckAccessResponse> CheckAccessAsync(AsmxUtilityWebService.CheckAccessRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Factorial", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<AsmxUtilityWebService.FactorialResponse> FactorialAsync(AsmxUtilityWebService.FactorialRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SecuredToken
    {
        
        private string userNameField;
        
        private string passwordField;
        
        private string authenticationTokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string AuthenticationToken
        {
            get
            {
                return this.authenticationTokenField;
            }
            set
            {
                this.authenticationTokenField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticateUser", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthenticateUserRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public AsmxUtilityWebService.SecuredToken SecuredToken;
        
        public AuthenticateUserRequest()
        {
        }
        
        public AuthenticateUserRequest(AsmxUtilityWebService.SecuredToken SecuredToken)
        {
            this.SecuredToken = SecuredToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticateUserResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthenticateUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string AuthenticateUserResult;
        
        public AuthenticateUserResponse()
        {
        }
        
        public AuthenticateUserResponse(string AuthenticateUserResult)
        {
            this.AuthenticateUserResult = AuthenticateUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloWorld", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class HelloWorldRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public AsmxUtilityWebService.SecuredToken SecuredToken;
        
        public HelloWorldRequest()
        {
        }
        
        public HelloWorldRequest(AsmxUtilityWebService.SecuredToken SecuredToken)
        {
            this.SecuredToken = SecuredToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloWorldResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class HelloWorldResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponse()
        {
        }
        
        public HelloWorldResponse(string HelloWorldResult)
        {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckAccess", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CheckAccessRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public AsmxUtilityWebService.SecuredToken SecuredToken;
        
        public CheckAccessRequest()
        {
        }
        
        public CheckAccessRequest(AsmxUtilityWebService.SecuredToken SecuredToken)
        {
            this.SecuredToken = SecuredToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckAccessResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CheckAccessResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string CheckAccessResult;
        
        public CheckAccessResponse()
        {
        }
        
        public CheckAccessResponse(string CheckAccessResult)
        {
            this.CheckAccessResult = CheckAccessResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Factorial", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FactorialRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public AsmxUtilityWebService.SecuredToken SecuredToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int input;
        
        public FactorialRequest()
        {
        }
        
        public FactorialRequest(AsmxUtilityWebService.SecuredToken SecuredToken, int input)
        {
            this.SecuredToken = SecuredToken;
            this.input = input;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FactorialResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FactorialResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int FactorialResult;
        
        public FactorialResponse()
        {
        }
        
        public FactorialResponse(int FactorialResult)
        {
            this.FactorialResult = FactorialResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface AuthTokenSoapChannel : AsmxUtilityWebService.AuthTokenSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class AuthTokenSoapClient : System.ServiceModel.ClientBase<AsmxUtilityWebService.AuthTokenSoap>, AsmxUtilityWebService.AuthTokenSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AuthTokenSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(AuthTokenSoapClient.GetBindingForEndpoint(endpointConfiguration), AuthTokenSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthTokenSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AuthTokenSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthTokenSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AuthTokenSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthTokenSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AsmxUtilityWebService.AuthenticateUserResponse> AsmxUtilityWebService.AuthTokenSoap.AuthenticateUserAsync(AsmxUtilityWebService.AuthenticateUserRequest request)
        {
            return base.Channel.AuthenticateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<AsmxUtilityWebService.AuthenticateUserResponse> AuthenticateUserAsync(AsmxUtilityWebService.SecuredToken SecuredToken)
        {
            AsmxUtilityWebService.AuthenticateUserRequest inValue = new AsmxUtilityWebService.AuthenticateUserRequest();
            inValue.SecuredToken = SecuredToken;
            return ((AsmxUtilityWebService.AuthTokenSoap)(this)).AuthenticateUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AsmxUtilityWebService.HelloWorldResponse> AsmxUtilityWebService.AuthTokenSoap.HelloWorldAsync(AsmxUtilityWebService.HelloWorldRequest request)
        {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<AsmxUtilityWebService.HelloWorldResponse> HelloWorldAsync(AsmxUtilityWebService.SecuredToken SecuredToken)
        {
            AsmxUtilityWebService.HelloWorldRequest inValue = new AsmxUtilityWebService.HelloWorldRequest();
            inValue.SecuredToken = SecuredToken;
            return ((AsmxUtilityWebService.AuthTokenSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AsmxUtilityWebService.CheckAccessResponse> AsmxUtilityWebService.AuthTokenSoap.CheckAccessAsync(AsmxUtilityWebService.CheckAccessRequest request)
        {
            return base.Channel.CheckAccessAsync(request);
        }
        
        public System.Threading.Tasks.Task<AsmxUtilityWebService.CheckAccessResponse> CheckAccessAsync(AsmxUtilityWebService.SecuredToken SecuredToken)
        {
            AsmxUtilityWebService.CheckAccessRequest inValue = new AsmxUtilityWebService.CheckAccessRequest();
            inValue.SecuredToken = SecuredToken;
            return ((AsmxUtilityWebService.AuthTokenSoap)(this)).CheckAccessAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AsmxUtilityWebService.FactorialResponse> AsmxUtilityWebService.AuthTokenSoap.FactorialAsync(AsmxUtilityWebService.FactorialRequest request)
        {
            return base.Channel.FactorialAsync(request);
        }
        
        public System.Threading.Tasks.Task<AsmxUtilityWebService.FactorialResponse> FactorialAsync(AsmxUtilityWebService.SecuredToken SecuredToken, int input)
        {
            AsmxUtilityWebService.FactorialRequest inValue = new AsmxUtilityWebService.FactorialRequest();
            inValue.SecuredToken = SecuredToken;
            inValue.input = input;
            return ((AsmxUtilityWebService.AuthTokenSoap)(this)).FactorialAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.AuthTokenSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.AuthTokenSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.AuthTokenSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44350/AuthToken.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.AuthTokenSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44350/AuthToken.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            AuthTokenSoap,
            
            AuthTokenSoap12,
        }
    }
}
