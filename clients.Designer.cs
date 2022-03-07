
namespace AutofactApp
{
    partial class clients
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectClient = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BackMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.NewMail = new System.Windows.Forms.Label();
            this.NewTel = new System.Windows.Forms.Label();
            this.NewMailText = new System.Windows.Forms.TextBox();
            this.NewTelText = new System.Windows.Forms.TextBox();
            this.NewPrenom = new System.Windows.Forms.Label();
            this.NewNom = new System.Windows.Forms.Label();
            this.NewPrenomText = new System.Windows.Forms.TextBox();
            this.NewNomText = new System.Windows.Forms.TextBox();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.idUser = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectClient)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectClient
            // 
            this.SelectClient.AllowUserToOrderColumns = true;
            this.SelectClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.SelectClient.Location = new System.Drawing.Point(189, 330);
            this.SelectClient.Name = "SelectClient";
            this.SelectClient.ReadOnly = true;
            this.SelectClient.RowTemplate.Height = 25;
            this.SelectClient.Size = new System.Drawing.Size(543, 150);
            this.SelectClient.TabIndex = 1;
            this.SelectClient.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectClient_RowHeaderMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "prenom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "telephone";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "mail";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(381, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste des clients";
            // 
            // BackMenu
            // 
            this.BackMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackMenu.Location = new System.Drawing.Point(12, 12);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(149, 33);
            this.BackMenu.TabIndex = 4;
            this.BackMenu.Text = "Retour au menu principal";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(789, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Clear.Location = new System.Drawing.Point(321, 263);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 33);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Effacer";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // NewMail
            // 
            this.NewMail.AutoSize = true;
            this.NewMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewMail.Location = new System.Drawing.Point(500, 165);
            this.NewMail.Name = "NewMail";
            this.NewMail.Size = new System.Drawing.Size(99, 21);
            this.NewMail.TabIndex = 19;
            this.NewMail.Text = "Adresse mail";
            // 
            // NewTel
            // 
            this.NewTel.AutoSize = true;
            this.NewTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewTel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewTel.Location = new System.Drawing.Point(189, 165);
            this.NewTel.Name = "NewTel";
            this.NewTel.Size = new System.Drawing.Size(80, 21);
            this.NewTel.TabIndex = 18;
            this.NewTel.Text = "Téléphone";
            // 
            // NewMailText
            // 
            this.NewMailText.Location = new System.Drawing.Point(632, 167);
            this.NewMailText.Name = "NewMailText";
            this.NewMailText.Size = new System.Drawing.Size(100, 23);
            this.NewMailText.TabIndex = 13;
            // 
            // NewTelText
            // 
            this.NewTelText.Location = new System.Drawing.Point(321, 163);
            this.NewTelText.Name = "NewTelText";
            this.NewTelText.Size = new System.Drawing.Size(100, 23);
            this.NewTelText.TabIndex = 12;
            // 
            // NewPrenom
            // 
            this.NewPrenom.AutoSize = true;
            this.NewPrenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPrenom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewPrenom.Location = new System.Drawing.Point(534, 98);
            this.NewPrenom.Name = "NewPrenom";
            this.NewPrenom.Size = new System.Drawing.Size(65, 21);
            this.NewPrenom.TabIndex = 15;
            this.NewPrenom.Text = "Prenom";
            // 
            // NewNom
            // 
            this.NewNom.AutoSize = true;
            this.NewNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewNom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewNom.Location = new System.Drawing.Point(224, 94);
            this.NewNom.Name = "NewNom";
            this.NewNom.Size = new System.Drawing.Size(45, 21);
            this.NewNom.TabIndex = 14;
            this.NewNom.Text = "Nom";
            // 
            // NewPrenomText
            // 
            this.NewPrenomText.Location = new System.Drawing.Point(632, 98);
            this.NewPrenomText.Name = "NewPrenomText";
            this.NewPrenomText.Size = new System.Drawing.Size(100, 23);
            this.NewPrenomText.TabIndex = 11;
            // 
            // NewNomText
            // 
            this.NewNomText.Location = new System.Drawing.Point(321, 96);
            this.NewNomText.Name = "NewNomText";
            this.NewNomText.Size = new System.Drawing.Size(100, 23);
            this.NewNomText.TabIndex = 10;
            // 
            // AddConfirm
            // 
            this.AddConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddConfirm.Location = new System.Drawing.Point(500, 263);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(99, 33);
            this.AddConfirm.TabIndex = 16;
            this.AddConfirm.Text = "Confirmer";
            this.AddConfirm.UseVisualStyleBackColor = true;
            // 
            // idUser
            // 
            this.idUser.Enabled = false;
            this.idUser.Location = new System.Drawing.Point(61, 96);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(100, 23);
            this.idUser.TabIndex = 20;
            this.idUser.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(789, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 24);
            this.button3.TabIndex = 21;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 552);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.idUser);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectClient);
            this.Name = "clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SelectClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label NewMail;
        private System.Windows.Forms.Label NewTel;
        private System.Windows.Forms.TextBox NewMailText;
        private System.Windows.Forms.TextBox NewTelText;
        private System.Windows.Forms.Label NewPrenom;
        private System.Windows.Forms.Label NewNom;
        private System.Windows.Forms.TextBox NewPrenomText;
        private System.Windows.Forms.TextBox NewNomText;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.TextBox idUser;
        private System.Windows.Forms.Button button3;
    }
}

