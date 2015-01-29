// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>NFe.NET</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>True</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>True</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>True</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NFCerta.NFe.Schemas.Cancelamento
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Xml;
    using NFCerta.NFe.Schemas.TiposBasicos;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetEnvEvento
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string idLoteField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private AmbienteSefaz tpAmbField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string verAplicField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private CodUfIbge cOrgaoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string cStatField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string xMotivoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private TRetEvento[] retEventoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string versaoField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string idLote
        {
            get
            {
                return this.idLoteField;
            }
            set
            {
                this.idLoteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AmbienteSefaz tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CodUfIbge cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("retEvento", Order = 6)]
        public TRetEvento[] retEvento
        {
            get
            {
                return this.retEventoField;
            }
            set
            {
                this.retEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(TRetEnvEvento));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current TRetEnvEvento object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize(System.Text.Encoding encoding)
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
                xmlWriterSettings.Encoding = encoding;
                System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
                Serializer.Serialize(xmlWriter, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }

        public virtual string Serialize()
        {
            return Serialize(Encoding.UTF8);
        }

        /// <summary>
        /// Deserializes workflow markup into an TRetEnvEvento object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TRetEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out TRetEnvEvento obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TRetEnvEvento);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string xml, out TRetEnvEvento obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static TRetEnvEvento Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((TRetEnvEvento)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        /// <summary>
        /// Serializes current TRetEnvEvento object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName, encoding);
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual bool SaveToFile(string fileName, out System.Exception exception)
        {
            return SaveToFile(fileName, Encoding.UTF8, out exception);
        }

        public virtual void SaveToFile(string fileName)
        {
            SaveToFile(fileName, Encoding.UTF8);
        }

        public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize(encoding);
                streamWriter = new System.IO.StreamWriter(fileName, false, Encoding.UTF8);
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes xml markup from file into an TRetEnvEvento object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TRetEnvEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out TRetEnvEvento obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TRetEnvEvento);
            try
            {
                obj = LoadFromFile(fileName, encoding);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out TRetEnvEvento obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out TRetEnvEvento obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static TRetEnvEvento LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, Encoding.UTF8);
        }

        public static TRetEnvEvento LoadFromFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try
            {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file, encoding);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEvento
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private TRetEventoInfEvento infEventoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private SignatureType signatureField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string versaoField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TRetEventoInfEvento infEvento
        {
            get
            {
                return this.infEventoField;
            }
            set
            {
                this.infEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 1)]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(TRetEvento));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current TRetEvento object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize(System.Text.Encoding encoding)
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
                xmlWriterSettings.Encoding = encoding;
                System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
                Serializer.Serialize(xmlWriter, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }

        public virtual string Serialize()
        {
            return Serialize(Encoding.UTF8);
        }

        /// <summary>
        /// Deserializes workflow markup into an TRetEvento object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TRetEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out TRetEvento obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TRetEvento);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string xml, out TRetEvento obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static TRetEvento Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((TRetEvento)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        /// <summary>
        /// Serializes current TRetEvento object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName, encoding);
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual bool SaveToFile(string fileName, out System.Exception exception)
        {
            return SaveToFile(fileName, Encoding.UTF8, out exception);
        }

        public virtual void SaveToFile(string fileName)
        {
            SaveToFile(fileName, Encoding.UTF8);
        }

        public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize(encoding);
                streamWriter = new System.IO.StreamWriter(fileName, false, Encoding.UTF8);
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes xml markup from file into an TRetEvento object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TRetEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out TRetEvento obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TRetEvento);
            try
            {
                obj = LoadFromFile(fileName, encoding);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out TRetEvento obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out TRetEvento obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static TRetEvento LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, Encoding.UTF8);
        }

        public static TRetEvento LoadFromFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try
            {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file, encoding);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEventoInfEvento
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private AmbienteSefaz tpAmbField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string verAplicField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private TCOrgaoIBGE cOrgaoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string cStatField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string xMotivoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string chNFeField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string tpEventoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string xEventoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string nSeqEventoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string itemField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private TipoDocumentoDest itemElementNameField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string emailDestField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string dhRegEventoField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string nProtField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string idField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AmbienteSefaz tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return this.cOrgaoField;
            }
            set
            {
                this.cOrgaoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string tpEvento
        {
            get
            {
                return this.tpEventoField;
            }
            set
            {
                this.tpEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string xEvento
        {
            get
            {
                return this.xEventoField;
            }
            set
            {
                this.xEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string nSeqEvento
        {
            get
            {
                return this.nSeqEventoField;
            }
            set
            {
                this.nSeqEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string), Order = 9)]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string), Order = 9)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocumentoDest ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string emailDest
        {
            get
            {
                return this.emailDestField;
            }
            set
            {
                this.emailDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string dhRegEvento
        {
            get
            {
                return this.dhRegEventoField;
            }
            set
            {
                this.dhRegEventoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(TRetEventoInfEvento));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current TRetEventoInfEvento object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize(System.Text.Encoding encoding)
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
                xmlWriterSettings.Encoding = encoding;
                System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
                Serializer.Serialize(xmlWriter, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }

        public virtual string Serialize()
        {
            return Serialize(Encoding.UTF8);
        }

        /// <summary>
        /// Deserializes workflow markup into an TRetEventoInfEvento object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output TRetEventoInfEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out TRetEventoInfEvento obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TRetEventoInfEvento);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string xml, out TRetEventoInfEvento obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static TRetEventoInfEvento Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((TRetEventoInfEvento)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        /// <summary>
        /// Serializes current TRetEventoInfEvento object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName, encoding);
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual bool SaveToFile(string fileName, out System.Exception exception)
        {
            return SaveToFile(fileName, Encoding.UTF8, out exception);
        }

        public virtual void SaveToFile(string fileName)
        {
            SaveToFile(fileName, Encoding.UTF8);
        }

        public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize(encoding);
                streamWriter = new System.IO.StreamWriter(fileName, false, Encoding.UTF8);
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes xml markup from file into an TRetEventoInfEvento object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output TRetEventoInfEvento object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out TRetEventoInfEvento obj, out System.Exception exception)
        {
            exception = null;
            obj = default(TRetEventoInfEvento);
            try
            {
                obj = LoadFromFile(fileName, encoding);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out TRetEventoInfEvento obj, out System.Exception exception)
        {
            return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
        }

        public static bool LoadFromFile(string fileName, out TRetEventoInfEvento obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static TRetEventoInfEvento LoadFromFile(string fileName)
        {
            return LoadFromFile(fileName, Encoding.UTF8);
        }

        public static TRetEventoInfEvento LoadFromFile(string fileName, System.Text.Encoding encoding)
        {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try
            {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file, encoding);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum TipoDocumentoDest
    {

        /// <remarks/>
        CNPJDest,

        /// <remarks/>
        CPFDest,
    }
}
