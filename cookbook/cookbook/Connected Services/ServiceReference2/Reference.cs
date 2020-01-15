﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cookbook.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIngred", ReplyAction="http://tempuri.org/IService/GetIngredResponse")]
        string[] GetIngred();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetIngred", ReplyAction="http://tempuri.org/IService/GetIngredResponse")]
        System.Threading.Tasks.Task<string[]> GetIngredAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMeasure", ReplyAction="http://tempuri.org/IService/GetMeasureResponse")]
        string[] GetMeasure();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMeasure", ReplyAction="http://tempuri.org/IService/GetMeasureResponse")]
        System.Threading.Tasks.Task<string[]> GetMeasureAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : cookbook.ServiceReference2.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<cookbook.ServiceReference2.IService>, cookbook.ServiceReference2.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetIngred() {
            return base.Channel.GetIngred();
        }
        
        public System.Threading.Tasks.Task<string[]> GetIngredAsync() {
            return base.Channel.GetIngredAsync();
        }
        
        public string[] GetMeasure() {
            return base.Channel.GetMeasure();
        }
        
        public System.Threading.Tasks.Task<string[]> GetMeasureAsync() {
            return base.Channel.GetMeasureAsync();
        }
    }
}
