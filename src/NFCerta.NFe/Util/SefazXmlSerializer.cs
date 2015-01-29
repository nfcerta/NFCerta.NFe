namespace NFCerta.NFe.Util
{
    using System;
    using System.Collections.Concurrent;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    public static class SefazXmlSerializer
    {
        private readonly static XmlSerializerFactory Factory = new XmlSerializerFactory();
        private readonly static ConcurrentDictionary<Type, XmlSerializer> Serializers = new ConcurrentDictionary<Type, XmlSerializer>(); 
        
        public static string Serialize(object obj)
        {
            var type = obj.GetType();
            var serializer = Serializers.GetOrAdd(type, t => Factory.CreateSerializer(type));

            using (var memoryStream = new MemoryStream())
            using (var streamReader = new StreamReader(memoryStream))
            {
                serializer.Serialize(new SefazXmlTextWriter(memoryStream), obj, SerializerHelpers.Namespace.Value);
                memoryStream.Seek(0, SeekOrigin.Begin);
                var xml = streamReader.ReadToEnd();

                return xml;
            }
        }

        public static T Deserialize<T>(string xml)
        {
            var type = typeof(T);
            var serializer = Serializers.GetOrAdd(type, t => Factory.CreateSerializer(type));

            using (var reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(XmlReader.Create(reader));
            }
        }
    }
}