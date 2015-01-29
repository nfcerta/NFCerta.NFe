namespace NFCerta.NFe.Schemas.Extensions
{
    using System.Security.Cryptography.X509Certificates;

    public static class EnviNFeExtensions
    {
        public static TEnviNFe AssinaNotas(this TEnviNFe envi, X509Certificate2 certificate)
        {
            foreach (var nfe in envi.NFe)
            {
                nfe.GeraAssinatura(certificate);
            }

            return envi;
        }
    }
}