namespace NFCerta.NFe.Schemas.Extensions
{
    using System;
    using System.Globalization;
    using System.Security.Cryptography.X509Certificates;
    using System.Xml;
    using CertificadoDigital;
    using Util;

    public static class TnFeExtensions
    {
        public static string CalculaChave(this TNFe nfe)
        {
            var random = new Random();
            var dtEmissao = Convert.ToDateTime(nfe.infNFe.ide.dhEmi);
            var codUF = ((int)nfe.infNFe.ide.cUF).ToString(CultureInfo.InvariantCulture);
            var dEmi = dtEmissao.ToString("yyMM");
            var cnpj = nfe.infNFe.emit.Item;
            var mod = ((int)nfe.infNFe.ide.mod).ToString(CultureInfo.InvariantCulture);
            var serie = string.Format("{0:000}", Convert.ToInt32(nfe.infNFe.ide.serie));
            var numNf = string.Format("{0:000000000}", Convert.ToInt32(nfe.infNFe.ide.nNF));
            var codigo = nfe.infNFe.ide.cNF ?? string.Format("{0:00000000}", random.Next(10000000, 99999999));
            var tpEmissao = ((int)nfe.infNFe.ide.tpEmis).ToString(CultureInfo.InvariantCulture);
            var chaveNF = codUF + dEmi + cnpj + mod + serie + numNf + tpEmissao + codigo;

            var dv = Digit.Modulo11(chaveNF);
            nfe.infNFe.Id = "NFe" + chaveNF + dv;
            nfe.infNFe.ide.cDV = dv.ToString(CultureInfo.InvariantCulture);
            nfe.infNFe.ide.cNF = codigo;

            return chaveNF + dv;
        }

        public static TNFe GeraAssinatura(this TNFe nfe, X509Certificate2 certificate)
        {
            if (string.IsNullOrEmpty(nfe.infNFe.Id))
            {
                nfe.CalculaChave();
            }

            var nfeXml = new XmlDocument();
            nfeXml.LoadXml(nfe.Serialize().LimpaNamespaces());
            nfe.Signature = AssinadorXml.GeraAssinatura(nfeXml, "infNFe", certificate);
            return nfe;
        }
    }
}
