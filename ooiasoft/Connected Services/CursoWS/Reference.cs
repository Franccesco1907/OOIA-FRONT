//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ooiasoft.CursoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", ConfigurationName="CursoWS.CursoWS")]
    public interface CursoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/CursoWS/modificarCursoRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/CursoWS/modificarCursoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.CursoWS.modificarCursoResponse modificarCurso(ooiasoft.CursoWS.modificarCursoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/CursoWS/modificarCursoRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/CursoWS/modificarCursoResponse")]
        System.Threading.Tasks.Task<ooiasoft.CursoWS.modificarCursoResponse> modificarCursoAsync(ooiasoft.CursoWS.modificarCursoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/CursoWS/insertarCursoRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/CursoWS/insertarCursoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.CursoWS.insertarCursoResponse insertarCurso(ooiasoft.CursoWS.insertarCursoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/CursoWS/insertarCursoRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/CursoWS/insertarCursoResponse")]
        System.Threading.Tasks.Task<ooiasoft.CursoWS.insertarCursoResponse> insertarCursoAsync(ooiasoft.CursoWS.insertarCursoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/CursoWS/eliminarCursoRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/CursoWS/eliminarCursoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.CursoWS.eliminarCursoResponse eliminarCurso(ooiasoft.CursoWS.eliminarCursoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/CursoWS/eliminarCursoRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/CursoWS/eliminarCursoResponse")]
        System.Threading.Tasks.Task<ooiasoft.CursoWS.eliminarCursoResponse> eliminarCursoAsync(ooiasoft.CursoWS.eliminarCursoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/CursoWS/listarCursosPorCodigoNombreRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/CursoWS/listarCursosPorCodigoNombreResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ooiasoft.CursoWS.listarCursosPorCodigoNombreResponse listarCursosPorCodigoNombre(ooiasoft.CursoWS.listarCursosPorCodigoNombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.ooiasoft.pucp.edu.pe/CursoWS/listarCursosPorCodigoNombreRequest", ReplyAction="http://services.ooiasoft.pucp.edu.pe/CursoWS/listarCursosPorCodigoNombreResponse")]
        System.Threading.Tasks.Task<ooiasoft.CursoWS.listarCursosPorCodigoNombreResponse> listarCursosPorCodigoNombreAsync(ooiasoft.CursoWS.listarCursosPorCodigoNombreRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/")]
    public partial class curso : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codigoField;
        
        private double creditosField;
        
        private especialidad especialidadField;
        
        private bool estadoField;
        
        private int idCursoField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double creditos {
            get {
                return this.creditosField;
            }
            set {
                this.creditosField = value;
                this.RaisePropertyChanged("creditos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public especialidad especialidad {
            get {
                return this.especialidadField;
            }
            set {
                this.especialidadField = value;
                this.RaisePropertyChanged("especialidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int idCurso {
            get {
                return this.idCursoField;
            }
            set {
                this.idCursoField = value;
                this.RaisePropertyChanged("idCurso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/")]
    public partial class especialidad : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionField;
        
        private bool estadoField;
        
        private int idEspecialidadField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public bool estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int idEspecialidad {
            get {
                return this.idEspecialidadField;
            }
            set {
                this.idEspecialidadField = value;
                this.RaisePropertyChanged("idEspecialidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarCurso", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarCursoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ooiasoft.CursoWS.curso curso;
        
        public modificarCursoRequest() {
        }
        
        public modificarCursoRequest(ooiasoft.CursoWS.curso curso) {
            this.curso = curso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarCursoResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarCursoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarCursoResponse() {
        }
        
        public modificarCursoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarCurso", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarCursoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ooiasoft.CursoWS.curso curso;
        
        public insertarCursoRequest() {
        }
        
        public insertarCursoRequest(ooiasoft.CursoWS.curso curso) {
            this.curso = curso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarCursoResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarCursoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarCursoResponse() {
        }
        
        public insertarCursoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarCurso", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarCursoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idCurso;
        
        public eliminarCursoRequest() {
        }
        
        public eliminarCursoRequest(int idCurso) {
            this.idCurso = idCurso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarCursoResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarCursoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarCursoResponse() {
        }
        
        public eliminarCursoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarCursosPorCodigoNombre", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarCursosPorCodigoNombreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigoNombre;
        
        public listarCursosPorCodigoNombreRequest() {
        }
        
        public listarCursosPorCodigoNombreRequest(string codigoNombre) {
            this.codigoNombre = codigoNombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarCursosPorCodigoNombreResponse", WrapperNamespace="http://services.ooiasoft.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarCursosPorCodigoNombreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.ooiasoft.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ooiasoft.CursoWS.curso[] @return;
        
        public listarCursosPorCodigoNombreResponse() {
        }
        
        public listarCursosPorCodigoNombreResponse(ooiasoft.CursoWS.curso[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CursoWSChannel : ooiasoft.CursoWS.CursoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CursoWSClient : System.ServiceModel.ClientBase<ooiasoft.CursoWS.CursoWS>, ooiasoft.CursoWS.CursoWS {
        
        public CursoWSClient() {
        }
        
        public CursoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CursoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.CursoWS.modificarCursoResponse ooiasoft.CursoWS.CursoWS.modificarCurso(ooiasoft.CursoWS.modificarCursoRequest request) {
            return base.Channel.modificarCurso(request);
        }
        
        public int modificarCurso(ooiasoft.CursoWS.curso curso) {
            ooiasoft.CursoWS.modificarCursoRequest inValue = new ooiasoft.CursoWS.modificarCursoRequest();
            inValue.curso = curso;
            ooiasoft.CursoWS.modificarCursoResponse retVal = ((ooiasoft.CursoWS.CursoWS)(this)).modificarCurso(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.CursoWS.modificarCursoResponse> ooiasoft.CursoWS.CursoWS.modificarCursoAsync(ooiasoft.CursoWS.modificarCursoRequest request) {
            return base.Channel.modificarCursoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.CursoWS.modificarCursoResponse> modificarCursoAsync(ooiasoft.CursoWS.curso curso) {
            ooiasoft.CursoWS.modificarCursoRequest inValue = new ooiasoft.CursoWS.modificarCursoRequest();
            inValue.curso = curso;
            return ((ooiasoft.CursoWS.CursoWS)(this)).modificarCursoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.CursoWS.insertarCursoResponse ooiasoft.CursoWS.CursoWS.insertarCurso(ooiasoft.CursoWS.insertarCursoRequest request) {
            return base.Channel.insertarCurso(request);
        }
        
        public int insertarCurso(ooiasoft.CursoWS.curso curso) {
            ooiasoft.CursoWS.insertarCursoRequest inValue = new ooiasoft.CursoWS.insertarCursoRequest();
            inValue.curso = curso;
            ooiasoft.CursoWS.insertarCursoResponse retVal = ((ooiasoft.CursoWS.CursoWS)(this)).insertarCurso(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.CursoWS.insertarCursoResponse> ooiasoft.CursoWS.CursoWS.insertarCursoAsync(ooiasoft.CursoWS.insertarCursoRequest request) {
            return base.Channel.insertarCursoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.CursoWS.insertarCursoResponse> insertarCursoAsync(ooiasoft.CursoWS.curso curso) {
            ooiasoft.CursoWS.insertarCursoRequest inValue = new ooiasoft.CursoWS.insertarCursoRequest();
            inValue.curso = curso;
            return ((ooiasoft.CursoWS.CursoWS)(this)).insertarCursoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.CursoWS.eliminarCursoResponse ooiasoft.CursoWS.CursoWS.eliminarCurso(ooiasoft.CursoWS.eliminarCursoRequest request) {
            return base.Channel.eliminarCurso(request);
        }
        
        public int eliminarCurso(int idCurso) {
            ooiasoft.CursoWS.eliminarCursoRequest inValue = new ooiasoft.CursoWS.eliminarCursoRequest();
            inValue.idCurso = idCurso;
            ooiasoft.CursoWS.eliminarCursoResponse retVal = ((ooiasoft.CursoWS.CursoWS)(this)).eliminarCurso(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.CursoWS.eliminarCursoResponse> ooiasoft.CursoWS.CursoWS.eliminarCursoAsync(ooiasoft.CursoWS.eliminarCursoRequest request) {
            return base.Channel.eliminarCursoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.CursoWS.eliminarCursoResponse> eliminarCursoAsync(int idCurso) {
            ooiasoft.CursoWS.eliminarCursoRequest inValue = new ooiasoft.CursoWS.eliminarCursoRequest();
            inValue.idCurso = idCurso;
            return ((ooiasoft.CursoWS.CursoWS)(this)).eliminarCursoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ooiasoft.CursoWS.listarCursosPorCodigoNombreResponse ooiasoft.CursoWS.CursoWS.listarCursosPorCodigoNombre(ooiasoft.CursoWS.listarCursosPorCodigoNombreRequest request) {
            return base.Channel.listarCursosPorCodigoNombre(request);
        }
        
        public ooiasoft.CursoWS.curso[] listarCursosPorCodigoNombre(string codigoNombre) {
            ooiasoft.CursoWS.listarCursosPorCodigoNombreRequest inValue = new ooiasoft.CursoWS.listarCursosPorCodigoNombreRequest();
            inValue.codigoNombre = codigoNombre;
            ooiasoft.CursoWS.listarCursosPorCodigoNombreResponse retVal = ((ooiasoft.CursoWS.CursoWS)(this)).listarCursosPorCodigoNombre(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ooiasoft.CursoWS.listarCursosPorCodigoNombreResponse> ooiasoft.CursoWS.CursoWS.listarCursosPorCodigoNombreAsync(ooiasoft.CursoWS.listarCursosPorCodigoNombreRequest request) {
            return base.Channel.listarCursosPorCodigoNombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<ooiasoft.CursoWS.listarCursosPorCodigoNombreResponse> listarCursosPorCodigoNombreAsync(string codigoNombre) {
            ooiasoft.CursoWS.listarCursosPorCodigoNombreRequest inValue = new ooiasoft.CursoWS.listarCursosPorCodigoNombreRequest();
            inValue.codigoNombre = codigoNombre;
            return ((ooiasoft.CursoWS.CursoWS)(this)).listarCursosPorCodigoNombreAsync(inValue);
        }
    }
}
