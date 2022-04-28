
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
            this.SearchCustomerLabel = new System.Windows.Forms.Label();
            this.SearchCustomerText = new System.Windows.Forms.TextBox();
            this.idCustomer = new System.Windows.Forms.TextBox();
            this.NewMail = new System.Windows.Forms.Label();
            this.NewTel = new System.Windows.Forms.Label();
            this.NewMailText = new System.Windows.Forms.TextBox();
            this.NewTelText = new System.Windows.Forms.TextBox();
            this.NewPrenom = new System.Windows.Forms.Label();
            this.NewNom = new System.Windows.Forms.Label();
            this.NewPrenomText = new System.Windows.Forms.TextBox();
            this.NewNomText = new System.Windows.Forms.TextBox();
            this.AddConfirm = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SearchCustomerGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.SearchCustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchCustomerLabel
            // 
            this.SearchCustomerLabel.AutoSize = true;
            this.SearchCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchCustomerLabel.Location = new System.Drawing.Point(71, 117);
            this.SearchCustomerLabel.Name = "SearchCustomerLabel";
            this.SearchCustomerLabel.Size = new System.Drawing.Size(278, 28);
            this.SearchCustomerLabel.TabIndex = 43;
            this.SearchCustomerLabel.Text = "Recherche de client par le nom";
            // 
            // SearchCustomerText
            // 
            this.SearchCustomerText.Location = new System.Drawing.Point(71, 204);
            this.SearchCustomerText.Name = "SearchCustomerText";
            this.SearchCustomerText.Size = new System.Drawing.Size(262, 23);
            this.SearchCustomerText.TabIndex = 42;
            this.SearchCustomerText.TextChanged += new System.EventHandler(this.SearchCustomerText_TextChanged);
            // 
            // idCustomer
            // 
            this.idCustomer.Enabled = false;
            this.idCustomer.Location = new System.Drawing.Point(442, 179);
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.ReadOnly = true;
            this.idCustomer.Size = new System.Drawing.Size(100, 23);
            this.idCustomer.TabIndex = 40;
            this.idCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idCustomer.Visible = false;
            // 
            // NewMail
            // 
            this.NewMail.AutoSize = true;
            this.NewMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewMail.Location = new System.Drawing.Point(511, 351);
            this.NewMail.Name = "NewMail";
            this.NewMail.Size = new System.Drawing.Size(99, 21);
            this.NewMail.TabIndex = 39;
            this.NewMail.Text = "Adresse mail";
            // 
            // NewTel
            // 
            this.NewTel.AutoSize = true;
            this.NewTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewTel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewTel.Location = new System.Drawing.Point(530, 293);
            this.NewTel.Name = "NewTel";
            this.NewTel.Size = new System.Drawing.Size(80, 21);
            this.NewTel.TabIndex = 38;
            this.NewTel.Text = "Téléphone";
            // 
            // NewMailText
            // 
            this.NewMailText.Enabled = false;
            this.NewMailText.Location = new System.Drawing.Point(643, 349);
            this.NewMailText.Name = "NewMailText";
            this.NewMailText.ReadOnly = true;
            this.NewMailText.Size = new System.Drawing.Size(100, 23);
            this.NewMailText.TabIndex = 33;
            this.NewMailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewTelText
            // 
            this.NewTelText.Enabled = false;
            this.NewTelText.Location = new System.Drawing.Point(643, 290);
            this.NewTelText.Name = "NewTelText";
            this.NewTelText.ReadOnly = true;
            this.NewTelText.Size = new System.Drawing.Size(100, 23);
            this.NewTelText.TabIndex = 32;
            this.NewTelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewPrenom
            // 
            this.NewPrenom.AutoSize = true;
            this.NewPrenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPrenom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewPrenom.Location = new System.Drawing.Point(545, 235);
            this.NewPrenom.Name = "NewPrenom";
            this.NewPrenom.Size = new System.Drawing.Size(65, 21);
            this.NewPrenom.TabIndex = 35;
            this.NewPrenom.Text = "Prenom";
            // 
            // NewNom
            // 
            this.NewNom.AutoSize = true;
            this.NewNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewNom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewNom.Location = new System.Drawing.Point(565, 177);
            this.NewNom.Name = "NewNom";
            this.NewNom.Size = new System.Drawing.Size(45, 21);
            this.NewNom.TabIndex = 34;
            this.NewNom.Text = "Nom";
            // 
            // NewPrenomText
            // 
            this.NewPrenomText.Enabled = false;
            this.NewPrenomText.Location = new System.Drawing.Point(643, 235);
            this.NewPrenomText.Name = "NewPrenomText";
            this.NewPrenomText.ReadOnly = true;
            this.NewPrenomText.Size = new System.Drawing.Size(100, 23);
            this.NewPrenomText.TabIndex = 31;
            this.NewPrenomText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewNomText
            // 
            this.NewNomText.Enabled = false;
            this.NewNomText.Location = new System.Drawing.Point(643, 175);
            this.NewNomText.Name = "NewNomText";
            this.NewNomText.ReadOnly = true;
            this.NewNomText.Size = new System.Drawing.Size(100, 23);
            this.NewNomText.TabIndex = 30;
            this.NewNomText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddConfirm
            // 
            this.AddConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddConfirm.Location = new System.Drawing.Point(1124, 590);
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
            this.Title.Location = new System.Drawing.Point(962, 92);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(349, 28);
            this.Title.TabIndex = 26;
            this.Title.Text = "Affecter une prestation à la commande";
            // 
            // SearchCustomerGrid
            // 
            this.SearchCustomerGrid.AllowUserToAddRows = false;
            this.SearchCustomerGrid.AllowUserToDeleteRows = false;
            this.SearchCustomerGrid.AllowUserToResizeRows = false;
            this.SearchCustomerGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.SearchCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchCustomerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.LastName,
            this.FirstName,
            this.Telephone,
            this.Mail});
            this.SearchCustomerGrid.Location = new System.Drawing.Point(85, 500);
            this.SearchCustomerGrid.Name = "SearchCustomerGrid";
            this.SearchCustomerGrid.ReadOnly = true;
            this.SearchCustomerGrid.RowTemplate.Height = 25;
            this.SearchCustomerGrid.Size = new System.Drawing.Size(693, 282);
            this.SearchCustomerGrid.TabIndex = 25;
            this.SearchCustomerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectClient_CellContentClick);
            this.SearchCustomerGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SearchCustomerGrid_RowHeaderMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 25;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 42;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "nom";
            this.LastName.MinimumWidth = 40;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 163;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "prenom";
            this.FirstName.MinimumWidth = 40;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 162;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "telephone";
            this.Telephone.MinimumWidth = 40;
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            this.Telephone.Width = 163;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "mail";
            this.Mail.MinimumWidth = 50;
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 162;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(584, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Client selectionné";
            // 
            // NewPrice
            // 
            this.NewPrice.AutoSize = true;
            this.NewPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NewPrice.Location = new System.Drawing.Point(956, 428);
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
            this.NewQuantity.Location = new System.Drawing.Point(981, 374);
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
            this.NewDetails.Location = new System.Drawing.Point(962, 312);
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
            this.NewLabel.Location = new System.Drawing.Point(996, 256);
            this.NewLabel.Name = "NewLabel";
            this.NewLabel.Size = new System.Drawing.Size(55, 21);
            this.NewLabel.TabIndex = 45;
            this.NewLabel.Text = "Libelle";
            // 
            // NewPriceText
            // 
            this.NewPriceText.Enabled = false;
            this.NewPriceText.Location = new System.Drawing.Point(1083, 428);
            this.NewPriceText.Name = "NewPriceText";
            this.NewPriceText.ReadOnly = true;
            this.NewPriceText.Size = new System.Drawing.Size(100, 23);
            this.NewPriceText.TabIndex = 52;
            this.NewPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewDetailsText
            // 
            this.NewDetailsText.Enabled = false;
            this.NewDetailsText.Location = new System.Drawing.Point(1083, 314);
            this.NewDetailsText.Name = "NewDetailsText";
            this.NewDetailsText.ReadOnly = true;
            this.NewDetailsText.Size = new System.Drawing.Size(100, 23);
            this.NewDetailsText.TabIndex = 50;
            this.NewDetailsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewLabelText
            // 
            this.NewLabelText.Enabled = false;
            this.NewLabelText.Location = new System.Drawing.Point(1083, 254);
            this.NewLabelText.Name = "NewLabelText";
            this.NewLabelText.ReadOnly = true;
            this.NewLabelText.Size = new System.Drawing.Size(100, 23);
            this.NewLabelText.TabIndex = 49;
            this.NewLabelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectService
            // 
            this.selectService.FormattingEnabled = true;
            this.selectService.Location = new System.Drawing.Point(956, 191);
            this.selectService.Name = "selectService";
            this.selectService.Size = new System.Drawing.Size(223, 23);
            this.selectService.TabIndex = 54;
            // 
            // NewQuantityText
            // 
            this.NewQuantityText.Enabled = false;
            this.NewQuantityText.Location = new System.Drawing.Point(1083, 372);
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
            this.ChoiceService.Location = new System.Drawing.Point(1235, 149);
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
            this.IdService.Location = new System.Drawing.Point(1244, 254);
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
            this.TotalPrice.Location = new System.Drawing.Point(979, 488);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(72, 21);
            this.TotalPrice.TabIndex = 57;
            this.TotalPrice.Text = "Prix Total";
            // 
            // TotalPriceText
            // 
            this.TotalPriceText.Enabled = false;
            this.TotalPriceText.Location = new System.Drawing.Point(1083, 490);
            this.TotalPriceText.Name = "TotalPriceText";
            this.TotalPriceText.ReadOnly = true;
            this.TotalPriceText.Size = new System.Drawing.Size(100, 23);
            this.TotalPriceText.TabIndex = 58;
            // 
            // Radioproduit
            // 
            this.Radioproduit.AutoSize = true;
            this.Radioproduit.Location = new System.Drawing.Point(932, 149);
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
            this.Radioservice.Location = new System.Drawing.Point(1067, 149);
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
            this.BackMenu.Location = new System.Drawing.Point(12, 12);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(147, 38);
            this.BackMenu.TabIndex = 1;
            this.BackMenu.Text = "Retour au menu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // AjoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1484, 861);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchCustomerLabel);
            this.Controls.Add(this.SearchCustomerText);
            this.Controls.Add(this.idCustomer);
            this.Controls.Add(this.NewMail);
            this.Controls.Add(this.NewTel);
            this.Controls.Add(this.NewMailText);
            this.Controls.Add(this.NewTelText);
            this.Controls.Add(this.NewPrenom);
            this.Controls.Add(this.NewNom);
            this.Controls.Add(this.NewPrenomText);
            this.Controls.Add(this.NewNomText);
            this.Controls.Add(this.AddConfirm);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SearchCustomerGrid);
            this.Controls.Add(this.BackMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AjoutCommande";
            this.Text = "AjoutCommande";
            this.Load += new System.EventHandler(this.AjoutCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchCustomerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SearchCustomerLabel;
        private System.Windows.Forms.TextBox SearchCustomerText;
        private System.Windows.Forms.TextBox idCustomer;
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
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView SearchCustomerGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NewPrice;
        private System.Windows.Forms.Label NewQuantity;
        private System.Windows.Forms.Label NewDetails;
        private System.Windows.Forms.Label NewLabel;
        private System.Windows.Forms.TextBox NewPriceText;
        private System.Windows.Forms.TextBox NewDetailsText;
        private System.Windows.Forms.TextBox NewLabelText;
        private System.Windows.Forms.ComboBox selectService;
        private System.Windows.Forms.TextBox NewQuantityText;
        private System.Windows.Forms.Button ChoiceService;
        private System.Windows.Forms.TextBox IdService;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.TextBox TotalPriceText;
        private System.Windows.Forms.RadioButton Radioproduit;
        private System.Windows.Forms.RadioButton Radioservice;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
    }
}