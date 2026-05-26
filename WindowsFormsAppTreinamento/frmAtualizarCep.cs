using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBus;

namespace WindowsFormsAppTreinamento
{
    public partial class frmAtualizarCep : Form
    {
        public frmAtualizarCep()
        {
            InitializeComponent();
        }

        public string Cep { get; internal set; }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }

        private void frmAtualizarCep_Load(object sender, EventArgs e)
        {
            var pesquisarcep = ClassLibraryBus.BusClass.Localizar(Cep);

            txtId.Text = pesquisarcep.Id.ToString();
            mskCep.Text = pesquisarcep.Cep;
            txtLogradouro.Text = pesquisarcep.Logradouro;
            txtNumero.Text = pesquisarcep.Numero;
            txtComplemento.Text = pesquisarcep.Complemento;
            txtBairro.Text = pesquisarcep.Bairro;
            txtCidade.Text = pesquisarcep.Cidade;
            cboUf.Text = pesquisarcep.Uf;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Valida o campo de CEP
            if (mskCep.Text == "     -")
            {
                MessageBox.Show("Por favor, insira um CEP para cadastrar.");
                mskCep.Focus();
                return;
            }

            // Valida os campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtLogradouro.Text) ||
                string.IsNullOrWhiteSpace(txtBairro.Text) ||
                string.IsNullOrWhiteSpace(txtCidade.Text) ||
                string.IsNullOrWhiteSpace(cboUf.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            // Cria um novo objeto MdClass com os dados do formulário
            BusClass.Alterar(new ClassLibraryMd.MdClass
            {
                Id = int.Parse(txtId.Text),
                Cep = mskCep.Text,
                Logradouro = txtLogradouro.Text,
                Numero = txtNumero.Text ,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Uf = cboUf.Text
            });

            // Exibe uma mensagem de sucesso
            MessageBox.Show("CEP alterado com sucesso!");

            // Fecha o formulário
            this.Close();
        }
    }
}
