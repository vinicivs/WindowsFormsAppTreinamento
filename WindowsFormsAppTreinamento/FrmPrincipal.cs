using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTreinamento
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmiPesquisarCep_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de pesquisa de CEP e exibe-o como uma janela modal
            FrmCep frmCep = new FrmCep();
            frmCep.ShowDialog();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            // Fecha o formulário principal
            this.Close();
        }

        private void tsmiCadastrarCep_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de cadastro de CEP e exibe-o como uma janela modal
            FrmCadastrarCep frmCadastrarCep = new FrmCadastrarCep();
            frmCadastrarCep.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de ajuda sobre e exibe-o como uma janela modal
            AbxSobre frmSobre = new AbxSobre();
            frmSobre.ShowDialog();
        }
    }
}
