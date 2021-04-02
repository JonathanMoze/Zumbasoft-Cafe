
namespace ZumbaSoft.Fenetres_Commande
{
    partial class ChoixProd_BY_FourniCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixProd_BY_FourniCmd));
            this.barreQuantite = new System.Windows.Forms.NumericUpDown();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.labelQuantiteStock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProduit = new System.Windows.Forms.Label();
            this.labelRechercheProd = new System.Windows.Forms.Label();
            this.textBoxRecherchePrd = new System.Windows.Forms.TextBox();
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.labelErreurListPrd = new System.Windows.Forms.Label();
            this.labelErreurBarreQtt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).BeginInit();
            this.backgroundBlock1.SuspendLayout();
            this.backgroundBlock2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barreQuantite
            // 
            this.barreQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.barreQuantite.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barreQuantite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.barreQuantite.Location = new System.Drawing.Point(510, 270);
            this.barreQuantite.Name = "barreQuantite";
            this.barreQuantite.Size = new System.Drawing.Size(100, 32);
            this.barreQuantite.TabIndex = 49;
            this.barreQuantite.ValueChanged += new System.EventHandler(this.barreQuantite_ValueChanged);
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock1.Controls.Add(this.labelTitle);
            this.backgroundBlock1.Location = new System.Drawing.Point(0, 0);
            this.backgroundBlock1.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(702, 84);
            this.backgroundBlock1.TabIndex = 73;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(24, 24);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(301, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Ajout dans les stocks";
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Controls.Add(this.buttonAjouter);
            this.backgroundBlock2.Location = new System.Drawing.Point(0, 467);
            this.backgroundBlock2.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(702, 54);
            this.backgroundBlock2.TabIndex = 74;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnuler.Location = new System.Drawing.Point(431, 12);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(105, 29);
            this.buttonAnnuler.TabIndex = 63;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Transparent;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAjouter.Location = new System.Drawing.Point(568, 13);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(108, 29);
            this.buttonAjouter.TabIndex = 47;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // labelQuantiteStock
            // 
            this.labelQuantiteStock.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantiteStock.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantiteStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelQuantiteStock.Location = new System.Drawing.Point(514, 230);
            this.labelQuantiteStock.Name = "labelQuantiteStock";
            this.labelQuantiteStock.Size = new System.Drawing.Size(96, 24);
            this.labelQuantiteStock.TabIndex = 75;
            this.labelQuantiteStock.Text = "Quantité : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.labelProduit);
            this.panel1.Controls.Add(this.labelRechercheProd);
            this.panel1.Controls.Add(this.textBoxRecherchePrd);
            this.panel1.Controls.Add(this.listBoxProduits);
            this.panel1.Controls.Add(this.labelErreurListPrd);
            this.panel1.Location = new System.Drawing.Point(24, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 360);
            this.panel1.TabIndex = 77;
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.BackColor = System.Drawing.Color.Transparent;
            this.labelProduit.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProduit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelProduit.Location = new System.Drawing.Point(21, 13);
            this.labelProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(86, 25);
            this.labelProduit.TabIndex = 52;
            this.labelProduit.Text = "Produit :";
            // 
            // labelRechercheProd
            // 
            this.labelRechercheProd.AutoSize = true;
            this.labelRechercheProd.BackColor = System.Drawing.Color.Transparent;
            this.labelRechercheProd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRechercheProd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRechercheProd.Location = new System.Drawing.Point(21, 56);
            this.labelRechercheProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRechercheProd.Name = "labelRechercheProd";
            this.labelRechercheProd.Size = new System.Drawing.Size(87, 20);
            this.labelRechercheProd.TabIndex = 54;
            this.labelRechercheProd.Text = "Recherche :";
            // 
            // textBoxRecherchePrd
            // 
            this.textBoxRecherchePrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxRecherchePrd.Location = new System.Drawing.Point(116, 54);
            this.textBoxRecherchePrd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRecherchePrd.Name = "textBoxRecherchePrd";
            this.textBoxRecherchePrd.Size = new System.Drawing.Size(247, 27);
            this.textBoxRecherchePrd.TabIndex = 53;
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listBoxProduits.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.ItemHeight = 20;
            this.listBoxProduits.Location = new System.Drawing.Point(21, 83);
            this.listBoxProduits.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(342, 244);
            this.listBoxProduits.TabIndex = 51;
            // 
            // labelErreurListPrd
            // 
            this.labelErreurListPrd.AutoSize = true;
            this.labelErreurListPrd.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurListPrd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurListPrd.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurListPrd.Location = new System.Drawing.Point(21, 333);
            this.labelErreurListPrd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErreurListPrd.Name = "labelErreurListPrd";
            this.labelErreurListPrd.Size = new System.Drawing.Size(186, 20);
            this.labelErreurListPrd.TabIndex = 55;
            this.labelErreurListPrd.Text = "Veuillez choisir un produit.";
            this.labelErreurListPrd.Visible = false;
            // 
            // labelErreurBarreQtt
            // 
            this.labelErreurBarreQtt.AutoSize = true;
            this.labelErreurBarreQtt.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurBarreQtt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurBarreQtt.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurBarreQtt.Location = new System.Drawing.Point(489, 329);
            this.labelErreurBarreQtt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErreurBarreQtt.Name = "labelErreurBarreQtt";
            this.labelErreurBarreQtt.Size = new System.Drawing.Size(143, 40);
            this.labelErreurBarreQtt.TabIndex = 76;
            this.labelErreurBarreQtt.Text = "Veuillez saisir la \r\nquantité de produit.";
            this.labelErreurBarreQtt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelErreurBarreQtt.Visible = false;
            // 
            // ChoixProd_BY_FourniCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 521);
            this.Controls.Add(this.labelQuantiteStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelErreurBarreQtt);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.barreQuantite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChoixProd_BY_FourniCmd";
            this.Text = "Choix d\'un produit";
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).EndInit();
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.backgroundBlock2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown barreQuantite;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelQuantiteStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.Label labelRechercheProd;
        private System.Windows.Forms.TextBox textBoxRecherchePrd;
        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.Label labelErreurListPrd;
        private System.Windows.Forms.Label labelErreurBarreQtt;
    }
}