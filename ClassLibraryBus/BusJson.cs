using ClassLibraryMd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClassLibraryBus
{
    public class BusJson
    {
        private static List<MdCepXmlJson> _ceps = new List<MdCepXmlJson>();

        // Tornado estático para poder usar o campo estático _ceps
        public static void CriarJson()
        {
            // Exemplo de dados
            _ceps.Add(new MdCepXmlJson { Cep = "01001-000", Logradouro = "Praça da Sé", Numero = "123", Complemento = "Complemento Teste", Bairro = "Centro", Cidade = "São Paulo", Uf = "SP" });
            _ceps.Add(new MdCepXmlJson { Cep = "20040-010", Logradouro = "Rua da Quitanda", Numero = "987", Complemento = "Complemento Teste Rio", Bairro = "Centro", Cidade = "Rio de Janeiro", Uf = "RJ" });

            // Serializar para JSON
            string json = JsonConvert.SerializeObject(_ceps, Formatting.Indented);
            File.WriteAllText("arquivo_de_ceps.json", json);
        }

        public static List<MdCepXmlJson> LerXJson()
        {
            // Desserializar do JSON
            string json = File.ReadAllText("arquivo_de_ceps.json");
            _ceps = JsonConvert.DeserializeObject<List<MdCepXmlJson>>(json);

            // Exibir os dados
            string resultado = "";
            foreach (var cep in _ceps)
            {
                resultado += $"{cep.Cep} - {cep.Logradouro}, {cep.Numero}, {cep.Complemento}, {cep.Bairro}, {cep.Cidade}/{cep.Uf}\n";
            }

            return _ceps;
        }
    }
}
