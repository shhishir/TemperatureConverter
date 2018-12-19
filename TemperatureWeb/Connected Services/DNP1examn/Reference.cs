﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TemperatureWeb.DNP1examn {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DNP1examn.TemperatureWebServiceSoap")]
    public interface TemperatureWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        TemperatureWeb.DNP1examn.HelloWorldResponse HelloWorld(TemperatureWeb.DNP1examn.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<TemperatureWeb.DNP1examn.HelloWorldResponse> HelloWorldAsync(TemperatureWeb.DNP1examn.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToFahrenheit", ReplyAction="*")]
        double ConvertToFahrenheit(double celsius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToFahrenheit", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertToFahrenheitAsync(double celsius);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToCelsius", ReplyAction="*")]
        double ConvertToCelsius(double fahren);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToCelsius", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertToCelsiusAsync(double fahren);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public TemperatureWeb.DNP1examn.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(TemperatureWeb.DNP1examn.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public TemperatureWeb.DNP1examn.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(TemperatureWeb.DNP1examn.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TemperatureWebServiceSoapChannel : TemperatureWeb.DNP1examn.TemperatureWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TemperatureWebServiceSoapClient : System.ServiceModel.ClientBase<TemperatureWeb.DNP1examn.TemperatureWebServiceSoap>, TemperatureWeb.DNP1examn.TemperatureWebServiceSoap {
        
        public TemperatureWebServiceSoapClient() {
        }
        
        public TemperatureWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TemperatureWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TemperatureWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TemperatureWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TemperatureWeb.DNP1examn.HelloWorldResponse TemperatureWeb.DNP1examn.TemperatureWebServiceSoap.HelloWorld(TemperatureWeb.DNP1examn.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            TemperatureWeb.DNP1examn.HelloWorldRequest inValue = new TemperatureWeb.DNP1examn.HelloWorldRequest();
            inValue.Body = new TemperatureWeb.DNP1examn.HelloWorldRequestBody();
            TemperatureWeb.DNP1examn.HelloWorldResponse retVal = ((TemperatureWeb.DNP1examn.TemperatureWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TemperatureWeb.DNP1examn.HelloWorldResponse> TemperatureWeb.DNP1examn.TemperatureWebServiceSoap.HelloWorldAsync(TemperatureWeb.DNP1examn.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<TemperatureWeb.DNP1examn.HelloWorldResponse> HelloWorldAsync() {
            TemperatureWeb.DNP1examn.HelloWorldRequest inValue = new TemperatureWeb.DNP1examn.HelloWorldRequest();
            inValue.Body = new TemperatureWeb.DNP1examn.HelloWorldRequestBody();
            return ((TemperatureWeb.DNP1examn.TemperatureWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public double ConvertToFahrenheit(double celsius) {
            return base.Channel.ConvertToFahrenheit(celsius);
        }
        
        public System.Threading.Tasks.Task<double> ConvertToFahrenheitAsync(double celsius) {
            return base.Channel.ConvertToFahrenheitAsync(celsius);
        }
        
        public double ConvertToCelsius(double fahren) {
            return base.Channel.ConvertToCelsius(fahren);
        }
        
        public System.Threading.Tasks.Task<double> ConvertToCelsiusAsync(double fahren) {
            return base.Channel.ConvertToCelsiusAsync(fahren);
        }
    }
}