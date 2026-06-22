using ClassLibraryBus;
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
    public partial class FrmXlsx : Form
    {
        public FrmXlsx()
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
            // Criar o arquivo Excel Xslx
            BusXlsx.CriarXlsx(@"C:\Users\Public\Documents");

            // Alerta de criação
            MessageBox.Show("Arquivo Xlsx criado com sucesso!");
        }

        private void BtnLer_Click(object sender, EventArgs e)
        {
            // Ler o arquivo Excel
            var _ceps = BusXlsx.LerXlsx(@"C:\Users\Public\Documents");

            // Exibir os dados
            string resultado = "";
            foreach (var cep in _ceps)
            {
                resultado += $"{cep.Cep} - {cep.Logradouro}, {cep.Numero}, {cep.Complemento}, {cep.Bairro}, {cep.Cidade}/{cep.Uf}\n";
            }
            MessageBox.Show(resultado, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Alerta de leitura
            MessageBox.Show("Arquivo Excel Xlsx lido com sucesso!");
        }
    }
}
