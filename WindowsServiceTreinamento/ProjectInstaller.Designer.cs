namespace WindowsServiceTreinamento
{
    partial class ProjectInstaller
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

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerTreinamento = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerTreinamento = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerTreinamento
            // 
            this.serviceProcessInstallerTreinamento.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallerTreinamento.Password = null;
            this.serviceProcessInstallerTreinamento.Username = null;
            // 
            // serviceInstallerTreinamento
            // 
            this.serviceInstallerTreinamento.Description = "Serviço Windows Treinamento Descrição";
            this.serviceInstallerTreinamento.DisplayName = "Serviço Windows Treinamento";
            this.serviceInstallerTreinamento.ServiceName = "WindowsServiceTreinamento";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerTreinamento,
            this.serviceInstallerTreinamento});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerTreinamento;
        private System.ServiceProcess.ServiceInstaller serviceInstallerTreinamento;
    }
}