namespace AutofactApp
{
    partial class Commandes
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
            this.button1 = new System.Windows.Forms.Button();
            this.selectCmd = new System.Windows.Forms.DataGridView();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paye = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prixht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.selectCmd)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // selectCmd
            // 
            this.selectCmd.AllowUserToOrderColumns = true;
            this.selectCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libelle,
            this.description,
            this.categorie,
            this.datecreation,
            this.paye,
            this.prixht,
            this.quantite,
            this.tva,
            this.prixtotal});
            this.selectCmd.Location = new System.Drawing.Point(37, 153);
            this.selectCmd.Name = "selectCmd";
            this.selectCmd.ReadOnly = true;
            this.selectCmd.RowTemplate.Height = 25;
            this.selectCmd.Size = new System.Drawing.Size(973, 214);
            this.selectCmd.TabIndex = 4;
            // 
            // libelle
            // 
            this.libelle.HeaderText = "libelle";
            this.libelle.Name = "libelle";
            this.libelle.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // categorie
            // 
            this.categorie.HeaderText = "categorie";
            this.categorie.Name = "categorie";
            this.categorie.ReadOnly = true;
            // 
            // datecreation
            // 
            this.datecreation.HeaderText = "date de creation";
            this.datecreation.Name = "datecreation";
            this.datecreation.ReadOnly = true;
            this.datecreation.Width = 125;
            // 
            // paye
            // 
            this.paye.HeaderText = "paye";
            this.paye.Name = "paye";
            this.paye.ReadOnly = true;
            this.paye.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // prixht
            // 
            this.prixht.HeaderText = "prixht";
            this.prixht.Name = "prixht";
            this.prixht.ReadOnly = true;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "quantite";
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            // 
            // tva
            // 
            this.tva.HeaderText = "tva";
            this.tva.Name = "tva";
            this.tva.ReadOnly = true;
            // 
            // prixtotal
            // 
            this.prixtotal.HeaderText = "prixtotal";
            this.prixtotal.Name = "prixtotal";
            this.prixtotal.ReadOnly = true;
            // 
            // Commandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 615);
            this.Controls.Add(this.selectCmd);
            this.Controls.Add(this.button1);
            this.Name = "Commandes";
            this.Text = "Commandes";
            this.Load += new System.EventHandler(this.Commandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectCmd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView selectCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paye;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixht;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn tva;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixtotal;
    }
}