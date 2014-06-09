﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 12.0.21005.1
// 
namespace EgyenlitoWin.DataProviderService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataProviderService.IWinDataProviderService")]
    public interface IWinDataProviderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinDataProviderService/GetNewspapers", ReplyAction="http://tempuri.org/IWinDataProviderService/GetNewspapersResponse")]
        System.Threading.Tasks.Task<string> GetNewspapersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinDataProviderService/GetAllArticles", ReplyAction="http://tempuri.org/IWinDataProviderService/GetAllArticlesResponse")]
        System.Threading.Tasks.Task<string> GetAllArticlesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinDataProviderService/GetArticles", ReplyAction="http://tempuri.org/IWinDataProviderService/GetArticlesResponse")]
        System.Threading.Tasks.Task<string> GetArticlesAsync(int newspaperId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWinDataProviderServiceChannel : EgyenlitoWin.DataProviderService.IWinDataProviderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WinDataProviderServiceClient : System.ServiceModel.ClientBase<EgyenlitoWin.DataProviderService.IWinDataProviderService>, EgyenlitoWin.DataProviderService.IWinDataProviderService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WinDataProviderServiceClient() : 
                base(WinDataProviderServiceClient.GetDefaultBinding(), WinDataProviderServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWinDataProviderService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WinDataProviderServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WinDataProviderServiceClient.GetBindingForEndpoint(endpointConfiguration), WinDataProviderServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WinDataProviderServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WinDataProviderServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WinDataProviderServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WinDataProviderServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WinDataProviderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<string> GetNewspapersAsync() {
            return base.Channel.GetNewspapersAsync();
        }
        
        public System.Threading.Tasks.Task<string> GetAllArticlesAsync() {
            return base.Channel.GetAllArticlesAsync();
        }
        
        public System.Threading.Tasks.Task<string> GetArticlesAsync(int newspaperId) {
            return base.Channel.GetArticlesAsync(newspaperId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWinDataProviderService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWinDataProviderService)) {
                return new System.ServiceModel.EndpointAddress("http://ujegyenlito.softit.hu/Egyenlito/WCF/WinDataProviderService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return WinDataProviderServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWinDataProviderService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return WinDataProviderServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWinDataProviderService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IWinDataProviderService,
        }
    }
}
