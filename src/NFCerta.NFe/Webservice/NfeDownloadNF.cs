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
    [WebServiceBinding(Name = "NfeDownloadNFSoap", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeDownloadNF")]
    public partial class NfeDownloadNF : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private nfeCabecMsg nfeCabecMsgValueField;

        private System.Threading.SendOrPostCallback nfeDownloadNFOperationCompleted;

        /// <remarks/>
        //public NfeDownloadNF()
        //{
        //    this.Url = "https://hom.sefazvirtual.fazenda.gov.br/NfeDownloadNF/NfeDownloadNF.asmx";
        //}

        public NfeDownloadNF(string pUrl)
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = pUrl;
        }

        public nfeCabecMsg nfeCabecMsgValue
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
        public event nfeDownloadNFCompletedEventHandler nfeDownloadNFCompleted;

        /// <remarks/>
        [SoapHeader("nfeCabecMsgValue")]
        [SoapDocumentMethod("http://www.portalfiscal.inf.br/nfe/wsdl/NfeDownloadNF/nfeDownloadNF", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeDownloadNF")]
        public System.Xml.XmlNode nfeDownloadNF([XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeDownloadNF")] System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeDownloadNF", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginnfeDownloadNF(System.Xml.XmlNode nfeDadosMsg, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("nfeDownloadNF", new object[] {
                    nfeDadosMsg}, callback, asyncState);
        }

        /// <remarks/>
        public System.Xml.XmlNode EndnfeDownloadNF(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void nfeDownloadNFAsync(System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeDownloadNFAsync(nfeDadosMsg, null);
        }

        /// <remarks/>
        public void nfeDownloadNFAsync(System.Xml.XmlNode nfeDadosMsg, object userState)
        {
            if ((this.nfeDownloadNFOperationCompleted == null))
            {
                this.nfeDownloadNFOperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeDownloadNFOperationCompleted);
            }
            this.InvokeAsync("nfeDownloadNF", new object[] {
                    nfeDadosMsg}, this.nfeDownloadNFOperationCompleted, userState);
        }

        private void OnnfeDownloadNFOperationCompleted(object arg)
        {
            if ((this.nfeDownloadNFCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeDownloadNFCompleted(this, new nfeDownloadNFCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void nfeDownloadNFCompletedEventHandler(object sender, nfeDownloadNFCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class nfeDownloadNFCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal nfeDownloadNFCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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