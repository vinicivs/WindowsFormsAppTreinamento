using ClassLibraryMd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDao
{
    public class DaoClass
    {
        private String _sql = "";
        private SqlConnection _myconn = new SqlConnection(@"Persist Security Info=False;User ID=sa;Pwd=123; Initial Catalog=MeuBancoDeDados; Data Source=(localdb)\MSSQLLocalDB");
        //private MySqlConnection _myconn = new MySqlConnection(@"Persist Security Info=False;User ID=bd_robomga;Pwd=Dye122700; Initial Catalog=bd_robomga; Data Source=187.45.196.179"); //Server=servidor\gvinci;Database=Abrava;Uid=sa;Pwd=123;
        private DataSet _ds = new DataSet();
        private SqlCommand _cmd;
        public new DataTable _dt;

        private MdClass _MdClass;

        public MdClass MdClass
        {
            get { return this._MdClass; }
            set { this._MdClass = value; }
        }

        //Inserir
        public int Inserir()
        {
            //Inserir na tabela CEP
            _sql = "";
            _sql = _sql + "INSERT INTO CEP ";
            _sql = _sql + "(";
            _sql = _sql + "             CEP,";
            _sql = _sql + "             LOGRADOURO,";
            _sql = _sql + "             NUMERO,";
            _sql = _sql + "             COMPLEMENTO,";
            _sql = _sql + "             BAIRRO,";
            _sql = _sql + "             CIDADE,";
            _sql = _sql + "             UF";
            _sql = _sql + ")";
            _sql = _sql + "values";
            _sql = _sql + "(";
            _sql = _sql + "       '" + this.MdClass.Cep.ToString() + "',";
            _sql = _sql + "       '" + this.MdClass.Logradouro.ToString() + "',";
            _sql = _sql + "       '" + this.MdClass.Numero + "',";
            _sql = _sql + "       '" + this.MdClass.Complemento + "',";
            _sql = _sql + "       '" + this.MdClass.Bairro.ToString() + "',";
            _sql = _sql + "       '" + this.MdClass.Cidade.ToString() + "',";
            _sql = _sql + "       '" + this.MdClass.Uf.ToString() + "'";
            _sql = _sql + ")";

            _cmd = new SqlCommand(_sql, _myconn);
            _cmd.CommandText = _sql;

            try
            {
                if (_myconn.State == ConnectionState.Closed)
                {

                    _myconn.Open();
                }
                return _cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception();

            }
            finally
            {
                if (_myconn.State == ConnectionState.Open)
                {
                    _myconn.Close();

                }
            }

        }

        public int Atualizar()
        {
            //Atualiza tabela de CEP
            _sql = "";
            _sql = _sql + "UPDATE CEP SET";
            _sql = _sql + "             CEP = '" + this.MdClass.Cep.ToString() + "',";
            _sql = _sql + "             LOGRADOURO = '" + this.MdClass.Logradouro.ToString() + "',";
            _sql = _sql + "             NUMERO = '" + this.MdClass.Numero + "',";
            _sql = _sql + "             COMPLEMENTO = '" + this.MdClass.Complemento + "',";
            _sql = _sql + "             BAIRRO = '" + this.MdClass.Bairro.ToString() + "',";
            _sql = _sql + "             CIDADE = '" + this.MdClass.Cidade.ToString() + "',";
            _sql = _sql + "             UF = '" + this.MdClass.Uf.ToString() + "'";
            _sql = _sql + "             WHERE ID = " + this.MdClass.Id;

            _cmd = new SqlCommand(_sql, _myconn);
            _cmd.CommandText = _sql;

            try
            {
                if (_myconn.State == ConnectionState.Closed)
                {

                    _myconn.Open();
                }
                return _cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            finally
            {
                if (_myconn.State == ConnectionState.Open)
                {
                    _myconn.Close();

                }
            }

        }

        public int Deletar()
        {
            ///deletar na tabela cep
            _sql = "";
            _sql = _sql + "Delete from CEP ";
            _sql = _sql + "where ";
            _sql = _sql + "  id =     '" + this.MdClass.Id + "'";

            _cmd = new SqlCommand(_sql, _myconn);
            _cmd.CommandText = _sql;

            try
            {
                if (_myconn.State == ConnectionState.Closed)
                {

                    _myconn.Open();
                }
                return _cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception();

            }
            finally
            {
                if (_myconn.State == ConnectionState.Open)
                {
                    _myconn.Close();

                }
            }

        }

        public DataTable Listagem()
        {

            //Listagem tabela cliente
            _sql = "";
            _sql = _sql + "SELECT ";
            _sql = _sql + "             ID,";
            _sql = _sql + "             CEP,";
            _sql = _sql + "             LOGRADOURO,";
            _sql = _sql + "             NUMERO,";
            _sql = _sql + "             COMPLEMENTO,";
            _sql = _sql + "             BAIRRO,";
            _sql = _sql + "             CIDADE,";
            _sql = _sql + "             UF";
            _sql = _sql + " FROM ";
            _sql = _sql + " CEP ";

            _cmd = new SqlCommand(_sql, _myconn);

            var da = new SqlDataAdapter(_cmd);

            _cmd.CommandText = _sql;

            _dt = new DataTable();

            try

            {

                da.Fill(_dt);

                return _dt;

            }

            catch (Exception ex)

            {

                throw new Exception();

            }

        }

        public DataTable Localizar(String cep_)
        {

            //Listagem tabela cliente
            _sql = "";
            _sql = _sql + "             SELECT";
            _sql = _sql + "             ID,";
            _sql = _sql + "             CEP,";
            _sql = _sql + "             LOGRADOURO,";
            _sql = _sql + "             NUMERO,";
            _sql = _sql + "             COMPLEMENTO,";
            _sql = _sql + "             BAIRRO,";
            _sql = _sql + "             CIDADE,";
            _sql = _sql + "             UF";
            _sql = _sql + " FROM ";
            _sql = _sql + " CEP ";
            _sql = _sql + " Where CEP = '" + cep_ + "'";
          
            _cmd = new SqlCommand(_sql, _myconn);

            var da = new SqlDataAdapter(_cmd);

            _cmd.CommandText = _sql;

            _dt = new DataTable();

            try

            {

                da.Fill(_dt);

                return _dt;

            }

            catch (Exception ex)

            {

                throw new Exception();

            }

        }
    }
}
