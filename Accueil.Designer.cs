
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
            this.label3 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConfirmLog = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(141, 149);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(45, 21);
            this.login.TabIndex = 0;
            this.login.Text = "login";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(128, 235);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(77, 21);
            this.password.TabIndex = 0;
            this.password.Text = "password";
            // 
            // Logintext
            // 
            this.Logintext.Location = new System.Drawing.Point(234, 146);
            this.Logintext.Name = "Logintext";
            this.Logintext.Size = new System.Drawing.Size(188, 23);
            this.Logintext.TabIndex = 1;
            // 
            // Passtext
            // 
            this.Passtext.Location = new System.Drawing.Point(234, 232);
            this.Passtext.Name = "Passtext";
            this.Passtext.PasswordChar = '*';
            this.Passtext.Size = new System.Drawing.Size(188, 23);
            this.Passtext.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(246, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "WELCOME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(530, 22);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 37);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConfirmLog
            // 
            this.ConfirmLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmLog.Location = new System.Drawing.Point(346, 290);
            this.ConfirmLog.Name = "ConfirmLog";
            this.ConfirmLog.Size = new System.Drawing.Size(76, 37);
            this.ConfirmLog.TabIndex = 3;
            this.ConfirmLog.Text = "Confirm";
            this.ConfirmLog.UseVisualStyleBackColor = true;
            this.ConfirmLog.Click += new System.EventHandler(this.ConfirmLog_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(234, 290);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 37);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.ConfirmLog);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passtext);
            this.Controls.Add(this.Logintext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(640, 480);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ConfirmLog;
        private System.Windows.Forms.Button clear;
    }
}