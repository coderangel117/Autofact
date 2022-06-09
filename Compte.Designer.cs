namespace AutofactApp
{
    partial class Compte
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
            this.title = new System.Windows.Forms.Label();
            this.Passtext = new System.Windows.Forms.TextBox();
            this.Logintext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.ConfirmLog = new System.Windows.Forms.Button();
            this.ConfirmPassText = new System.Windows.Forms.TextBox();
            this.ConfirmPass = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(291, 50);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(157, 28);
            this.title.TabIndex = 0;
            this.title.Text = "Créer un compte";
            // 
            // Passtext
            // 
            this.Passtext.Location = new System.Drawing.Point(310, 191);
            this.Passtext.Name = "Passtext";
            this.Passtext.Size = new System.Drawing.Size(188, 23);
            this.Passtext.TabIndex = 7;
            // 
            // Logintext
            // 
            this.Logintext.Location = new System.Drawing.Point(310, 132);
            this.Logintext.Name = "Logintext";
            this.Logintext.Size = new System.Drawing.Size(188, 23);
            this.Logintext.TabIndex = 6;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(182, 193);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 21);
            this.password.TabIndex = 0;
            this.password.Text = "Mot de passe";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(204, 132);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(80, 21);
            this.login.TabIndex = 0;
            this.login.Text = "Identifiant";
            this.login.UseMnemonic = false;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(228, 337);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(98, 37);
            this.clear.TabIndex = 10;
            this.clear.Text = "Effacer";
            this.clear.UseMnemonic = false;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // ConfirmLog
            // 
            this.ConfirmLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmLog.Location = new System.Drawing.Point(400, 337);
            this.ConfirmLog.Name = "ConfirmLog";
            this.ConfirmLog.Size = new System.Drawing.Size(98, 37);
            this.ConfirmLog.TabIndex = 9;
            this.ConfirmLog.Text = "Confirmer";
            this.ConfirmLog.UseMnemonic = false;
            this.ConfirmLog.UseVisualStyleBackColor = true;
            this.ConfirmLog.Click += new System.EventHandler(this.ConfirmLog_Click);
            // 
            // ConfirmPassText
            // 
            this.ConfirmPassText.Location = new System.Drawing.Point(310, 249);
            this.ConfirmPassText.Name = "ConfirmPassText";
            this.ConfirmPassText.Size = new System.Drawing.Size(188, 23);
            this.ConfirmPassText.TabIndex = 8;
            this.ConfirmPassText.TextChanged += new System.EventHandler(this.ConfirmPassText_TextChanged);
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.AutoSize = true;
            this.ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPass.Location = new System.Drawing.Point(87, 251);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(197, 21);
            this.ConfirmPass.TabIndex = 0;
            this.ConfirmPass.Text = "Confirmer le mot de passe ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(474, 295);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Afficher les caractères";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 416);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ConfirmPassText);
            this.Controls.Add(this.ConfirmPass);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.ConfirmLog);
            this.Controls.Add(this.Passtext);
            this.Controls.Add(this.Logintext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.title);
            this.Name = "Compte";
            this.Text = "Compte";
            this.Load += new System.EventHandler(this.Compte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox Passtext;
        private System.Windows.Forms.TextBox Logintext;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button ConfirmLog;
        private System.Windows.Forms.TextBox ConfirmPassText;
        private System.Windows.Forms.Label ConfirmPass;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}