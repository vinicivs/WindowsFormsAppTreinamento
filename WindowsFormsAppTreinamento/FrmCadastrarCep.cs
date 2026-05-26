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
    public partial class FrmCadastrarCep : Form
    {
        public FrmCadastrarCep()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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
            BusClass.Inserir(new ClassLibraryMd.MdClass
            {
                Cep = mskCep.Text,
                Logradouro = txtLogradouro.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Uf = cboUf.Text
            });

            // Exibe uma mensagem de sucesso
            MessageBox.Show("CEP cadastrado com sucesso!");

        }
    }
}
