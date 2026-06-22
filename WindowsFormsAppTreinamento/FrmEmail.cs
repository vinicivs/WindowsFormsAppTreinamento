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
    public partial class FrmEmail : Form
    {
        public FrmEmail()
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
            // Lógica para criar um novo e-mail
            
            openFileDialogEmail.Multiselect = true; // permitir vários arquivos
            if (openFileDialogEmail.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialogEmail.FileNames)
                {
                    lbxAnexo.Items.Add(file);
                }
            }

            // Cria uma nova instância do formulário de criação de email
            BusEmail.EnviarEmail("vinicivs@gmail.com", "Teste de Email", "Este é um teste de envio de email.", openFileDialogEmail.FileNames[0]);

            // Exibe uma mensagem de sucesso
            MessageBox.Show("Email enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnLer_Click(object sender, EventArgs e)
        {
            // leitura de emails
            BusEmail.LerEmail(@"C:\Users\Public\Documents");

            // Alerta de leitura de e-mails
            MessageBox.Show("Leitura de e-mails concluída!");
        }
    }
}
