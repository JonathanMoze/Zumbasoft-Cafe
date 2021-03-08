
namespace ZumbaSoft.Fenetres_Commande
{
    partial class ChoixProd_Fourni
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
            this.labelErreurBarreQtt = new System.Windows.Forms.Label();
            this.labelErreurListPrd = new System.Windows.Forms.Label();
            this.labelRechercheProd = new System.Windows.Forms.Label();
            this.textBoxRecherchePrd = new System.Windows.Forms.TextBox();
            this.labelProduit = new System.Windows.Forms.Label();
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.barreQuantite = new System.Windows.Forms.NumericUpDown();
            this.labelQuantiteStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAjouterStock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRechercheFourni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxFournisseur = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // labelErreurBarreQtt
            // 
            this.labelErreurBarreQtt.AutoSize = true;
            this.labelErreurBarreQtt.Location = new System.Drawing.Point(4, 277);
            this.labelErreurBarreQtt.Name = "labelErreurBarreQtt";
            this.labelErreurBarreQtt.Size = new System.Drawing.Size(170, 50);
            this.labelErreurBarreQtt.TabIndex = 39;
            this.labelErreurBarreQtt.Text = "Veuillez saisir la \r\nquantité de produit.";
            this.labelErreurBarreQtt.Visible = false;
            // 
            // labelErreurListPrd
            // 
            this.labelErreurListPrd.AutoSize = true;
            this.labelErreurListPrd.Location = new System.Drawing.Point(180, 402);
            this.labelErreurListPrd.Name = "labelErreurListPrd";
            this.labelErreurListPrd.Size = new System.Drawing.Size(219, 25);
            this.labelErreurListPrd.TabIndex = 38;
            this.labelErreurListPrd.Text = "Veuillez choisir un produit.";
            this.labelErreurListPrd.Visible = false;
            // 
            // labelRechercheProd
            // 
            this.labelRechercheProd.AutoSize = true;
            this.labelRechercheProd.Location = new System.Drawing.Point(180, 57);
            this.labelRechercheProd.Name = "labelRechercheProd";
            this.labelRechercheProd.Size = new System.Drawing.Size(100, 25);
            this.labelRechercheProd.TabIndex = 37;
            this.labelRechercheProd.Text = "Recherche :";
            // 
            // textBoxRecherchePrd
            // 
            this.textBoxRecherchePrd.Location = new System.Drawing.Point(299, 54);
            this.textBoxRecherchePrd.Name = "textBoxRecherchePrd";
            this.textBoxRecherchePrd.Size = new System.Drawing.Size(308, 31);
            this.textBoxRecherchePrd.TabIndex = 36;
            this.textBoxRecherchePrd.TextChanged += new System.EventHandler(this.textBoxRecherchePrd_TextChanged);
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.Location = new System.Drawing.Point(180, 12);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(79, 25);
            this.labelProduit.TabIndex = 35;
            this.labelProduit.Text = "Produit :";
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.ItemHeight = 25;
            this.listBoxProduits.Location = new System.Drawing.Point(180, 91);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(427, 304);
            this.listBoxProduits.TabIndex = 34;
            this.listBoxProduits.SelectedIndexChanged += new System.EventHandler(this.listBoxProduits_SelectedIndexChanged);
            // 
            // barreQuantite
            // 
            this.barreQuantite.Location = new System.Drawing.Point(30, 242);
            this.barreQuantite.Margin = new System.Windows.Forms.Padding(4);
            this.barreQuantite.Name = "barreQuantite";
            this.barreQuantite.Size = new System.Drawing.Size(125, 31);
            this.barreQuantite.TabIndex = 33;
            this.barreQuantite.ValueChanged += new System.EventHandler(this.barreQuantite_ValueChanged);
            // 
            // labelQuantiteStock
            // 
            this.labelQuantiteStock.AutoSize = true;
            this.labelQuantiteStock.Location = new System.Drawing.Point(30, 200);
            this.labelQuantiteStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantiteStock.Name = "labelQuantiteStock";
            this.labelQuantiteStock.Size = new System.Drawing.Size(94, 25);
            this.labelQuantiteStock.TabIndex = 32;
            this.labelQuantiteStock.Text = "Quantité : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ajouter";
            // 
            // buttonAjouterStock
            // 
            this.buttonAjouterStock.Location = new System.Drawing.Point(1132, 404);
            this.buttonAjouterStock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouterStock.Name = "buttonAjouterStock";
            this.buttonAjouterStock.Size = new System.Drawing.Size(118, 36);
            this.buttonAjouterStock.TabIndex = 30;
            this.buttonAjouterStock.Text = "Ajouter";
            this.buttonAjouterStock.UseVisualStyleBackColor = true;
            this.buttonAjouterStock.TextChanged += new System.EventHandler(this.buttonAjouterStock_TextChanged);
            this.buttonAjouterStock.Click += new System.EventHandler(this.buttonAjouterStock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Recherche :";
            // 
            // textBoxRechercheFourni
            // 
            this.textBoxRechercheFourni.Enabled = false;
            this.textBoxRechercheFourni.Location = new System.Drawing.Point(943, 54);
            this.textBoxRechercheFourni.Name = "textBoxRechercheFourni";
            this.textBoxRechercheFourni.Size = new System.Drawing.Size(308, 31);
            this.textBoxRechercheFourni.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Fournisseur :";
            // 
            // listBoxFournisseur
            // 
            this.listBoxFournisseur.Enabled = false;
            this.listBoxFournisseur.FormattingEnabled = true;
            this.listBoxFournisseur.ItemHeight = 25;
            this.listBoxFournisseur.Location = new System.Drawing.Point(824, 91);
            this.listBoxFournisseur.Name = "listBoxFournisseur";
            this.listBoxFournisseur.Size = new System.Drawing.Size(427, 304);
            this.listBoxFournisseur.TabIndex = 40;
            this.listBoxFournisseur.SelectedIndexChanged += new System.EventHandler(this.listBoxFournisseur_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(824, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Veuillez choisir un fournisseur.";
            this.label4.Visible = false;
            // 
            // buttonSelectionner
            // 
            this.buttonSelectionner.Enabled = false;
            this.buttonSelectionner.Location = new System.Drawing.Point(484, 404);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(123, 34);
            this.buttonSelectionner.TabIndex = 45;
            this.buttonSelectionner.Text = "Selectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = true;
            this.buttonSelectionner.Click += new System.EventHandler(this.buttonSelectionner_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(665, 214);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(112, 34);
            this.buttonAnnuler.TabIndex = 46;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // ChoixProd_Fourni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 450);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRechercheFourni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxFournisseur);
            this.Controls.Add(this.labelErreurBarreQtt);
            this.Controls.Add(this.labelErreurListPrd);
            this.Controls.Add(this.labelRechercheProd);
            this.Controls.Add(this.textBoxRecherchePrd);
            this.Controls.Add(this.labelProduit);
            this.Controls.Add(this.listBoxProduits);
            this.Controls.Add(this.barreQuantite);
            this.Controls.Add(this.labelQuantiteStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAjouterStock);
            this.Name = "ChoixProd_Fourni";
            this.Text = "ChoixProd_Fourni";
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErreurBarreQtt;
        private System.Windows.Forms.Label labelErreurListPrd;
        private System.Windows.Forms.Label labelRechercheProd;
        private System.Windows.Forms.TextBox textBoxRecherchePrd;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.NumericUpDown barreQuantite;
        private System.Windows.Forms.Label labelQuantiteStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAjouterStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRechercheFourni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxFournisseur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSelectionner;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}