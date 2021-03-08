
namespace ZumbaSoft.Fenetres_Produit
{
    partial class AccueilProduits
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
            this.ListeProduits = new System.Windows.Forms.ListBox();
            this.TitreProduit = new System.Windows.Forms.Label();
            this.ajouterProduit = new System.Windows.Forms.Button();
            this.modifierProduit = new System.Windows.Forms.Button();
            this.supprimerProduit = new System.Windows.Forms.Button();
            this.retourAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListeProduits
            // 
            this.ListeProduits.FormattingEnabled = true;
            this.ListeProduits.ItemHeight = 20;
            this.ListeProduits.Location = new System.Drawing.Point(30, 117);
            this.ListeProduits.Name = "ListeProduits";
            this.ListeProduits.Size = new System.Drawing.Size(295, 244);
            this.ListeProduits.TabIndex = 0;
            // 
            // TitreProduit
            // 
            this.TitreProduit.AutoSize = true;
            this.TitreProduit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitreProduit.Location = new System.Drawing.Point(30, 13);
            this.TitreProduit.Name = "TitreProduit";
            this.TitreProduit.Size = new System.Drawing.Size(287, 38);
            this.TitreProduit.TabIndex = 1;
            this.TitreProduit.Text = "Gestion des Produits";
            // 
            // ajouterProduit
            // 
            this.ajouterProduit.Location = new System.Drawing.Point(489, 117);
            this.ajouterProduit.Name = "ajouterProduit";
            this.ajouterProduit.Size = new System.Drawing.Size(94, 29);
            this.ajouterProduit.TabIndex = 2;
            this.ajouterProduit.Text = "Ajouter";
            this.ajouterProduit.UseVisualStyleBackColor = true;
            // 
            // modifierProduit
            // 
            this.modifierProduit.Location = new System.Drawing.Point(489, 175);
            this.modifierProduit.Name = "modifierProduit";
            this.modifierProduit.Size = new System.Drawing.Size(94, 29);
            this.modifierProduit.TabIndex = 3;
            this.modifierProduit.Text = "Modifier";
            this.modifierProduit.UseVisualStyleBackColor = true;
            // 
            // supprimerProduit
            // 
            this.supprimerProduit.Location = new System.Drawing.Point(489, 232);
            this.supprimerProduit.Name = "supprimerProduit";
            this.supprimerProduit.Size = new System.Drawing.Size(94, 29);
            this.supprimerProduit.TabIndex = 4;
            this.supprimerProduit.Text = "Supprimer";
            this.supprimerProduit.UseVisualStyleBackColor = true;
            // 
            // retourAccueil
            // 
            this.retourAccueil.Location = new System.Drawing.Point(489, 300);
            this.retourAccueil.Name = "retourAccueil";
            this.retourAccueil.Size = new System.Drawing.Size(94, 29);
            this.retourAccueil.TabIndex = 5;
            this.retourAccueil.Text = "Retour";
            this.retourAccueil.UseVisualStyleBackColor = true;
            // 
            // AccueilProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.retourAccueil);
            this.Controls.Add(this.supprimerProduit);
            this.Controls.Add(this.modifierProduit);
            this.Controls.Add(this.ajouterProduit);
            this.Controls.Add(this.TitreProduit);
            this.Controls.Add(this.ListeProduits);
            this.Name = "AccueilProduits";
            this.Text = "AccueilProduits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListeProduits;
        private System.Windows.Forms.Label TitreProduit;
        private System.Windows.Forms.Button ajouterProduit;
        private System.Windows.Forms.Button modifierProduit;
        private System.Windows.Forms.Button supprimerProduit;
        private System.Windows.Forms.Button retourAccueil;
    }
}