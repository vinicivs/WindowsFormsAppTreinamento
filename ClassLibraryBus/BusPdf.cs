using ClassLibraryMd;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBus
{
    public class BusPdf
    {
        private static List<MdClass> _ceps = new List<MdClass>();

        // Tornado estático para poder usar o campo estático _ceps
        public static void CriarPdf(string caminho_)
        {

            // Exemplo de dados
            _ceps.Add(new MdClass { Cep = "01001-000", Logradouro = "Praça da Sé", Numero = "123", Complemento = "Complemento Teste", Bairro = "Centro", Cidade = "São Paulo", Uf = "SP" });
            _ceps.Add(new MdClass { Cep = "20040-010", Logradouro = "Rua da Quitanda", Numero = "987", Complemento = "Complemento Teste Rio", Bairro = "Centro", Cidade = "Rio de Janeiro", Uf = "RJ" });

            string path = caminho_ + "\\arquivo_de_ceps.pdf";

            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            // Título
            doc.Add(new Paragraph("Lista de CEPs"));
            doc.Add(new Paragraph(" "));

            // Tabela
            PdfPTable table = new PdfPTable(4);
            table.AddCell("CEP");
            table.AddCell("Logradouro");
            table.AddCell("Numero");
            table.AddCell("Complemento");
            table.AddCell("Bairro");
            table.AddCell("Cidade");
            table.AddCell("Uf");

            foreach (var cep in _ceps)
            {
                table.AddCell(cep.Cep);
                table.AddCell(cep.Logradouro);
                table.AddCell(cep.Numero);
                table.AddCell(cep.Complemento);
                table.AddCell(cep.Bairro);
                table.AddCell(cep.Cidade);
                table.AddCell(cep.Uf);
            }

            doc.Add(table);
            doc.Close();
        }

        public static string LerPdf(string caminho_)
        {
            string path = caminho_ + "\\arquivo_de_ceps.pdf";
            string texto = "";

            using (PdfReader reader = new PdfReader(path))
            {

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    // Extrai o texto da página
                    texto += iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, i);

                    // Quebra o texto em linhas e adiciona na lista
                    string[] linhas = texto.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    
                }
            }

            return texto;
        }

    }
}
