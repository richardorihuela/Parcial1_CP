﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace consumirDB.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/alumno", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] alumno(int ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/alumno", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> alumnoAsync(int ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/alumnoDB", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet alumnoDB(int ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/alumnoDB", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> alumnoDBAsync(int ci);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : consumirDB.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<consumirDB.ServiceReference1.WebServiceSoap>, consumirDB.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] alumno(int ci) {
            return base.Channel.alumno(ci);
        }
        
        public System.Threading.Tasks.Task<string[]> alumnoAsync(int ci) {
            return base.Channel.alumnoAsync(ci);
        }
        
        public System.Data.DataSet alumnoDB(int ci) {
            return base.Channel.alumnoDB(ci);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> alumnoDBAsync(int ci) {
            return base.Channel.alumnoDBAsync(ci);
        }
    }
}