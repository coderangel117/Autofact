
namespace AutofactApp
{
    partial class Prestations
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
            this.BackMenu = new System.Windows.Forms.Button();
            this.SelectServices = new System.Windows.Forms.DataGridView();
            this.IdPrestation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixHt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddService = new System.Windows.Forms.Button();
            this.DeleteService = new System.Windows.Forms.Button();
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.LabelText = new System.Windows.Forms.TextBox();
            this.DetailsText = new System.Windows.Forms.RichTextBox();
            this.IdPrestationText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchServices = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TvaText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectServices)).BeginInit();
            this.SuspendLayout();
            // 
            // BackMenu
            // 
            this.BackMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackMenu.Location = new System.Drawing.Point(25, 39);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(163, 30);
            this.BackMenu.TabIndex = 8;
            this.BackMenu.Text = "Retour au menu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // SelectServices
            // 
            this.SelectServices.AllowUserToAddRows = false;
            this.SelectServices.AllowUserToDeleteRows = false;
            this.SelectServices.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPrestation,
            this.Categorie,
            this.Libelle,
            this.Description,
            this.PrixHt,
            this.TVA});
            this.SelectServices.Location = new System.Drawing.Point(25, 260);
            this.SelectServices.Name = "SelectServices";
            this.SelectServices.ReadOnly = true;
            this.SelectServices.RowTemplate.Height = 25;
            this.SelectServices.Size = new System.Drawing.Size(995, 351);
            this.SelectServices.TabIndex = 0;
            this.SelectServices.TabStop = false;
            this.SelectServices.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectServices_RowHeaderMouseClick);
            // 
            // IdPrestation
            // 
            this.IdPrestation.HeaderText = "IdPrestation";
            this.IdPrestation.Name = "IdPrestation";
            this.IdPrestation.ReadOnly = true;
            this.IdPrestation.Visible = false;
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.Name = "Categorie";
            this.Categorie.ReadOnly = true;
            this.Categorie.Width = 150;
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            this.Libelle.Width = 200;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // PrixHt
            // 
            this.PrixHt.HeaderText = "Prix";
            this.PrixHt.Name = "PrixHt";
            this.PrixHt.ReadOnly = true;
            this.PrixHt.Width = 150;
            // 
            // TVA
            // 
            this.TVA.HeaderText = "TVA";
            this.TVA.Name = "TVA";
            this.TVA.ReadOnly = true;
            this.TVA.Width = 150;
            // 
            // AddService
            // 
            this.AddService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddService.Location = new System.Drawing.Point(1108, 334);
            this.AddService.Name = "AddService";
            this.AddService.Size = new System.Drawing.Size(143, 33);
            this.AddService.TabIndex = 5;
            this.AddService.Text = "Ajouter";
            this.AddService.UseVisualStyleBackColor = true;
            this.AddService.Click += new System.EventHandler(this.AddService_Click);
            // 
            // DeleteService
            // 
            this.DeleteService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteService.Location = new System.Drawing.Point(1108, 455);
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Size = new System.Drawing.Size(143, 31);
            this.DeleteService.TabIndex = 7;
            this.DeleteService.Text = "Supprimer";
            this.DeleteService.UseVisualStyleBackColor = true;
            this.DeleteService.Click += new System.EventHandler(this.DeleteService_Click);
            // 
            // CategoryText
            // 
            this.CategoryText.Location = new System.Drawing.Point(152, 231);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(95, 23);
            this.CategoryText.TabIndex = 1;
            this.CategoryText.Visible = false;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(742, 221);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(95, 23);
            this.PriceText.TabIndex = 4;
            this.PriceText.Visible = false;
            // 
            // LabelText
            // 
            this.LabelText.Location = new System.Drawing.Point(279, 231);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(95, 23);
            this.LabelText.TabIndex = 2;
            this.LabelText.Visible = false;
            // 
            // DetailsText
            // 
            this.DetailsText.Location = new System.Drawing.Point(437, 210);
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.Size = new System.Drawing.Size(246, 35);
            this.DetailsText.TabIndex = 0;
            this.DetailsText.TabStop = false;
            this.DetailsText.Text = "";
            this.DetailsText.Visible = false;
            // 
            // IdPrestationText
            // 
            this.IdPrestationText.Enabled = false;
            this.IdPrestationText.Location = new System.Drawing.Point(42, 231);
            this.IdPrestationText.Name = "IdPrestationText";
            this.IdPrestationText.ReadOnly = true;
            this.IdPrestationText.Size = new System.Drawing.Size(95, 23);
            this.IdPrestationText.TabIndex = 0;
            this.IdPrestationText.TabStop = false;
            this.IdPrestationText.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1108, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(509, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Liste des prestations";
            // 
            // SearchServices
            // 
            this.SearchServices.Location = new System.Drawing.Point(193, 143);
            this.SearchServices.Name = "SearchServices";
            this.SearchServices.Size = new System.Drawing.Size(227, 23);
            this.SearchServices.TabIndex = 13;
            this.SearchServices.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(206, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Recherche par libelle";
            // 
            // TvaText
            // 
            this.TvaText.Location = new System.Drawing.Point(879, 210);
            this.TvaText.Name = "TvaText";
            this.TvaText.Size = new System.Drawing.Size(170, 23);
            this.TvaText.TabIndex = 46;
            this.TvaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prestations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 685);
            this.Controls.Add(this.TvaText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchServices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdPrestationText);
            this.Controls.Add(this.DetailsText);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.DeleteService);
            this.Controls.Add(this.AddService);
            this.Controls.Add(this.SelectServices);
            this.Controls.Add(this.BackMenu);
            this.Name = "Prestations";
            this.Text = "Prestations";
            this.Load += new System.EventHandler(this.Prestations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.DataGridView SelectServices;
        private System.Windows.Forms.Button AddService;
        private System.Windows.Forms.Button DeleteService;
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox LabelText;
        private System.Windows.Forms.RichTextBox DetailsText;
        private System.Windows.Forms.TextBox IdPrestationText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchServices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrestation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixHt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
        private System.Windows.Forms.TextBox TvaText;
    }
}