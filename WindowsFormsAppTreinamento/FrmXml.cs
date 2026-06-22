using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBus;

namespace WindowsFormsAppTreinamento
{
    public partial class FrmXml : Form
    {
        public FrmXml()
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
            // Lógica para criar o XML a partir da lista de MdCepXml
            BusXml.CriarXml();

            // Exibe uma mensagem de sucesso
            MessageBox.Show("XML criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnLer_Click(object sender, EventArgs e)
        {
            // Lógica para ler o XML e exibir os dados em um MessageBox
            var _lerxml = BusXml.LerXml();

            // Exibe os dados lidos do XML

            string resultado = "";
            foreach (var cep in _lerxml)
            {
                resultado += $"{cep.Cep} - {cep.Logradouro}, {cep.Numero}, {cep.Complemento}, {cep.Bairro}, {cep.Cidade}/{cep.Uf}\n";
            }

            MessageBox.Show(resultado, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("XML lido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
