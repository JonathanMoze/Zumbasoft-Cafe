
namespace ZumbaSoft.Fenetres_Stock
{
    partial class AccueilStock
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
            this.listStock = new System.Windows.Forms.ListBox();
            this.labelListProdStock = new System.Windows.Forms.Label();
            this.buttonAjouterStock = new System.Windows.Forms.Button();
            this.buttonSuppStock = new System.Windows.Forms.Button();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.labelRechercheProd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelProduit = new System.Windows.Forms.Label();
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.barreQuantite = new System.Windows.Forms.NumericUpDown();
            this.labelQuantiteStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelErreurListPrd = new System.Windows.Forms.Label();
            this.labelErreurBarreQtt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCmd = new System.Windows.Forms.Button();
            this.buttonNewCmd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // listStock
            // 
            this.listStock.FormattingEnabled = true;
            this.listStock.ItemHeight = 25;
            this.listStock.Location = new System.Drawing.Point(13, 174);
            this.listStock.Margin = new System.Windows.Forms.Padding(4);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(476, 354);
            this.listStock.TabIndex = 0;
            // 
            // labelListProdStock
            // 
            this.labelListProdStock.AutoSize = true;
            this.labelListProdStock.Location = new System.Drawing.Point(13, 145);
            this.labelListProdStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListProdStock.Name = "labelListProdStock";
            this.labelListProdStock.Size = new System.Drawing.Size(223, 25);
            this.labelListProdStock.TabIndex = 1;
            this.labelListProdStock.Text = "Liste des produits en stock";
            // 
            // buttonAjouterStock
            // 
            this.buttonAjouterStock.Location = new System.Drawing.Point(1532, 535);
            this.buttonAjouterStock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouterStock.Name = "buttonAjouterStock";
            this.buttonAjouterStock.Size = new System.Drawing.Size(118, 36);
            this.buttonAjouterStock.TabIndex = 2;
            this.buttonAjouterStock.Text = "Ajouter";
            this.buttonAjouterStock.UseVisualStyleBackColor = true;
            this.buttonAjouterStock.Click += new System.EventHandler(this.buttonAjouterStock_Click);
            // 
            // buttonSuppStock
            // 
            this.buttonSuppStock.Location = new System.Drawing.Point(497, 224);
            this.buttonSuppStock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSuppStock.Name = "buttonSuppStock";
            this.buttonSuppStock.Size = new System.Drawing.Size(132, 36);
            this.buttonSuppStock.TabIndex = 4;
            this.buttonSuppStock.Text = "Supprimer";
            this.buttonSuppStock.UseVisualStyleBackColor = true;
            this.buttonSuppStock.Click += new System.EventHandler(this.buttonSuppStock_Click);
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(644, 540);
            this.buttonAccueil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(118, 36);
            this.buttonAccueil.TabIndex = 5;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // labelRechercheProd
            // 
            this.labelRechercheProd.AutoSize = true;
            this.labelRechercheProd.Location = new System.Drawing.Point(1237, 190);
            this.labelRechercheProd.Name = "labelRechercheProd";
            this.labelRechercheProd.Size = new System.Drawing.Size(100, 25);
            this.labelRechercheProd.TabIndex = 27;
            this.labelRechercheProd.Text = "Recherche :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1343, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 31);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.Location = new System.Drawing.Point(1139, 196);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(79, 25);
            this.labelProduit.TabIndex = 25;
            this.labelProduit.Text = "Produit :";
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.ItemHeight = 25;
            this.listBoxProduits.Location = new System.Drawing.Point(1224, 224);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(427, 304);
            this.listBoxProduits.TabIndex = 24;
            // 
            // barreQuantite
            // 
            this.barreQuantite.Location = new System.Drawing.Point(1074, 375);
            this.barreQuantite.Margin = new System.Windows.Forms.Padding(4);
            this.barreQuantite.Name = "barreQuantite";
            this.barreQuantite.Size = new System.Drawing.Size(125, 31);
            this.barreQuantite.TabIndex = 21;
            this.barreQuantite.ValueChanged += new System.EventHandler(this.barreQuantite_ValueChanged);
            // 
            // labelQuantiteStock
            // 
            this.labelQuantiteStock.AutoSize = true;
            this.labelQuantiteStock.Location = new System.Drawing.Point(1074, 333);
            this.labelQuantiteStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantiteStock.Name = "labelQuantiteStock";
            this.labelQuantiteStock.Size = new System.Drawing.Size(94, 25);
            this.labelQuantiteStock.TabIndex = 20;
            this.labelQuantiteStock.Text = "Quantité : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1051, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ajouter";
            // 
            // labelErreurListPrd
            // 
            this.labelErreurListPrd.AutoSize = true;
            this.labelErreurListPrd.Location = new System.Drawing.Point(1224, 535);
            this.labelErreurListPrd.Name = "labelErreurListPrd";
            this.labelErreurListPrd.Size = new System.Drawing.Size(219, 25);
            this.labelErreurListPrd.TabIndex = 28;
            this.labelErreurListPrd.Text = "Veuillez choisir un produit.";
            this.labelErreurListPrd.Visible = false;
            // 
            // labelErreurBarreQtt
            // 
            this.labelErreurBarreQtt.AutoSize = true;
            this.labelErreurBarreQtt.Location = new System.Drawing.Point(1048, 410);
            this.labelErreurBarreQtt.Name = "labelErreurBarreQtt";
            this.labelErreurBarreQtt.Size = new System.Drawing.Size(170, 50);
            this.labelErreurBarreQtt.TabIndex = 29;
            this.labelErreurBarreQtt.Text = "Veuillez saisir la \r\nquantité de produit.";
            this.labelErreurBarreQtt.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "Stock du ";
            // 
            // buttonCmd
            // 
            this.buttonCmd.Location = new System.Drawing.Point(497, 267);
            this.buttonCmd.Name = "buttonCmd";
            this.buttonCmd.Size = new System.Drawing.Size(132, 34);
            this.buttonCmd.TabIndex = 32;
            this.buttonCmd.Text = "Commander";
            this.buttonCmd.UseVisualStyleBackColor = true;
            // 
            // buttonNewCmd
            // 
            this.buttonNewCmd.Location = new System.Drawing.Point(13, 535);
            this.buttonNewCmd.Name = "buttonNewCmd";
            this.buttonNewCmd.Size = new System.Drawing.Size(204, 34);
            this.buttonNewCmd.TabIndex = 33;
            this.buttonNewCmd.Text = "Nouvelle commande";
            this.buttonNewCmd.UseVisualStyleBackColor = true;
            this.buttonNewCmd.Click += new System.EventHandler(this.buttonNewCmd_Click);
            // 
            // AccueilStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 680);
            this.Controls.Add(this.buttonNewCmd);
            this.Controls.Add(this.buttonCmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelErreurBarreQtt);
            this.Controls.Add(this.labelErreurListPrd);
            this.Controls.Add(this.labelRechercheProd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelProduit);
            this.Controls.Add(this.listBoxProduits);
            this.Controls.Add(this.barreQuantite);
            this.Controls.Add(this.labelQuantiteStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAccueil);
            this.Controls.Add(this.buttonSuppStock);
            this.Controls.Add(this.buttonAjouterStock);
            this.Controls.Add(this.labelListProdStock);
            this.Controls.Add(this.listStock);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccueilStock";
            this.Text = "AccueilStock";
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listStock;
        private System.Windows.Forms.Label labelListProdStock;
        private System.Windows.Forms.Button buttonAjouterStock;
        private System.Windows.Forms.Button buttonSuppStock;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Label labelRechercheProd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.NumericUpDown barreQuantite;
        private System.Windows.Forms.Label labelQuantiteStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErreurListPrd;
        private System.Windows.Forms.Label labelErreurBarreQtt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCmd;
        private System.Windows.Forms.Button buttonNewCmd;
    }
}