
namespace AutofactApp
{
    partial class ChangementMotDePasse
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
            this.AncienMdpBox = new System.Windows.Forms.TextBox();
            this.AncienMdp = new System.Windows.Forms.Label();
            this.NouveauMdp = new System.Windows.Forms.Label();
            this.NouveauMdpBox = new System.Windows.Forms.TextBox();
            this.ConfirmationNouveauMdpBox = new System.Windows.Forms.TextBox();
            this.ConfirmationNouveauMdp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmerChangementMdp = new System.Windows.Forms.Button();
            this.EffacerChamps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AncienMdpBox
            // 
            this.AncienMdpBox.Location = new System.Drawing.Point(429, 139);
            this.AncienMdpBox.Margin = new System.Windows.Forms.Padding(4);
            this.AncienMdpBox.Name = "AncienMdpBox";
            this.AncienMdpBox.Size = new System.Drawing.Size(127, 29);
            this.AncienMdpBox.TabIndex = 0;
            // 
            // AncienMdp
            // 
            this.AncienMdp.AutoSize = true;
            this.AncienMdp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AncienMdp.Location = new System.Drawing.Point(233, 142);
            this.AncienMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AncienMdp.Name = "AncienMdp";
            this.AncienMdp.Size = new System.Drawing.Size(153, 21);
            this.AncienMdp.TabIndex = 1;
            this.AncienMdp.Text = "Ancien mot de passe";
            // 
            // NouveauMdp
            // 
            this.NouveauMdp.AutoSize = true;
            this.NouveauMdp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NouveauMdp.Location = new System.Drawing.Point(233, 228);
            this.NouveauMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NouveauMdp.Name = "NouveauMdp";
            this.NouveauMdp.Size = new System.Drawing.Size(173, 21);
            this.NouveauMdp.TabIndex = 2;
            this.NouveauMdp.Text = "Nouveau mot de passe ";
            // 
            // NouveauMdpBox
            // 
            this.NouveauMdpBox.Location = new System.Drawing.Point(429, 225);
            this.NouveauMdpBox.Margin = new System.Windows.Forms.Padding(4);
            this.NouveauMdpBox.Name = "NouveauMdpBox";
            this.NouveauMdpBox.Size = new System.Drawing.Size(127, 29);
            this.NouveauMdpBox.TabIndex = 3;
            // 
            // ConfirmationNouveauMdpBox
            // 
            this.ConfirmationNouveauMdpBox.Location = new System.Drawing.Point(429, 311);
            this.ConfirmationNouveauMdpBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmationNouveauMdpBox.Name = "ConfirmationNouveauMdpBox";
            this.ConfirmationNouveauMdpBox.Size = new System.Drawing.Size(127, 29);
            this.ConfirmationNouveauMdpBox.TabIndex = 5;
            // 
            // ConfirmationNouveauMdp
            // 
            this.ConfirmationNouveauMdp.AutoSize = true;
            this.ConfirmationNouveauMdp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationNouveauMdp.Location = new System.Drawing.Point(131, 319);
            this.ConfirmationNouveauMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmationNouveauMdp.Name = "ConfirmationNouveauMdp";
            this.ConfirmationNouveauMdp.Size = new System.Drawing.Size(284, 21);
            this.ConfirmationNouveauMdp.TabIndex = 4;
            this.ConfirmationNouveauMdp.Text = "Confirmation du nouveau mot de passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(334, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Changement de mot de passe";
            // 
            // ConfirmerChangementMdp
            // 
            this.ConfirmerChangementMdp.Location = new System.Drawing.Point(474, 423);
            this.ConfirmerChangementMdp.Name = "ConfirmerChangementMdp";
            this.ConfirmerChangementMdp.Size = new System.Drawing.Size(120, 32);
            this.ConfirmerChangementMdp.TabIndex = 7;
            this.ConfirmerChangementMdp.Text = "Confirmer";
            this.ConfirmerChangementMdp.UseVisualStyleBackColor = true;
            this.ConfirmerChangementMdp.Click += new System.EventHandler(this.ConfirmerChangementMdp_Click);
            // 
            // EffacerChamps
            // 
            this.EffacerChamps.Location = new System.Drawing.Point(314, 423);
            this.EffacerChamps.Name = "EffacerChamps";
            this.EffacerChamps.Size = new System.Drawing.Size(120, 32);
            this.EffacerChamps.TabIndex = 8;
            this.EffacerChamps.Text = "Effacer";
            this.EffacerChamps.UseVisualStyleBackColor = true;
            this.EffacerChamps.Click += new System.EventHandler(this.EffacerChamps_Click);
            // 
            // ChangementMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.EffacerChamps);
            this.Controls.Add(this.ConfirmerChangementMdp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmationNouveauMdpBox);
            this.Controls.Add(this.ConfirmationNouveauMdp);
            this.Controls.Add(this.NouveauMdpBox);
            this.Controls.Add(this.NouveauMdp);
            this.Controls.Add(this.AncienMdp);
            this.Controls.Add(this.AncienMdpBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangementMotDePasse";
            this.Text = "ChangementMotDePasse";
            this.Load += new System.EventHandler(this.ChangementMotDePasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AncienMdpBox;
        private System.Windows.Forms.Label AncienMdp;
        private System.Windows.Forms.Label NouveauMdp;
        private System.Windows.Forms.TextBox NouveauMdpBox;
        private System.Windows.Forms.TextBox ConfirmationNouveauMdpBox;
        private System.Windows.Forms.Label ConfirmationNouveauMdp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfirmerChangementMdp;
        private System.Windows.Forms.Button EffacerChamps;
    }
}