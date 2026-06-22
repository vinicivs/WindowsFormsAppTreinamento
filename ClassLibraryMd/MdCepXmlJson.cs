using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibraryMd
{
    [Serializable]
    public class MdCepXmlJson
    {
        private Int32 _id;
        private String _cep;
        private String _logradouro;
        private String _numero;
        private String _complemento;
        private String _bairro;
        private String _cidade;
        private String _uf;

        public Int32 Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public String Cep
        {
            get { return this._cep; }
            set { this._cep = value; }
        }

        public String Logradouro
        {
            get { return this._logradouro; }
            set { this._logradouro = value; }
        }

        public String Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public String Complemento
        {
            get { return this._complemento; }
            set { this._complemento = value; }
        }

        public String Bairro
        {
            get { return this._bairro; }
            set { this._bairro = value; }
        }

        public String Cidade
        {
            get { return this._cidade; }
            set { this._cidade = value; }
        }

        public String Uf
        {
            get { return this._uf; }
            set { this._uf = value; }
        }
    }
}
