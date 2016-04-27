namespace MonPetitEditeur
{
    partial class FrmEditeur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAffiche = new System.Windows.Forms.RichTextBox();
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // rtbAffiche
            // 
            this.rtbAffiche.BackColor = System.Drawing.Color.DimGray;
            this.rtbAffiche.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbAffiche.Location = new System.Drawing.Point(-8, -5);
            this.rtbAffiche.Name = "rtbAffiche";
            this.rtbAffiche.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAffiche.Size = new System.Drawing.Size(800, 600);
            this.rtbAffiche.TabIndex = 0;
            this.rtbAffiche.Text = "";
            this.rtbAffiche.TextChanged += new System.EventHandler(this.rtbAffiche_TextChanged);
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.Color.Maroon;
            this.MnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(782, 24);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            this.MnuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MnuPrincipal_ItemClicked);
            // 
            // FrmEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.rtbAffiche);
            this.Controls.Add(this.MnuPrincipal);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmEditeur";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAffiche;
        private System.Windows.Forms.MenuStrip MnuPrincipal;
    }
}

