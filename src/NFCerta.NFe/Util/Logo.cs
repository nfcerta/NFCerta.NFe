namespace NFCerta.NFe.Util
{
    using System.IO;
    using System.Reflection;

    public class Logo
    {
        public static byte[] ToBytes()
        {
            using (var stream = typeof (Logo).Assembly.GetManifestResourceStream("NFCerta.NFe.Resources.logo.jpg"))
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
