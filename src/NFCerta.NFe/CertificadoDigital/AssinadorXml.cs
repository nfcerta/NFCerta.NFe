namespace NFCerta.NFe.CertificadoDigital
{
    using System;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;
    using System.Security.Cryptography.Xml;
    using System.Xml;
    using Schemas;

    public static class AssinadorXml
    {
        public static SignatureType GeraAssinatura(XmlDocument doc, string pUri, X509Certificate2 cert)
        {
            try
            {
                var signature = doc.GetElementsByTagName("Signature");
                if (signature.Count == 1)
                {
                    signature.Item(0).ParentNode.RemoveChild(signature.Item(0));
                }
                else if (signature.Count > 1)
                {
                    throw new InvalidOperationException("Não é possível assinar um documento com mais de uma assinatura existente.");
                }

                // Create a SignedXml object.
                var signedXml = new SignedXml(doc) {SigningKey = cert.PrivateKey};

                // Create a reference to be signed.
                var reference = new Reference();
                // pega o uri que deve ser assinada
                var uri = doc.GetElementsByTagName(pUri).Item(0).Attributes;
                foreach (XmlAttribute atributo in uri) {
                    if (atributo.Name == "Id") {
                        reference.Uri = "#" + atributo.InnerText;
                    }
                }

                // Add an enveloped transformation to the reference.
                var env = new XmlDsigEnvelopedSignatureTransform();
                reference.AddTransform(env);

                var c14 = new XmlDsigC14NTransform();
                reference.AddTransform(c14);

                // Add the reference to the SignedXml object.
                signedXml.AddReference(reference);

                // Create a new KeyInfo object.
                var keyInfo = new KeyInfo();

                // Load the certificate into a KeyInfoX509Data object
                // and add it to the KeyInfo object.
                keyInfo.AddClause(new KeyInfoX509Data(cert));

                // Add the KeyInfo object to the SignedXml object.
                signedXml.KeyInfo = keyInfo;

                // Compute the signature.
                signedXml.ComputeSignature();

                var xml = signedXml.GetXml();

                using (var sw = new StringWriter())
                using (var xw = new XmlTextWriter(sw))
                {
                    xml.WriteTo(xw);
                    xw.Close();

                    var sigXml = sw.ToString();
                    return SignatureType.Deserialize(sigXml);
                }
            } catch (Exception ex) {
                throw new Exception("Erro ao efetuar assinatura digital, detalhes: " + ex.Message);
            }
        }
    }
}