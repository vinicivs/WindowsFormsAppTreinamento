using ClassLibraryMd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibraryBus
{
    public class BusXml
    {
        private static List<MdCepXmlJson> _ceps = new List<MdCepXmlJson>();

        // Tornado estático para poder usar o campo estático _ceps
        public static void CriarXml()
        {

            // Exemplo de dados
            _ceps.Add(new MdCepXmlJson { Cep = "01001-000", Logradouro = "Praça da Sé", Numero = "123", Complemento = "Complemento Teste", Bairro = "Centro", Cidade = "São Paulo", Uf = "SP" });
            _ceps.Add(new MdCepXmlJson { Cep = "20040-010", Logradouro = "Rua da Quitanda", Numero = "987", Complemento = "Complemento Teste Rio", Bairro = "Centro", Cidade = "Rio de Janeiro", Uf = "RJ" });

            // Serializar para XML
            XmlSerializer serializer = new XmlSerializer(typeof(List<MdCepXmlJson>));
            using (TextWriter writer = new StreamWriter("arquivo_de_ceps.xml"))
            {
                serializer.Serialize(writer, _ceps);
            }
        }

        public static List<MdCepXmlJson> LerXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<MdCepXmlJson>));
            using (TextReader reader = new StreamReader("arquivo_de_ceps.xml"))
            {
                _ceps = (List<MdCepXmlJson>)serializer.Deserialize(reader);
            }

            return _ceps;
        }
    }
}
