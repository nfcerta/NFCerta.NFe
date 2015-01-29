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
    [WebServiceBinding(Name = "NfeStatusServico2Soap12", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2")]
    public partial class NfeStatusServico2 : SoapHttpClientProtocol
    {

        private CabecalhoStatus nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback nfeStatusServicoNF2OperationCompleted;

        /// <remarks/>
        public NfeStatusServico2(string pUrl)
        {
            this.SoapVersion = SoapProtocolVersion.Soap12;
            this.Url = pUrl;
        }

        public CabecalhoStatus nfeCabecMsgValue
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
        public event nfeStatusServicoNF2CompletedEventHandler nfeStatusServicoNF2Completed;

        /// <remarks/>
        [SoapHeader("nfeCabecMsgValue", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [SoapDocumentMethod("http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2/nfeStatusServicoNF2", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2")]
        public System.Xml.XmlNode nfeStatusServicoNF2([XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeStatusServicoNF2", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeStatusServicoNF2(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeStatusServicoNF2", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeStatusServicoNF2(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeStatusServicoNF2Async(System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeStatusServicoNF2Async(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void nfeStatusServicoNF2Async(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.nfeStatusServicoNF2OperationCompleted == null))
            {
                this.nfeStatusServicoNF2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeStatusServicoNF2OperationCompleted);
            }
            this.InvokeAsync("nfeStatusServicoNF2", new object[] {
                    nfeDadosMsg}, this.nfeStatusServicoNF2OperationCompleted, userState);
        }

        private void OnnfeStatusServicoNF2OperationCompleted(object arg)
        {
            if ((this.nfeStatusServicoNF2Completed != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeStatusServicoNF2Completed(this, new nfeStatusServicoNF2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void nfeStatusServicoNF2CompletedEventHandler(object sender, nfeStatusServicoNF2CompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class nfeStatusServicoNF2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeStatusServicoNF2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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