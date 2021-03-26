
namespace ZumbaSoft.Fenetres_Commande
{
    partial class ChoixProd_BY_Fourni
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.labelErreurBarreQtt = new System.Windows.Forms.Label();
            this.labelErreurListPrd = new System.Windows.Forms.Label();
            this.labelRechercheProd = new System.Windows.Forms.Label();
            this.textBoxRecherchePrd = new System.Windows.Forms.TextBox();
            this.labelProduit = new System.Windows.Forms.Label();
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.barreQuantite = new System.Windows.Forms.NumericUpDown();
            this.labelQuantiteStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(539, 521);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(112, 34);
            this.buttonAnnuler.TabIndex = 57;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(665, 521);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(123, 34);
            this.buttonAjouter.TabIndex = 56;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // labelErreurBarreQtt
            // 
            this.labelErreurBarreQtt.AutoSize = true;
            this.labelErreurBarreQtt.Location = new System.Drawing.Point(539, 329);
            this.labelErreurBarreQtt.Name = "labelErreurBarreQtt";
            this.labelErreurBarreQtt.Size = new System.Drawing.Size(170, 50);
            this.labelErreurBarreQtt.TabIndex = 55;
            this.labelErreurBarreQtt.Text = "Veuillez saisir la \r\nquantité de produit.";
            this.labelErreurBarreQtt.Visible = false;
            // 
            // labelErreurListPrd
            // 
            this.labelErreurListPrd.AutoSize = true;
            this.labelErreurListPrd.Location = new System.Drawing.Point(12, 500);
            this.labelErreurListPrd.Name = "labelErreurListPrd";
            this.labelErreurListPrd.Size = new System.Drawing.Size(219, 25);
            this.labelErreurListPrd.TabIndex = 54;
            this.labelErreurListPrd.Text = "Veuillez choisir un produit.";
            this.labelErreurListPrd.Visible = false;
            // 
            // labelRechercheProd
            // 
            this.labelRechercheProd.AutoSize = true;
            this.labelRechercheProd.Location = new System.Drawing.Point(12, 155);
            this.labelRechercheProd.Name = "labelRechercheProd";
            this.labelRechercheProd.Size = new System.Drawing.Size(100, 25);
            this.labelRechercheProd.TabIndex = 53;
            this.labelRechercheProd.Text = "Recherche :";
            // 
            // textBoxRecherchePrd
            // 
            this.textBoxRecherchePrd.Location = new System.Drawing.Point(131, 152);
            this.textBoxRecherchePrd.Name = "textBoxRecherchePrd";
            this.textBoxRecherchePrd.Size = new System.Drawing.Size(308, 31);
            this.textBoxRecherchePrd.TabIndex = 52;
            this.textBoxRecherchePrd.TextChanged += new System.EventHandler(this.textBoxRecherchePrd_TextChanged);
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.Location = new System.Drawing.Point(12, 110);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(168, 25);
            this.labelProduit.TabIndex = 51;
            this.labelProduit.Text = "Tous les produit de ";
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.ItemHeight = 25;
            this.listBoxProduits.Location = new System.Drawing.Point(12, 189);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(427, 304);
            this.listBoxProduits.TabIndex = 50;
            // 
            // barreQuantite
            // 
            this.barreQuantite.Location = new System.Drawing.Point(565, 294);
            this.barreQuantite.Margin = new System.Windows.Forms.Padding(4);
            this.barreQuantite.Name = "barreQuantite";
            this.barreQuantite.Size = new System.Drawing.Size(125, 31);
            this.barreQuantite.TabIndex = 49;
            this.barreQuantite.ValueChanged += new System.EventHandler(this.barreQuantite_ValueChanged);
            // 
            // labelQuantiteStock
            // 
            this.labelQuantiteStock.AutoSize = true;
            this.labelQuantiteStock.Location = new System.Drawing.Point(565, 252);
            this.labelQuantiteStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantiteStock.Name = "labelQuantiteStock";
            this.labelQuantiteStock.Size = new System.Drawing.Size(94, 25);
            this.labelQuantiteStock.TabIndex = 48;
            this.labelQuantiteStock.Text = "Quantité : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Ajouter";
            // 
            // ChoixProd_BY_Fourni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelErreurBarreQtt);
            this.Controls.Add(this.labelErreurListPrd);
            this.Controls.Add(this.labelRechercheProd);
            this.Controls.Add(this.textBoxRecherchePrd);
            this.Controls.Add(this.labelProduit);
            this.Controls.Add(this.listBoxProduits);
            this.Controls.Add(this.barreQuantite);
            this.Controls.Add(this.labelQuantiteStock);
            this.Controls.Add(this.label1);
            this.Name = "ChoixProd_BY_Fourni";
            this.Text = "ChoixProd_BY_Fourni";
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelErreurBarreQtt;
        private System.Windows.Forms.Label labelErreurListPrd;
        private System.Windows.Forms.Label labelRechercheProd;
        private System.Windows.Forms.TextBox textBoxRecherchePrd;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.NumericUpDown barreQuantite;
        private System.Windows.Forms.Label labelQuantiteStock;
        private System.Windows.Forms.Label label1;
    }
}