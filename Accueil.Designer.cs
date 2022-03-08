
namespace AutofactApp
{
    partial class Accueil
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
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Logintext = new System.Windows.Forms.TextBox();
            this.Passtext = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConfirmLog = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Bienvenue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(141, 149);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(80, 21);
            this.login.TabIndex = 0;
            this.login.Text = "Identifiant";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(127, 235);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 21);
            this.password.TabIndex = 0;
            this.password.Text = "Mot de passe";
            // 
            // Logintext
            // 
            this.Logintext.Location = new System.Drawing.Point(234, 146);
            this.Logintext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logintext.Name = "Logintext";
            this.Logintext.Size = new System.Drawing.Size(187, 23);
            this.Logintext.TabIndex = 1;
            // 
            // Passtext
            // 
            this.Passtext.Location = new System.Drawing.Point(234, 232);
            this.Passtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Passtext.Name = "Passtext";
            this.Passtext.PasswordChar = '*';
            this.Passtext.Size = new System.Drawing.Size(187, 23);
            this.Passtext.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(981, 22);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 38);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConfirmLog
            // 
            this.ConfirmLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmLog.Location = new System.Drawing.Point(359, 304);
            this.ConfirmLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfirmLog.Name = "ConfirmLog";
            this.ConfirmLog.Size = new System.Drawing.Size(93, 38);
            this.ConfirmLog.TabIndex = 3;
            this.ConfirmLog.Text = "Confirmer";
            this.ConfirmLog.UseVisualStyleBackColor = true;
            this.ConfirmLog.Click += new System.EventHandler(this.ConfirmLog_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(217, 304);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(93, 38);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Effacer";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Bienvenue
            // 
            this.Bienvenue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bienvenue.Location = new System.Drawing.Point(256, 50);
            this.Bienvenue.Name = "Bienvenue";
            this.Bienvenue.Size = new System.Drawing.Size(142, 44);
            this.Bienvenue.TabIndex = 0;
            this.Bienvenue.Text = "BIENVENUE";
            this.Bienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(518, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ConfirmLog);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Bienvenue);
            this.Controls.Add(this.Passtext);
            this.Controls.Add(this.Logintext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(44, 51);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox Logintext;
        private System.Windows.Forms.TextBox Passtext;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ConfirmLog;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Bienvenue;
        private System.Windows.Forms.Button button1;
    }
}