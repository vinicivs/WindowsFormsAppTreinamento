namespace WindowsFormsAppTreinamento
{
    partial class FrmTxt
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
            this.btnCriarTxt = new System.Windows.Forms.Button();
            this.btnAnexarTxt = new System.Windows.Forms.Button();
            this.btnLerTxt = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarTxt
            // 
            this.btnCriarTxt.Location = new System.Drawing.Point(12, 12);
            this.btnCriarTxt.Name = "btnCriarTxt";
            this.btnCriarTxt.Size = new System.Drawing.Size(75, 23);
            this.btnCriarTxt.TabIndex = 0;
            this.btnCriarTxt.Text = "&Criar";
            this.btnCriarTxt.UseVisualStyleBackColor = true;
            this.btnCriarTxt.Click += new System.EventHandler(this.BtnCriarTxt_Click);
            // 
            // btnAnexarTxt
            // 
            this.btnAnexarTxt.Location = new System.Drawing.Point(93, 12);
            this.btnAnexarTxt.Name = "btnAnexarTxt";
            this.btnAnexarTxt.Size = new System.Drawing.Size(75, 23);
            this.btnAnexarTxt.TabIndex = 1;
            this.btnAnexarTxt.Text = "&Anexar";
            this.btnAnexarTxt.UseVisualStyleBackColor = true;
            this.btnAnexarTxt.Click += new System.EventHandler(this.BtnAnexarTxt_Click);
            // 
            // btnLerTxt
            // 
            this.btnLerTxt.Location = new System.Drawing.Point(174, 12);
            this.btnLerTxt.Name = "btnLerTxt";
            this.btnLerTxt.Size = new System.Drawing.Size(75, 23);
            this.btnLerTxt.TabIndex = 2;
            this.btnLerTxt.Text = "&Ler";
            this.btnLerTxt.UseVisualStyleBackColor = true;
            this.btnLerTxt.Click += new System.EventHandler(this.BtnLerTxt_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(255, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 48);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLerTxt);
            this.Controls.Add(this.btnAnexarTxt);
            this.Controls.Add(this.btnCriarTxt);
            this.MaximizeBox = false;
            this.Name = "FrmTxt";
            this.Text = "Txt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarTxt;
        private System.Windows.Forms.Button btnAnexarTxt;
        private System.Windows.Forms.Button btnLerTxt;
        private System.Windows.Forms.Button btnSair;
    }
}