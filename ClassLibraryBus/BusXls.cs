using ClassLibraryMd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ClassLibraryBus
{
    public class BusXls
    {
        private static List<MdClass> _ceps = new List<MdClass>();

        // Tornado estático para poder usar o campo estático _ceps
        public static void CriarXls(string caminho_)
        {

            // Exemplo de dados
            _ceps.Add(new MdClass { Cep = "01001-000", Logradouro = "Praça da Sé", Numero = "123", Complemento = "Complemento Teste", Bairro = "Centro", Cidade = "São Paulo", Uf = "SP" });
            _ceps.Add(new MdClass { Cep = "20040-010", Logradouro = "Rua da Quitanda", Numero = "987", Complemento = "Complemento Teste Rio", Bairro = "Centro", Cidade = "Rio de Janeiro", Uf = "RJ" });

            /// Criar Excel
            var app = new Excel.Application();
            app.Visible = false;
            var wb = app.Workbooks.Add();
            var ws = (Excel.Worksheet)wb.Sheets[1];

            // Cabeçalho
            ws.Cells[1, 1] = "CEP";
            ws.Cells[1, 2] = "Logradouro";
            ws.Cells[1, 3] = "Numero";
            ws.Cells[1, 4] = "Complemento";
            ws.Cells[1, 5] = "Bairro";
            ws.Cells[1, 6] = "Cidade";
            ws.Cells[1, 7] = "Uf";

            // Dados
            int row = 2;
            foreach (var cep in _ceps)
            {
                ws.Cells[row, 1] = cep.Cep;
                ws.Cells[row, 2] = cep.Logradouro;
                ws.Cells[row, 3] = cep.Numero;
                ws.Cells[row, 4] = cep.Complemento;
                ws.Cells[row, 5] = cep.Bairro;
                ws.Cells[row, 6] = cep.Cidade;
                ws.Cells[row, 7] = cep.Uf;
                row++;
            }

            // Salvar
            string path = caminho_ + "\\arquivo_de_ceps.xls";
            wb.SaveAs(path);
            wb.Close();
            app.Quit();
        }

        public static List<MdClass> LerXls(string caminho_)
        {
            string path = caminho_ + "\\arquivo_de_ceps.xls";
            var app = new Excel.Application();
            var wb = app.Workbooks.Open(path);
            var ws = (Excel.Worksheet)wb.Sheets[1];

            _ceps.Clear();
            int row = 2;
            while (((Excel.Range)ws.Cells[row, 1]).Value2 != null)
            {
                var cep = new MdClass
                {
                    Cep = ((Excel.Range)ws.Cells[row, 1]).Value2.ToString(),
                    Logradouro = ((Excel.Range)ws.Cells[row, 2]).Value2.ToString(),
                    Numero = ((Excel.Range)ws.Cells[row, 3]).Value2.ToString(),
                    Complemento = ((Excel.Range)ws.Cells[row, 4]).Value2.ToString(),
                    Bairro = ((Excel.Range)ws.Cells[row, 5]).Value2.ToString(),
                    Cidade = ((Excel.Range)ws.Cells[row, 6]).Value2.ToString(),
                    Uf = ((Excel.Range)ws.Cells[row, 7]).Value2.ToString()
                };
                _ceps.Add(cep);
                row++;
            }

            wb.Close();
            app.Quit();

            return _ceps;
        }
    }
}
