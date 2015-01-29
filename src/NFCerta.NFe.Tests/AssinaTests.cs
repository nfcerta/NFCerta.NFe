namespace NFCerta.NFe.Tests
{
    using NFCerta.NFe.Tests.Helpers;
    using Schemas.Extensions;
    using Shouldly;
    using Xunit;

    public class AssinaTests
    {
        [Fact]
        public void WhenSigningNFe()
        {
            var nfe = MockData.NFCe.Value;

            nfe.GeraAssinatura(CertificateHelper.Certificate);

            nfe.Signature.SignatureValue.ShouldNotBe(null);
        }
    }
}
