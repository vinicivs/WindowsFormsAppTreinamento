namespace WindowsFormsAppTreinamento
{
    partial class FrmXlsx
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
            this.components = new System.ComponentModel.Container();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLer = new System.Windows.Forms.Button();
            this.BtnCriar = new System.Windows.Forms.Button();
            this.ttpXlsx = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(166, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sai&r";
            this.ttpXlsx.SetToolTip(this.BtnSair, "Sair");
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLer
            // 
            this.BtnLer.Location = new System.Drawing.Point(85, 12);
            this.BtnLer.Name = "BtnLer";
            this.BtnLer.Size = new System.Drawing.Size(75, 23);
            this.BtnLer.TabIndex = 4;
            this.BtnLer.Text = "&Ler";
            this.ttpXlsx.SetToolTip(this.BtnLer, "Ler");
            this.BtnLer.UseVisualStyleBackColor = true;
            // 
            // BtnCriar
            // 
            this.BtnCriar.Location = new System.Drawing.Point(4, 12);
            this.BtnCriar.Name = "BtnCriar";
            this.BtnCriar.Size = new System.Drawing.Size(75, 23);
            this.BtnCriar.TabIndex = 3;
            this.BtnCriar.Text = "&Criar";
            this.ttpXlsx.SetToolTip(this.BtnCriar, "Criar");
            this.BtnCriar.UseVisualStyleBackColor = true;
            // 
            // FrmXlsx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 40);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLer);
            this.Controls.Add(this.BtnCriar);
            this.MaximizeBox = false;
            this.Name = "FrmXlsx";
            this.Text = "XLSX Excel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLer;
        private System.Windows.Forms.Button BtnCriar;
        private System.Windows.Forms.ToolTip ttpXlsx;
    }
}