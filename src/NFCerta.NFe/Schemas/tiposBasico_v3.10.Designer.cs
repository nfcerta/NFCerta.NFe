// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.0.0.392
//    <NameSpace>ConsoleApplication2</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><DataMemberNameArg>OnlyIfDifferent</DataMemberNameArg><DataMemberOnXmlIgnore>False</DataMemberOnXmlIgnore><CodeBaseTag>Net45</CodeBaseTag><InitializeFields>All</InitializeFields><GenerateUnusedComplexTypes>True</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>True</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>True</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>True</AutomaticProperties><PropNameSpecified>Default</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><PrivateFieldNamePrefix></PrivateFieldNamePrefix><EnableRestriction>True</EnableRestriction><RestrictionMaxLenght>False</RestrictionMaxLenght><RestrictionRegEx>False</RestrictionRegEx><RestrictionRange>False</RestrictionRange><ValidateProperty>False</ValidateProperty><ClassNamePrefix></ClassNamePrefix><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>True</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>True</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>True</CleanupCode><EnableXmlSerialization>True</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><GenerateShouldSerialize>False</GenerateShouldSerialize><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings></CustomUsings>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace NFCerta.NFe.Schemas.TiposBasicos
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerDownloadNFe
    {

        /// <remarks/>
        [XmlEnumAttribute("1.00")]
        Item100,
    }

    /// <summary>
    /// Tipo C�digo da UF da tabela do IBGE
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public enum CodUfIbge
    {

        ///<remarks/>
        [XmlEnumAttribute("11")]
        Rondonia = 11,

        ///<remarks/>
        [XmlEnumAttribute("12")]
        Acre = 12,

        ///<remarks/>
        [XmlEnumAttribute("13")]
        Amazonas = 13,

        ///<remarks/>
        [XmlEnumAttribute("14")]
        Roraima = 14,

        ///<remarks/>
        [XmlEnumAttribute("15")]
        Para = 15,

        ///<remarks/>
        [XmlEnumAttribute("16")]
        Amapa = 16,

        ///<remarks/>
        [XmlEnumAttribute("17")]
        Tocantis = 17,

        ///<remarks/>
        [XmlEnumAttribute("21")]
        Maranhao = 21,

        ///<remarks/>
        [XmlEnumAttribute("22")]
        Piaui = 22,

        ///<remarks/>
        [XmlEnumAttribute("23")]
        Ceara = 23,

        ///<remarks/>
        [XmlEnumAttribute("24")]
        RioGrandeDoNorte = 24,

        ///<remarks/>
        [XmlEnumAttribute("25")]
        Paraiba = 25,

        ///<remarks/>
        [XmlEnumAttribute("26")]
        Pernambuco = 26,

        ///<remarks/>
        [XmlEnumAttribute("27")]
        Alagoas = 27,

        ///<remarks/>
        [XmlEnumAttribute("28")]
        Sergipe = 28,

        ///<remarks/>
        [XmlEnumAttribute("29")]
        Bahia = 29,

        ///<remarks/>
        [XmlEnumAttribute("31")]
        MinasGerais = 31,

        ///<remarks/>
        [XmlEnumAttribute("32")]
        EspiritoSanto = 32,

        ///<remarks/>
        [XmlEnumAttribute("33")]
        RioDeJaneiro = 33,

        ///<remarks/>
        [XmlEnumAttribute("35")]
        SaoPaulo = 35,

        ///<remarks/>
        [XmlEnumAttribute("41")]
        Parana = 41,

        ///<remarks/>
        [XmlEnumAttribute("42")]
        SantaCatarina = 42,

        ///<remarks/>
        [XmlEnumAttribute("43")]
        RioGrandeDoSul = 43,

        ///<remarks/>
        [XmlEnumAttribute("50")]
        MatoGrossoDoSul = 50,

        ///<remarks/>
        [XmlEnumAttribute("51")]
        MatoGrosso = 51,

        ///<remarks/>
        [XmlEnumAttribute("52")]
        Goias = 52,

        ///<remarks/>
        [XmlEnumAttribute("53")]
        DistritoFederal = 53,

        ///<remarks/>
        [XmlEnumAttribute("91")]
        Exterior = 91,
    }

    /// <summary>
    /// Tipo Modelo Documento Fiscal
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public enum ModeloDocumento
    {

        [XmlEnumAttribute("55")]
        NFe = 55,

        [XmlEnumAttribute("65")]
        NFCe = 65,
    }

    /// <summary>
    /// Tipo C�digo do Pais
    /// // PL_005d - 11/08/09
    /// eliminado:
    /// 4235-LEBUAN, ILHAS -
    /// acrescentado:
    /// 7200 SAO TOME E PRINCIPE, ILHAS,
    /// 8958 ZONA DO CANAL DO PANAMA
    /// 9903 PROVISAO DE NAVIOS E AERONAVES
    /// 9946 A DESIGNAR
    /// 9950 BANCOS CENTRAIS
    /// 9970 ORGANIZACOES INTERNACIONAIS
    /// // PL_005b - 24/10/08
    /// // Acrescentado:
    /// 4235 - LEBUAN,ILHAS
    /// 4885 - MAYOTTE (ILHAS FRANCESAS)
    /// // NT2011/004
    /// acrescentado a tabela de paises
    /// //PL_006t - 21/03/2014
    /// acrescentado:
    /// 5780 - Palestina
    /// 7600 - Sud�o do Sul
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public enum Tpais
    {

        [XmlEnumAttribute("132")]
        Item132,

        [XmlEnumAttribute("175")]
        Item175,

        [XmlEnumAttribute("230")]
        Item230,

        [XmlEnumAttribute("310")]
        Item310,

        [XmlEnumAttribute("370")]
        Item370,

        [XmlEnumAttribute("400")]
        Item400,

        [XmlEnumAttribute("418")]
        Item418,

        [XmlEnumAttribute("434")]
        Item434,

        [XmlEnumAttribute("477")]
        Item477,

        [XmlEnumAttribute("531")]
        Item531,

        [XmlEnumAttribute("590")]
        Item590,

        [XmlEnumAttribute("639")]
        Item639,

        [XmlEnumAttribute("647")]
        Item647,

        [XmlEnumAttribute("655")]
        Item655,

        [XmlEnumAttribute("698")]
        Item698,

        [XmlEnumAttribute("728")]
        Item728,

        [XmlEnumAttribute("736")]
        Item736,

        [XmlEnumAttribute("779")]
        Item779,

        [XmlEnumAttribute("809")]
        Item809,

        [XmlEnumAttribute("817")]
        Item817,

        [XmlEnumAttribute("833")]
        Item833,

        [XmlEnumAttribute("850")]
        Item850,

        [XmlEnumAttribute("876")]
        Item876,

        [XmlEnumAttribute("884")]
        Item884,

        [XmlEnumAttribute("906")]
        Item906,

        [XmlEnumAttribute("930")]
        Item930,

        [XmlEnumAttribute("973")]
        Item973,

        [XmlEnumAttribute("981")]
        Item981,

        [XmlEnumAttribute("0132")]
        Item0132,

        [XmlEnumAttribute("0175")]
        Item0175,

        [XmlEnumAttribute("0230")]
        Item0230,

        [XmlEnumAttribute("0310")]
        Item0310,

        [XmlEnumAttribute("0370")]
        Item0370,

        [XmlEnumAttribute("0400")]
        Item0400,

        [XmlEnumAttribute("0418")]
        Item0418,

        [XmlEnumAttribute("0434")]
        Item0434,

        [XmlEnumAttribute("0477")]
        Item0477,

        [XmlEnumAttribute("0531")]
        Item0531,

        [XmlEnumAttribute("0590")]
        Item0590,

        [XmlEnumAttribute("0639")]
        Item0639,

        [XmlEnumAttribute("0647")]
        Item0647,

        [XmlEnumAttribute("0655")]
        Item0655,

        [XmlEnumAttribute("0698")]
        Item0698,

        [XmlEnumAttribute("0728")]
        Item0728,

        [XmlEnumAttribute("0736")]
        Item0736,

        [XmlEnumAttribute("0779")]
        Item0779,

        [XmlEnumAttribute("0809")]
        Item0809,

        [XmlEnumAttribute("0817")]
        Item0817,

        [XmlEnumAttribute("0833")]
        Item0833,

        [XmlEnumAttribute("0850")]
        Item0850,

        [XmlEnumAttribute("0876")]
        Item0876,

        [XmlEnumAttribute("0884")]
        Item0884,

        [XmlEnumAttribute("0906")]
        Item0906,

        [XmlEnumAttribute("0930")]
        Item0930,

        [XmlEnumAttribute("0973")]
        Item0973,

        [XmlEnumAttribute("0981")]
        Item0981,

        [XmlEnumAttribute("1015")]
        Item1015,

        [XmlEnumAttribute("1058")]
        Item1058,

        [XmlEnumAttribute("1082")]
        Item1082,

        [XmlEnumAttribute("1112")]
        Item1112,

        [XmlEnumAttribute("1155")]
        Item1155,

        [XmlEnumAttribute("1198")]
        Item1198,

        [XmlEnumAttribute("1279")]
        Item1279,

        [XmlEnumAttribute("1376")]
        Item1376,

        [XmlEnumAttribute("1414")]
        Item1414,

        [XmlEnumAttribute("1457")]
        Item1457,

        [XmlEnumAttribute("1490")]
        Item1490,

        [XmlEnumAttribute("1504")]
        Item1504,

        [XmlEnumAttribute("1508")]
        Item1508,

        [XmlEnumAttribute("1511")]
        Item1511,

        [XmlEnumAttribute("1538")]
        Item1538,

        [XmlEnumAttribute("1546")]
        Item1546,

        [XmlEnumAttribute("1589")]
        Item1589,

        [XmlEnumAttribute("1600")]
        Item1600,

        [XmlEnumAttribute("1619")]
        Item1619,

        [XmlEnumAttribute("1635")]
        Item1635,

        [XmlEnumAttribute("1651")]
        Item1651,

        [XmlEnumAttribute("1694")]
        Item1694,

        [XmlEnumAttribute("1732")]
        Item1732,

        [XmlEnumAttribute("1775")]
        Item1775,

        [XmlEnumAttribute("1830")]
        Item1830,

        [XmlEnumAttribute("1872")]
        Item1872,

        [XmlEnumAttribute("1902")]
        Item1902,

        [XmlEnumAttribute("1937")]
        Item1937,

        [XmlEnumAttribute("1953")]
        Item1953,

        [XmlEnumAttribute("1961")]
        Item1961,

        [XmlEnumAttribute("1988")]
        Item1988,

        [XmlEnumAttribute("1996")]
        Item1996,

        [XmlEnumAttribute("2291")]
        Item2291,

        [XmlEnumAttribute("2321")]
        Item2321,

        [XmlEnumAttribute("2356")]
        Item2356,

        [XmlEnumAttribute("2399")]
        Item2399,

        [XmlEnumAttribute("2402")]
        Item2402,

        [XmlEnumAttribute("2437")]
        Item2437,

        [XmlEnumAttribute("2445")]
        Item2445,

        [XmlEnumAttribute("2453")]
        Item2453,

        [XmlEnumAttribute("2461")]
        Item2461,

        [XmlEnumAttribute("2470")]
        Item2470,

        [XmlEnumAttribute("2496")]
        Item2496,

        [XmlEnumAttribute("2518")]
        Item2518,

        [XmlEnumAttribute("2534")]
        Item2534,

        [XmlEnumAttribute("2550")]
        Item2550,

        [XmlEnumAttribute("2593")]
        Item2593,

        [XmlEnumAttribute("2674")]
        Item2674,

        [XmlEnumAttribute("2712")]
        Item2712,

        [XmlEnumAttribute("2755")]
        Item2755,

        [XmlEnumAttribute("2810")]
        Item2810,

        [XmlEnumAttribute("2852")]
        Item2852,

        [XmlEnumAttribute("2895")]
        Item2895,

        [XmlEnumAttribute("2917")]
        Item2917,

        [XmlEnumAttribute("2933")]
        Item2933,

        [XmlEnumAttribute("2976")]
        Item2976,

        [XmlEnumAttribute("3018")]
        Item3018,

        [XmlEnumAttribute("3050")]
        Item3050,

        [XmlEnumAttribute("3093")]
        Item3093,

        [XmlEnumAttribute("3131")]
        Item3131,

        [XmlEnumAttribute("3174")]
        Item3174,

        [XmlEnumAttribute("3255")]
        Item3255,

        [XmlEnumAttribute("3298")]
        Item3298,

        [XmlEnumAttribute("3310")]
        Item3310,

        [XmlEnumAttribute("3344")]
        Item3344,

        [XmlEnumAttribute("3379")]
        Item3379,

        [XmlEnumAttribute("3417")]
        Item3417,

        [XmlEnumAttribute("3450")]
        Item3450,

        [XmlEnumAttribute("3514")]
        Item3514,

        [XmlEnumAttribute("3557")]
        Item3557,

        [XmlEnumAttribute("3573")]
        Item3573,

        [XmlEnumAttribute("3595")]
        Item3595,

        [XmlEnumAttribute("3611")]
        Item3611,

        [XmlEnumAttribute("3654")]
        Item3654,

        [XmlEnumAttribute("3697")]
        Item3697,

        [XmlEnumAttribute("3727")]
        Item3727,

        [XmlEnumAttribute("3751")]
        Item3751,

        [XmlEnumAttribute("3794")]
        Item3794,

        [XmlEnumAttribute("3832")]
        Item3832,

        [XmlEnumAttribute("3867")]
        Item3867,

        [XmlEnumAttribute("3913")]
        Item3913,

        [XmlEnumAttribute("3964")]
        Item3964,

        [XmlEnumAttribute("3999")]
        Item3999,

        [XmlEnumAttribute("4030")]
        Item4030,

        [XmlEnumAttribute("4111")]
        Item4111,

        [XmlEnumAttribute("4200")]
        Item4200,

        [XmlEnumAttribute("4235")]
        Item4235,

        [XmlEnumAttribute("4260")]
        Item4260,

        [XmlEnumAttribute("4278")]
        Item4278,

        [XmlEnumAttribute("4316")]
        Item4316,

        [XmlEnumAttribute("4340")]
        Item4340,

        [XmlEnumAttribute("4383")]
        Item4383,

        [XmlEnumAttribute("4405")]
        Item4405,

        [XmlEnumAttribute("4421")]
        Item4421,

        [XmlEnumAttribute("4456")]
        Item4456,

        [XmlEnumAttribute("4472")]
        Item4472,

        [XmlEnumAttribute("4499")]
        Item4499,

        [XmlEnumAttribute("4502")]
        Item4502,

        [XmlEnumAttribute("4525")]
        Item4525,

        [XmlEnumAttribute("4553")]
        Item4553,

        [XmlEnumAttribute("4588")]
        Item4588,

        [XmlEnumAttribute("4618")]
        Item4618,

        [XmlEnumAttribute("4642")]
        Item4642,

        [XmlEnumAttribute("4677")]
        Item4677,

        [XmlEnumAttribute("4723")]
        Item4723,

        [XmlEnumAttribute("4740")]
        Item4740,

        [XmlEnumAttribute("4766")]
        Item4766,

        [XmlEnumAttribute("4774")]
        Item4774,

        [XmlEnumAttribute("4855")]
        Item4855,

        [XmlEnumAttribute("4880")]
        Item4880,

        [XmlEnumAttribute("4885")]
        Item4885,

        [XmlEnumAttribute("4901")]
        Item4901,

        [XmlEnumAttribute("4936")]
        Item4936,

        [XmlEnumAttribute("4944")]
        Item4944,

        [XmlEnumAttribute("4952")]
        Item4952,

        [XmlEnumAttribute("4979")]
        Item4979,

        [XmlEnumAttribute("4985")]
        Item4985,

        [XmlEnumAttribute("4995")]
        Item4995,

        [XmlEnumAttribute("5010")]
        Item5010,

        [XmlEnumAttribute("5053")]
        Item5053,

        [XmlEnumAttribute("5070")]
        Item5070,

        [XmlEnumAttribute("5088")]
        Item5088,

        [XmlEnumAttribute("5118")]
        Item5118,

        [XmlEnumAttribute("5177")]
        Item5177,

        [XmlEnumAttribute("5215")]
        Item5215,

        [XmlEnumAttribute("5258")]
        Item5258,

        [XmlEnumAttribute("5282")]
        Item5282,

        [XmlEnumAttribute("5312")]
        Item5312,

        [XmlEnumAttribute("5355")]
        Item5355,

        [XmlEnumAttribute("5380")]
        Item5380,

        [XmlEnumAttribute("5428")]
        Item5428,

        [XmlEnumAttribute("5452")]
        Item5452,

        [XmlEnumAttribute("5487")]
        Item5487,

        [XmlEnumAttribute("5517")]
        Item5517,

        [XmlEnumAttribute("5568")]
        Item5568,

        [XmlEnumAttribute("5665")]
        Item5665,

        [XmlEnumAttribute("5738")]
        Item5738,

        [XmlEnumAttribute("5754")]
        Item5754,

        [XmlEnumAttribute("5762")]
        Item5762,

        [XmlEnumAttribute("5780")]
        Item5780,

        [XmlEnumAttribute("5800")]
        Item5800,

        [XmlEnumAttribute("5860")]
        Item5860,

        [XmlEnumAttribute("5894")]
        Item5894,

        [XmlEnumAttribute("5932")]
        Item5932,

        [XmlEnumAttribute("5991")]
        Item5991,

        [XmlEnumAttribute("6033")]
        Item6033,

        [XmlEnumAttribute("6076")]
        Item6076,

        [XmlEnumAttribute("6114")]
        Item6114,

        [XmlEnumAttribute("6238")]
        Item6238,

        [XmlEnumAttribute("6254")]
        Item6254,

        [XmlEnumAttribute("6289")]
        Item6289,

        [XmlEnumAttribute("6408")]
        Item6408,

        [XmlEnumAttribute("6475")]
        Item6475,

        [XmlEnumAttribute("6602")]
        Item6602,

        [XmlEnumAttribute("6653")]
        Item6653,

        [XmlEnumAttribute("6700")]
        Item6700,

        [XmlEnumAttribute("6750")]
        Item6750,

        [XmlEnumAttribute("6769")]
        Item6769,

        [XmlEnumAttribute("6777")]
        Item6777,

        [XmlEnumAttribute("6781")]
        Item6781,

        [XmlEnumAttribute("6858")]
        Item6858,

        [XmlEnumAttribute("6874")]
        Item6874,

        [XmlEnumAttribute("6904")]
        Item6904,

        [XmlEnumAttribute("6912")]
        Item6912,

        [XmlEnumAttribute("6955")]
        Item6955,

        [XmlEnumAttribute("6971")]
        Item6971,

        [XmlEnumAttribute("7005")]
        Item7005,

        [XmlEnumAttribute("7056")]
        Item7056,

        [XmlEnumAttribute("7102")]
        Item7102,

        [XmlEnumAttribute("7153")]
        Item7153,

        [XmlEnumAttribute("7200")]
        Item7200,

        [XmlEnumAttribute("7285")]
        Item7285,

        [XmlEnumAttribute("7315")]
        Item7315,

        [XmlEnumAttribute("7358")]
        Item7358,

        [XmlEnumAttribute("7370")]
        Item7370,

        [XmlEnumAttribute("7412")]
        Item7412,

        [XmlEnumAttribute("7447")]
        Item7447,

        [XmlEnumAttribute("7480")]
        Item7480,

        [XmlEnumAttribute("7501")]
        Item7501,

        [XmlEnumAttribute("7544")]
        Item7544,

        [XmlEnumAttribute("7560")]
        Item7560,

        [XmlEnumAttribute("7595")]
        Item7595,

        [XmlEnumAttribute("7600")]
        Item7600,

        [XmlEnumAttribute("7641")]
        Item7641,

        [XmlEnumAttribute("7676")]
        Item7676,

        [XmlEnumAttribute("7706")]
        Item7706,

        [XmlEnumAttribute("7722")]
        Item7722,

        [XmlEnumAttribute("7765")]
        Item7765,

        [XmlEnumAttribute("7803")]
        Item7803,

        [XmlEnumAttribute("7820")]
        Item7820,

        [XmlEnumAttribute("7838")]
        Item7838,

        [XmlEnumAttribute("7889")]
        Item7889,

        [XmlEnumAttribute("7919")]
        Item7919,

        [XmlEnumAttribute("7951")]
        Item7951,

        [XmlEnumAttribute("8001")]
        Item8001,

        [XmlEnumAttribute("8052")]
        Item8052,

        [XmlEnumAttribute("8109")]
        Item8109,

        [XmlEnumAttribute("8150")]
        Item8150,

        [XmlEnumAttribute("8206")]
        Item8206,

        [XmlEnumAttribute("8230")]
        Item8230,

        [XmlEnumAttribute("8249")]
        Item8249,

        [XmlEnumAttribute("8273")]
        Item8273,

        [XmlEnumAttribute("8281")]
        Item8281,

        [XmlEnumAttribute("8311")]
        Item8311,

        [XmlEnumAttribute("8338")]
        Item8338,

        [XmlEnumAttribute("8451")]
        Item8451,

        [XmlEnumAttribute("8478")]
        Item8478,

        [XmlEnumAttribute("8486")]
        Item8486,

        [XmlEnumAttribute("8508")]
        Item8508,

        [XmlEnumAttribute("8583")]
        Item8583,

        [XmlEnumAttribute("8630")]
        Item8630,

        [XmlEnumAttribute("8664")]
        Item8664,

        [XmlEnumAttribute("8702")]
        Item8702,

        [XmlEnumAttribute("8737")]
        Item8737,

        [XmlEnumAttribute("8885")]
        Item8885,

        [XmlEnumAttribute("8907")]
        Item8907,

        [XmlEnumAttribute("8958")]
        Item8958,

        [XmlEnumAttribute("9903")]
        Item9903,

        [XmlEnumAttribute("9946")]
        Item9946,

        [XmlEnumAttribute("9950")]
        Item9950,

        [XmlEnumAttribute("9970")]
        Item9970,
    }

    /// <summary>
    /// Tipo Sigla da UF
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public enum TUf
    {

        AC,

        AL,

        AM,

        AP,

        BA,

        CE,

        DF,

        ES,

        GO,

        MA,

        MG,

        MS,

        MT,

        PA,

        PB,

        PE,

        PI,

        PR,

        RJ,

        RN,

        RO,

        RR,

        RS,

        SC,

        SE,

        SP,

        TO,

        EX,
    }

    /// <summary>
    /// Tipo Sigla da UF de emissor // acrescentado em 24/10/08
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public enum TUfEmi
    {

        AC,

        AL,

        AM,

        AP,

        BA,

        CE,

        DF,

        ES,

        GO,

        MA,

        MG,

        MS,

        MT,

        PA,

        PB,

        PE,

        PI,

        PR,

        RJ,

        RN,

        RO,

        RR,

        RS,

        SC,

        SE,

        SP,

        TO,
    }

    /// <summary>
    /// Tipo Ambiente
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public enum AmbienteSefaz
    {

        [XmlEnumAttribute("1")]
        Producao=1,

        [XmlEnumAttribute("2")]
        Homologacao=2,
    }

    /// <summary>
    /// Tipo C�digo de org�o (UF da tabela do IBGE + 90 RFB)
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public enum TCOrgaoIBGE
    {

        [XmlEnumAttribute("11")]
        Rondonia,

        [XmlEnumAttribute("12")]
        Acre,

        [XmlEnumAttribute("13")]
        Amazonas,

        [XmlEnumAttribute("14")]
        Roraima,

        [XmlEnumAttribute("15")]
        Para,

        [XmlEnumAttribute("16")]
        Amapa,

        [XmlEnumAttribute("17")]
        Tocantins,

        [XmlEnumAttribute("21")]
        Maranhao,

        [XmlEnumAttribute("22")]
        Piaui,

        [XmlEnumAttribute("23")]
        Ceara,

        [XmlEnumAttribute("24")]
        RioGrandeDoNorte,

        [XmlEnumAttribute("25")]
        Paraiba,

        [XmlEnumAttribute("26")]
        Pernambuco,

        [XmlEnumAttribute("27")]
        Alagoas,

        [XmlEnumAttribute("28")]
        Sergipe,

        [XmlEnumAttribute("29")]
        Bahia,

        [XmlEnumAttribute("31")]
        MinasGerais,

        [XmlEnumAttribute("32")]
        EspiritoSanto,

        /// <remarks/>
        [XmlEnumAttribute("33")]
        RioDeJaneiro,

        /// <remarks/>
        [XmlEnumAttribute("35")]
        SaoPaulo,

        /// <remarks/>
        [XmlEnumAttribute("41")]
        Parana,

        /// <remarks/>
        [XmlEnumAttribute("42")]
        SantaCatarina,

        /// <remarks/>
        [XmlEnumAttribute("43")]
        RioGrandeDoSul,

        /// <remarks/>
        [XmlEnumAttribute("50")]
        MatoGrossoDoSul,

        /// <remarks/>
        [XmlEnumAttribute("51")]
        MatoGrosso,

        /// <remarks/>
        [XmlEnumAttribute("52")]
        Goias,

        /// <remarks/>
        [XmlEnumAttribute("53")]
        DistritoFederal,

        /// <remarks/>
        [XmlEnumAttribute("90")]
        Exterior,

        /// <remarks/>
        [XmlEnumAttribute("91")]
        AmbienteNacional,
    }
}
#pragma warning restore
