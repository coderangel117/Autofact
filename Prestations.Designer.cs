
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
            this.AddService = new System.Windows.Forms.Button();
            this.UpdateService = new System.Windows.Forms.Button();
            this.DeleteService = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.CategoryText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.LabelText = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.DetailsText = new System.Windows.Forms.RichTextBox();
            this.IdPrestationText = new System.Windows.Forms.TextBox();
            this.IdPrestation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixHt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SelectServices)).BeginInit();
            this.SuspendLayout();
            // 
            // BackMenu
            // 
            this.BackMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackMenu.Location = new System.Drawing.Point(25, 39);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(124, 58);
            this.BackMenu.TabIndex = 8;
            this.BackMenu.Text = "Retour au menu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // SelectServices
            // 
            this.SelectServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPrestation,
            this.Categorie,
            this.Libelle,
            this.Description,
            this.PrixHt});
            this.SelectServices.Location = new System.Drawing.Point(156, 535);
            this.SelectServices.Name = "SelectServices";
            this.SelectServices.RowTemplate.Height = 25;
            this.SelectServices.Size = new System.Drawing.Size(444, 150);
            this.SelectServices.TabIndex = 0;
            this.SelectServices.TabStop = false;
            this.SelectServices.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectServices_RowHeaderMouseClick);
            // 
            // AddService
            // 
            this.AddService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddService.Location = new System.Drawing.Point(786, 64);
            this.AddService.Name = "AddService";
            this.AddService.Size = new System.Drawing.Size(184, 54);
            this.AddService.TabIndex = 5;
            this.AddService.Text = "Ajouter une prestation";
            this.AddService.UseVisualStyleBackColor = true;
            this.AddService.Click += new System.EventHandler(this.AddService_Click);
            // 
            // UpdateService
            // 
            this.UpdateService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateService.Location = new System.Drawing.Point(786, 124);
            this.UpdateService.Name = "UpdateService";
            this.UpdateService.Size = new System.Drawing.Size(184, 63);
            this.UpdateService.TabIndex = 6;
            this.UpdateService.Text = "Modifier la prestation";
            this.UpdateService.UseVisualStyleBackColor = true;
            this.UpdateService.Click += new System.EventHandler(this.UpdateService_Click);
            // 
            // DeleteService
            // 
            this.DeleteService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteService.Location = new System.Drawing.Point(786, 193);
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Size = new System.Drawing.Size(184, 63);
            this.DeleteService.TabIndex = 7;
            this.DeleteService.Text = "Supprimer la prestation";
            this.DeleteService.UseVisualStyleBackColor = true;
            this.DeleteService.Click += new System.EventHandler(this.DeleteService_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(367, 421);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(95, 36);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Effacer";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // CategoryText
            // 
            this.CategoryText.Location = new System.Drawing.Point(401, 140);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(156, 23);
            this.CategoryText.TabIndex = 1;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(401, 344);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(156, 23);
            this.PriceText.TabIndex = 4;
            // 
            // LabelText
            // 
            this.LabelText.Location = new System.Drawing.Point(401, 190);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(156, 23);
            this.LabelText.TabIndex = 2;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Category.Location = new System.Drawing.Point(283, 142);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(77, 21);
            this.Category.TabIndex = 0;
            this.Category.Text = "Categorie";
            this.Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(305, 190);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(55, 21);
            this.Label.TabIndex = 0;
            this.Label.Text = "Libelle";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Details.Location = new System.Drawing.Point(271, 246);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(89, 21);
            this.Details.TabIndex = 0;
            this.Details.Text = "Description";
            this.Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(305, 344);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(36, 21);
            this.Price.TabIndex = 0;
            this.Price.Text = "Prix";
            // 
            // DetailsText
            // 
            this.DetailsText.Location = new System.Drawing.Point(401, 240);
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.Size = new System.Drawing.Size(156, 67);
            this.DetailsText.TabIndex = 0;
            this.DetailsText.TabStop = false;
            this.DetailsText.Text = "";
            // 
            // IdPrestationText
            // 
            this.IdPrestationText.Enabled = false;
            this.IdPrestationText.Location = new System.Drawing.Point(401, 95);
            this.IdPrestationText.Name = "IdPrestationText";
            this.IdPrestationText.ReadOnly = true;
            this.IdPrestationText.Size = new System.Drawing.Size(156, 23);
            this.IdPrestationText.TabIndex = 0;
            this.IdPrestationText.TabStop = false;
            this.IdPrestationText.Visible = false;
            // 
            // IdPrestation
            // 
            this.IdPrestation.HeaderText = "IdPrestation";
            this.IdPrestation.Name = "IdPrestation";
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.Name = "Categorie";
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // PrixHt
            // 
            this.PrixHt.HeaderText = "Prix";
            this.PrixHt.Name = "PrixHt";
            // 
            // Prestations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 722);
            this.Controls.Add(this.IdPrestationText);
            this.Controls.Add(this.DetailsText);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DeleteService);
            this.Controls.Add(this.UpdateService);
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
        private System.Windows.Forms.Button UpdateService;
        private System.Windows.Forms.Button DeleteService;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox CategoryText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox LabelText;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.RichTextBox DetailsText;
        private System.Windows.Forms.TextBox IdPrestationText;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrestation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixHt;
    }
}