namespace NFCerta.NFe.Json
{
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Serialization;

    public sealed class NFCertaJsonSerializer : JsonSerializer
    {
        public NFCertaJsonSerializer()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver();
            DateFormatHandling = DateFormatHandling.IsoDateFormat;
            DateParseHandling = DateParseHandling.DateTimeOffset;
            Converters.Add(new StringEnumConverter());
        }

        public string Serialize(object data)
        {
            using(var sw = new StringWriter())
            {
                Serialize(sw, data);
                sw.Flush();
                return sw.ToString();
            }
        }

        public T Deserialize<T>(string json)
        {
            using(var textReader = new StringReader(json))
            using(var reader = new JsonTextReader(textReader))
            {
                return this.Deserialize<T>(reader);
            }
        }
    }
}
