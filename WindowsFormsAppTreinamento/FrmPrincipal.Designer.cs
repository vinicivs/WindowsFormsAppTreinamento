namespace WindowsFormsAppTreinamento
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPesquisarCep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarCep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXml = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXls = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXlsx = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.tsmiSair});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(800, 24);
            this.mspMenu.TabIndex = 0;
            this.mspMenu.Text = "Principal";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPesquisarCep,
            this.tsmiCadastrarCep});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "&Principal";
            // 
            // tsmiPesquisarCep
            // 
            this.tsmiPesquisarCep.Name = "tsmiPesquisarCep";
            this.tsmiPesquisarCep.Size = new System.Drawing.Size(180, 22);
            this.tsmiPesquisarCep.Text = "Pesquisar &Cep";
            this.tsmiPesquisarCep.ToolTipText = "Pesquisar Cep";
            this.tsmiPesquisarCep.Click += new System.EventHandler(this.tsmiPesquisarCep_Click);
            // 
            // tsmiCadastrarCep
            // 
            this.tsmiCadastrarCep.Name = "tsmiCadastrarCep";
            this.tsmiCadastrarCep.Size = new System.Drawing.Size(180, 22);
            this.tsmiCadastrarCep.Text = "&Cadastrar Cep";
            this.tsmiCadastrarCep.ToolTipText = "Cadastrar Cep";
            this.tsmiCadastrarCep.Click += new System.EventHandler(this.tsmiCadastrarCep_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem2.Text = "&Sobre";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "&Sair";
            this.tsmiSair.ToolTipText = "Sair";
            this.tsmiSair.Click += new System.EventHandler(this.tsmiSair_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTxt,
            this.tsmiXml,
            this.tsmiJson,
            this.tsmiEmail,
            this.tsmiXls,
            this.tsmiXlsx});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem3.Text = "E&xemplos";
            // 
            // tsmiTxt
            // 
            this.tsmiTxt.Name = "tsmiTxt";
            this.tsmiTxt.Size = new System.Drawing.Size(189, 22);
            this.tsmiTxt.Text = "Arquivo (.&txt)";
            this.tsmiTxt.ToolTipText = "Arquivo (.txt)";
            this.tsmiTxt.Click += new System.EventHandler(this.tsmiTxt_Click);
            // 
            // tsmiXml
            // 
            this.tsmiXml.Name = "tsmiXml";
            this.tsmiXml.Size = new System.Drawing.Size(189, 22);
            this.tsmiXml.Text = "Arquivo (.xml)";
            this.tsmiXml.ToolTipText = "Arquivo (.xml)";
            // 
            // tsmiJson
            // 
            this.tsmiJson.Name = "tsmiJson";
            this.tsmiJson.Size = new System.Drawing.Size(189, 22);
            this.tsmiJson.Text = "Arquivo (.&json)";
            this.tsmiJson.ToolTipText = "Arquivo (.json)";
            // 
            // tsmiEmail
            // 
            this.tsmiEmail.Name = "tsmiEmail";
            this.tsmiEmail.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiEmail.Size = new System.Drawing.Size(189, 22);
            this.tsmiEmail.Text = "E-&mail";
            this.tsmiEmail.ToolTipText = "E-mail";
            // 
            // tsmiXls
            // 
            this.tsmiXls.Name = "tsmiXls";
            this.tsmiXls.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.tsmiXls.Size = new System.Drawing.Size(189, 22);
            this.tsmiXls.Text = "Excel (.xls)";
            this.tsmiXls.ToolTipText = "Excel (.xls)";
            // 
            // tsmiXlsx
            // 
            this.tsmiXlsx.Name = "tsmiXlsx";
            this.tsmiXlsx.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F11)));
            this.tsmiXlsx.Size = new System.Drawing.Size(189, 22);
            this.tsmiXlsx.Text = "Excel (.xlsx)";
            this.tsmiXlsx.ToolTipText = "Excel (.xlsx)";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mspMenu);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Treinamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPesquisarCep;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarCep;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiTxt;
        private System.Windows.Forms.ToolStripMenuItem tsmiXml;
        private System.Windows.Forms.ToolStripMenuItem tsmiJson;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmiXls;
        private System.Windows.Forms.ToolStripMenuItem tsmiXlsx;
    }
}