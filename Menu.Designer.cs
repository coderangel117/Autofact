
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
            this.CustomersButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.ChangeMdpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(26, 74);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(166, 60);
            this.CustomersButton.TabIndex = 0;
            this.CustomersButton.Text = "voir la liste des clients";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.Location = new System.Drawing.Point(348, 133);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(132, 38);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Se déconnecter";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(348, 76);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 38);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Quitter";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(26, 161);
            this.UsersButton.Margin = new System.Windows.Forms.Padding(2);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(166, 60);
            this.UsersButton.TabIndex = 5;
            this.UsersButton.Text = "La liste des utilisateurs";
            this.UsersButton.UseVisualStyleBackColor = true;
            // 
            // ChangeMdpButton
            // 
            this.ChangeMdpButton.Location = new System.Drawing.Point(26, 251);
            this.ChangeMdpButton.Name = "ChangeMdpButton";
            this.ChangeMdpButton.Size = new System.Drawing.Size(166, 60);
            this.ChangeMdpButton.TabIndex = 6;
            this.ChangeMdpButton.Text = "Changement de mot de passe";
            this.ChangeMdpButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menu Principal";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeMdpButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.CustomersButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button ChangeMdpButton;
        private System.Windows.Forms.Label label1;
    }
}