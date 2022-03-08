
namespace AutofactApp
{
    partial class ChangeFormMdp
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
            this.OldMdpBox = new System.Windows.Forms.TextBox();
            this.OldMdp = new System.Windows.Forms.Label();
            this.NewMdp = new System.Windows.Forms.Label();
            this.NewMdpBox = new System.Windows.Forms.TextBox();
            this.ConfirmNewMdpBox = new System.Windows.Forms.TextBox();
            this.ConfirmNewMdp = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ConfirmChangeMdp = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldMdpBox
            // 
            this.OldMdpBox.Location = new System.Drawing.Point(429, 139);
            this.OldMdpBox.Margin = new System.Windows.Forms.Padding(4);
            this.OldMdpBox.Name = "OldMdpBox";
            this.OldMdpBox.Size = new System.Drawing.Size(127, 29);
            this.OldMdpBox.TabIndex = 0;
            // 
            // OldMdp
            // 
            this.OldMdp.AutoSize = true;
            this.OldMdp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OldMdp.Location = new System.Drawing.Point(233, 142);
            this.OldMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OldMdp.Name = "OldMdp";
            this.OldMdp.Size = new System.Drawing.Size(153, 21);
            this.OldMdp.TabIndex = 1;
            this.OldMdp.Text = "Ancien mot de passe";
            // 
            // NewMdp
            // 
            this.NewMdp.AutoSize = true;
            this.NewMdp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewMdp.Location = new System.Drawing.Point(233, 228);
            this.NewMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewMdp.Name = "NewMdp";
            this.NewMdp.Size = new System.Drawing.Size(173, 21);
            this.NewMdp.TabIndex = 2;
            this.NewMdp.Text = "Nouveau mot de passe ";
            // 
            // NewMdpBox
            // 
            this.NewMdpBox.Location = new System.Drawing.Point(429, 225);
            this.NewMdpBox.Margin = new System.Windows.Forms.Padding(4);
            this.NewMdpBox.Name = "NewMdpBox";
            this.NewMdpBox.Size = new System.Drawing.Size(127, 29);
            this.NewMdpBox.TabIndex = 3;
            // 
            // ConfirmNewMdpBox
            // 
            this.ConfirmNewMdpBox.Location = new System.Drawing.Point(429, 311);
            this.ConfirmNewMdpBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmNewMdpBox.Name = "ConfirmNewMdpBox";
            this.ConfirmNewMdpBox.Size = new System.Drawing.Size(127, 29);
            this.ConfirmNewMdpBox.TabIndex = 5;
            // 
            // ConfirmNewMdp
            // 
            this.ConfirmNewMdp.AutoSize = true;
            this.ConfirmNewMdp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmNewMdp.Location = new System.Drawing.Point(131, 319);
            this.ConfirmNewMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmNewMdp.Name = "ConfirmNewMdp";
            this.ConfirmNewMdp.Size = new System.Drawing.Size(284, 21);
            this.ConfirmNewMdp.TabIndex = 4;
            this.ConfirmNewMdp.Text = "Confirmation du nouveau mot de passe";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(334, 45);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(271, 28);
            this.Title.TabIndex = 6;
            this.Title.Text = "Changement de mot de passe";
            // 
            // ConfirmChangeMdp
            // 
            this.ConfirmChangeMdp.Location = new System.Drawing.Point(474, 423);
            this.ConfirmChangeMdp.Name = "ConfirmChangeMdp";
            this.ConfirmChangeMdp.Size = new System.Drawing.Size(120, 32);
            this.ConfirmChangeMdp.TabIndex = 7;
            this.ConfirmChangeMdp.Text = "Confirmer";
            this.ConfirmChangeMdp.UseVisualStyleBackColor = true;
            this.ConfirmChangeMdp.Click += new System.EventHandler(this.ConfirmerChangementMdp_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(314, 423);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(120, 32);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Effacer";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.EffacerChamps_Click);
            // 
            // ChangeFormMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ConfirmChangeMdp);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ConfirmNewMdpBox);
            this.Controls.Add(this.ConfirmNewMdp);
            this.Controls.Add(this.NewMdpBox);
            this.Controls.Add(this.NewMdp);
            this.Controls.Add(this.OldMdp);
            this.Controls.Add(this.OldMdpBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeFormMdp";
            this.Text = "Page de changement de mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldMdpBox;
        private System.Windows.Forms.Label OldMdp;
        private System.Windows.Forms.Label NewMdp;
        private System.Windows.Forms.TextBox NewMdpBox;
        private System.Windows.Forms.TextBox ConfirmNewMdpBox;
        private System.Windows.Forms.Label ConfirmNewMdp;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ConfirmChangeMdp;
        private System.Windows.Forms.Button Clear;
    }
}