namespace JTL.Tax1040.EfileServices.PingService
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetACKserviceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.ExciseGetAckService = new System.ServiceProcess.ServiceInstaller();
            // 
            // GetACKserviceProcessInstaller
            // 
            this.GetACKserviceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.GetACKserviceProcessInstaller.Password = null;
            this.GetACKserviceProcessInstaller.Username = null;
            // 
            // ExciseGetAckService
            // 
            this.ExciseGetAckService.Description = "ExtensionTax.GetAckService";
            this.ExciseGetAckService.DisplayName = "ExtensionTax.GetAckService";
            this.ExciseGetAckService.ServiceName = "ExtensionTax.GetAckService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.GetACKserviceProcessInstaller,
            this.ExciseGetAckService});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller GetACKserviceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller ExciseGetAckService;
    }
}