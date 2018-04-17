namespace TP_Réservation_Vetements
{
    partial class Form1
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
            this.Produit = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Taille = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Aperçu = new System.Windows.Forms.Label();
            this.Sexe = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Produit
            // 
            this.Produit.AutoSize = true;
            this.Produit.Location = new System.Drawing.Point(90, 37);
            this.Produit.Name = "Produit";
            this.Produit.Size = new System.Drawing.Size(46, 13);
            this.Produit.TabIndex = 0;
            this.Produit.Text = "Produit :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            
            // 
            // Taille
            // 
            this.Taille.AutoSize = true;
            this.Taille.Location = new System.Drawing.Point(95, 102);
            this.Taille.Name = "Taille";
            this.Taille.Size = new System.Drawing.Size(41, 13);
            this.Taille.TabIndex = 2;
            this.Taille.Text = "Taille : ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(64, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // Aperçu
            // 
            this.Aperçu.AutoSize = true;
            this.Aperçu.Location = new System.Drawing.Point(458, 55);
            this.Aperçu.Name = "Aperçu";
            this.Aperçu.Size = new System.Drawing.Size(47, 13);
            this.Aperçu.TabIndex = 4;
            this.Aperçu.Text = "Aperçu :";
            // 
            // Sexe
            // 
            this.Sexe.AutoSize = true;
            this.Sexe.Location = new System.Drawing.Point(95, 159);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(37, 13);
            this.Sexe.TabIndex = 5;
            this.Sexe.Text = "Sexe :";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(142, 174);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(64, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "Femme";
                
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 447);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.Sexe);
            this.Controls.Add(this.Aperçu);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Taille);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Produit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Produit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Taille;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Aperçu;
        private System.Windows.Forms.Label Sexe;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

