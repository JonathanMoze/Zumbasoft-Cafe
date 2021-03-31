
namespace ZumbaSoft.Fenetres_Produit
{
    partial class RechercheProduit
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
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.labelSelectionnez = new System.Windows.Forms.Label();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.ItemHeight = 20;
            this.listBoxProduits.Location = new System.Drawing.Point(36, 105);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(366, 284);
            this.listBoxProduits.TabIndex = 0;
            // 
            // labelSelectionnez
            // 
            this.labelSelectionnez.AutoSize = true;
            this.labelSelectionnez.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectionnez.Location = new System.Drawing.Point(12, 9);
            this.labelSelectionnez.Name = "labelSelectionnez";
            this.labelSelectionnez.Size = new System.Drawing.Size(256, 31);
            this.labelSelectionnez.TabIndex = 1;
            this.labelSelectionnez.Text = "Selectionnez un produit";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(36, 61);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.PlaceholderText = "Recherche...";
            this.textBoxRecherche.Size = new System.Drawing.Size(366, 27);
            this.textBoxRecherche.TabIndex = 2;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(88, 414);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(94, 29);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(240, 414);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // RechercheProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 468);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.labelSelectionnez);
            this.Controls.Add(this.listBoxProduits);
            this.Name = "RechercheProduit";
            this.Text = "RechercheProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.Label labelSelectionnez;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}