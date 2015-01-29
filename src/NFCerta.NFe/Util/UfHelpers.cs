namespace NFCerta.NFe.Util
{
    using System;
    using Schemas.TiposBasicos;

    public static class UfHelpers
    {
        public static CodUfIbge ToCodUfIbge(this string uf)
        {
            switch (uf)
            {
                case "RJ":
                    return CodUfIbge.RioDeJaneiro;
                case "SP":
                    return CodUfIbge.SaoPaulo;
                case "AC":
                    return CodUfIbge.Acre;
                case "AL":
                    return CodUfIbge.Alagoas;
                case "AM":
                    return CodUfIbge.Amazonas;
                case "AP":
                    return CodUfIbge.Amapa;
                case "BA":
                    return CodUfIbge.Bahia;
                case "CE":
                    return CodUfIbge.Ceara;
                case "DF":
                    return CodUfIbge.DistritoFederal;
                case "ES":
                    return CodUfIbge.EspiritoSanto;
                case "GO":
                    return CodUfIbge.Goias;
                case "MA":
                    return CodUfIbge.Maranhao;
                case "MG":
                    return CodUfIbge.MinasGerais;
                case "MS":
                    return CodUfIbge.MatoGrossoDoSul;
                case "MT":
                    return CodUfIbge.MatoGrosso;
                case "PA":
                    return CodUfIbge.Para;
                case "PB":
                    return CodUfIbge.Paraiba;
                case "PE":
                    return CodUfIbge.Pernambuco;
                case "PI":
                    return CodUfIbge.Piaui;
                case "PR":
                    return CodUfIbge.Parana;
                case "RN":
                    return CodUfIbge.RioGrandeDoNorte;
                case "RO":
                    return CodUfIbge.Rondonia;
                case "RR":
                    return CodUfIbge.Roraima;
                case "RS":
                    return CodUfIbge.RioGrandeDoSul;
                case "SC":
                    return CodUfIbge.SantaCatarina;
                case "SE":
                    return CodUfIbge.Sergipe;
                case "TO":
                    return CodUfIbge.Tocantis;
                default:
                    throw new InvalidOperationException("Não foi posshbla");
            }
        }

        public static string GetTimeZoneName(this TUfEmi uf)
        {
            // http://en.wikipedia.org/wiki/Time_in_Brazil#IANA_time_zone_database

            string zoneName = "";

            switch (uf)
            {
                //case Atlantic islands
                //    zoneName = "America/Noronha";
                //    break;
                case TUfEmi.AP:
                case TUfEmi.PA: //East
                    zoneName = "America/Belem";
                    break;
                case TUfEmi.MA:
                case TUfEmi.PI:
                case TUfEmi.CE:
                case TUfEmi.RN:
                case TUfEmi.PB:
                    zoneName = "America/Fortaleza";
                    break;
                case TUfEmi.PE:
                    zoneName = "America/Fortaleza";
                    break;
                case TUfEmi.TO:
                    zoneName = "America/Araguaiaina";
                    break;
                case TUfEmi.AL:
                case TUfEmi.SE:
                    zoneName = "America/Maceio";
                    break;
                case TUfEmi.BA:
                    zoneName = "America/Bahia";
                    break;
                case TUfEmi.GO:
                case TUfEmi.DF:
                case TUfEmi.MG:
                case TUfEmi.ES:
                case TUfEmi.RJ:
                case TUfEmi.SP:
                case TUfEmi.PR:
                case TUfEmi.SC:
                case TUfEmi.RS:
                    zoneName = "America/Sao_Paulo";
                    break;
                case TUfEmi.MS:
                    zoneName = "America/Campo_Grande";
                    break;
                case TUfEmi.MT:
                    zoneName = "America/Cuiaba";
                    break;
                //case TUfEmi.PA: //West
                //    zoneName = "America/Santarem";
                //    break;
                case TUfEmi.RO:
                    zoneName = "America/Boa_Vista";
                    break;
                case TUfEmi.RR:
                    zoneName = "America/Porto_Velho";
                    break;
                case TUfEmi.AM: //East
                    zoneName = "America/Manaus";
                    break;
                //case TUfEmi.AM: //West
                //    zoneName = "America/Eirunepe";
                //    break;
                case TUfEmi.AC:
                    zoneName = "America/Rio_Branco";
                    break;
            }

            return zoneName;
        }
    }

    public enum CodStatus
    {
        AutorizadooUsoDaNFe = 100,
        CancelamentoDeNFeHomologado = 101,
        InutilizacaoDeNumeroHomologado = 102,
        LoteRecebidoComSucesso = 103,
        LoteProcessado = 104,
        LoteEmProcessamento = 105,
        LoteNaoLocalizado = 106,
        ServicoEmOperacao = 107,
        ServicoParalisadoMomentaneamente = 108,
        ServicoParalisadoSemPrevisao = 109,
        UsoDenegado = 110,
        ConsultaCadastroComUmaOcorrencia = 111,
        ConsultaCadastroComMaisDeUmaOcorreencia = 112,
        LoteDeEventoProcessado = 128,
        EventoRegistradoEVinculadoaNFe = 135,
        EventoRegistradoMasNaoVinculadoaNFe = 136
    }
}
