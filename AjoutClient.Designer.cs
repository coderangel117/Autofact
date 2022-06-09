
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
            this.NewNomText = new System.Windows.Forms.TextBox();
            this.NewPrenomText = new System.Windows.Forms.TextBox();
            this.NewNom = new System.Windows.Forms.Label();
            this.NewPrenom = new System.Windows.Forms.Label();
            this.NewMail = new System.Windows.Forms.Label();
            this.NewTel = new System.Windows.Forms.Label();
            this.NewMailText = new System.Windows.Forms.TextBox();
            this.NewTelText = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
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
            // NewNomText
            // 
            resources.ApplyResources(this.NewNomText, "NewNomText");
            this.NewNomText.Name = "NewNomText";
            // 
            // NewPrenomText
            // 
            resources.ApplyResources(this.NewPrenomText, "NewPrenomText");
            this.NewPrenomText.Name = "NewPrenomText";
            // 
            // NewNom
            // 
            resources.ApplyResources(this.NewNom, "NewNom");
            this.NewNom.Name = "NewNom";
            // 
            // NewPrenom
            // 
            resources.ApplyResources(this.NewPrenom, "NewPrenom");
            this.NewPrenom.Name = "NewPrenom";
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
            // AjoutClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.NewMail);
            this.Controls.Add(this.NewTel);
            this.Controls.Add(this.NewMailText);
            this.Controls.Add(this.NewTelText);
            this.Controls.Add(this.NewPrenom);
            this.Controls.Add(this.NewNom);
            this.Controls.Add(this.NewPrenomText);
            this.Controls.Add(this.NewNomText);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.BackMenu);
            this.Name = "AjoutClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.TextBox NewNomText;
        private System.Windows.Forms.TextBox NewPrenomText;
        private System.Windows.Forms.Label NewNom;
        private System.Windows.Forms.Label NewPrenom;
        private System.Windows.Forms.Label NewMail;
        private System.Windows.Forms.Label NewTel;
        private System.Windows.Forms.TextBox NewMailText;
        private System.Windows.Forms.TextBox NewTelText;
        private System.Windows.Forms.Button Clear;
    }
}