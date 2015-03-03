namespace NFCerta.NFe.Tests.Helpers
{
    using System;
    using System.Collections.Generic;
    using NFe.Schemas;
    using NFe.Schemas.TiposBasicos;
    using NFe.Util;

    public static class MockData
    {
        public readonly static Lazy<TNFe> NFCe = new Lazy<TNFe>(() =>
        {
            var nfe = new TNFe()
            {
                Signature = new SignatureType()
                {
                    SignedInfo = new SignedInfoType()
                    {
                        Reference = new ReferenceType()
                        {
                            DigestValue = Convert.FromBase64String("72qQa+b0taoQO9fAJwfdlXuqQv8="),
                        }
                    }
                },
                infNFe = new TNFeInfNFe()
                {
                    versao = "3.10",
                    avulsa = null,
                    retirada = null,
                    entrega = null,
                    dest = null,
                    exporta = null,
                    cana = null,
                    cobr = null,
                    compra = null,
                    ide = new IdentificacaoNFe()
                    {
                        cUF = CodUfIbge.RioDeJaneiro,
                        nNF = "1",
                        dhEmi = DateTime.Now.ToSefazTime(),
                        serie = "1",
                        tpAmb = AmbienteSefaz.Homologacao,
                        indPag = IndicadorFormaPgto.Vista,
                        idDest = IndicadorLocalDestino.Interna,
                        cMunFG = "3304557",
                        tpNF = TipoNotaFiscal.Saida,
                        tpImp = TipoImpressaoNFe.DanfeNFCe,
                        tpEmis = TipoEmissaoNFe.Normal,
                        finNFe = FinalidadeNFe.Normal,
                        indFinal = OperacaoComConsumidorFinal.Sim,
                        indPres = IndicadorPresencaComprador.Presencial,
                        procEmi = ProcessoEmissao.AplicativoContribuinte,
                        verProc = "1.0",
                        natOp = "Venda",
                        mod = ModeloDocumento.NFCe
                    },
                    emit = new InformacoesEmitente()
                    {
                        ItemElementName = TipoDocumentoEmitente.CNPJ,
                        Item = "21277658000115",
                        IE = "86815044",
                        xNome = "WINE BROS LTDA",
                        CRT = CodigoRegimeTributario.Simples,
                        xFant = "DEGUSTO",
                        enderEmit = new TEnderEmi()
                        {
                            CEP = "20560032",
                            cMun = "3304557",
                            xMun = "Rio de Janeiro",
                            cPais = TEnderEmiCPais.Brasil,
                            xLgr = "R BARAO DE SAO FRANCISCO",
                            xBairro = "ANDARAI",
                            nro = "236",
                            cPaisSpecified = true,
                            UF = TUfEmi.RJ,
                            xCpl = "QUIOSQ: 124; : 1 PISO; : SHOPPING BOULEVARD;",
                        }
                    },
                    det = new List<InformacoesDetalhe>()
                    {
                        new InformacoesDetalhe()
                        {
                            nItem = "1",
                            prod = new DetalhesProduto()
                            {
                                cProd = "1",
                                cEAN = String.Empty,
                                cEANTrib = String.Empty,
                                xProd = "PAO DE QUEIJO",
                                NCM = "39231090",
                                CFOP = CFOP.MercadoriaTerceiros,
                                uCom = "UN",
                                qCom = "8026.0000",
                                vUnCom = "1.00",
                                vProd = "8026.00",
                                uTrib = "UN",
                                qTrib = "8026.0000",
                                vUnTrib = "1.00",
                                vOutro = "802.60",
                                indTot = IndicadorProdutoValorTotal.CompoeValorTotalNFe
                            },
                            imposto = new DetalhesImposto()
                            {
                                PIS = null,
                                PISST = null,
                                COFINS = null,
                                COFINSST = null,
                                Items = new List<object>()
                                {
                                    new DetImpostoICMS()
                                    {
                                        Item = new ImpostoICMSN900()
                                        {
                                            orig = OrigemMercadoria.Item0,
                                            CSOSN = ICMS900CSOSN.Item900,
                                            modBC = ICMS900ModBC.Item3,
                                            vBC = "0.00",
                                            pICMS = "0.00",
                                            vICMS = "0.00",
                                            modBCST = ICMS900ModBcst.Item0,
                                            vBCST = "0.00",
                                            pICMSST = "0.00",
                                            vICMSST = "0.00",
                                            pCredSN = "0.00",
                                            vCredICMSSN = "0.00",
                                        }
                                    }
                                }
                            },
                            impostoDevol = null
                        },
                        new InformacoesDetalhe()
                        {
                            nItem = "2",
                            prod = new DetalhesProduto()
                            {
                                cProd = "2",
                                cEAN = String.Empty,
                                cEANTrib = String.Empty,
                                xProd = "CHOPP Legal e Barato",
                                NCM = "39231090",
                                CFOP = CFOP.MercadoriaTerceiros,
                                uCom = "UN",
                                qCom = "23.0000",
                                vUnCom = "3.00",
                                vProd = "69.00",
                                uTrib = "UN",
                                qTrib = "23.0000",
                                vUnTrib = "3.00",
                                vOutro = "6.90",
                                indTot = IndicadorProdutoValorTotal.CompoeValorTotalNFe
                            },
                            impostoDevol = null,
                            imposto = new DetalhesImposto()
                            {
                                PIS = null,
                                PISST = null,
                                COFINS = null,
                                COFINSST = null,
                                Items = new List<object>()
                                {
                                    new DetImpostoICMS() {
                                        Item = new ImpostoICMSN900()
                                        {
                                            orig = OrigemMercadoria.Item0,
                                            CSOSN = ICMS900CSOSN.Item900,
                                            modBC = ICMS900ModBC.Item3,
                                            vBC = "0.00",
                                            pICMS = "5.00",
                                            vICMS = "0.00",
                                            modBCST = ICMS900ModBcst.Item0,
                                            vBCST = "0.00",
                                            pICMSST = "0.00",
                                            vICMSST = "0.00",
                                            pCredSN = "0.00",
                                            vCredICMSSN = "0.00",
                                        }
                                    }   
                                }
                            }
                        }
                    },
                    total = new NFeTotal()
                    {
                        ICMSTot = new TotalICMS()
                        {
                            vBC = "0.00",
                            vICMS = "0.00",
                            vICMSDeson = "0.00",
                            vBCST = "0.00",
                            vST = "0.00",
                            vProd = "8095.00",
                            vFrete = "0.00",
                            vSeg = "0.00",
                            vDesc = "0.00",
                            vII = "0.00",
                            vIPI = "0.00",
                            vPIS = "0.00",
                            vCOFINS = "0.00",
                            vOutro = "809.50",
                            vNF = "8904.50"
                        },
                        ISSQNtot = null,
                        retTrib = null
                    },
                    transp = new NFeTransp()
                    {
                        modFrete = ModFrete.SemFrete,
                        retTransp = null,
                        transporta = null
                    },
                    pag = new List<NFePag>()
                    {
                        new NFePag()
                        {
                            tPag = TipoPagamento.Dinheiro,
                            vPag = "8904.50",
                            card = null
                        }
                    },
                    infAdic = new NFeInfAdicional()
                    {
                        infCpl = "Mesa: 1",
                    }
                }
            };
            return nfe;
        });

        public readonly static Lazy<NFeProcessada> NFeProcessada = new Lazy<NFeProcessada>(() =>
        {
            var nfeProcessada = new NFeProcessada()
            {
                versao = "3.10",
                NFe = MockData.NFCe.Value,
                protNFe = new TProtNFe()
                {
                    infProt = new TProtNFeInfProt()
                    {
                        chNFe = "99999999999999999999999999999999999999999999",
                        dhRecbto = DateTime.Now.ToSefazTime(),
                        nProt = "9999999999999",
                    }
                }
            };

            return nfeProcessada;
        });
    }
}