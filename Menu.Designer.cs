
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
            this.ChangeMdp = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customers
            // 
            this.Customers.Location = new System.Drawing.Point(89, 196);
            this.Customers.Margin = new System.Windows.Forms.Padding(2);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(167, 57);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Les clients";
            this.Customers.UseVisualStyleBackColor = true;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logout.Location = new System.Drawing.Point(12, 21);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(127, 44);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Se déconnecter";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(501, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(127, 44);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Quitter";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChangeMdp
            // 
            this.ChangeMdp.Location = new System.Drawing.Point(89, 307);
            this.ChangeMdp.Name = "ChangeMdp";
            this.ChangeMdp.Size = new System.Drawing.Size(167, 60);
            this.ChangeMdp.TabIndex = 6;
            this.ChangeMdp.Text = "Changement de mot de passe";
            this.ChangeMdp.UseVisualStyleBackColor = true;
            this.ChangeMdp.Click += new System.EventHandler(this.ChangeMdp_Click);
            // 
            // Services
            // 
            this.Services.Location = new System.Drawing.Point(384, 196);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(167, 57);
            this.Services.TabIndex = 7;
            this.Services.Text = "Les prestations";
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(195, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu Principal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 307);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "Les commandes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.ChangeMdp);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Customers);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ChangeMdp;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}