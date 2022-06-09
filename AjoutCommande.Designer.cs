
namespace AutofactApp
{
    partial class AjoutCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutCommande));
            this.idCustomer = new System.Windows.Forms.TextBox();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.NewPrice = new System.Windows.Forms.Label();
            this.NewQuantity = new System.Windows.Forms.Label();
            this.NewDetails = new System.Windows.Forms.Label();
            this.NewLabel = new System.Windows.Forms.Label();
            this.NewPriceText = new System.Windows.Forms.TextBox();
            this.NewDetailsText = new System.Windows.Forms.TextBox();
            this.NewLabelText = new System.Windows.Forms.TextBox();
            this.selectService = new System.Windows.Forms.ComboBox();
            this.NewQuantityText = new System.Windows.Forms.TextBox();
            this.ChoiceService = new System.Windows.Forms.Button();
            this.IdService = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.TotalPriceText = new System.Windows.Forms.TextBox();
            this.Radioproduit = new System.Windows.Forms.RadioButton();
            this.Radioservice = new System.Windows.Forms.RadioButton();
            this.BackMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idCustomer
            // 
            this.idCustomer.Enabled = false;
            this.idCustomer.Location = new System.Drawing.Point(59, 122);
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.ReadOnly = true;
            this.idCustomer.Size = new System.Drawing.Size(100, 23);
            this.idCustomer.TabIndex = 40;
            this.idCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idCustomer.Visible = false;
            // 
            // AddConfirm
            // 
            this.AddConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddConfirm.Location = new System.Drawing.Point(132, 593);
            this.AddConfirm.Name = "AddConfirm";
            this.AddConfirm.Size = new System.Drawing.Size(133, 33);
            this.AddConfirm.TabIndex = 36;
            this.AddConfirm.Text = "Confirmer";
            this.AddConfirm.UseVisualStyleBackColor = true;
            this.AddConfirm.Click += new System.EventHandler(this.AddConfirm_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(132, 71);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(349, 28);
            this.Title.TabIndex = 26;
            this.Title.Text = "Affecter une prestation à la commande";
            // 
            // NewPrice
            // 
            this.NewPrice.AutoSize = true;
            this.NewPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewPrice.Location = new System.Drawing.Point(78, 470);
            this.NewPrice.Name = "NewPrice";
            this.NewPrice.Size = new System.Drawing.Size(95, 21);
            this.NewPrice.TabIndex = 48;
            this.NewPrice.Text = "Prix Unitaire";
            // 
            // NewQuantity
            // 
            this.NewQuantity.AutoSize = true;
            this.NewQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewQuantity.Location = new System.Drawing.Point(103, 416);
            this.NewQuantity.Name = "NewQuantity";
            this.NewQuantity.Size = new System.Drawing.Size(70, 21);
            this.NewQuantity.TabIndex = 47;
            this.NewQuantity.Text = "Quantité";
            // 
            // NewDetails
            // 
            this.NewDetails.AutoSize = true;
            this.NewDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewDetails.Location = new System.Drawing.Point(84, 354);
            this.NewDetails.Name = "NewDetails";
            this.NewDetails.Size = new System.Drawing.Size(89, 21);
            this.NewDetails.TabIndex = 46;
            this.NewDetails.Text = "Description";
            // 
            // NewLabel
            // 
            this.NewLabel.AutoSize = true;
            this.NewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewLabel.Location = new System.Drawing.Point(118, 298);
            this.NewLabel.Name = "NewLabel";
            this.NewLabel.Size = new System.Drawing.Size(55, 21);
            this.NewLabel.TabIndex = 45;
            this.NewLabel.Text = "Libelle";
            // 
            // NewPriceText
            // 
            this.NewPriceText.Enabled = false;
            this.NewPriceText.Location = new System.Drawing.Point(205, 470);
            this.NewPriceText.Name = "NewPriceText";
            this.NewPriceText.ReadOnly = true;
            this.NewPriceText.Size = new System.Drawing.Size(100, 23);
            this.NewPriceText.TabIndex = 52;
            this.NewPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewDetailsText
            // 
            this.NewDetailsText.Enabled = false;
            this.NewDetailsText.Location = new System.Drawing.Point(205, 356);
            this.NewDetailsText.Name = "NewDetailsText";
            this.NewDetailsText.ReadOnly = true;
            this.NewDetailsText.Size = new System.Drawing.Size(100, 23);
            this.NewDetailsText.TabIndex = 50;
            this.NewDetailsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewLabelText
            // 
            this.NewLabelText.Enabled = false;
            this.NewLabelText.Location = new System.Drawing.Point(205, 296);
            this.NewLabelText.Name = "NewLabelText";
            this.NewLabelText.ReadOnly = true;
            this.NewLabelText.Size = new System.Drawing.Size(100, 23);
            this.NewLabelText.TabIndex = 49;
            this.NewLabelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectService
            // 
            this.selectService.FormattingEnabled = true;
            this.selectService.Location = new System.Drawing.Point(89, 215);
            this.selectService.Name = "selectService";
            this.selectService.Size = new System.Drawing.Size(269, 23);
            this.selectService.TabIndex = 54;
            // 
            // NewQuantityText
            // 
            this.NewQuantityText.Enabled = false;
            this.NewQuantityText.Location = new System.Drawing.Point(205, 414);
            this.NewQuantityText.Name = "NewQuantityText";
            this.NewQuantityText.Size = new System.Drawing.Size(100, 23);
            this.NewQuantityText.TabIndex = 55;
            this.NewQuantityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewQuantityText.TextChanged += new System.EventHandler(this.NewQuantityText_TextChanged);
            // 
            // ChoiceService
            // 
            this.ChoiceService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceService.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChoiceService.Location = new System.Drawing.Point(401, 205);
            this.ChoiceService.Name = "ChoiceService";
            this.ChoiceService.Size = new System.Drawing.Size(133, 33);
            this.ChoiceService.TabIndex = 56;
            this.ChoiceService.Text = "Choisir";
            this.ChoiceService.UseVisualStyleBackColor = true;
            this.ChoiceService.Click += new System.EventHandler(this.ChoiceService_Click);
            // 
            // IdService
            // 
            this.IdService.Enabled = false;
            this.IdService.Location = new System.Drawing.Point(366, 296);
            this.IdService.Name = "IdService";
            this.IdService.ReadOnly = true;
            this.IdService.Size = new System.Drawing.Size(100, 23);
            this.IdService.TabIndex = 0;
            this.IdService.TabStop = false;
            this.IdService.Visible = false;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPrice.Location = new System.Drawing.Point(101, 530);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(72, 21);
            this.TotalPrice.TabIndex = 57;
            this.TotalPrice.Text = "Prix Total";
            // 
            // TotalPriceText
            // 
            this.TotalPriceText.Enabled = false;
            this.TotalPriceText.Location = new System.Drawing.Point(205, 532);
            this.TotalPriceText.Name = "TotalPriceText";
            this.TotalPriceText.ReadOnly = true;
            this.TotalPriceText.Size = new System.Drawing.Size(100, 23);
            this.TotalPriceText.TabIndex = 58;
            // 
            // Radioproduit
            // 
            this.Radioproduit.AutoSize = true;
            this.Radioproduit.Location = new System.Drawing.Point(111, 173);
            this.Radioproduit.Name = "Radioproduit";
            this.Radioproduit.Size = new System.Drawing.Size(64, 19);
            this.Radioproduit.TabIndex = 60;
            this.Radioproduit.Text = "produit";
            this.Radioproduit.UseVisualStyleBackColor = true;
            this.Radioproduit.CheckedChanged += new System.EventHandler(this.Radioproduit_CheckedChanged);
            // 
            // Radioservice
            // 
            this.Radioservice.AutoSize = true;
            this.Radioservice.Location = new System.Drawing.Point(246, 173);
            this.Radioservice.Name = "Radioservice";
            this.Radioservice.Size = new System.Drawing.Size(61, 19);
            this.Radioservice.TabIndex = 61;
            this.Radioservice.Text = "service";
            this.Radioservice.UseVisualStyleBackColor = true;
            this.Radioservice.CheckedChanged += new System.EventHandler(this.Radioservice_CheckedChanged);
            // 
            // BackMenu
            // 
            this.BackMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackMenu.Location = new System.Drawing.Point(319, 593);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(147, 38);
            this.BackMenu.TabIndex = 1;
            this.BackMenu.Text = "Annuler";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // AjoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(622, 672);
            this.Controls.Add(this.Radioservice);
            this.Controls.Add(this.Radioproduit);
            this.Controls.Add(this.TotalPriceText);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.IdService);
            this.Controls.Add(this.ChoiceService);
            this.Controls.Add(this.NewQuantityText);
            this.Controls.Add(this.selectService);
            this.Controls.Add(this.NewPriceText);
            this.Controls.Add(this.NewDetailsText);
            this.Controls.Add(this.NewLabelText);
            this.Controls.Add(this.NewPrice);
            this.Controls.Add(this.NewQuantity);
            this.Controls.Add(this.NewDetails);
            this.Controls.Add(this.NewLabel);
            this.Controls.Add(this.idCustomer);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.BackMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AjoutCommande";
            this.Text = "AjoutCommande";
            this.Load += new System.EventHandler(this.AjoutCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idCustomer;
        private System.Windows.Forms.Button AddConfirm;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label NewPrice;
        private System.Windows.Forms.Label NewQuantity;
        private System.Windows.Forms.Label NewDetails;
        private System.Windows.Forms.Label NewLabel;
        public System.Windows.Forms.TextBox NewPriceText;
        private System.Windows.Forms.TextBox NewDetailsText;
        private System.Windows.Forms.TextBox NewLabelText;
        private System.Windows.Forms.ComboBox selectService;
        public System.Windows.Forms.TextBox NewQuantityText;
        private System.Windows.Forms.Button ChoiceService;
        private System.Windows.Forms.TextBox IdService;
        public System.Windows.Forms.Label TotalPrice;
        public System.Windows.Forms.TextBox TotalPriceText;
        private System.Windows.Forms.RadioButton Radioproduit;
        private System.Windows.Forms.RadioButton Radioservice;
        private System.Windows.Forms.Button BackMenu;
    }
}