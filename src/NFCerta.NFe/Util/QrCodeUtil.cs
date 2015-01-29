namespace NFCerta.NFe.Util
{
    using System;
    using System.Security.Cryptography;
    using System.Text;
    using Schemas;

    public static class QrCodeUtil
    {
        public static string GeraQrCode(this TNFe nfe, string cscId, string cscToken, string digest=null)
        {
            var builder = new StringBuilder();

            builder.Append(ListaUrl.BuscaUrls(nfe.infNFe.ide.cUF, nfe.infNFe.ide.tpAmb).UrlNfceQrCode);

            var dataHex = ToHex(nfe.infNFe.ide.dhEmi ?? nfe.infNFe.ide.dhCont);
            if (digest == null)
            {
                digest = ToHex(nfe.Signature.SignedInfo.Reference.DigestValue);
            }

            var parametros = string.Format("chNFe={0}&nVersao={1}&tpAmb={2}&cDest={3}&dhEmi={4}&vNF={5}&vICMS={6}&digVal={7}",
                nfe.infNFe.Id.Substring(3),
                nfe.infNFe.versao,
                (int)nfe.infNFe.ide.tpAmb,
                (nfe.infNFe.dest != null && nfe.infNFe.dest.Item.HasValue()) ? nfe.infNFe.dest.Item : String.Empty,
                dataHex,
                nfe.infNFe.total.ICMSTot.vNF,
                nfe.infNFe.total.ICMSTot.vICMS,
                digest);

            builder.Append(parametros);
            builder.AppendFormat("&cIdToken={0}", cscId);
            using (var sha = SHA1.Create())
            {
                parametros += "&CSC=" + cscToken;
                builder.Append("&cHashQRCode=" + ToHex(sha.ComputeHash(Encoding.UTF8.GetBytes(parametros))));
            }

            return builder.ToString();
        }

        public static string ToHex(byte[] buffer)
        {
            var sb = new StringBuilder(buffer.Length * 2);

            foreach (byte b in buffer)
            {
                sb.Append(HexChar((int)(b >> 4)));
                sb.Append(HexChar((int)(b & 0xF)));
            }

            return sb.ToString();

        }

        public static string ToHex(string str)
        {
            var chars = str.ToCharArray();
            var sb = new StringBuilder(chars.Length * 2);
            foreach (var c in chars)
            {
                sb.AppendFormat("{0:X}", (int)c);
            }

            return sb.ToString();

        }

        private static char HexChar(int value)
        {
            return (char)(value > 9 ? value + '7' : value + '0');
        }
    }
}
