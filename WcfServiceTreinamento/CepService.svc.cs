using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ClassLibraryMd;

namespace WcfServiceTreinamento
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "CepService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione CepService.svc ou CepService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class CepService : ICepService
    {
        string conStr = ConfigurationManager.ConnectionStrings["ConexaoDB"].ConnectionString;

        public void InserirCep(MdClass cep)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "INSERT INTO Cep (Cep, Logradouro, Numero, Complemento, Bairro, Cidade, Uf) VALUES (@Cep, @Logradouro, @Numero, @Complemento, @Bairro, @Cidade, @Uf)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Cep", cep.Cep);
                cmd.Parameters.AddWithValue("@Logradouro", cep.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", cep.Numero);
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade);
                cmd.Parameters.AddWithValue("@Uf", cep.Uf);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<MdClass> ListarCeps()
        {
            List<MdClass> lista = new List<MdClass>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cep", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new MdClass
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Cep = dr["Cep"].ToString(),
                        Logradouro = dr["Logradouro"].ToString(),
                        Numero = dr["Numero"].ToString(),
                        Complemento = dr["Complemento"].ToString(),
                        Bairro = dr["Bairro"].ToString(),
                        Cidade = dr["Cidade"].ToString(),
                        Uf = dr["Uf"].ToString()
                    });
                }
            }
            return lista;
        }

        public void AtualizarCep(MdClass cep)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "UPDATE Cep SET Cep=@Cep, Logradouro=@Logradouro, Numero=@Numero, Complemento=@Complemento, Bairro=@Bairro, Cidade=@Cidade, Uf=@Uf WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Cep", cep.Cep);
                cmd.Parameters.AddWithValue("@Logradouro", cep.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", cep.Numero);
                cmd.Parameters.AddWithValue("@Complemento", cep.Complemento);
                cmd.Parameters.AddWithValue("@Bairro", cep.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", cep.Cidade);
                cmd.Parameters.AddWithValue("@Uf", cep.Uf);
                cmd.Parameters.AddWithValue("@Id", cep.Id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirCep(int id)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Cep WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
