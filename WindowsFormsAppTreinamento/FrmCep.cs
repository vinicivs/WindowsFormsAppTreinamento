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
using ClassLibraryMd;

namespace WindowsFormsAppTreinamento
{
    public partial class FrmCep : Form
    {
        public FrmCep()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de texto e o DataGridView
            mskCep.Text = string.Empty;
            dgvCep.Rows.Clear();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo de CEP está vazio
            if (mskCep.Text == "     -")
            {
                MessageBox.Show("Por favor, insira um CEP para pesquisar.");
                mskCep.Focus();
                return;
            }

            //Pesquisar Cep
            var pesquisarcep = BusClass.Localizar(mskCep.Text);

            // Verificar se o cep foi encontrado
            if (pesquisarcep.Id  == 0)
            {
                MessageBox.Show("Cep não encontrado!");
                mskCep.Focus();
                return;
            }

            // Limpar o DataGridView antes de exibir os resultados
            dgvCep.Rows.Clear();

            // Exibir os dados do cep encontrado no DataGridView
            dgvCep.Rows.Add(pesquisarcep.Id, pesquisarcep.Cep, pesquisarcep.Logradouro, pesquisarcep.Numero, pesquisarcep.Complemento, pesquisarcep.Bairro, pesquisarcep.Cidade, pesquisarcep.Uf);
            
        }

        private void FrmCep_Load(object sender, EventArgs e)
        {
            //Listagem de Ceps
            var listagemceps = BusClass.Listagem();

            foreach (var item in listagemceps)
            {
                
                dgvCep.Rows.Add(item.Id, item.Cep, item.Logradouro, item.Numero, item.Complemento, item.Bairro, item.Cidade, item.Uf);
            }
        }
    }
}
