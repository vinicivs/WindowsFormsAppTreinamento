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

        private void tsmiTxt_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de manipulação de arquivos de texto e exibe-o como uma janela modal
            FrmTxt frmTxt = new FrmTxt();
            frmTxt.ShowDialog();
        }

        private void tsmiXml_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de manipulação de arquivos XML e exibe-o como uma janela modal
            FrmXml frmXml = new FrmXml();
            frmXml.ShowDialog();
        }

        private void tsmiJson_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de manipulação de arquivos JSON e exibe-o como uma janela modal
            FrmJson frmJson = new FrmJson();
            frmJson.ShowDialog();
        }

        private void tsmiEmail_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de envio de email e exibe-o como uma janela modal
            FrmEmail frmEmail = new FrmEmail();
            frmEmail.ShowDialog();
        }

        private void tsmiXls_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de manipulação de arquivos Excel e exibe-o como uma janela modal
            FrmXls frmXls = new FrmXls();
            frmXls.ShowDialog();
        }

        private void tsmiXlsx_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de manipulação de arquivos Excel (formato XLSX) e exibe-o como uma janela modal
            FrmXlsx frmXlsx = new FrmXlsx();
            frmXlsx.ShowDialog();
        }

        private void arquivopdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário de manipulação de arquivos PDF e exibe-o como uma janela modal
            FrmPdf frmPdf = new FrmPdf();
            frmPdf.ShowDialog();
        }
    }
}
