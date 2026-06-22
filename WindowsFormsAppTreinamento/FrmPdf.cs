using ClassLibraryBus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTreinamento
{
    public partial class FrmPdf : Form
    {
        public FrmPdf()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            // Criar o arquivo Pdf
            BusPdf.CriarPdf(@"C:\Users\Public\Documents");

            // Alerta de criação
            MessageBox.Show("Arquivo Pdf criado com sucesso!");
        }

        private void BtnLer_Click(object sender, EventArgs e)
        {
            // Ler o arquivo Excel
            var _ceps = BusPdf.LerPdf(@"C:\Users\Public\Documents");

            // Exibir o conteúdo do PDF em uma MessageBox
            MessageBox.Show(_ceps, "Conteúdo do PDF");

            // Alerta de leitura
            MessageBox.Show("Arquivo Pdf lido com sucesso!");
        }
    }
}
