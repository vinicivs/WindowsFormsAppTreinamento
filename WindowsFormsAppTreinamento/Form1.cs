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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
