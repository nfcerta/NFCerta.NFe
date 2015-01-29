using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using NFCerta.NFe.Schemas;
using NFCerta.NFe.Schemas.TiposBasicos;
using NFCerta.NFe.Util;
using PdfSharp.Pdf;
using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NFCerta.NFe
{
    public class Danfe : IDisposable
    {
        public List<IDisposable> Disposables { get; set; }

        public Danfe()
        {
            Disposables = new List<IDisposable>();
        }

        public void Pdf(Stream stream, TNFe nfe, TProtNFe protocolo, string cscId, string cscToken, bool mostrarDetalhes = false)
        {
            var document = new Document();

            var style = document.Styles["Normal"].Font.Name = "Helvetica";

            if (nfe.infNFe.ide.tpEmis == TipoEmissaoNFe.ContingenciaOffline)
            {
                MontaPagina(document, nfe, protocolo, cscId, cscToken, mostrarDetalhes, " - Via do Consumidor");
                MontaPagina(document, nfe, protocolo, cscId, cscToken, mostrarDetalhes, " - Via do Estabelecimento");
            }
            else
            {
                MontaPagina(document, nfe, protocolo, cscId, cscToken, mostrarDetalhes);
            }

            var pdfRenderer = new PdfDocumentRenderer(false, PdfFontEmbedding.Always);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(stream);
        }

        private void MontaPagina(Document document, TNFe nfe, TProtNFe protocolo, string cscId, string cscToken, bool mostrarDetalhesVenda, string via = "")
        {
            var page = document.AddSection();

            // 2.3.1 Divisão I - Informações do Cabeçalho
            var table = page.AddTable();
            table.Rows.LeftIndent = 0;

            // Before you can add a row, you must define the columns
            var column = table.AddColumn("4cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = table.AddColumn("6cm");
            //column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn("6cm");
            //column.Format.Alignment = ParagraphAlignment.Left;

            // Logo NFC-e (opcional)
            // Logo do Contribuinte (opcional)
            var row = table.AddRow();
            row.Cells[0].MergeDown = 2;
            var file = @"..\..\..\NFCerta.NFe\Resources\logo.jpg";
            var image = row.Cells[0].AddImage(file);
            image.Height = "1.3cm";

            // Razão social do Emitente
            row.Cells[1].AddParagraph(nfe.infNFe.emit.xNome);

            // Inscrição Municipal do Emitente (se houver)
            if (nfe.infNFe.emit.IM.HasValue())
            {
                row.Cells[2].AddParagraph("Inscrição Municipal - " + nfe.infNFe.emit.IM);
            }

            row = table.AddRow();

            // CNPJ do Emitente
            row.Cells[1].AddParagraph("CNPJ - " + nfe.infNFe.emit.Item);

            // Inscrição Estadual do Emitente
            row.Cells[2].AddParagraph("Inscrição Estadual - " + nfe.infNFe.emit.IE);

            row = table.AddRow();

            // Endereço Completo do Emitente 
            // Endereço Completo (Logradouro, n, bairro, municipio, sigla, uf)
            row.Cells[1].AddParagraph(nfe.infNFe.emit.enderEmit.xLgr + ", "
                                    + nfe.infNFe.emit.enderEmit.nro + ", "
                                    + nfe.infNFe.emit.enderEmit.xBairro + ", "
                                    + nfe.infNFe.emit.enderEmit.xMun + ", "
                                    + nfe.infNFe.emit.enderEmit.UF.ToString());
            row.Cells[1].MergeRight = 1;

            table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);

            // 2.3.2 Divisão II – Informações Fixas do DANFE NFC-e
            table = page.AddTable();
            table.Rows.LeftIndent = 0;

            column = table.AddColumn("16cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            row = table.AddRow();
            row.Cells[0].AddParagraph("DANFE NFC-e - Documento Auxiliar de Nota Fiscal de Consumidor Eletrônica");

            row = table.AddRow();
            row.Cells[0].AddParagraph("Não permite aproveitamento de crédito de ICMS");

            table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);

            // 2.3.3 Divisão III – Informações de Detalhe da Venda
            if (mostrarDetalhesVenda || nfe.infNFe.ide.tpEmis == TipoEmissaoNFe.ContingenciaOffline)
            {
                table = page.AddTable();
                table.Rows.LeftIndent = 0;

                table.AddColumn("2cm");
                table.AddColumn("3cm");
                table.AddColumn("3cm");
                table.AddColumn("2cm");
                table.AddColumn("3cm");
                table.AddColumn("3cm");

                row = table.AddRow();
                row.HeadingFormat = true;
                row.Cells[0].AddParagraph("Código");
                row.Cells[1].AddParagraph("Descrição");
                row.Cells[2].AddParagraph("Qtde");
                row.Cells[3].AddParagraph("Un");
                row.Cells[4].AddParagraph("Valor unit.");
                row.Cells[5].AddParagraph("Valor total");

                foreach (var det in nfe.infNFe.det)
                {
                    row = table.AddRow();
                    row.Cells[0].AddParagraph(det.prod.cProd);
                    row.Cells[1].AddParagraph(det.prod.xProd);
                    row.Cells[2].AddParagraph(det.prod.qCom);
                    row.Cells[3].AddParagraph(det.prod.uCom);
                    row.Cells[4].AddParagraph(det.prod.vUnCom);
                    row.Cells[5].AddParagraph(det.prod.vProd);
                }

                table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);
            }

            // 2.3.4 Divisão IV – Informações de Total do DANFE NFC-e
            table = page.AddTable();
            table.Rows.LeftIndent = 0;
            table.AddColumn("8cm");
            column = table.AddColumn("8cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            // QTD. TOTAL DE ITENS = somatório da quantidade de itens; 
            var qtdTotal = nfe.infNFe.det.Sum(det => float.Parse(det.prod.qCom));
            row = table.AddRow();
            row.Cells[0].AddParagraph("QTD. TOTAL DE ITENS");
            row.Cells[1].AddParagraph(qtdTotal.ToString("0.####"));

            // ACRESCIMO
            row = table.AddRow();
            row.Cells[0].AddParagraph("ACRESCIMO");
            row.Cells[1].AddParagraph(nfe.infNFe.total.ICMSTot.vOutro);

            // VALOR TOTAL = somatório dos valores totais dos itens somados os acréscimos e subtraído dos descontos
            row = table.AddRow();
            row.Cells[0].AddParagraph("VALOR TOTAL R$");
            row.Cells[1].AddParagraph(nfe.infNFe.total.ICMSTot.vNF);

            row = table.AddRow();
            row.Cells[0].AddParagraph("FORMA DE PAGAMENTO");
            // VALOR PAGO = valor pago efetivamente na forma de pagamento identificada imediatamente acima
            row.Cells[1].AddParagraph("Valor Pago");

            // FORMA PAGAMENTO = forma na qual o pagamento da NFC-e foi efetuado (podem ocorrer mais de uma forma de pagamento, devendo neste caso ser indicado o montante parcial do pagamento para a respectiva forma. Exemplo: em dinheiro, em cheque, etc
            nfe.infNFe.pag.ForEach(pag =>
            {
                row = table.AddRow();
                row.Cells[0].AddParagraph(pag.tPag.ToString());
                row.Cells[1].AddParagraph(pag.vPag);
            });

            table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);

            // 2.3.5 Divisão V – Informações dos Tributos no DANFE NFC-e 
            table = page.AddTable();
            table.Rows.LeftIndent = 0;
            table.AddColumn("8cm");
            column = table.AddColumn("8cm");
            column.Format.Alignment = ParagraphAlignment.Right;
            row = table.AddRow();
            row.Cells[0].AddParagraph("Informação dos TributosTotais Incedentais (Lei Federal 12.741/2012)");
            // Soma de todos os tributos incidentes na operação/prestação, contemplando toda a cadeia de fornecimento
            row.Cells[1].AddParagraph(nfe.infNFe.total.ICMSTot.vTotTrib ?? "0.00");

            table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);

            // 2.3.6 Divisão Va – Mensagem de Interesse do Contribuinte
            table = page.AddTable();
            table.Rows.LeftIndent = 0;
            column = table.AddColumn("16cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            row = table.AddRow();
            row.Cells[0].AddParagraph(nfe.infNFe.infAdic.infCpl);

            table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);

            // 2.3.7 Divisão VI – Mensagem Fiscal e Informações da Consulta via Chave de Acesso
            table = page.AddTable();
            table.Rows.LeftIndent = 0;
            column = table.AddColumn("16cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            // Área de Mensagem Fiscal. Quando for o caso deve ser incluídas as seguintes mensagens: “EMITIDA EM CONTINGÊNCIA”, “EMITIDA EM AMBIENTE DE HOMOLOGAÇÃO – SEM VALOR FISCAL”)
            if (nfe.infNFe.ide.tpEmis == TipoEmissaoNFe.ContingenciaOffline)
            {
                row = table.AddRow();
                row.Cells[0].AddParagraph("EMITIDA EM CONTINGÊNCIA");
            }

            if (nfe.infNFe.ide.tpAmb == AmbienteSefaz.Homologacao)
            {
                row = table.AddRow();
                row.Cells[0].AddParagraph("EMITIDA EM AMBIENTE DE HOMOLOGAÇÃO – SEM VALOR FISCAL");
            }

            // Número da NFC-e
            // Série da NFC-e
            // Data e Hora de Emissão da NFC-e (observação: a data de emissão apesar de constar no arquivo XML da NFC-  NFC-e sempre convertida para o horário local)
            var dataEmissaoLocal = nfe.infNFe.ide.dhEmi.FromSefazTime().InZone(nfe.infNFe.emit.enderEmit.UF).ToString("dd/MM/yyyy HH:mm:ss");
            row = table.AddRow();
            var text = "Número {0} Série {1} Emissão {2}".F(nfe.infNFe.ide.nNF, nfe.infNFe.ide.serie, dataEmissaoLocal);
            row.Cells[0].AddParagraph(text + via);
            row = table.AddRow();

            // O texto “Consulte pela Chave de Acesso em” seguido do endereço eletrônico para consulta pública da NFC-e no Portal da Secretaria da Fazenda do Estado do contribuinte
            row.Cells[0].AddParagraph("Consulte pela Chave de Acesso em " + ListaUrl.BuscaUrls(nfe.infNFe.ide.cUF, nfe.infNFe.ide.tpAmb).UrlNfceConsultaChaveAcesso);
            row = table.AddRow();

            // O texto “CHAVE DE ACESSO”, em caixa alta
            row.Cells[0].AddParagraph("CHAVE DE ACESSO");
            row = table.AddRow();

            // A chave de acesso impressa em 11 blocos de quatro dígitos, com um espaço entre cada bloco
            row.Cells[0].AddParagraph(protocolo.infProt.chNFe.SplitChunks(4).JoinString(" "));

            table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);

            // 2.3.8 Divisão VII – Informações sobre o Consumidor
            table = page.AddTable();
            table.Rows.LeftIndent = 0;
            column = table.AddColumn("16cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            row = table.AddRow();
            row.Cells[0].AddParagraph("CONSUMIDOR");

            if (nfe.infNFe.dest != null)
            {
                var doc = "";

                if (nfe.infNFe.dest.TipoDocumento == TipoDocumento.CNPJ)
                {
                    doc = "CNPJ: ";
                }

                if (nfe.infNFe.dest.TipoDocumento == TipoDocumento.CNPJ)
                {
                    doc = "CPF: ";
                }

                if (nfe.infNFe.dest.TipoDocumento == TipoDocumento.CNPJ)
                {
                    doc = "Id. Estrangeiro: ";
                }

                doc += nfe.infNFe.dest.Item;

                // Nome opcional
                row = table.AddRow();
                row.Cells[0].AddParagraph(doc + " " + nfe.infNFe.dest.xNome);
                row = table.AddRow();

                // Endereco opcional
                row.Cells[0].AddParagraph(nfe.infNFe.emit.enderEmit.xLgr + ", "
                            + nfe.infNFe.emit.enderEmit.nro + ", "
                            + nfe.infNFe.emit.enderEmit.xBairro + ", "
                            + nfe.infNFe.emit.enderEmit.xMun);
            }
            else
            {
                // Na hipótese do não preenchimento das informações de identificação do consumidor na NFCe, deverá ser impressa na área reservada apenas a mensagem “CONSUMIDOR NÃO IDENTIFICADO”.
                row = table.AddRow();
                row.Cells[0].AddParagraph("CONSUMIDOR NÃO IDENTIFICADO");
            }

            table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);

            // 2.3.9 Divisão VIII – Informações da Consulta via QR Code 
            table = page.AddTable();
            table.Rows.LeftIndent = 0;
            column = table.AddColumn("16cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            row = table.AddRow();

            // O texto “Consulta via leitor de QR Code”
            row.Cells[0].AddParagraph("Consulta via leitor de QR Code");
            table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);


            // A imagem do QR Code em tamanho mínimo 25 mm x 25 mm
            var url = nfe.GeraQrCode(cscId, cscToken);
            // "http://www4.fazenda.rj.gov.br/consultaNFCe/QRCode?chNFe=99999999999999999999999999999999999999999999&nVersao=&tpAmp=2&cDest=&dhEmi=323031342D31322D32365430313A31383A33342D30323A3030&vNF=8904.50&vICMS=0.00&digVal=370032007100510061002B0062003000740061006F0051004F003900660041004A007700660064006C005800750071005100760038003D00&cIdToken=cscId&cHashQRCode=1975033D50D8B701C99A2E201E8ED85A75B0D4F4"
            var qrGenerator = new QRCodeGenerator();

            var bitmap = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.L).GetGraphic(1);

            var qrFile = new DisposableFile();
            Disposables.Add(qrFile);

            bitmap.Save(qrFile.Path);

            table = page.AddTable();
            table.Rows.LeftIndent = 0;
            column = table.AddColumn("65mm");
            column = table.AddColumn("30mm");
            column = table.AddColumn("65mm");
            row = table.AddRow();

            image = row.Cells[1].AddImage(qrFile.Path);
            image.Height = "30mm";

            table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);

            // No caso de emissão em contingência a informação sobre o protocolo de autorização será suprimida
            if (nfe.infNFe.ide.tpEmis != TipoEmissaoNFe.ContingenciaOffline)
            {
                table = page.AddTable();
                table.Rows.LeftIndent = 0;
                column = table.AddColumn("16cm");
                column.Format.Alignment = ParagraphAlignment.Center;
                row = table.AddRow();
                // O texto “Protocolo de autorização:” com o número do protocolo de autorização obtido para NFC-e e a data e hora da autorização. 
                row.Cells[0].AddParagraph("Protocolo de Autorização: " + protocolo.infProt.nProt + " " +
                                            protocolo.infProt.dhRecbto.FromSefazTime().ToString("dd/MM/yyyy HH:mm:ss"));

                table.SetEdge(0, 0, table.Columns.Count, table.Rows.Count, Edge.Box, BorderStyle.Single, 0.5);
            }
        }

        public void Dispose()
        {
            Disposables.ForEach(x => x.Dispose());
        }
    }
}
