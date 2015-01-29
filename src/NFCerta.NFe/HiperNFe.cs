namespace NFCerta.NFe
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Xml;
    using System.Xml.Schema;
    using ACBr.Net.NFe;
    using ACBr.Net.NFe.DownloadNFe;
    using ACBr.Net.NFe.TiposBasicos;
    using Util;
    using Webservice.Urls;

    public class HiperNFe
    {
        private readonly CultureInfo _ptBr = CultureInfo.GetCultureInfo("pt-BR");
        private X509Certificate2 _certificado;
        private List<TNfeProc> _notasFiscais;
        private ConfiguracaoHiperNFe _configuracao;

        public static List<string> Erros { get; set; }

        public ConfiguracaoHiperNFe Configuracao
        {
            get { return _configuracao ?? (_configuracao = new ConfiguracaoHiperNFe()); }
            set { _configuracao = value; }
        }

        public List<TNfeProc> NotasFiscais
        {
            get { return _notasFiscais ?? (_notasFiscais = new List<TNfeProc>()); }
            set { _notasFiscais = value; }
        }

        public X509Certificate2 Certificado
        {
            get
            {
                return _certificado ??
                       (_certificado = CertificadoDigital.CertificadoDigital.SelecionarCertificado(Configuracao.NumCertificado));
            }
            set { _certificado = value; }
        }

        public TRetConsReciNFe ConsultarLote(TConsReciNFe consRecibo, TRetEnviNFe retEnvio)
        {
            throw new NotImplementedException("Trocar para consulta de RetAutorizacao");
            /*var ws = new C_WebService(Configuracao.PastaLog);
            var reciboNFe = ws.ConsultaRecLote2(consRecibo, retEnvio, Certificado);
            if (reciboNFe.protNFe == null) return reciboNFe;
            foreach (var item in reciboNFe.protNFe)
            {
                var nota = NotasFiscais.FirstOrDefault(n => n.NFe.infNFe.Id == "NFe" + item.infProt.chNFe);
                if (nota == null) continue;
                nota.protNFe = item;

                if (item.infProt.cStat == "100")
                {
                    SalvarNFe(ref nota);
                }
            }
            return reciboNFe;*/
        }

        public TRetConsReciNFe Enviar(int numeroLote)
        {
            throw new NotImplementedException("Ver como tratar envio de NFe (asíncrono) e envio de NFCe (síncrono)");
            /*var ws = new C_WebService(Configuracao.PastaLog);
            var retEnvio = ws.EnviaLote2(this, numeroLote);

            var consRecibo = new TConsReciNFe
            {
                //nRec = retEnvio.infRec.nRec,
                tpAmb = retEnvio.tpAmb,
                versao = retEnvio.versao
            };
            System.Threading.Thread.Sleep(5000);
            try
            {
                return ConsultarLote(consRecibo, retEnvio);
            }
            catch (Exception)
            {
                System.Threading.Thread.Sleep(3000);
                return ConsultarLote(consRecibo, retEnvio);
            }*/
        }

        public TRetConsStatServ StatusServico()
        {
            if (!Directory.Exists(Configuracao.PastaLog))
            {
                Directory.CreateDirectory(Configuracao.PastaLog);
            }

            /*Comentei pois não estava sendo utilizado*/
            //var listaURL = default(C_WebService.ListaUrl);            
            //listaURL = WsUrls.BuscaURL(Configuracao.CodUF, Configuracao.Ambiente);

            /*
             * Mantive pos não sei se precisa executar, porem o retorno 
             * não esta sendo utilizado em lugar nenhum
             */
            WsUrls.BuscaURL(Configuracao.CodUF, Configuracao.Ambiente);
            var ws = new C_WebService(Configuracao.PastaLog);
            var consStatus = new TConsStatServ
            {
                tpAmb = Configuracao.Ambiente,
                versao = Configuracao.Versao,
                cUF = Configuracao.CodUF
            };

            try
            {
                return ws.ConsultaStatusWs(consStatus, Certificado);
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível consultar o status do servidor da Receita Federal. Favor tentar novamente.");
            }
        }

        public static TRetDownloadNFe DownloadNFe(TDownloadNFe downloadNFe, string codUF, X509Certificate2 cert)
        {
            return C_WebService.DownloadNFe(downloadNFe, (CodUfIbge)Enum.Parse(typeof(CodUfIbge), codUF), cert);
        }

        public List<TRetConsSitNFe> ConsultaSituacao()
        {
            if (!Directory.Exists(Configuracao.PastaLog))
            {
                Directory.CreateDirectory(Configuracao.PastaLog);
            }
            var ws = new C_WebService(Configuracao.PastaLog);
            var retorno = ws.ConsultaSitNFe(this, Certificado);
            return retorno;
        }

        public ACBr.Net.NFe.CartaCorrecao.TRetEnvEvento CartaCorrecao(string correcao, int numLote, int nSequencia, out ACBr.Net.NFe.CartaCorrecao.TProcEvento procCorrecao)
        {
            if (NotasFiscais.Count > 1)
            {
                throw new InvalidOperationException("Só é possível corrigir uma nota por vez.");
            }
            var nota = NotasFiscais[0];
            correcao = Funcoes.RemoverAcentos(correcao.Trim());
            var ws = new C_WebService(Configuracao.PastaLog);
            var retCorrecao = ws.CartaCorrecao(nota, correcao, Certificado, numLote, nSequencia, Configuracao.Ambiente, out procCorrecao);
            if (retCorrecao.retEvento[0].infEvento.cStat == "135")
            {
                SalvarEventoCorrecao(ref procCorrecao, nota.NFe.infNFe.ide.dhEmi);
            }
            return retCorrecao;
        }

        public ACBr.Net.NFe.Cancelamento.TRetEnvEvento Cancelar(string justificativa, int numLote, int nSequencia, out ACBr.Net.NFe.Cancelamento.TProcEvento procCancelamento)
        {
            if (NotasFiscais.Count > 1)
            {
                throw new InvalidOperationException("Só é possível cancelar uma nota por vez.");
            }
            var nota = NotasFiscais[0];
            var ws = new C_WebService(Configuracao.PastaLog);
            justificativa = Funcoes.RemoverAcentos(justificativa.Trim());
            var retCanc = ws.CancelaNFe(nota, justificativa, Certificado, numLote, nSequencia, Configuracao.Ambiente, out procCancelamento);
            if (retCanc.retEvento[0].infEvento.cStat == "135")
            {
                SalvarEventoCancelamento(ref procCancelamento, nota.NFe.infNFe.ide.dhEmi);
            }
            return retCanc;
        }

        #region Inutilização

        public TRetInutNFe Inutilizar(int inicio, int final, int serie, string justificativa)
        {
            if (Configuracao == null)
            {
                return null;
            }

            if (String.IsNullOrEmpty(Configuracao.CodUF.ToString()))
            {
                return null;
            }

            if (String.IsNullOrEmpty(Configuracao.Versao))
            {
                return null;
            }

            var inutilizacao = new TInutNFe
            {
                infInut =
                {
                    ano = DateTime.Now.Year.ToString(_ptBr),
                    CNPJ = Configuracao.Emitente.Item,
                    mod = ModeloDocumento.NFe,
                    serie = serie.ToString(_ptBr),
                    nNFIni = inicio.ToString(_ptBr),
                    nNFFin = final.ToString(_ptBr)
                }
            };


            var chave = new StringBuilder();
            chave.Append(Configuracao.CodUF);
            chave.Append(inutilizacao.infInut.ano);
            chave.Append(inutilizacao.infInut.CNPJ);
            chave.Append(inutilizacao.infInut.mod);
            chave.Append(string.Format("{0:000}", Convert.ToInt32(inutilizacao.infInut.serie)));
            chave.Append(string.Format("{0:000000000}", Convert.ToInt32(inutilizacao.infInut.nNFIni)));
            chave.Append(string.Format("{0:000000000}", Convert.ToInt32(inutilizacao.infInut.nNFFin)));


            inutilizacao.infInut.Id = string.Format("ID{0}", chave);
            inutilizacao.infInut.xServ = TInutNFeInfInutXServ.INUTILIZAR;
            inutilizacao.infInut.xJust = justificativa;

            return Inutilizar(inutilizacao);
        }

        private TRetInutNFe Inutilizar(TInutNFe inutilizacao)
        {
            var ws = new C_WebService(Configuracao.PastaLog);
            return ws.InutilizaNumeracao(inutilizacao, Certificado, Configuracao.Ambiente);
        }

        #endregion Inutilização

        #region Geração de Arquivo

        public void GerarArquivoNFe()
        {
            foreach (var nota in NotasFiscais)
            {
                if ((nota.NFe.infNFe.emit == null) && (Configuracao.Emitente != null))
                {
                    nota.NFe.infNFe.emit = Configuracao.Emitente;
                }

                var dtEmissao = Convert.ToDateTime(nota.NFe.infNFe.ide.dhEmi);
                var codUF = nota.NFe.infNFe.ide.cUF.GetHashCode().ToString(_ptBr);
                var dEmi = dtEmissao.ToString("yyMM");
                if (nota.NFe.infNFe.emit == null) continue;
                var cnpj = removeFormatacao(nota.NFe.infNFe.emit.Item);
                var mod = nota.NFe.infNFe.ide.mod.GetHashCode().ToString(_ptBr);
                var serie = string.Format("{0:000}", Int32.Parse(nota.NFe.infNFe.ide.serie));
                var numNf = string.Format("{0:000000000}", Int32.Parse(nota.NFe.infNFe.ide.nNF));
                var codigo = string.Format("{0:00000000}", Convert.ToInt32(nota.NFe.infNFe.ide.nNF));
                var tpEmissao = nota.NFe.infNFe.ide.tpEmis.GetHashCode().ToString(_ptBr);
                var chaveNF = codUF + dEmi + cnpj + mod + serie + numNf + tpEmissao + codigo;

                #region Validations

                if (string.IsNullOrEmpty(dtEmissao.ToString(_ptBr)))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta Data de Emissão");
                }

                if (string.IsNullOrEmpty(codUF))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta CodUF do emissor");
                }

                if (string.IsNullOrEmpty(dEmi))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta mes e ano da Data de Emissão");
                }

                if (string.IsNullOrEmpty(cnpj))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta o CNPJ do Emissor");
                }

                if (string.IsNullOrEmpty(mod))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta o modelo na Nota Fiscal");
                }

                if (string.IsNullOrEmpty(serie))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta a série da Nota Fiscal");
                }

                if (string.IsNullOrEmpty(numNf))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta o número da Nota Fiscal");
                }

                if (string.IsNullOrEmpty(codigo))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta número da Nota Fiscal");
                }

                #endregion Validations

                var dv = Digit.Modulo11(chaveNF);
                nota.NFe.infNFe.Id = "NFe" + chaveNF + dv;
                nota.NFe.infNFe.ide.cDV = dv.ToString(_ptBr);
                nota.NFe.infNFe.ide.cNF = codigo;
                var arquivoNFe = Configuracao.PastaLog + chaveNF + dv + "-nfe.xml";

                nota.NFe.ArquivoXML = SaveXml(nota.Serialize(), arquivoNFe);
                nota.NFe.NomeArquivo = arquivoNFe;
            }
        }

        public void GerarArquivoNFeProc()
        {
            foreach (var nota in NotasFiscais)
            {
                if ((nota.NFe.infNFe.emit == null) && (Configuracao.Emitente != null))
                {
                    nota.NFe.infNFe.emit = Configuracao.Emitente;
                }

                var dtEmissao = Convert.ToDateTime(nota.NFe.infNFe.ide.dhEmi);
                var codUF = nota.NFe.infNFe.ide.cUF.GetHashCode().ToString(_ptBr);
                var dEmi = dtEmissao.ToString("yyMM");
                if (nota.NFe.infNFe.emit == null) continue;
                var cnpj = removeFormatacao(nota.NFe.infNFe.emit.Item);
                var mod = nota.NFe.infNFe.ide.mod.GetHashCode().ToString(_ptBr);
                var serie = string.Format("{0:000}", Int32.Parse(nota.NFe.infNFe.ide.serie));
                var numNF = string.Format("{0:000000000}", Int32.Parse(nota.NFe.infNFe.ide.nNF));
                var codigo = string.Format("{0:00000000}", Convert.ToInt32(nota.NFe.infNFe.ide.nNF)).Substring(0, 8);
                var tpEmissao = nota.NFe.infNFe.ide.tpEmis.GetHashCode().ToString(_ptBr);
                var chaveNF = codUF + dEmi + cnpj + mod + serie + numNF + tpEmissao + codigo;

                #region Validations

                if (String.IsNullOrEmpty(dtEmissao.ToString(_ptBr)))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta Data de Emissão");
                }

                if (string.IsNullOrEmpty(codUF))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta CodUF do emissor");
                }

                if (string.IsNullOrEmpty(dEmi))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta mes e ano da Data de Emissão");
                }

                if (string.IsNullOrEmpty(cnpj))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta o CNPJ do Emissor");
                }

                if (string.IsNullOrEmpty(mod))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta o modelo na Nota Fiscal");
                }

                if (string.IsNullOrEmpty(serie))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta a série da Nota Fiscal");
                }

                if (string.IsNullOrEmpty(numNF))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta o número da Nota Fiscal");
                }

                if (string.IsNullOrEmpty(codigo))
                {
                    throw new Exception("Chave inválida, não é possível calcular o digito verificador: Falta número da Nota Fiscal");
                }

                #endregion Validations

                var dv = Digit.Modulo11(chaveNF);
                nota.protNFe.infProt = new TProtNFeInfProt
                {
                    nProt = "Nao autorizado",
                    cStat = "000",
                    chNFe = chaveNF + dv
                };
                nota.NFe.infNFe.Id = "NFe" + chaveNF + dv;
                nota.NFe.infNFe.ide.cDV = dv.ToString(_ptBr);
                nota.NFe.infNFe.ide.cNF = codigo;
                nota.NFe.infNFe.infAdic.infCpl = Funcoes.RemoverAcentos(nota.NFe.infNFe.infAdic.infCpl);
                var arquivoNFe = Configuracao.PastaLog + chaveNF + dv + "-nfe.xml";

                nota.NFe.ArquivoXML = SaveXml(nota.Serialize(), arquivoNFe);
                nota.NFe.NomeArquivo = arquivoNFe;
            }
        }

        #endregion Geração de Arquivo

        #region Assinatura

        public void Assinar()
        {
            foreach (var nota in NotasFiscais)
            {
                if (Certificado == null)
                {
                    throw new Exception("O Certificado Digital não está Configurado.");
                }
                nota.NFe = AssinarNFE(nota.NFe, "infNFe");
            }
        }

        public void Assinar(ref TNfeProc nota)
        {
            if (Certificado == null)
            {
                throw new Exception("O Certificado Digital não está Configurado.");
            }
            nota.NFe = AssinarNFE(nota.NFe, "infNFe");
        }

        public TNFe AssinarNFE(TNFe nota, string pUri)
        {
            var arquivoNaoAssinado = new XmlDocument();
            arquivoNaoAssinado.LoadXml(Funcoes.RemoveNameSpaceFromXml(nota.Serialize()));

            var auxDocXML = CertificadoDigital.CertificadoDigital.Assinar(arquivoNaoAssinado, pUri, Certificado);
            auxDocXML.Save(nota.NomeArquivo);

            var retorno = TNFe.LoadFromFile(nota.NomeArquivo);
            retorno.NomeArquivo = nota.NomeArquivo;
            retorno.ArquivoXML = auxDocXML;
            return retorno;
        }

        #endregion Assinatura

        #region Validação

        public List<string> Validar()
        {
            return (from nota in NotasFiscais
                    let absolutePath = (new Uri(Assembly.GetExecutingAssembly().CodeBase)).AbsolutePath
                    let schemasPath = Path.GetDirectoryName(absolutePath) + "\\Schemas\\nfe_v2.00.xsd"
                    let retorno = ValidarXML(nota.NFe.NomeArquivo, schemasPath)
                    where !string.IsNullOrEmpty(retorno)
                    select "Nota Fiscal: " + nota.NFe.infNFe.ide.nNF + " - " + retorno).ToList();
        }

        public static string ValidarXML(string arquivoXML, string schemaNf)
        {
            var settings = new XmlReaderSettings();
            settings.ValidationEventHandler += ValidationEventHandler;

            if (!File.Exists(arquivoXML))
            {
                return "Arquivo da nota fiscal não encontrado.";
            }

            if (!File.Exists(schemaNf))
            {
                return "Arquivo de Schema não encontrado.";
            }

            try
            {
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", XmlReader.Create(schemaNf));
                using (var xmlValidatingReader = XmlReader.Create(arquivoXML, settings))
                {
                    while (xmlValidatingReader.Read())
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;

            }

            if (Erros == null) return string.Empty;
            var retorno = String.Join(String.Empty, Erros);
            Erros = null;
            return retorno;
        }

        public static void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            Erros = new List<string>();
            if (args.Severity == XmlSeverityType.Warning)
            {
                Erros.Add("Nenhum arquivo de Schema foi encontrado para efetuar a validação...");
            }
            else if (args.Severity == XmlSeverityType.Error)
            {
                Erros.Add("Ocorreu um erro durante a validação....");
            }
            // Erro na validação do schema XSD
            if ((args.Exception != null))
            {
                Erros.Add("\nErro: " + args.Exception.Message + "\nLinha " + args.Exception.LinePosition + " - Coluna "
                          + args.Exception.LineNumber + "\nSource: " + args.Exception.SourceUri);
            }
        }

        #endregion Validação

        #region Auxiliares

        

        private string removeFormatacao(string texto)
        {
            return string.Join(null, System.Text.RegularExpressions.Regex.Split(texto, "[^\\d]"));
        }

        public static MemoryStream StringXmlToStreamUTF8(string strXml)
        {
            var encoding = new UTF8Encoding();
            var byteArray = encoding.GetBytes(strXml);
            var memoryStream = new MemoryStream(byteArray);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return memoryStream;
        }
        #endregion Auxiliares

        #region Arquivos e Pastas

        #region Eventos

        public string GetCurrentPathEventos(string cnpjEmpresa, string dataEmissao)
        {
            var pastaEventos = GetCurrentPathNFe(cnpjEmpresa, dataEmissao) + "\\Eventos";
            if (!Directory.Exists(pastaEventos))
            {
                Directory.CreateDirectory(pastaEventos);
            }
            return pastaEventos;
        }

        public string GetFileNameEventoCancelamento(ACBr.Net.NFe.Cancelamento.TEventoInfEvento infEvento, string dataEmissao)
        {
            var cnpjEmpresa = infEvento.Item;
            var tipoEvento = Funcoes.ConvertEnumToString(infEvento.tpEvento);
            var chaveEvento = infEvento.chNFe;
            var seqEvento = infEvento.nSeqEvento;
            return GetFileNameEvento(cnpjEmpresa, tipoEvento, chaveEvento, seqEvento, dataEmissao);
        }

        public string GetFileNameEventoCorrecao(ACBr.Net.NFe.CartaCorrecao.TEventoInfEvento infEvento, string dataEmissao)
        {
            var cnpjEmpresa = infEvento.Item;
            var tipoEvento = Funcoes.ConvertEnumToString(infEvento.tpEvento);
            var chaveEvento = infEvento.chNFe;
            var seqEvento = infEvento.nSeqEvento;
            return GetFileNameEvento(cnpjEmpresa, tipoEvento, chaveEvento, seqEvento, dataEmissao);
        }

        public string GetFileNameEvento(TEventoInfEvento infEvento, string dataEmissao, string cnpjEmitente)
        {
            var cnpjEmpresa = cnpjEmitente;
            var tipoEvento = infEvento.tpEvento;
            var chaveEvento = infEvento.chNFe;
            var seqEvento = infEvento.nSeqEvento;
            return GetFileNameEvento(cnpjEmpresa, tipoEvento, chaveEvento, seqEvento, dataEmissao);
        }

        public string GetFileNameEvento(string cnpjEmpresa, string tipoEvento, string chaveEvento, string seqEvento, string dataEmissao)
        {
            return GetCurrentPathEventos(cnpjEmpresa, dataEmissao) + "\\" + tipoEvento + "-" + chaveEvento + "-" + seqEvento + "-procEventoNfe.xml";
        }

        public void SalvarEventoCancelamento(ref ACBr.Net.NFe.Cancelamento.TProcEvento procEvento, string dataEmissao)
        {
            procEvento.NomeArquivo = GetFileNameEventoCancelamento(procEvento.evento.infEvento, dataEmissao);
            procEvento.ArquivoXML = SaveXml(procEvento.Serialize(), procEvento.NomeArquivo);
        }

        public void SalvarEventoCorrecao(ref ACBr.Net.NFe.CartaCorrecao.TProcEvento procEvento, string dataEmissao)
        {
            procEvento.NomeArquivo = GetFileNameEventoCorrecao(procEvento.evento.infEvento, dataEmissao);
            procEvento.ArquivoXML = SaveXml(procEvento.Serialize(), procEvento.NomeArquivo);
        }

        public void SalvarEvento(ref TProcEvento procEvento, string dataEmissao, string cnpjEmitente)
        {
            procEvento.NomeArquivo = GetFileNameEvento(procEvento.evento.infEvento, dataEmissao, cnpjEmitente);
            procEvento.ArquivoXML = SaveXml(procEvento.Serialize(), procEvento.NomeArquivo);
        }

        #endregion Eventos

        #region Notas Fiscais Eletrônicas

        public string GetCurrentPathNFe(string cnpjEmpresa, string dataEmissao)
        {
            var data = DateTimeOffset.Parse(dataEmissao);

            var pasta = Configuracao.PastaEmitidas + cnpjEmpresa + "\\" + data.ToLocalTime().ToString("yyMM");
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            return pasta;
        }

        public string GetFileNameNFe(TNFeInfNFe infNFe)
        {
            var cnpjEmpresa = infNFe.emit.Item;
            var chaveNFe = infNFe.Id.Substring(3);
            var dataEmissao = infNFe.ide.dhEmi;
            return GetCurrentPathNFe(cnpjEmpresa, dataEmissao) + "\\" + chaveNFe + "-nfe.xml";
        }

        public void SalvarNFe(ref TNfeProc nota)
        {
            nota.NFe.NomeArquivo = GetFileNameNFe(nota.NFe.infNFe);
            nota.NFe.ArquivoXML = SaveXml(nota.Serialize(), nota.NFe.NomeArquivo);
        }

        #endregion Notas Fiscais Eletrônicas

        public XmlDocument SaveXml(string xml, string fileName)
        {
            XmlTextWriter xtw = null;
            try
            {
                var dInfo = Directory.GetParent(fileName);
                if (!dInfo.Exists)
                {
                    dInfo.Create();
                }
                xtw = new XmlTextWriter(fileName, Encoding.UTF8);
                var xd = new XmlDocument();
                xd.LoadXml(Funcoes.RemoveNameSpaceFromXml(xml));
                xd.Save(xtw);
                return xd;
            }
            finally
            {
                if ((xtw != null))
                {
                    xtw.Flush();
                    xtw.Close();
                }
            }
        }

        #endregion Arquivos e Pastas
    }
}