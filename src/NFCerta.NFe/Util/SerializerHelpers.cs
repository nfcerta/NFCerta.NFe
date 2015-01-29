namespace NFCerta.NFe.Util
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    public static class SerializerHelpers
    {
        public readonly static Lazy<XmlSerializerNamespaces> Namespace = new Lazy<XmlSerializerNamespaces>(() =>
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add(String.Empty, "http://www.portalfiscal.inf.br/nfe");
            return ns;
        });

        public static string LimpaNamespaces(this string xml)
        {
            xml = xml.Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "");
            xml = xml.Replace("xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "");
            return xml;
        }

        public static XmlDocument ToXmlDocument(this string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml.LimpaNamespaces());

            return doc;
        }
    }

    public class SefazXmlTextWriter : XmlTextWriter
    {
        public SefazXmlTextWriter(Stream stream) : base(stream, Encoding.UTF8)
        {

        }

        public override void WriteEndElement()
        {
            base.WriteFullEndElement();
        }
    }
}