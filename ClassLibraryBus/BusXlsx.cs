using ClassLibraryMd;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBus
{
    public class BusXlsx
    {
        private static List<MdClass> _ceps = new List<MdClass>();

        // Tornado estático para poder usar o campo estático _ceps
        public static void CriarXlsx(string caminho_)
        {

            // Exemplo de dados
            _ceps.Add(new MdClass { Cep = "01001-000", Logradouro = "Praça da Sé", Numero = "123", Complemento = "Complemento Teste", Bairro = "Centro", Cidade = "São Paulo", Uf = "SP" });
            _ceps.Add(new MdClass { Cep = "20040-010", Logradouro = "Rua da Quitanda", Numero = "987", Complemento = "Complemento Teste Rio", Bairro = "Centro", Cidade = "Rio de Janeiro", Uf = "RJ" });

            // Criar planilha
            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("CEPs");

                // Cabeçalho
                ws.Cell(1, 1).Value = "CEP";
                ws.Cell(1, 2).Value = "Logradouro";
                ws.Cell(1, 3).Value = "Número";
                ws.Cell(1, 4).Value = "Complemento";
                ws.Cell(1, 5).Value = "Bairro";
                ws.Cell(1, 6).Value = "Cidade";
                ws.Cell(1, 7).Value = "Uf";

                // Dados
                int row = 2;
                foreach (var cep in _ceps)
                {
                    ws.Cell(row, 1).Value = cep.Cep;
                    ws.Cell(row, 2).Value = cep.Logradouro;
                    ws.Cell(row, 3).Value = cep.Numero;
                    ws.Cell(row, 4).Value = cep.Complemento;
                    ws.Cell(row, 5).Value = cep.Bairro;
                    ws.Cell(row, 6).Value = cep.Cidade;
                    ws.Cell(row, 7).Value = cep.Uf;
                    row++;
                }

                string path = caminho_ + "\\arquivo_de_ceps.xlsx";
                wb.SaveAs(path);
                
            }

        }

        public static List<MdClass> LerXlsx(string caminho_)
        {
            string path = caminho_ + "\\arquivo_de_ceps.xlsx";
            _ceps.Clear();

            using (var wb = new XLWorkbook(path))
            {
                var ws = wb.Worksheet("CEPs");
                int row = 2;

                while (!ws.Cell(row, 1).IsEmpty())
                {
                    var cep = new MdClass
                    {
                        Cep = ws.Cell(row, 1).GetString(),
                        Logradouro = ws.Cell(row, 2).GetString(),
                        Numero = ws.Cell(row, 3).GetString(),
                        Complemento = ws.Cell(row, 4).GetString(),
                        Bairro = ws.Cell(row, 5).GetString(),
                        Cidade = ws.Cell(row, 6).GetString(),
                        Uf = ws.Cell(row, 7).GetString()
                    };
                    _ceps.Add(cep);
                    row++;
                }
            }

            return _ceps;
        }
    }
}
