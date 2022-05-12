
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
            this.Customers = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.ChangeMdp = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.AddCmd = new System.Windows.Forms.Button();
            this.ListCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customers
            // 
            this.Customers.Location = new System.Drawing.Point(30, 17);
            this.Customers.Margin = new System.Windows.Forms.Padding(2);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(166, 60);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Gérer les clients";
            this.Customers.UseVisualStyleBackColor = true;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logout.Location = new System.Drawing.Point(740, 181);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(127, 44);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "déconnexion";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(740, 36);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(127, 44);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Quitter";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(212, 17);
            this.Users.Margin = new System.Windows.Forms.Padding(2);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(193, 60);
            this.Users.TabIndex = 5;
            this.Users.Text = "Gérer les utilisateurs";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // ChangeMdp
            // 
            this.ChangeMdp.Location = new System.Drawing.Point(422, 20);
            this.ChangeMdp.Name = "ChangeMdp";
            this.ChangeMdp.Size = new System.Drawing.Size(193, 60);
            this.ChangeMdp.TabIndex = 6;
            this.ChangeMdp.Text = "Changement de mot de passe";
            this.ChangeMdp.UseVisualStyleBackColor = true;
            this.ChangeMdp.Click += new System.EventHandler(this.ChangeMdp_Click);
            // 
            // Services
            // 
            this.Services.Location = new System.Drawing.Point(30, 196);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(166, 57);
            this.Services.TabIndex = 7;
            this.Services.Text = "Gérer les prestations proposées";
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // AddCmd
            // 
            this.AddCmd.Location = new System.Drawing.Point(212, 196);
            this.AddCmd.Name = "AddCmd";
            this.AddCmd.Size = new System.Drawing.Size(193, 57);
            this.AddCmd.TabIndex = 8;
            this.AddCmd.Text = "ajouter une commande";
            this.AddCmd.UseVisualStyleBackColor = true;
            this.AddCmd.Click += new System.EventHandler(this.AddCmd_Click);
            // 
            // ListCmd
            // 
            this.ListCmd.Location = new System.Drawing.Point(422, 196);
            this.ListCmd.Name = "ListCmd";
            this.ListCmd.Size = new System.Drawing.Size(193, 57);
            this.ListCmd.TabIndex = 9;
            this.ListCmd.Text = "liste des commandes";
            this.ListCmd.UseVisualStyleBackColor = true;
            this.ListCmd.Click += new System.EventHandler(this.ListCmd_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 520);
            this.Controls.Add(this.ListCmd);
            this.Controls.Add(this.AddCmd);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.ChangeMdp);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Customers);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button ChangeMdp;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Button AddCmd;
        private System.Windows.Forms.Button ListCmd;
    }
}