
namespace AutofactApp
{
    partial class AjoutUtilisateur
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
            this.Clear = new System.Windows.Forms.Button();
            this.ConfirmAdd = new System.Windows.Forms.Button();
            this.NewPassText = new System.Windows.Forms.TextBox();
            this.NewLoginText = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.Label();
            this.NewLogin = new System.Windows.Forms.Label();
            this.BackMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(359, 309);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 37);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ConfirmAdd
            // 
            this.ConfirmAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmAdd.Location = new System.Drawing.Point(471, 309);
            this.ConfirmAdd.Name = "ConfirmAdd";
            this.ConfirmAdd.Size = new System.Drawing.Size(76, 37);
            this.ConfirmAdd.TabIndex = 10;
            this.ConfirmAdd.Text = "Confirm";
            this.ConfirmAdd.UseVisualStyleBackColor = true;
            this.ConfirmAdd.Click += new System.EventHandler(this.ConfirmAdd_Click);
            // 
            // NewPassText
            // 
            this.NewPassText.Location = new System.Drawing.Point(359, 251);
            this.NewPassText.Name = "NewPassText";
            this.NewPassText.PasswordChar = '*';
            this.NewPassText.Size = new System.Drawing.Size(188, 23);
            this.NewPassText.TabIndex = 9;
            // 
            // NewLoginText
            // 
            this.NewLoginText.Location = new System.Drawing.Point(359, 165);
            this.NewLoginText.Name = "NewLoginText";
            this.NewLoginText.Size = new System.Drawing.Size(188, 23);
            this.NewLoginText.TabIndex = 8;
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPassword.Location = new System.Drawing.Point(253, 254);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(77, 21);
            this.NewPassword.TabIndex = 6;
            this.NewPassword.Text = "password";
            // 
            // NewLogin
            // 
            this.NewLogin.AutoSize = true;
            this.NewLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewLogin.Location = new System.Drawing.Point(266, 168);
            this.NewLogin.Name = "NewLogin";
            this.NewLogin.Size = new System.Drawing.Size(45, 21);
            this.NewLogin.TabIndex = 7;
            this.NewLogin.Text = "login";
            // 
            // BackMenu
            // 
            this.BackMenu.Location = new System.Drawing.Point(172, 60);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(118, 38);
            this.BackMenu.TabIndex = 12;
            this.BackMenu.Text = "Retour au menu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // AjoutUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ConfirmAdd);
            this.Controls.Add(this.NewPassText);
            this.Controls.Add(this.NewLoginText);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NewLogin);
            this.Name = "AjoutUtilisateur";
            this.Text = "AjoutUtilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ConfirmAdd;
        private System.Windows.Forms.TextBox NewPassText;
        private System.Windows.Forms.TextBox NewLoginText;
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.Label NewLogin;
        private System.Windows.Forms.Button BackMenu;
    }
}