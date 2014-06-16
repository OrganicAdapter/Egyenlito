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
namespace EgyenlitoWin.EventService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EventService.IWinEventService")]
    public interface IWinEventService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinEventService/GetEvents", ReplyAction="http://tempuri.org/IWinEventService/GetEventsResponse")]
        System.Threading.Tasks.Task<string> GetEventsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWinEventService/GetUpholders", ReplyAction="http://tempuri.org/IWinEventService/GetUpholdersResponse")]
        System.Threading.Tasks.Task<string> GetUpholdersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWinEventServiceChannel : EgyenlitoWin.EventService.IWinEventService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WinEventServiceClient : System.ServiceModel.ClientBase<EgyenlitoWin.EventService.IWinEventService>, EgyenlitoWin.EventService.IWinEventService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WinEventServiceClient() : 
                base(WinEventServiceClient.GetDefaultBinding(), WinEventServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWinEventService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WinEventServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WinEventServiceClient.GetBindingForEndpoint(endpointConfiguration), WinEventServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WinEventServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WinEventServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WinEventServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WinEventServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WinEventServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<string> GetEventsAsync() {
            return base.Channel.GetEventsAsync();
        }
        
        public System.Threading.Tasks.Task<string> GetUpholdersAsync() {
            return base.Channel.GetUpholdersAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWinEventService)) {
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWinEventService)) {
                return new System.ServiceModel.EndpointAddress("http://ujegyenlito.softit.hu/Egyenlito/WCF/WinEventService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return WinEventServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWinEventService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return WinEventServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWinEventService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IWinEventService,
        }
    }
}
