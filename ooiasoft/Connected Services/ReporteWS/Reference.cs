﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ooiasoft.ReporteWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", ConfigurationName="ReporteWS.ReporteWS")]
    public interface ReporteWS {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://services.ooiasoft.pucp.edu.pe/).
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/ReporteWS/generarReporteEventosxCicloRequest" +
            "", ReplyAction="http://services.ooiasoft.pucp.edu.pe/ReporteWS/generarReporteEventosxCicloRespons" +
            "e")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.ReporteWS.generarReporteEventosxCicloResponse generarReporteEventosxCiclo(ooiasoft.ReporteWS.generarReporteEventosxCicloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/ReporteWS/generarReporteEventosxCicloRequest" +
            "", ReplyAction="http://services.ooiasoft.pucp.edu.pe/ReporteWS/generarReporteEventosxCicloRespons" +
            "e")]
        System.Threading.Tasks.Task<ooiasoft.ReporteWS.generarReporteEventosxCicloResponse> generarReporteEventosxCicloAsync(ooiasoft.ReporteWS.generarReporteEventosxCicloRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://services.ooiasoft.pucp.edu.pe/).
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/ReporteWS/generarReporteCitasxPersonalReques" +
            "t", ReplyAction="http://services.ooiasoft.pucp.edu.pe/ReporteWS/generarReporteCitasxPersonalRespon" +
            "se")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.ReporteWS.generarReporteCitasxPersonalResponse generarReporteCitasxPersonal(ooiasoft.ReporteWS.generarReporteCitasxPersonalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/ReporteWS/generarReporteCitasxPersonalReques" +
            "t", ReplyAction="http://services.ooiasoft.pucp.edu.pe/ReporteWS/generarReporteCitasxPersonalRespon" +
            "se")]
        System.Threading.Tasks.Task<ooiasoft.ReporteWS.generarReporteCitasxPersonalResponse> generarReporteCitasxPersonalAsync(ooiasoft.ReporteWS.generarReporteCitasxPersonalRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="generarReporteEventosxCiclo", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class generarReporteEventosxCicloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int arg0;
        
        public generarReporteEventosxCicloRequest() {
        }
        
        public generarReporteEventosxCicloRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="generarReporteEventosxCicloResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class generarReporteEventosxCicloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public byte[] @return;
        
        public generarReporteEventosxCicloResponse() {
        }
        
        public generarReporteEventosxCicloResponse(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="generarReporteCitasxPersonal", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class generarReporteCitasxPersonalRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int arg0;
        
        public generarReporteCitasxPersonalRequest() {
        }
        
        public generarReporteCitasxPersonalRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="generarReporteCitasxPersonalResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class generarReporteCitasxPersonalResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public byte[] @return;
        
        public generarReporteCitasxPersonalResponse() {
        }
        
        public generarReporteCitasxPersonalResponse(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ReporteWSChannel : ooiasoft.ReporteWS.ReporteWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReporteWSClient : System.ServiceModel.ClientBase<ooiasoft.ReporteWS.ReporteWS>, ooiasoft.ReporteWS.ReporteWS {
        
        public ReporteWSClient() {
        }
        
        public ReporteWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReporteWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReporteWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReporteWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.ReporteWS.generarReporteEventosxCicloResponse ooiasoft.ReporteWS.ReporteWS.generarReporteEventosxCiclo(ooiasoft.ReporteWS.generarReporteEventosxCicloRequest request) {
            return base.Channel.generarReporteEventosxCiclo(request);
        }
        
        public byte[] generarReporteEventosxCiclo(int arg0) {
            ooiasoft.ReporteWS.generarReporteEventosxCicloRequest inValue = new ooiasoft.ReporteWS.generarReporteEventosxCicloRequest();
            inValue.arg0 = arg0;
            ooiasoft.ReporteWS.generarReporteEventosxCicloResponse retVal = ((ooiasoft.ReporteWS.ReporteWS)(this)).generarReporteEventosxCiclo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.ReporteWS.generarReporteEventosxCicloResponse> ooiasoft.ReporteWS.ReporteWS.generarReporteEventosxCicloAsync(ooiasoft.ReporteWS.generarReporteEventosxCicloRequest request) {
            return base.Channel.generarReporteEventosxCicloAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.ReporteWS.generarReporteEventosxCicloResponse> generarReporteEventosxCicloAsync(int arg0) {
            ooiasoft.ReporteWS.generarReporteEventosxCicloRequest inValue = new ooiasoft.ReporteWS.generarReporteEventosxCicloRequest();
            inValue.arg0 = arg0;
            return ((ooiasoft.ReporteWS.ReporteWS)(this)).generarReporteEventosxCicloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.ReporteWS.generarReporteCitasxPersonalResponse ooiasoft.ReporteWS.ReporteWS.generarReporteCitasxPersonal(ooiasoft.ReporteWS.generarReporteCitasxPersonalRequest request) {
            return base.Channel.generarReporteCitasxPersonal(request);
        }
        
        public byte[] generarReporteCitasxPersonal(int arg0) {
            ooiasoft.ReporteWS.generarReporteCitasxPersonalRequest inValue = new ooiasoft.ReporteWS.generarReporteCitasxPersonalRequest();
            inValue.arg0 = arg0;
            ooiasoft.ReporteWS.generarReporteCitasxPersonalResponse retVal = ((ooiasoft.ReporteWS.ReporteWS)(this)).generarReporteCitasxPersonal(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.ReporteWS.generarReporteCitasxPersonalResponse> ooiasoft.ReporteWS.ReporteWS.generarReporteCitasxPersonalAsync(ooiasoft.ReporteWS.generarReporteCitasxPersonalRequest request) {
            return base.Channel.generarReporteCitasxPersonalAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.ReporteWS.generarReporteCitasxPersonalResponse> generarReporteCitasxPersonalAsync(int arg0) {
            ooiasoft.ReporteWS.generarReporteCitasxPersonalRequest inValue = new ooiasoft.ReporteWS.generarReporteCitasxPersonalRequest();
            inValue.arg0 = arg0;
            return ((ooiasoft.ReporteWS.ReporteWS)(this)).generarReporteCitasxPersonalAsync(inValue);
        }
    }
}