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
    public partial class FrmTxt : Form
    {
        public FrmTxt()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }

        private void BtnCriarTxt_Click(object sender, EventArgs e)
        {
            // Chama o método EscreverTxt da classe BusTxt para criar ou sobrescrever um arquivo de texto com o conteúdo especificado
            BusTxt.EscreverTxt(@"C:\Logs\Treinamento\WindowsFormsApp\TextoCriado.txt", "Este é um texto criado pelo método EscreverTxt.");
        }

        private void BtnAnexarTxt_Click(object sender, EventArgs e)
        {
            // Chama o método AnexarTxt da classe BusTxt para anexar um texto a um arquivo de texto, criando-o se não existir
            BusTxt.AnexarTxt(@"C:\Logs\Treinamento\WindowsFormsApp\TextoCriado.txt", "Este é um texto anexado pelo método AnexarTxt.");
        }

        private void BtnLerTxt_Click(object sender, EventArgs e)
        {
            // Chama o método LerTxt da classe BusTxt para ler o conteúdo de um arquivo de texto e exibi-lo em uma caixa de mensagem
            var lerTxt = BusTxt.LerTxt(@"C:\Logs\Treinamento\WindowsFormsApp\TextoCriado.txt");

            // Exibe o conteúdo lido do arquivo em uma caixa de mensagem
            MessageBox.Show(lerTxt, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
