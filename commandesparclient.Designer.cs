namespace AutofactApp
{
    partial class commandesparclient
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
            this.selectCmd = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paye = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prixht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectCmd)).BeginInit();
            this.SuspendLayout();
            // 
            // BackMenu
            // 
            this.BackMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackMenu.Location = new System.Drawing.Point(35, 30);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(136, 34);
            this.BackMenu.TabIndex = 0;
            this.BackMenu.Text = "retour au menu";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click_1);
            // 
            // selectCmd
            // 
            this.selectCmd.AllowUserToOrderColumns = true;
            this.selectCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.libelle,
            this.description,
            this.categorie,
            this.datecreation,
            this.paye,
            this.prixht,
            this.quantite,
            this.tva,
            this.prixtotal});
            this.selectCmd.Location = new System.Drawing.Point(35, 178);
            this.selectCmd.Name = "selectCmd";
            this.selectCmd.ReadOnly = true;
            this.selectCmd.RowTemplate.Height = 25;
            this.selectCmd.Size = new System.Drawing.Size(1049, 214);
            this.selectCmd.TabIndex = 3;
            this.selectCmd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.selectCmd.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selectCmd_RowHeaderMouseClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // name
            // 
            this.name.Location = new System.Drawing.Point(148, 101);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(100, 23);
            this.name.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "libelle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "categorie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "datecreation";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "paye";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(474, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choisissez la commande";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(502, 416);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(242, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Marquer cette commande comme payée";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // commandesparclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.selectCmd);
            this.Controls.Add(this.BackMenu);
            this.Name = "commandesparclient";
            this.Text = "commandesparclient";
            this.Load += new System.EventHandler(this.commandesparclient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectCmd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.DataGridView selectCmd;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paye;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixht;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn tva;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixtotal;
        private System.Windows.Forms.Label label2;
    }
}