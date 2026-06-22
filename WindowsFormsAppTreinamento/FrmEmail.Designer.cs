namespace WindowsFormsAppTreinamento
{
    partial class FrmEmail
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
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLer = new System.Windows.Forms.Button();
            this.BtnCriar = new System.Windows.Forms.Button();
            this.openFileDialogEmail = new System.Windows.Forms.OpenFileDialog();
            this.lbxAnexo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(174, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sai&r";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLer
            // 
            this.BtnLer.Location = new System.Drawing.Point(93, 12);
            this.BtnLer.Name = "BtnLer";
            this.BtnLer.Size = new System.Drawing.Size(75, 23);
            this.BtnLer.TabIndex = 7;
            this.BtnLer.Text = "&Ler";
            this.BtnLer.UseVisualStyleBackColor = true;
            // 
            // BtnCriar
            // 
            this.BtnCriar.Location = new System.Drawing.Point(12, 12);
            this.BtnCriar.Name = "BtnCriar";
            this.BtnCriar.Size = new System.Drawing.Size(75, 23);
            this.BtnCriar.TabIndex = 6;
            this.BtnCriar.Text = "&Criar";
            this.BtnCriar.UseVisualStyleBackColor = true;
            this.BtnCriar.Click += new System.EventHandler(this.BtnCriar_Click);
            // 
            // openFileDialogEmail
            // 
            this.openFileDialogEmail.FileName = "Anexo";
            // 
            // lbxAnexo
            // 
            this.lbxAnexo.FormattingEnabled = true;
            this.lbxAnexo.Location = new System.Drawing.Point(12, 41);
            this.lbxAnexo.Name = "lbxAnexo";
            this.lbxAnexo.Size = new System.Drawing.Size(237, 30);
            this.lbxAnexo.TabIndex = 9;
            // 
            // FrmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 83);
            this.Controls.Add(this.lbxAnexo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLer);
            this.Controls.Add(this.BtnCriar);
            this.MaximizeBox = false;
            this.Name = "FrmEmail";
            this.Text = "Email";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLer;
        private System.Windows.Forms.Button BtnCriar;
        private System.Windows.Forms.OpenFileDialog openFileDialogEmail;
        private System.Windows.Forms.ListBox lbxAnexo;
    }
}