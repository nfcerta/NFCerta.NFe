namespace NFCerta.NFe.Schemas.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography.X509Certificates;
    using System.Xml;
    using Cancelamento;
    using CertificadoDigital;
    using Util;

    public static class EventoCancelamentoExtensions
    {
        public static EventoCancelamento CalculaId(this EventoCancelamento cancelamento)
        {
            var tpEvento = ((int) cancelamento.infEvento.tpEvento).ToString();
            cancelamento.infEvento.Id = "ID" + tpEvento + cancelamento.infEvento.chNFe + "0" + cancelamento.infEvento.nSeqEvento;
            return cancelamento;
        }

        public static EventoCancelamento Assina(this EventoCancelamento cancelamento, X509Certificate2 certificate)
        {
            cancelamento.CalculaId();
            var xml = new XmlDocument();
            xml.LoadXml(cancelamento.Serialize().LimpaNamespaces());
            cancelamento.Signature = AssinadorXml.GeraAssinatura(xml, "infEvento", certificate);

            return cancelamento;
        }

        public static EnvioEventoCancelamento AssinaEnvio(this EnvioEventoCancelamento envio, X509Certificate2 certificate)
        {
            foreach (var evento in envio.evento)
            {
                evento.Assina(certificate);
            }

            return envio;
        }
    }
}
