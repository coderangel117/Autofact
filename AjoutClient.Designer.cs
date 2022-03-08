
namespace AutofactApp
{
    partial class AjoutClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutClient));
            this.BackMenu = new System.Windows.Forms.Button();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.NewLastnameText = new System.Windows.Forms.TextBox();
            this.NewFirstnameText = new System.Windows.Forms.TextBox();
            this.NewLastname = new System.Windows.Forms.Label();
            this.NewFirstname = new System.Windows.Forms.Label();
            this.NewMail = new System.Windows.Forms.Label();
            this.NewTel = new System.Windows.Forms.Label();
            this.NewMailText = new System.Windows.Forms.TextBox();
            this.NewTelText = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackMenu
            // 
            resources.ApplyResources(this.BackMenu, "BackMenu");
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // AddConfirm
            // 
            resources.ApplyResources(this.AddConfirm, "AddConfirm");
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // NewLastnameText
            // 
            resources.ApplyResources(this.NewLastnameText, "NewLastnameText");
            this.NewLastnameText.Name = "NewLastnameText";
            // 
            // NewFirstnameText
            // 
            resources.ApplyResources(this.NewFirstnameText, "NewFirstnameText");
            this.NewFirstnameText.Name = "NewFirstnameText";
            // 
            // NewLastname
            // 
            resources.ApplyResources(this.NewLastname, "NewLastname");
            this.NewLastname.Name = "NewLastname";
            // 
            // NewFirstname
            // 
            resources.ApplyResources(this.NewFirstname, "NewFirstname");
            this.NewFirstname.Name = "NewFirstname";
            // 
            // NewMail
            // 
            resources.ApplyResources(this.NewMail, "NewMail");
            this.NewMail.Name = "NewMail";
            // 
            // NewTel
            // 
            resources.ApplyResources(this.NewTel, "NewTel");
            this.NewTel.Name = "NewTel";
            // 
            // NewMailText
            // 
            resources.ApplyResources(this.NewMailText, "NewMailText");
            this.NewMailText.Name = "NewMailText";
            // 
            // NewTelText
            // 
            resources.ApplyResources(this.NewTelText, "NewTelText");
            this.NewTelText.Name = "NewTelText";
            // 
            // Clear
            // 
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.Name = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // AjoutClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.NewMail);
            this.Controls.Add(this.NewTel);
            this.Controls.Add(this.NewMailText);
            this.Controls.Add(this.NewTelText);
            this.Controls.Add(this.NewFirstname);
            this.Controls.Add(this.NewLastname);
            this.Controls.Add(this.NewFirstnameText);
            this.Controls.Add(this.NewLastnameText);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.BackMenu);
            this.Name = "AjoutClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.TextBox NewLastnameText;
        private System.Windows.Forms.TextBox NewFirstnameText;
        private System.Windows.Forms.Label NewLastname;
        private System.Windows.Forms.Label NewFirstname;
        private System.Windows.Forms.Label NewMail;
        private System.Windows.Forms.Label NewTel;
        private System.Windows.Forms.TextBox NewMailText;
        private System.Windows.Forms.TextBox NewTelText;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Title;
    }
}