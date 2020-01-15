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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAutor", ReplyAction="http://tempuri.org/IService/GetAutorResponse")]
        string[] GetAutor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAutor", ReplyAction="http://tempuri.org/IService/GetAutorResponse")]
        System.Threading.Tasks.Task<string[]> GetAutorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetKitchen", ReplyAction="http://tempuri.org/IService/GetKitchenResponse")]
        string[] GetKitchen();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetKitchen", ReplyAction="http://tempuri.org/IService/GetKitchenResponse")]
        System.Threading.Tasks.Task<string[]> GetKitchenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetHowto", ReplyAction="http://tempuri.org/IService/GetHowtoResponse")]
        string[] GetHowto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetHowto", ReplyAction="http://tempuri.org/IService/GetHowtoResponse")]
        System.Threading.Tasks.Task<string[]> GetHowtoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddRecept", ReplyAction="http://tempuri.org/IService/AddReceptResponse")]
        void AddRecept(
                    string name, 
                    string autor, 
                    string kitchen, 
                    string howto, 
                    string category, 
                    string description, 
                    string calories, 
                    string ingred1, 
                    int measurec1, 
                    string measure1, 
                    string ingred2, 
                    int measurec2, 
                    string measure2, 
                    string ingred3, 
                    int measurec3, 
                    string measure3, 
                    string ingred4, 
                    int measurec4, 
                    string measure4, 
                    string ingred5, 
                    int measurec5, 
                    string measure5);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddRecept", ReplyAction="http://tempuri.org/IService/AddReceptResponse")]
        System.Threading.Tasks.Task AddReceptAsync(
                    string name, 
                    string autor, 
                    string kitchen, 
                    string howto, 
                    string category, 
                    string description, 
                    string calories, 
                    string ingred1, 
                    int measurec1, 
                    string measure1, 
                    string ingred2, 
                    int measurec2, 
                    string measure2, 
                    string ingred3, 
                    int measurec3, 
                    string measure3, 
                    string ingred4, 
                    int measurec4, 
                    string measure4, 
                    string ingred5, 
                    int measurec5, 
                    string measure5);
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
        
        public string[] GetAutor() {
            return base.Channel.GetAutor();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAutorAsync() {
            return base.Channel.GetAutorAsync();
        }
        
        public string[] GetKitchen() {
            return base.Channel.GetKitchen();
        }
        
        public System.Threading.Tasks.Task<string[]> GetKitchenAsync() {
            return base.Channel.GetKitchenAsync();
        }
        
        public string[] GetHowto() {
            return base.Channel.GetHowto();
        }
        
        public System.Threading.Tasks.Task<string[]> GetHowtoAsync() {
            return base.Channel.GetHowtoAsync();
        }
        
        public void AddRecept(
                    string name, 
                    string autor, 
                    string kitchen, 
                    string howto, 
                    string category, 
                    string description, 
                    string calories, 
                    string ingred1, 
                    int measurec1, 
                    string measure1, 
                    string ingred2, 
                    int measurec2, 
                    string measure2, 
                    string ingred3, 
                    int measurec3, 
                    string measure3, 
                    string ingred4, 
                    int measurec4, 
                    string measure4, 
                    string ingred5, 
                    int measurec5, 
                    string measure5) {
            base.Channel.AddRecept(name, autor, kitchen, howto, category, description, calories, ingred1, measurec1, measure1, ingred2, measurec2, measure2, ingred3, measurec3, measure3, ingred4, measurec4, measure4, ingred5, measurec5, measure5);
        }
        
        public System.Threading.Tasks.Task AddReceptAsync(
                    string name, 
                    string autor, 
                    string kitchen, 
                    string howto, 
                    string category, 
                    string description, 
                    string calories, 
                    string ingred1, 
                    int measurec1, 
                    string measure1, 
                    string ingred2, 
                    int measurec2, 
                    string measure2, 
                    string ingred3, 
                    int measurec3, 
                    string measure3, 
                    string ingred4, 
                    int measurec4, 
                    string measure4, 
                    string ingred5, 
                    int measurec5, 
                    string measure5) {
            return base.Channel.AddReceptAsync(name, autor, kitchen, howto, category, description, calories, ingred1, measurec1, measure1, ingred2, measurec2, measure2, ingred3, measurec3, measure3, ingred4, measurec4, measure4, ingred5, measurec5, measure5);
        }
    }
}
