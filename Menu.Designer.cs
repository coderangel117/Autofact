
namespace AutofactApp
{
    partial class Menu
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
            this.Clients = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AjoutUtilisateur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clients
            // 
            this.Clients.Location = new System.Drawing.Point(30, 17);
            this.Clients.Margin = new System.Windows.Forms.Padding(2);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(166, 60);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "voir la liste des clients";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logout.Location = new System.Drawing.Point(650, 99);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(94, 33);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(650, 34);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 27);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AjoutUtilisateur
            // 
            this.AjoutUtilisateur.Location = new System.Drawing.Point(193, 17);
            this.AjoutUtilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutUtilisateur.Name = "AjoutUtilisateur";
            this.AjoutUtilisateur.Size = new System.Drawing.Size(193, 60);
            this.AjoutUtilisateur.TabIndex = 5;
            this.AjoutUtilisateur.Text = "Ajouter un utilisateur";
            this.AjoutUtilisateur.UseVisualStyleBackColor = true;
            this.AjoutUtilisateur.Click += new System.EventHandler(this.Ajoututilisateur_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 446);
            this.Controls.Add(this.AjoutUtilisateur);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Clients);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AjoutUtilisateur;
    }
}