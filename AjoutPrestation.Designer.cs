﻿
namespace AutofactApp
{
    partial class AjoutPrestation
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
            this.Confirm = new System.Windows.Forms.Button();
            this.DetailsText = new System.Windows.Forms.RichTextBox();
            this.Price = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.LabelText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.BackMenu = new System.Windows.Forms.Button();
            this.CategoryText = new System.Windows.Forms.ComboBox();
            this.Tva = new System.Windows.Forms.Label();
            this.TvaText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Confirm.Location = new System.Drawing.Point(459, 387);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(95, 36);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "Confirmer";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // DetailsText
            // 
            this.DetailsText.Location = new System.Drawing.Point(366, 167);
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.Size = new System.Drawing.Size(156, 67);
            this.DetailsText.TabIndex = 3;
            this.DetailsText.Text = "";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(270, 271);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(36, 21);
            this.Price.TabIndex = 0;
            this.Price.Text = "Prix";
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Details.Location = new System.Drawing.Point(236, 173);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(89, 21);
            this.Details.TabIndex = 0;
            this.Details.Text = "Description";
            this.Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(270, 117);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(55, 21);
            this.Label.TabIndex = 0;
            this.Label.Text = "Libelle";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Category.Location = new System.Drawing.Point(248, 69);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(77, 21);
            this.Category.TabIndex = 0;
            this.Category.Text = "Categorie";
            this.Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelText
            // 
            this.LabelText.Location = new System.Drawing.Point(366, 117);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(156, 23);
            this.LabelText.TabIndex = 2;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(366, 271);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(156, 23);
            this.PriceText.TabIndex = 4;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(321, 387);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(95, 36);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Effacer";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // BackMenu
            // 
            this.BackMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackMenu.Location = new System.Drawing.Point(12, 12);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(124, 58);
            this.BackMenu.TabIndex = 7;
            this.BackMenu.Text = "Retour au menu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // CategoryText
            // 
            this.CategoryText.FormattingEnabled = true;
            this.CategoryText.Location = new System.Drawing.Point(366, 66);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(156, 23);
            this.CategoryText.TabIndex = 1;
            // 
            // Tva
            // 
            this.Tva.AutoSize = true;
            this.Tva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tva.Location = new System.Drawing.Point(270, 328);
            this.Tva.Name = "Tva";
            this.Tva.Size = new System.Drawing.Size(33, 21);
            this.Tva.TabIndex = 8;
            this.Tva.Text = "Tva";
            // 
            // TvaText
            // 
            this.TvaText.Location = new System.Drawing.Point(366, 328);
            this.TvaText.Name = "TvaText";
            this.TvaText.Size = new System.Drawing.Size(156, 23);
            this.TvaText.TabIndex = 9;
            // 
            // AjoutPrestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 491);
            this.Controls.Add(this.Tva);
            this.Controls.Add(this.TvaText);
            this.Controls.Add(this.CategoryText);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.DetailsText);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.Clear);
            this.Name = "AjoutPrestation";
            this.Text = "AjouterPrestation";
            this.Load += new System.EventHandler(this.AjoutPrestations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.RichTextBox DetailsText;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.TextBox LabelText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.ComboBox CategoryText;
        private System.Windows.Forms.Label Tva;
        private System.Windows.Forms.TextBox TvaText;
    }
}