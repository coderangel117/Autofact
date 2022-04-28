
namespace AutofactApp
{
    partial class utilisateurs
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
            this.SupprimerUtilisateur = new System.Windows.Forms.Button();
            this.BackMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectUtilisateur = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUtilisateur = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // SupprimerUtilisateur
            // 
            this.SupprimerUtilisateur.Location = new System.Drawing.Point(692, 222);
            this.SupprimerUtilisateur.Name = "SupprimerUtilisateur";
            this.SupprimerUtilisateur.Size = new System.Drawing.Size(126, 23);
            this.SupprimerUtilisateur.TabIndex = 26;
            this.SupprimerUtilisateur.Text = "Supprimer";
            this.SupprimerUtilisateur.UseVisualStyleBackColor = true;
            this.SupprimerUtilisateur.Click += new System.EventHandler(this.SupprimerUtilisateur_Click);
            // 
            // BackMenu
            // 
            this.BackMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackMenu.Location = new System.Drawing.Point(12, 31);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(149, 33);
            this.BackMenu.TabIndex = 24;
            this.BackMenu.Text = "Retour au menu principal";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(381, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Liste des utilisateurs";
            // 
            // SelectUtilisateur
            // 
            this.SelectUtilisateur.AllowUserToAddRows = false;
            this.SelectUtilisateur.AllowUserToDeleteRows = false;
            this.SelectUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.login});
            this.SelectUtilisateur.Location = new System.Drawing.Point(251, 288);
            this.SelectUtilisateur.Name = "SelectUtilisateur";
            this.SelectUtilisateur.ReadOnly = true;
            this.SelectUtilisateur.RowTemplate.Height = 25;
            this.SelectUtilisateur.Size = new System.Drawing.Size(235, 139);
            this.SelectUtilisateur.TabIndex = 22;
            this.SelectUtilisateur.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectUtilisateur_RowHeaderMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // login
            // 
            this.login.HeaderText = "login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // IdUtilisateur
            // 
            this.IdUtilisateur.Enabled = false;
            this.IdUtilisateur.Location = new System.Drawing.Point(287, 118);
            this.IdUtilisateur.Name = "IdUtilisateur";
            this.IdUtilisateur.ReadOnly = true;
            this.IdUtilisateur.Size = new System.Drawing.Size(100, 23);
            this.IdUtilisateur.TabIndex = 40;
            this.IdUtilisateur.Visible = false;
            // 
            // utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 550);
            this.Controls.Add(this.IdUtilisateur);
            this.Controls.Add(this.SupprimerUtilisateur);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectUtilisateur);
            this.Name = "utilisateurs";
            this.Text = "utilisateurs";
            this.Load += new System.EventHandler(this.utilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SupprimerUtilisateur;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SelectUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.TextBox IdUtilisateur;
    }
}