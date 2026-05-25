namespace WindowsFormsAppTreinamento
{
    partial class FrmCep
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gbxEndereco = new System.Windows.Forms.GroupBox();
            this.dgvCep = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(12, 9);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(71, 6);
            this.mskCep.Mask = "99999-999";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(100, 20);
            this.mskCep.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(177, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gbxEndereco
            // 
            this.gbxEndereco.Controls.Add(this.dgvCep);
            this.gbxEndereco.Location = new System.Drawing.Point(12, 35);
            this.gbxEndereco.Name = "gbxEndereco";
            this.gbxEndereco.Size = new System.Drawing.Size(706, 221);
            this.gbxEndereco.TabIndex = 3;
            this.gbxEndereco.TabStop = false;
            this.gbxEndereco.Text = "Endereços:";
            // 
            // dgvCep
            // 
            this.dgvCep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmCep,
            this.clmLogradouro,
            this.clmNumero,
            this.clmComplemento,
            this.clmBairro,
            this.clmCidade,
            this.clmUf});
            this.dgvCep.Location = new System.Drawing.Point(6, 19);
            this.dgvCep.Name = "dgvCep";
            this.dgvCep.Size = new System.Drawing.Size(694, 196);
            this.dgvCep.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(258, 6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(339, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.ToolTipText = "Id";
            this.clmId.Width = 50;
            // 
            // clmCep
            // 
            this.clmCep.HeaderText = "Cep";
            this.clmCep.Name = "clmCep";
            this.clmCep.ReadOnly = true;
            this.clmCep.ToolTipText = "Cep";
            // 
            // clmLogradouro
            // 
            this.clmLogradouro.HeaderText = "Logradouro";
            this.clmLogradouro.Name = "clmLogradouro";
            this.clmLogradouro.ReadOnly = true;
            this.clmLogradouro.ToolTipText = "Logradouro";
            // 
            // clmNumero
            // 
            this.clmNumero.HeaderText = "Número";
            this.clmNumero.Name = "clmNumero";
            this.clmNumero.ReadOnly = true;
            this.clmNumero.ToolTipText = "Número";
            // 
            // clmComplemento
            // 
            this.clmComplemento.HeaderText = "Complemento";
            this.clmComplemento.Name = "clmComplemento";
            this.clmComplemento.ReadOnly = true;
            this.clmComplemento.ToolTipText = "Complemento";
            // 
            // clmBairro
            // 
            this.clmBairro.HeaderText = "Bairro";
            this.clmBairro.Name = "clmBairro";
            this.clmBairro.ReadOnly = true;
            this.clmBairro.ToolTipText = "Bairro";
            // 
            // clmCidade
            // 
            this.clmCidade.HeaderText = "Cidade";
            this.clmCidade.Name = "clmCidade";
            this.clmCidade.ReadOnly = true;
            this.clmCidade.ToolTipText = "Cidade";
            // 
            // clmUf
            // 
            this.clmUf.HeaderText = "UF";
            this.clmUf.Name = "clmUf";
            this.clmUf.ReadOnly = true;
            this.clmUf.ToolTipText = "UF";
            this.clmUf.Width = 50;
            // 
            // FrmCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 270);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbxEndereco);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.lblPesquisar);
            this.MaximizeBox = false;
            this.Name = "FrmCep";
            this.Text = "CEP - Pesquisar";
            this.Load += new System.EventHandler(this.FrmCep_Load);
            this.gbxEndereco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox gbxEndereco;
        private System.Windows.Forms.DataGridView dgvCep;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUf;
    }
}

