using NFCerta.NFe.Schemas;
using NFCerta.NFe.Tests.Helpers;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Xunit;

namespace NFCerta.NFe.Tests
{
    public class DanfeTests
    {
        [Fact]
        public void GeraDanfe()
        {
            using (var file = new DisposableFile(".pdf"))
            using (var stream = new FileStream(file.Path, FileMode.Create))
            using (var danfe = new Danfe())
            {
                var nfeProc = MockData.NFeProcessada.Value;

                danfe.Pdf(stream, nfeProc.NFe, nfeProc.protNFe, "cscId", "cscToken");
                stream.Close();
                Process.Start(file.Path);
                //time to load temp file
                Thread.Sleep(3000);
            }
        }

        [Fact]
        public void GeraDanfeContingencia()
        {
            using (var file = new DisposableFile(".pdf"))
            using (var stream = new FileStream(file.Path, FileMode.Create))
            using (var danfe = new Danfe())
            {
                var nfeProc = MockData.NFeProcessada.Value;

                nfeProc.NFe.infNFe.ide.tpEmis = TipoEmissaoNFe.ContingenciaOffline;

                danfe.Pdf(stream, nfeProc.NFe, nfeProc.protNFe, "cscId", "cscToken");
                stream.Close();
                Process.Start(file.Path);
                //time to load temp file
                Thread.Sleep(3000);
            }
        }
    }
}
