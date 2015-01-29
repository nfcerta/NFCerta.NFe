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
    [WebServiceBinding(Name = "RecepcaoEventoSoap12", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento")]
    public partial class RecepcaoEvento : SoapHttpClientProtocol
    {

        private CabecalhoRecepcaoEvento nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback nfeRecepcaoEventoOperationCompleted;

        /// <remarks/>
        public RecepcaoEvento(string pUrl)
        {
            this.SoapVersion = SoapProtocolVersion.Soap12;
            this.Url = pUrl;            
        }

        public CabecalhoRecepcaoEvento nfeCabecMsgValue
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
        public event nfeRecepcaoEventoCompletedEventHandler nfeRecepcaoEventoCompleted;

        /// <remarks/>
        [SoapHeader("nfeCabecMsgValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [SoapDocumentMethod("http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento/nfeRecepcaoEvento", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento")]
        public System.Xml.XmlNode nfeRecepcaoEvento([XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/RecepcaoEvento")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeRecepcaoEvento", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeRecepcaoEvento(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeRecepcaoEvento", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeRecepcaoEvento(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeRecepcaoEventoAsync(System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeRecepcaoEventoAsync(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void nfeRecepcaoEventoAsync(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.nfeRecepcaoEventoOperationCompleted == null))
            {
                this.nfeRecepcaoEventoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeRecepcaoEventoOperationCompleted);
            }
            this.InvokeAsync("nfeRecepcaoEvento", new object[] {
                    nfeDadosMsg}, this.nfeRecepcaoEventoOperationCompleted, userState);
        }

        private void OnnfeRecepcaoEventoOperationCompleted(object arg)
        {
            if ((this.nfeRecepcaoEventoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeRecepcaoEventoCompleted(this, new nfeRecepcaoEventoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void nfeRecepcaoEventoCompletedEventHandler(object sender, nfeRecepcaoEventoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class nfeRecepcaoEventoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeRecepcaoEventoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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