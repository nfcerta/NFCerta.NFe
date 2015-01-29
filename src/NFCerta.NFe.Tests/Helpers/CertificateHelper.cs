namespace NFCerta.NFe.Tests.Helpers
{
    using System.Security.Cryptography.X509Certificates;

    public static class CertificateHelper
    {
        private static X509Certificate2 certificate;

        public static X509Certificate2 Certificate
        {
            get
            {
                return certificate ??
                       (certificate = new X509Certificate2(@"C:\Temp\winebros.pfx", "1234", X509KeyStorageFlags.MachineKeySet));
            }
        }
    }
}
