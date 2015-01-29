namespace NFCerta.NFe
{
    using Schemas.TiposBasicos;

    public struct ListaUrl
    {
        public string UrlNfeRecepcao;
        public string UrlNfeRetRecepcao;
        public string UrlNfeCancelamento;
        public string UrlNfeInutilizacao;
        public string UrlNfeConsultaProtocolo;
        public string UrlNfeStatusServico;
        public string UrlNfeConsultaCadastro;
        public string UrlRecepcaoEvento;
        public string UrlNfeDownloadNF;
        public string UrlNfeAutorizacao;
        public string UrlNfeRetAutorizacao;
        public string UrlNfceQrCode;
        public string UrlNfceConsultaChaveAcesso;

        public static ListaUrl BuscaUrls(CodUfIbge uf, AmbienteSefaz ambiente)
        {
            var UrlWs = default(ListaUrl);
            switch (uf)
            {
                //ESTADOS QUE USAM A SEFAZ VIRTUAL DO RS PARA EMITIR NFE
                case CodUfIbge.Acre:
                case CodUfIbge.Alagoas:
                case CodUfIbge.Amapa:
                case CodUfIbge.DistritoFederal:
                case CodUfIbge.Paraiba:
                case CodUfIbge.RioDeJaneiro:
                case CodUfIbge.Rondonia:
                case CodUfIbge.Roraima:
                case CodUfIbge.SantaCatarina:
                case CodUfIbge.Sergipe:
                case CodUfIbge.Tocantis:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://homologacao.nfe.sefazvirtual.rs.gov.br/ws/nferecepcao/NfeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://homologacao.nfe.sefazvirtual.rs.gov.br/ws/nferetrecepcao/NfeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://homologacao.nfe.sefazvirtual.rs.gov.br/ws/nfecancelamento/NfeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://homologacao.nfe.sefazvirtual.rs.gov.br/ws/nfeinutilizacao/NfeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://homologacao.nfe.sefazvirtual.rs.gov.br/ws/nfeconsulta/NfeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://homologacao.nfe.sefazvirtual.rs.gov.br/ws/nfestatusservico/NfeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "";
                        UrlWs.UrlRecepcaoEvento = "https://homologacao.nfe.sefazvirtual.rs.gov.br/ws/recepcaoevento/recepcaoevento.asmx";
                        UrlWs.UrlNfeAutorizacao = "https://homologacao.nfe.sefazvirtual.rs.gov.br/ws/NfeAutorizacao/NFeAutorizacao.asmx";
                        UrlWs.UrlNfeRetAutorizacao = "https://homologacao.nfe.sefazvirtual.rs.gov.br/ws/NfeRetAutorizacao/NFeRetAutorizacao.asmx";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.sefazvirtual.rs.gov.br/ws/nferecepcao/NfeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.sefazvirtual.rs.gov.br/ws/nferetrecepcao/NfeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://nfe.sefazvirtual.rs.gov.br/ws/nfecancelamento/NfeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.sefazvirtual.rs.gov.br/ws/nfeinutilizacao/NfeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.sefazvirtual.rs.gov.br/ws/nfeconsulta/NfeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://nfe.sefazvirtual.rs.gov.br/ws/nfestatusservico/NfeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "";
                        UrlWs.UrlRecepcaoEvento = "https://nfe.sefazvirtual.rs.gov.br/ws/recepcaoevento/recepcaoevento.asmx";
                        UrlWs.UrlNfeAutorizacao = "https://nfe.sefazvirtual.rs.gov.br/ws/NfeAutorizacao/NFeAutorizacao.asmx";
                        UrlWs.UrlNfeRetAutorizacao = "https://nfe.sefazvirtual.rs.gov.br/ws/NfeRetAutorizacao/NFeRetAutorizacao.asmx";
                    }
                    break;
                //ESTADOS QUE USA O SEFAZ NACIONAL PARA EMITIR NFE
                case CodUfIbge.EspiritoSanto:
                case CodUfIbge.Maranhao:
                case CodUfIbge.Para:
                case CodUfIbge.Piaui:
                case CodUfIbge.RioGrandeDoNorte:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://hom.sefazvirtual.fazenda.gov.br/NfeRecepcao2/NfeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://hom.sefazvirtual.fazenda.gov.br/NFeRetRecepcao2/NFeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://hom.sefazvirtual.fazenda.gov.br/NFeCancelamento2/NFeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://hom.sefazvirtual.fazenda.gov.br/NFeInutilizacao2/NFeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://hom.sefazvirtual.fazenda.gov.br/nfeconsulta2/nfeconsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://hom.sefazvirtual.fazenda.gov.br/NFeStatusServico2/NFeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "";
                        UrlWs.UrlRecepcaoEvento = "";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://www.sefazvirtual.fazenda.gov.br/NfeRecepcao2/NfeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://www.sefazvirtual.fazenda.gov.br/NFeRetRecepcao2/NFeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://www.sefazvirtual.fazenda.gov.br/NFeCancelamento2/NFeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://www.sefazvirtual.fazenda.gov.br/NFeInutilizacao2/NFeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://www.sefazvirtual.fazenda.gov.br/nfeconsulta2/nfeconsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://www.sefazvirtual.fazenda.gov.br/NFeStatusServico2/NFeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "";
                        UrlWs.UrlRecepcaoEvento = "";
                    }
                    break;
                // ERROR: Case labels with binary operators are unsupported : Equality
                //AM USA SEFAZ PROPRIA
                case CodUfIbge.Amazonas:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://homnfe.sefaz.am.gov.br/services2/services/NfeRecepcao2";
                        UrlWs.UrlNfeRetRecepcao = "https://homnfe.sefaz.am.gov.br/services2/services/NfeRetRecepcao2";
                        UrlWs.UrlNfeCancelamento = "https://homnfe.sefaz.am.gov.br/services2/services/NfeCancelamento2";
                        UrlWs.UrlNfeInutilizacao = "https://homnfe.sefaz.am.gov.br/services2/services/NfeInutilizacao2";
                        UrlWs.UrlNfeConsultaProtocolo = "https://homnfe.sefaz.am.gov.br/services2/services/NfeConsulta2";
                        UrlWs.UrlNfeStatusServico = "https://homnfe.sefaz.am.gov.br/services2/services/NfeStatusServico2";
                        UrlWs.UrlNfeConsultaCadastro = "https://homnfe.sefaz.am.gov.br/services2/services/cadconsultacadastro2";
                        UrlWs.UrlRecepcaoEvento = "https://homnfe.sefaz.am.gov.br/services2/services/RecepcaoEvento";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.sefaz.am.gov.br/services2/services/NfeRecepcao2";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.sefaz.am.gov.br/services2/services/NfeRetRecepcao2";
                        UrlWs.UrlNfeCancelamento = "https://nfe.sefaz.am.gov.br/services2/services/NfeCancelamento2";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.sefaz.am.gov.br/services2/services/NfeInutilizacao2";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.sefaz.am.gov.br/services2/services/NfeConsulta2";
                        UrlWs.UrlNfeStatusServico = "https://nfe.sefaz.am.gov.br/services2/services/NfeStatusServico2";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfe.sefaz.am.gov.br/services2/services/cadconsultacadastro2";
                        UrlWs.UrlRecepcaoEvento = "https://nfe.sefaz.am.gov.br/services2/services/RecepcaoEvento";
                    }
                    break;
                //BA USA SEFAZ PROPRIA
                // ERROR: Case labels with binary operators are unsupported : Equality
                case CodUfIbge.Bahia:

                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://hnfe.sefaz.ba.gov.br/webservices/nfenw/NfeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://hnfe.sefaz.ba.gov.br/webservices/nfenw/NfeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://hnfe.sefaz.ba.gov.br/webservices/nfenw/NfeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://hnfe.sefaz.ba.gov.br/webservices/nfenw/NfeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://hnfe.sefaz.ba.gov.br/webservices/nfenw/NfeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://hnfe.sefaz.ba.gov.br/webservices/nfenw/NfeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "https://hnfe.sefaz.ba.gov.br/webservices/nfenw/CadConsultaCadastro2.asmx";
                        UrlWs.UrlRecepcaoEvento = "https://hnfe.sefaz.ba.gov.br/webservices/sre/nferecepcaoevento.asmx";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.sefaz.ba.gov.br/webservices/nfenw/NfeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.sefaz.ba.gov.br/webservices/nfenw/NfeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://nfe.sefaz.ba.gov.br/webservices/nfenw/NfeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.sefaz.ba.gov.br/webservices/nfenw/NfeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.sefaz.ba.gov.br/webservices/nfenw/NfeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://nfe.sefaz.ba.gov.br/webservices/nfenw/NfeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfe.sefaz.ba.gov.br/webservices/nfenw/CadConsultaCadastro2.asmx";
                        UrlWs.UrlRecepcaoEvento = "https://nfe.sefaz.ba.gov.br/webservices/sre/nferecepcaoevento.asmx";
                    }
                    break;
                // ERROR: Case labels with binary operators are unsupported : Equality
                //CE USA SEFAZ PROPRIA
                case CodUfIbge.Ceara:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfeh.sefaz.ce.gov.br/nfe2/services/NfeRecepcao2";
                        UrlWs.UrlNfeRetRecepcao = "https://nfeh.sefaz.ce.gov.br/nfe2/services/NfeRetRecepcao2";
                        UrlWs.UrlNfeCancelamento = "https://nfeh.sefaz.ce.gov.br/nfe2/services/NfeCancelamento2";
                        UrlWs.UrlNfeInutilizacao = "https://nfeh.sefaz.ce.gov.br/nfe2/services/NfeInutilizacao2";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfeh.sefaz.ce.gov.br/nfe2/services/NfeConsulta2";
                        UrlWs.UrlNfeStatusServico = "https://nfeh.sefaz.ce.gov.br/nfe2/services/NfeStatusServico2";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfeh.sefaz.ce.gov.br/nfe2/services/CadConsultaCadastro2";
                        UrlWs.UrlRecepcaoEvento = "";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.sefaz.ce.gov.br/nfe2/services/NfeRecepcao2";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.sefaz.ce.gov.br/nfe2/services/NfeRetRecepcao2";
                        UrlWs.UrlNfeCancelamento = "https://nfe.sefaz.ce.gov.br/nfe2/services/NfeCancelamento2";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.sefaz.ce.gov.br/nfe2/services/NfeInutilizacao2";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.sefaz.ce.gov.br/nfe2/services/NfeConsulta2";
                        UrlWs.UrlNfeStatusServico = "https://nfe.sefaz.ce.gov.br/nfe2/services/NfeStatusServico2";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfe.sefaz.ce.gov.br/nfe2/services/CadConsultaCadastro2";
                        UrlWs.UrlRecepcaoEvento = "";
                    }

                    break;
                // ERROR: Case labels with binary operators are unsupported : Equality
                //GO USA SEFAZ PROPRIA
                case CodUfIbge.Goias:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeRecepcao2?wsdl ";
                        UrlWs.UrlNfeRetRecepcao = "https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeRetRecepcao2?wsdl ";
                        UrlWs.UrlNfeCancelamento = "https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeCancelamento2?wsdl ";
                        UrlWs.UrlNfeInutilizacao = "https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeInutilizacao2?wsdl ";
                        UrlWs.UrlNfeConsultaProtocolo = "https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeConsulta2?wsdl ";
                        UrlWs.UrlNfeStatusServico = "https://homolog.sefaz.go.gov.br/nfe/services/v2/NfeStatusServico2?wsdl ";
                        UrlWs.UrlNfeConsultaCadastro = "https://homolog.sefaz.go.gov.br/nfe/services/v2/CadConsultaCadastro2?wsdl ";
                        UrlWs.UrlRecepcaoEvento = "";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeRecepcao2?wsdl ";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeRetRecepcao2?wsdl ";
                        UrlWs.UrlNfeCancelamento = "https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeCancelamento2?wsdl ";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeInutilizacao2?wsdl ";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeConsulta2?wsdl ";
                        UrlWs.UrlNfeStatusServico = "https://nfe.sefaz.go.gov.br/nfe/services/v2/NfeStatusServico2?wsdl ";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfe.sefaz.go.gov.br/nfe/services/v2/CadConsultaCadastro2?wsdl ";
                        UrlWs.UrlRecepcaoEvento = "";
                    }
                    break;
                // ERROR: Case labels with binary operators are unsupported : Equality
                //MG USA SEFAZ PROPRIA
                case CodUfIbge.MinasGerais:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://hnfe.fazenda.mg.gov.br/nfe2/services/NfeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://hnfe.fazenda.mg.gov.br/nfe2/services/NfeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://hnfe.fazenda.mg.gov.br/nfe2/services/NfeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://hnfe.fazenda.mg.gov.br/nfe2/services/NfeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://hnfe.fazenda.mg.gov.br/nfe2/services/NfeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://hnfe.fazenda.mg.gov.br/nfe2/services/NfeStatus2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "https://hnfe.fazenda.mg.gov.br/nfe2/services/cadconsultacadastro2.asmx";
                        UrlWs.UrlRecepcaoEvento = "";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.fazenda.mg.gov.br/nfe2/services/NfeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.fazenda.mg.gov.br/nfe2/services/NfeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://nfe.fazenda.mg.gov.br/nfe2/services/NfeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.fazenda.mg.gov.br/nfe2/services/NfeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.fazenda.mg.gov.br/nfe2/services/NfeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://nfe.fazenda.mg.gov.br/nfe2/services/NfeStatus2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfe.fazenda.mg.gov.br/nfe2/services/cadconsultacadastro2.asmx";
                        UrlWs.UrlRecepcaoEvento = "";
                    }
                    break;
                // ERROR: Case labels with binary operators are unsupported : Equality
                //MS USA SEFAZ PROPRIA
                case CodUfIbge.MatoGrossoDoSul:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://homologacao.nfe.ms.gov.br/homologacao/services2/NfeRecepcao2";
                        UrlWs.UrlNfeRetRecepcao = "https://homologacao.nfe.ms.gov.br/homologacao/services2/NfeRetRecepcao2";
                        UrlWs.UrlNfeCancelamento = "https://homologacao.nfe.ms.gov.br/homologacao/services2/NfeCancelamento2";
                        UrlWs.UrlNfeInutilizacao = "https://homologacao.nfe.ms.gov.br/homologacao/services2/NfeInutilizacao2";
                        UrlWs.UrlNfeConsultaProtocolo = "https://homologacao.nfe.ms.gov.br/homologacao/services2/NfeConsulta2";
                        UrlWs.UrlNfeStatusServico = "https://homologacao.nfe.ms.gov.br/homologacao/services2/NfeStatusServico2";
                        UrlWs.UrlNfeConsultaCadastro = "https://homologacao.nfe.ms.gov.br/homologacao/services2/CadConsultaCadastro2";
                        UrlWs.UrlRecepcaoEvento = "https://homologacao.nfe.fazenda.ms.gov.br/homologacao/services2/NfeRecepcaoEvento";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.fazenda.ms.gov.br/producao/services2/NfeRecepcao2";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.fazenda.ms.gov.br/producao/services2/NfeRetRecepcao2";
                        UrlWs.UrlNfeCancelamento = "https://nfe.fazenda.ms.gov.br/producao/services2/NfeCancelamento2";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.fazenda.ms.gov.br/producao/services2/NfeInutilizacao2";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.fazenda.ms.gov.br/producao/services2/NfeConsulta2";
                        UrlWs.UrlNfeStatusServico = "https://nfe.fazenda.ms.gov.br/producao/services2/NfeStatusServico2";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfe.fazenda.ms.gov.br/producao/services2/CadConsultaCadastro2";
                        UrlWs.UrlRecepcaoEvento = "https://nfe.fazenda.ms.gov.br/producao/services2/NfeRecepcaoEvento";
                    }
                    break;
                // ERROR: Case labels with binary operators are unsupported : Equality
                //MT USA SEFAZ PROPRIA
                case CodUfIbge.MatoGrosso:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://homologacao.sefaz.mt.gov.br/nfews/NfeRecepcao2?wsdl ";
                        UrlWs.UrlNfeRetRecepcao = "https://homologacao.sefaz.mt.gov.br/nfews/NfeRetRecepcao2?wsdl ";
                        UrlWs.UrlNfeCancelamento = "https://homologacao.sefaz.mt.gov.br/nfews/NfeCancelamento2?wsdl ";
                        UrlWs.UrlNfeInutilizacao = "https://homologacao.sefaz.mt.gov.br/nfews/NfeInutilizacao2?wsdl ";
                        UrlWs.UrlNfeConsultaProtocolo = "https://homologacao.sefaz.mt.gov.br/nfews/NfeConsulta2?wsdl ";
                        UrlWs.UrlNfeStatusServico = "https://homologacao.sefaz.mt.gov.br/nfews/NfeStatusServico2?wsdl ";
                        UrlWs.UrlNfeConsultaCadastro = "";
                        UrlWs.UrlRecepcaoEvento = "https://homologacao.sefaz.mt.gov.br/nfews/v2/services/RecepcaoEvento?wsdl ";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeRecepcao2?wsdl ";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeRetRecepcao2?wsdl ";
                        UrlWs.UrlNfeCancelamento = "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeCancelamento2?wsdl ";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeInutilizacao2?wsdl ";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeConsulta2?wsdl ";
                        UrlWs.UrlNfeStatusServico = "https://nfe.sefaz.mt.gov.br/nfews/v2/services/NfeStatusServico2?wsdl ";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfe.sefaz.mt.gov.br/nfews/CadConsultaCadastro?wsdl ";
                        UrlWs.UrlRecepcaoEvento = "https://nfe.sefaz.mt.gov.br/nfews/v2/services/RecepcaoEvento?wsdl ";
                    }
                    break;
                // ERROR: Case labels with binary operators are unsupported : Equality
                //PB USA SEFAZ VIRTUAL DO RIO GRANDE DO SUL
                case CodUfIbge.Pernambuco:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfehomolog.sefaz.pe.gov.br/nfe-service/services/NfeRecepcao2";
                        UrlWs.UrlNfeRetRecepcao = "https://nfehomolog.sefaz.pe.gov.br/nfe-service/services/NfeRetRecepcao2";
                        UrlWs.UrlNfeCancelamento = "https://nfehomolog.sefaz.pe.gov.br/nfe-service/services/NfeCancelamento2";
                        UrlWs.UrlNfeInutilizacao = "https://nfehomolog.sefaz.pe.gov.br/nfe-service/services/NfeInutilizacao2";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfehomolog.sefaz.pe.gov.br/nfe-service/services/NfeConsulta2";
                        UrlWs.UrlNfeStatusServico = "https://nfehomolog.sefaz.pe.gov.br/nfe-service/services/NfeStatusServico2";
                        UrlWs.UrlNfeConsultaCadastro = "";
                        UrlWs.UrlRecepcaoEvento = "https://nfehomolog.sefaz.pe.gov.br/nfe-service/services/RecepcaoEvento";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.sefaz.pe.gov.br/nfe-service/services/NfeRecepcao2";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.sefaz.pe.gov.br/nfe-service/services/NfeRetRecepcao2";
                        UrlWs.UrlNfeCancelamento = "https://nfe.sefaz.pe.gov.br/nfe-service/services/NfeCancelamento2";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.sefaz.pe.gov.br/nfe-service/services/NfeInutilizacao2";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.sefaz.pe.gov.br/nfe-service/services/NfeInutilizacao2";
                        UrlWs.UrlNfeStatusServico = "https://nfe.sefaz.pe.gov.br/nfe-service/services/NfeStatusServico2";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfe.sefaz.pe.gov.br/nfe-service/services/CadConsultaCadastro2";
                        UrlWs.UrlRecepcaoEvento = "https://nfe.sefaz.pe.gov.br/nfe-service/services/RecepcaoEvento";
                    }
                    break;
                // ERROR: Case labels with binary operators are unsupported : Equality
                //PB USA SEFAZ VIRTUAL DO RIO GRANDE DO SUL
                case CodUfIbge.Parana:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://homologacao.nfe2.fazenda.pr.gov.br/nfe/NFeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://homologacao.nfe2.fazenda.pr.gov.br/nfe/NFeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://homologacao.nfe2.fazenda.pr.gov.br/nfe/NFeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://homologacao.nfe2.fazenda.pr.gov.br/nfe/NFeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://homologacao.nfe2.fazenda.pr.gov.br/nfe/NFeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://homologacao.nfe2.fazenda.pr.gov.br/nfe/NFeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "";
                        UrlWs.UrlRecepcaoEvento = "";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe2.fazenda.pr.gov.br/nfe/NFeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe2.fazenda.pr.gov.br/nfe/NFeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://nfe2.fazenda.pr.gov.br/nfe/NFeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://nfe2.fazenda.pr.gov.br/nfe/NFeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe2.fazenda.pr.gov.br/nfe/NFeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://nfe2.fazenda.pr.gov.br/nfe/NFeConsulta2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "";
                        UrlWs.UrlRecepcaoEvento = "";
                    }

                    break;
                case CodUfIbge.RioGrandeDoSul:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://homologacao.nfe.sefaz.rs.gov.br/ws/Nferecepcao/NFeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://homologacao.nfe.sefaz.rs.gov.br/ws/nferetrecepcao/NfeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://homologacao.nfe.sefaz.rs.gov.br/ws/nfecancelamento/NfeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://homologacao.nfe.sefaz.rs.gov.br/ws/nfeinutilizacao/NfeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://homologacao.nfe.sefaz.rs.gov.br/ws/nfeconsulta/NfeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://homologacao.nfe.sefaz.rs.gov.br/ws/nfestatusservico/NfeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "";
                        UrlWs.UrlRecepcaoEvento = "https://homologacao.nfe.sefaz.rs.gov.br/ws/recepcaoevento/recepcaoevento.asmx";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.sefaz.rs.gov.br/ws/Nferecepcao/NFeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.sefaz.rs.gov.br/ws/NfeRetRecepcao/NfeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://nfe.sefaz.rs.gov.br/ws/NfeCancelamento/NfeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.sefaz.rs.gov.br/ws/nfeinutilizacao/nfeinutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.sefaz.rs.gov.br/ws/NfeConsulta/NfeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://nfe.sefaz.rs.gov.br/ws/NfeStatusServico/NfeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "https://sef.sefaz.rs.gov.br/ws/cadconsultacadastro/cadconsultacadastro2.asmx";
                        UrlWs.UrlRecepcaoEvento = "https://nfe.sefaz.rs.gov.br/ws/recepcaoevento/recepcaoevento.asmx";
                    }
                    break;
                //SP USA SEFAZ PROPRIO
                case CodUfIbge.SaoPaulo:
                    if (ambiente != AmbienteSefaz.Producao)
                    {
                        UrlWs.UrlNfeRecepcao = "https://homologacao.nfe.fazenda.sp.gov.br/nfeweb/services/NfeRecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://homologacao.nfe.fazenda.sp.gov.br/nfeweb/services/NfeRetRecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://homologacao.nfe.fazenda.sp.gov.br/nfeweb/services/NfeCancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://homologacao.nfe.fazenda.sp.gov.br/nfeweb/services/NfeInutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://homologacao.nfe.fazenda.sp.gov.br/nfeweb/services/NfeConsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://homologacao.nfe.fazenda.sp.gov.br/nfeweb/services/NfeStatusServico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "https://homologacao.nfe.fazenda.sp.gov.br/nfeweb/services/CadConsultaCadastro2.asmx";
                        UrlWs.UrlRecepcaoEvento = "https://homologacao.nfe.fazenda.sp.gov.br/eventosWEB/services/RecepcaoEvento.asmx";
                    }
                    else
                    {
                        UrlWs.UrlNfeRecepcao = "https://nfe.fazenda.sp.gov.br/nfeweb/services/nferecepcao2.asmx";
                        UrlWs.UrlNfeRetRecepcao = "https://nfe.fazenda.sp.gov.br/nfeweb/services/nferetrecepcao2.asmx";
                        UrlWs.UrlNfeCancelamento = "https://nfe.fazenda.sp.gov.br/nfeweb/services/nfecancelamento2.asmx";
                        UrlWs.UrlNfeInutilizacao = "https://nfe.fazenda.sp.gov.br/nfeweb/services/nfeinutilizacao2.asmx";
                        UrlWs.UrlNfeConsultaProtocolo = "https://nfe.fazenda.sp.gov.br/nfeweb/services/nfeconsulta2.asmx";
                        UrlWs.UrlNfeStatusServico = "https://nfe.fazenda.sp.gov.br/nfeweb/services/nfestatusservico2.asmx";
                        UrlWs.UrlNfeConsultaCadastro = "https://nfe.fazenda.sp.gov.br/nfeweb/services/cadconsultacadastro2.asmx";
                        UrlWs.UrlRecepcaoEvento = "https://nfe.fazenda.sp.gov.br/eventosWEB/services/RecepcaoEvento.asmx";
                    }
                    break;
            }
            if (ambiente != AmbienteSefaz.Producao)
            {
                UrlWs.UrlNfeDownloadNF = "https://hom.nfe.fazenda.gov.br/NfeDownloadNF/NfeDownloadNF.asmx";
            }
            else
            {
                UrlWs.UrlNfeDownloadNF = "https://www.nfe.fazenda.gov.br/NfeDownloadNF/NfeDownloadNF.asmx";
            }

            switch (uf)
            {
                case CodUfIbge.RioDeJaneiro:
                    UrlWs.UrlNfceQrCode = "http://www4.fazenda.rj.gov.br/consultaNFCe/QRCode?";
                    UrlWs.UrlNfceConsultaChaveAcesso = "http://www4.fazenda.rj.gov.br/consultaNFCe/paginas/consultaChaveAcesso.faces";
                    break;
            }

            return UrlWs;
        }
    }
}