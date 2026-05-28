using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryMd;
using ClassLibraryDao;
using System.Data;

namespace ClassLibraryBus
{
    public class BusClass
    {
        //Inserir
        public static int Inserir(MdClass ceps_)
        {

            DaoClass ceps = new DaoClass();

            ceps.MdClass = ceps_;

            return ceps.Inserir();

        }

        public static int Alterar(MdClass ceps_)
        {
            DaoClass ceps = new DaoClass();

            ceps.MdClass = ceps_;

            return ceps.Atualizar();

        }

        public static int Apagar(MdClass ceps_)
        {
            DaoClass ceps = new DaoClass();

            ceps.MdClass = ceps_;

            ceps.MdClass.Id = ceps_.Id;

            return ceps.Deletar();

        }

        public static List<MdClass> Listagem()
        {

            DaoClass ceps = new DaoClass();

            var dt = ceps.Listagem();

            var retorno = new List<MdClass>();

            int contador;

            contador = 0;

            foreach (DataRow Acoes in dt.Rows)

            {

                MdClass resultado = new MdClass();

                resultado.Id = Convert.ToInt32(dt.Rows[contador]["Id"]);

                resultado.Cep = Convert.ToString(dt.Rows[contador]["Cep"]);

                resultado.Logradouro = Convert.ToString(dt.Rows[contador]["Logradouro"]);

                resultado.Numero = Convert.ToString(dt.Rows[contador]["Numero"]);

                resultado.Complemento = Convert.ToString(dt.Rows[contador]["Complemento"]);

                resultado.Bairro = Convert.ToString(dt.Rows[contador]["Bairro"]);

                resultado.Cidade = Convert.ToString(dt.Rows[contador]["Cidade"]);

                resultado.Uf = Convert.ToString(dt.Rows[contador]["Uf"]);

                retorno.Add(resultado);

                contador = contador + 1;

            }

            return retorno;

        }

        public static MdClass Localizar(String Cep_)
        {

            DaoClass ceps = new DaoClass();

            var dt = ceps.Localizar(Cep_);

            MdClass resultado = new MdClass();

            if (dt.Rows.Count <= 0)
            {
                return resultado;
            }
            else
            {

                resultado.Id = Convert.ToInt32(dt.Rows[0]["Id"]);

                resultado.Cep = Convert.ToString(dt.Rows[0]["Cep"]);

                resultado.Logradouro = Convert.ToString(dt.Rows[0]["Logradouro"]);

                resultado.Numero = Convert.ToString(dt.Rows[0]["Numero"]);

                resultado.Complemento = Convert.ToString(dt.Rows[0]["Complemento"]);

                resultado.Bairro = Convert.ToString(dt.Rows[0]["Bairro"]);

                resultado.Cidade = Convert.ToString(dt.Rows[0]["Cidade"]);

                resultado.Uf = Convert.ToString(dt.Rows[0]["Uf"]);

                return resultado;
            }

        }

        public static MdClass Localizar(int Id_)
        {

            DaoClass ceps = new DaoClass();

            var dt = ceps.Localizar(Id_);

            MdClass resultado = new MdClass();

            if (dt.Rows.Count <= 0)
            {
                return resultado;
            }
            else
            {

                resultado.Id = Convert.ToInt32(dt.Rows[0]["Id"]);

                resultado.Cep = Convert.ToString(dt.Rows[0]["Cep"]);

                resultado.Logradouro = Convert.ToString(dt.Rows[0]["Logradouro"]);

                resultado.Numero = Convert.ToString(dt.Rows[0]["Numero"]);

                resultado.Complemento = Convert.ToString(dt.Rows[0]["Complemento"]);

                resultado.Bairro = Convert.ToString(dt.Rows[0]["Bairro"]);

                resultado.Cidade = Convert.ToString(dt.Rows[0]["Cidade"]);

                resultado.Uf = Convert.ToString(dt.Rows[0]["Uf"]);

                return resultado;
            }

        }

    }
}
