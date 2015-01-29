namespace NFCerta.NFe.Webservice
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Web.Services;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using Schemas.Cabecalhos;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [WebServiceBinding(Name = "NfeConsulta2Soap12", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")]
    public partial class NfeConsulta2 : SoapHttpClientProtocol
    {

        private CabecalhoConsulta nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback nfeConsultaNF2OperationCompleted;

        /// <remarks/>
        public NfeConsulta2(string pUrl)
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = pUrl;
        }

        public CabecalhoConsulta nfeCabecMsgValue
        {
            get
            {
                return this.nfeCabecMsgValueField;
            }
            set
            {
                this.nfeCabecMsgValueField = value;
            }
        }

        /// <remarks/>
        public event nfeConsultaNF2CompletedEventHandler nfeConsultaNF2Completed;

        /// <remarks/>
        [SoapHeader("nfeCabecMsgValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [SoapDocumentMethod("http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2/nfeConsultaNF2", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")]
        public System.Xml.XmlNode nfeConsultaNF2([XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeConsultaNF2", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeConsultaNF2(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeConsultaNF2", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeConsultaNF2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeConsultaNF2Async(System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeConsultaNF2Async(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void nfeConsultaNF2Async(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.nfeConsultaNF2OperationCompleted == null))
            {
                this.nfeConsultaNF2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeConsultaNF2OperationCompleted);
            }
            this.InvokeAsync("nfeConsultaNF2", new object[] {
                    nfeDadosMsg}, this.nfeConsultaNF2OperationCompleted, userState);
        }

        private void OnnfeConsultaNF2OperationCompleted(object arg)
        {
            if ((this.nfeConsultaNF2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeConsultaNF2Completed(this, new nfeConsultaNF2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void nfeConsultaNF2CompletedEventHandler(object sender, nfeConsultaNF2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class nfeConsultaNF2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeConsultaNF2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Xml.XmlNode Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}