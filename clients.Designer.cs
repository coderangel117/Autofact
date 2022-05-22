
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
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.Label();
            this.BackMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NewMailText = new System.Windows.Forms.TextBox();
            this.NewTelText = new System.Windows.Forms.TextBox();
            this.NewPrenomText = new System.Windows.Forms.TextBox();
            this.NewNomText = new System.Windows.Forms.TextBox();
            this.idCustomer = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SearchCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectClient)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectClient
            // 
            this.SelectClient.AllowUserToAddRows = false;
            this.SelectClient.AllowUserToDeleteRows = false;
            this.SelectClient.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.LastName,
            this.FirstName,
            this.Telephone,
            this.Mail});
            this.SelectClient.Location = new System.Drawing.Point(30, 264);
            this.SelectClient.MultiSelect = false;
            this.SelectClient.Name = "SelectClient";
            this.SelectClient.ReadOnly = true;
            this.SelectClient.RowTemplate.Height = 25;
            this.SelectClient.Size = new System.Drawing.Size(994, 368);
            this.SelectClient.TabIndex = 1;
            this.SelectClient.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectClient_RowHeaderMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "nom";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "prenom";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 250;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "telephone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            this.Telephone.Width = 200;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 300;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(560, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(146, 28);
            this.Title.TabIndex = 3;
            this.Title.Text = "Liste des clients";
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
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1189, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1189, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewMailText
            // 
            this.NewMailText.Location = new System.Drawing.Point(574, 220);
            this.NewMailText.Name = "NewMailText";
            this.NewMailText.Size = new System.Drawing.Size(100, 23);
            this.NewMailText.TabIndex = 13;
            this.NewMailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewMailText.Visible = false;
            // 
            // NewTelText
            // 
            this.NewTelText.Location = new System.Drawing.Point(257, 220);
            this.NewTelText.Name = "NewTelText";
            this.NewTelText.Size = new System.Drawing.Size(100, 23);
            this.NewTelText.TabIndex = 12;
            this.NewTelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewTelText.Visible = false;
            // 
            // NewPrenomText
            // 
            this.NewPrenomText.Location = new System.Drawing.Point(423, 220);
            this.NewPrenomText.Name = "NewPrenomText";
            this.NewPrenomText.Size = new System.Drawing.Size(100, 23);
            this.NewPrenomText.TabIndex = 11;
            this.NewPrenomText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPrenomText.Visible = false;
            // 
            // NewNomText
            // 
            this.NewNomText.Location = new System.Drawing.Point(97, 220);
            this.NewNomText.Name = "NewNomText";
            this.NewNomText.Size = new System.Drawing.Size(100, 23);
            this.NewNomText.TabIndex = 10;
            this.NewNomText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewNomText.Visible = false;
            // 
            // idCustomer
            // 
            this.idCustomer.Enabled = false;
            this.idCustomer.Location = new System.Drawing.Point(97, 186);
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.Size = new System.Drawing.Size(100, 23);
            this.idCustomer.TabIndex = 20;
            this.idCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idCustomer.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1189, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 33);
            this.button3.TabIndex = 21;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchCustomer
            // 
            this.SearchCustomer.Location = new System.Drawing.Point(226, 140);
            this.SearchCustomer.Name = "SearchCustomer";
            this.SearchCustomer.Size = new System.Drawing.Size(262, 23);
            this.SearchCustomer.TabIndex = 22;
            this.SearchCustomer.TextChanged += new System.EventHandler(this.SearchCustomer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(244, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Rechercher un client par le nom";
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchCustomer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.idCustomer);
            this.Controls.Add(this.NewMailText);
            this.Controls.Add(this.NewTelText);
            this.Controls.Add(this.NewPrenomText);
            this.Controls.Add(this.NewNomText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.Title);
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
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NewMailText;
        private System.Windows.Forms.TextBox NewTelText;
        private System.Windows.Forms.TextBox NewPrenomText;
        private System.Windows.Forms.TextBox NewNomText;
        private System.Windows.Forms.TextBox idCustomer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SearchCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
    }
}

