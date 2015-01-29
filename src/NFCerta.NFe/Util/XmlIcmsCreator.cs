namespace NFCerta.NFe.Util
{
    using System.Xml.Linq;

    public class XmlImpostoCreator
    {
        private const string Ns = "{http://www.portalfiscal.inf.br/nfe}";
        public static void Icms(XElement imposto)
        {
            
            if (imposto == null) return;

            var icms = imposto.Element(Ns + "ICMS");
            if (icms == null) return;

            if (icms.Element(Ns + "ICMS00") == null)
            {
                var icms00 = new XElement(Ns + "ICMS00");
                icms00.Add(new XElement(Ns + "orig", ""));
                icms00.Add(new XElement(Ns + "CST", ""));
                icms00.Add(new XElement(Ns + "vBC", ""));
                icms00.Add(new XElement(Ns + "vICMS", ""));
                icms00.Add(new XElement(Ns + "pICMS", ""));

                icms.Add(icms00);
            }

            if (icms.Element(Ns + "ICMS10") == null)
            {
                var icms10 = new XElement(Ns + "ICMS10");
                icms10.Add(new XElement(Ns + "orig", ""));
                icms10.Add(new XElement(Ns + "CST", ""));
                icms10.Add(new XElement(Ns + "vBC", ""));
                icms10.Add(new XElement(Ns + "vICMS", ""));
                icms10.Add(new XElement(Ns + "pICMS", ""));

                icms.Add(icms10);
            }

            if (icms.Element(Ns + "ICMS20") == null)
            {
                var icms20 = new XElement(Ns + "ICMS20");
                icms20.Add(new XElement(Ns + "orig", ""));
                icms20.Add(new XElement(Ns + "CST", ""));
                icms20.Add(new XElement(Ns + "vBC", ""));
                icms20.Add(new XElement(Ns + "vICMS", ""));
                icms20.Add(new XElement(Ns + "pICMS", ""));

                icms.Add(icms20);
            }

            if (icms.Element(Ns + "ICMS30") == null)
            {
                var icms30 = new XElement(Ns + "ICMS30");
                icms30.Add(new XElement(Ns + "orig", ""));
                icms30.Add(new XElement(Ns + "CST", ""));

                icms.Add(icms30);
            }

            if (icms.Element(Ns + "ICMS40") == null)
            {
                var icms40 = new XElement(Ns + "ICMS40");
                icms40.Add(new XElement(Ns + "orig", ""));
                icms40.Add(new XElement(Ns + "CST", ""));

                icms.Add(icms40);
            }

            if (icms.Element(Ns + "ICMS51") == null)
            {
                var icms51 = new XElement(Ns + "ICMS51");
                icms51.Add(new XElement(Ns + "orig", ""));
                icms51.Add(new XElement(Ns + "CST", ""));
                icms51.Add(new XElement(Ns + "vBC", ""));
                icms51.Add(new XElement(Ns + "vICMS", ""));
                icms51.Add(new XElement(Ns + "pICMS", ""));

                icms.Add(icms51);
            }

            if (icms.Element(Ns + "ICMS60") == null)
            {
                var icms60 = new XElement(Ns + "ICMS60");
                icms60.Add(new XElement(Ns + "orig", ""));
                icms60.Add(new XElement(Ns + "CST", ""));

                icms.Add(icms60);
            }

            if (icms.Element(Ns + "ICMS70") == null)
            {
                var icms70 = new XElement(Ns + "ICMS70");
                icms70.Add(new XElement(Ns + "orig", ""));
                icms70.Add(new XElement(Ns + "CST", ""));
                icms70.Add(new XElement(Ns + "vBC", ""));
                icms70.Add(new XElement(Ns + "vICMS", ""));
                icms70.Add(new XElement(Ns + "pICMS", ""));

                icms.Add(icms70);
            }

            if (icms.Element(Ns + "ICMS90") == null)
            {
                var icms90 = new XElement(Ns + "ICMS90");
                icms90.Add(new XElement(Ns + "orig", ""));
                icms90.Add(new XElement(Ns + "CST", ""));
                icms90.Add(new XElement(Ns + "vBC", ""));
                icms90.Add(new XElement(Ns + "vICMS", ""));
                icms90.Add(new XElement(Ns + "pICMS", ""));

                icms.Add(icms90);
            }

            if (icms.Element(Ns + "ICMSPart") == null)
            {
                var icmsPart = new XElement(Ns + "ICMSPart");
                icmsPart.Add(new XElement(Ns + "orig", ""));
                icmsPart.Add(new XElement(Ns + "CST", ""));
                icmsPart.Add(new XElement(Ns + "vBC", ""));
                icmsPart.Add(new XElement(Ns + "vICMS", ""));
                icmsPart.Add(new XElement(Ns + "pICMS", ""));

                icms.Add(icmsPart);
            }

            if (icms.Element(Ns + "ICMSSN101") == null)
            {
                var icmssn101 = new XElement(Ns + "ICMSSN101");
                icmssn101.Add(new XElement(Ns + "orig", ""));
                icmssn101.Add(new XElement(Ns + "CSOSN", ""));

                icms.Add(icmssn101);
            }

            if (icms.Element(Ns + "ICMSSN102") == null)
            {
                var icmssn102 = new XElement(Ns + "ICMSSN102");
                icmssn102.Add(new XElement(Ns + "orig", ""));
                icmssn102.Add(new XElement(Ns + "CSOSN", ""));

                icms.Add(icmssn102);
            }

            if (icms.Element(Ns + "ICMSSN201") == null)
            {
                var icmssn201 = new XElement(Ns + "ICMSSN201");
                icmssn201.Add(new XElement(Ns + "orig", ""));
                icmssn201.Add(new XElement(Ns + "CSOSN", ""));

                icms.Add(icmssn201);
            }

            if (icms.Element(Ns + "ICMSSN202") == null)
            {
                var icmssn202 = new XElement(Ns + "ICMSSN202");
                icmssn202.Add(new XElement(Ns + "orig", ""));
                icmssn202.Add(new XElement(Ns + "CSOSN", ""));

                icms.Add(icmssn202);
            }

            if (icms.Element(Ns + "ICMSSN500") == null)
            {
                var icmssn500 = new XElement(Ns + "ICMSSN500");
                icmssn500.Add(new XElement(Ns + "orig", ""));
                icmssn500.Add(new XElement(Ns + "CSOSN", ""));

                icms.Add(icmssn500);
            }

            if (icms.Element(Ns + "ICMSSN900") == null)
            {
                var icmssn900 = new XElement(Ns + "ICMSSN900");
                icmssn900.Add(new XElement(Ns + "orig", ""));
                icmssn900.Add(new XElement(Ns + "CSOSN", ""));
                icmssn900.Add(new XElement(Ns + "vBC", ""));
                icmssn900.Add(new XElement(Ns + "vICMS", ""));
                icmssn900.Add(new XElement(Ns + "pICMS", ""));

                icms.Add(icmssn900);
            }

            if (icms.Element(Ns + "ICMSST") == null)
            {
                var icmsst = new XElement(Ns + "ICMSST");
                icmsst.Add(new XElement(Ns + "orig", ""));
                icmsst.Add(new XElement(Ns + "CST", ""));

                icms.Add(icmsst);
            }

            if (icms.Element(Ns + "ISSQN") != null) return;
            var issqn = new XElement(Ns + "ISSQN");
            issqn.Add(new XElement(Ns + "ISSQN", ""));

            icms.Add(issqn);
        }

        public static void Ipi(XElement imposto)
        {
            var ipi = imposto.Element(Ns + "IPI");
            if (ipi == null)
            {
                ipi = new XElement(Ns + "IPI");
                imposto.Add(ipi);
            }
            if (ipi.Element(Ns + "IPITrib") != null) return;
            var ipiTrib = new XElement(Ns + "IPITrib");
            ipiTrib.Add(new XElement(Ns + "pIPI", "0.00"));
            ipiTrib.Add(new XElement(Ns + "vIPI", "0.00"));
            ipi.Add(ipiTrib);
        }
    }
}
