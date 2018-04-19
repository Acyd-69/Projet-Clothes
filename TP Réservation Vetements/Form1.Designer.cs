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
            this.Aperçu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vêtementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hommeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tShirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vestesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantalonJeansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaussuresBasketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tShirtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vestesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pantalonJeansToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chaussuresBasketsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Taille = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vêtementToolStripMenuItem,
            this.panierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vêtementToolStripMenuItem
            // 
            this.vêtementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hommeToolStripMenuItem,
            this.femmeToolStripMenuItem});
            this.vêtementToolStripMenuItem.Name = "vêtementToolStripMenuItem";
            this.vêtementToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.vêtementToolStripMenuItem.Text = "Passer une commande";
            // 
            // hommeToolStripMenuItem
            // 
            this.hommeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tShirtToolStripMenuItem,
            this.vestesToolStripMenuItem,
            this.pantalonJeansToolStripMenuItem,
            this.chaussuresBasketsToolStripMenuItem});
            this.hommeToolStripMenuItem.Name = "hommeToolStripMenuItem";
            this.hommeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hommeToolStripMenuItem.Text = "Homme";
            // 
            // tShirtToolStripMenuItem
            // 
            this.tShirtToolStripMenuItem.Name = "tShirtToolStripMenuItem";
            this.tShirtToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tShirtToolStripMenuItem.Text = "T-Shirt";
            this.tShirtToolStripMenuItem.Click += new System.EventHandler(this.tShirtToolStripMenuItem_Click);
            // 
            // vestesToolStripMenuItem
            // 
            this.vestesToolStripMenuItem.Name = "vestesToolStripMenuItem";
            this.vestesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.vestesToolStripMenuItem.Text = "Vestes";
            this.vestesToolStripMenuItem.Click += new System.EventHandler(this.vestesToolStripMenuItem_Click);
            // 
            // pantalonJeansToolStripMenuItem
            // 
            this.pantalonJeansToolStripMenuItem.Name = "pantalonJeansToolStripMenuItem";
            this.pantalonJeansToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.pantalonJeansToolStripMenuItem.Text = "Pantalon / Jeans";
            this.pantalonJeansToolStripMenuItem.Click += new System.EventHandler(this.pantalonJeansToolStripMenuItem_Click);
            // 
            // chaussuresBasketsToolStripMenuItem
            // 
            this.chaussuresBasketsToolStripMenuItem.Name = "chaussuresBasketsToolStripMenuItem";
            this.chaussuresBasketsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.chaussuresBasketsToolStripMenuItem.Text = "Chaussures / Baskets";
            this.chaussuresBasketsToolStripMenuItem.Click += new System.EventHandler(this.chaussuresBasketsToolStripMenuItem_Click);
            // 
            // femmeToolStripMenuItem
            // 
            this.femmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tShirtToolStripMenuItem1,
            this.vestesToolStripMenuItem1,
            this.pantalonJeansToolStripMenuItem1,
            this.chaussuresBasketsToolStripMenuItem1});
            this.femmeToolStripMenuItem.Name = "femmeToolStripMenuItem";
            this.femmeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.femmeToolStripMenuItem.Text = "Femme";
            // 
            // tShirtToolStripMenuItem1
            // 
            this.tShirtToolStripMenuItem1.Name = "tShirtToolStripMenuItem1";
            this.tShirtToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.tShirtToolStripMenuItem1.Text = "T-Shirt";
            this.tShirtToolStripMenuItem1.Click += new System.EventHandler(this.tShirtToolStripMenuItem1_Click);
            // 
            // vestesToolStripMenuItem1
            // 
            this.vestesToolStripMenuItem1.Name = "vestesToolStripMenuItem1";
            this.vestesToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.vestesToolStripMenuItem1.Text = "Vestes";
            this.vestesToolStripMenuItem1.Click += new System.EventHandler(this.vestesToolStripMenuItem1_Click);
            // 
            // pantalonJeansToolStripMenuItem1
            // 
            this.pantalonJeansToolStripMenuItem1.Name = "pantalonJeansToolStripMenuItem1";
            this.pantalonJeansToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.pantalonJeansToolStripMenuItem1.Text = "Pantalon / Jeans";
            this.pantalonJeansToolStripMenuItem1.Click += new System.EventHandler(this.pantalonJeansToolStripMenuItem1_Click);
            // 
            // chaussuresBasketsToolStripMenuItem1
            // 
            this.chaussuresBasketsToolStripMenuItem1.Name = "chaussuresBasketsToolStripMenuItem1";
            this.chaussuresBasketsToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.chaussuresBasketsToolStripMenuItem1.Text = "Chaussures / Baskets";
            this.chaussuresBasketsToolStripMenuItem1.Click += new System.EventHandler(this.chaussuresBasketsToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(511, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 354);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Taille
            // 
            this.Taille.AutoSize = true;
            this.Taille.Location = new System.Drawing.Point(310, 293);
            this.Taille.Name = "Taille";
            this.Taille.Size = new System.Drawing.Size(41, 13);
            this.Taille.TabIndex = 11;
            this.Taille.Text = "Taille : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.comboBox1.Location = new System.Drawing.Point(346, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(313, 355);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Cocher pour ajouter au panier";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panierToolStripMenuItem
            // 
            this.panierToolStripMenuItem.Name = "panierToolStripMenuItem";
            this.panierToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.panierToolStripMenuItem.Text = "Panier";
            this.panierToolStripMenuItem.Click += new System.EventHandler(this.panierToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 441);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Taille);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Aperçu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Aperçu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vêtementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hommeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tShirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vestesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantalonJeansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaussuresBasketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tShirtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vestesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pantalonJeansToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chaussuresBasketsToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Taille;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem panierToolStripMenuItem;
    }
}

