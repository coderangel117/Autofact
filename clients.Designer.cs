
namespace AutofactApp
{
    partial class Customers
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
            this.CustomersList = new System.Windows.Forms.Label();
            this.BackMenu = new System.Windows.Forms.Button();
            this.UpdateCustomersBtn = new System.Windows.Forms.Button();
            this.DeleteCustomersBtn = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.NewMail = new System.Windows.Forms.Label();
            this.NewTel = new System.Windows.Forms.Label();
            this.NewMailText = new System.Windows.Forms.TextBox();
            this.NewTelText = new System.Windows.Forms.TextBox();
            this.NewFirstname = new System.Windows.Forms.Label();
            this.NewLastname = new System.Windows.Forms.Label();
            this.NewFirstnameText = new System.Windows.Forms.TextBox();
            this.NewLastnameText = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.idUser = new System.Windows.Forms.TextBox();
            this.AddCustomersBtn = new System.Windows.Forms.Button();
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
            // CustomersList
            // 
            this.CustomersList.AutoSize = true;
            this.CustomersList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomersList.Location = new System.Drawing.Point(381, 12);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.Size = new System.Drawing.Size(146, 28);
            this.CustomersList.TabIndex = 3;
            this.CustomersList.Text = "Liste des clients";
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
            // UpdateCustomersBtn
            // 
            this.UpdateCustomersBtn.Location = new System.Drawing.Point(789, 167);
            this.UpdateCustomersBtn.Name = "UpdateCustomersBtn";
            this.UpdateCustomersBtn.Size = new System.Drawing.Size(128, 23);
            this.UpdateCustomersBtn.TabIndex = 6;
            this.UpdateCustomersBtn.Text = "Modifier";
            this.UpdateCustomersBtn.UseVisualStyleBackColor = true;
            this.UpdateCustomersBtn.Click += new System.EventHandler(this.UpdateCustomersBtn_Click);
            // 
            // DeleteCustomersBtn
            // 
            this.DeleteCustomersBtn.Location = new System.Drawing.Point(789, 233);
            this.DeleteCustomersBtn.Name = "DeleteCustomersBtn";
            this.DeleteCustomersBtn.Size = new System.Drawing.Size(126, 23);
            this.DeleteCustomersBtn.TabIndex = 7;
            this.DeleteCustomersBtn.Text = "Supprimer";
            this.DeleteCustomersBtn.UseVisualStyleBackColor = true;
            this.DeleteCustomersBtn.Click += new System.EventHandler(this.DeleteCustomersBtn_Click);
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
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
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
            this.NewMailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewTelText
            // 
            this.NewTelText.Location = new System.Drawing.Point(321, 163);
            this.NewTelText.Name = "NewTelText";
            this.NewTelText.Size = new System.Drawing.Size(100, 23);
            this.NewTelText.TabIndex = 12;
            this.NewTelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewFirstname
            // 
            this.NewFirstname.AutoSize = true;
            this.NewFirstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewFirstname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewFirstname.Location = new System.Drawing.Point(534, 98);
            this.NewFirstname.Name = "NewFirstname";
            this.NewFirstname.Size = new System.Drawing.Size(65, 21);
            this.NewFirstname.TabIndex = 15;
            this.NewFirstname.Text = "Prenom";
            // 
            // NewLastname
            // 
            this.NewLastname.AutoSize = true;
            this.NewLastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewLastname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewLastname.Location = new System.Drawing.Point(224, 94);
            this.NewLastname.Name = "NewLastname";
            this.NewLastname.Size = new System.Drawing.Size(45, 21);
            this.NewLastname.TabIndex = 14;
            this.NewLastname.Text = "Nom";
            // 
            // NewFirstnameText
            // 
            this.NewFirstnameText.Location = new System.Drawing.Point(632, 98);
            this.NewFirstnameText.Name = "NewFirstnameText";
            this.NewFirstnameText.Size = new System.Drawing.Size(100, 23);
            this.NewFirstnameText.TabIndex = 11;
            this.NewFirstnameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewLastnameText
            // 
            this.NewLastnameText.Location = new System.Drawing.Point(321, 96);
            this.NewLastnameText.Name = "NewLastnameText";
            this.NewLastnameText.Size = new System.Drawing.Size(100, 23);
            this.NewLastnameText.TabIndex = 10;
            this.NewLastnameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Confirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Confirm.Location = new System.Drawing.Point(500, 263);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(99, 33);
            this.Confirm.TabIndex = 16;
            this.Confirm.Text = "Confirmer";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // idUser
            // 
            this.idUser.Enabled = false;
            this.idUser.Location = new System.Drawing.Point(61, 96);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(100, 23);
            this.idUser.TabIndex = 20;
            this.idUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idUser.Visible = false;
            // 
            // AddCustomersBtn
            // 
            this.AddCustomersBtn.Location = new System.Drawing.Point(789, 98);
            this.AddCustomersBtn.Name = "AddCustomersBtn";
            this.AddCustomersBtn.Size = new System.Drawing.Size(133, 24);
            this.AddCustomersBtn.TabIndex = 21;
            this.AddCustomersBtn.Text = "Ajouter";
            this.AddCustomersBtn.UseVisualStyleBackColor = true;
            this.AddCustomersBtn.Click += new System.EventHandler(this.AddCustomersBtn_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 552);
            this.Controls.Add(this.AddCustomersBtn);
            this.Controls.Add(this.idUser);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.NewMail);
            this.Controls.Add(this.NewTel);
            this.Controls.Add(this.NewMailText);
            this.Controls.Add(this.NewTelText);
            this.Controls.Add(this.NewFirstname);
            this.Controls.Add(this.NewLastname);
            this.Controls.Add(this.NewFirstnameText);
            this.Controls.Add(this.NewLastnameText);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.DeleteCustomersBtn);
            this.Controls.Add(this.UpdateCustomersBtn);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.CustomersList);
            this.Controls.Add(this.SelectClient);
            this.Name = "Customers";
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
        private System.Windows.Forms.Label CustomersList;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Button UpdateCustomersBtn;
        private System.Windows.Forms.Button DeleteCustomersBtn;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label NewMail;
        private System.Windows.Forms.Label NewTel;
        private System.Windows.Forms.TextBox NewMailText;
        private System.Windows.Forms.TextBox NewTelText;
        private System.Windows.Forms.Label NewFirstname;
        private System.Windows.Forms.Label NewLastname;
        private System.Windows.Forms.TextBox NewFirstnameText;
        private System.Windows.Forms.TextBox NewLastnameText;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox idUser;
        private System.Windows.Forms.Button AddCustomersBtn;
    }
}

