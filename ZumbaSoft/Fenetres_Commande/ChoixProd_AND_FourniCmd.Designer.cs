
namespace ZumbaSoft.Fenetres_Commande
{
    partial class ChoixProd_AND_FourniCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixProd_AND_FourniCmd));
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouterStock = new System.Windows.Forms.Button();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRechercheFourni = new System.Windows.Forms.TextBox();
            this.listBoxFournisseur = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barreQuantite = new System.Windows.Forms.NumericUpDown();
            this.labelQuantiteStock = new System.Windows.Forms.Label();
            this.labelProduit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRechercheProd = new System.Windows.Forms.Label();
            this.textBoxRecherchePrd = new System.Windows.Forms.TextBox();
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.labelErreurListPrd = new System.Windows.Forms.Label();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.labelErreurBarreQtt = new System.Windows.Forms.Label();
            this.backgroundBlock2.SuspendLayout();
            this.backgroundBlock1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Controls.Add(this.buttonAjouterStock);
            this.backgroundBlock2.Location = new System.Drawing.Point(-2, 468);
            this.backgroundBlock2.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(1071, 54);
            this.backgroundBlock2.TabIndex = 73;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnuler.Location = new System.Drawing.Point(742, 12);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(108, 29);
            this.buttonAnnuler.TabIndex = 63;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonAjouterStock
            // 
            this.buttonAjouterStock.BackColor = System.Drawing.Color.Transparent;
            this.buttonAjouterStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterStock.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouterStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAjouterStock.Location = new System.Drawing.Point(877, 12);
            this.buttonAjouterStock.Name = "buttonAjouterStock";
            this.buttonAjouterStock.Size = new System.Drawing.Size(108, 29);
            this.buttonAjouterStock.TabIndex = 47;
            this.buttonAjouterStock.Text = "Ajouter";
            this.buttonAjouterStock.UseVisualStyleBackColor = false;
            this.buttonAjouterStock.Click += new System.EventHandler(this.buttonAjouterStock_Click);
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock1.Controls.Add(this.label1);
            this.backgroundBlock1.Location = new System.Drawing.Point(-2, -2);
            this.backgroundBlock1.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(1022, 84);
            this.backgroundBlock1.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout dans les stocks";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxRechercheFourni);
            this.panel2.Controls.Add(this.listBoxFournisseur);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(589, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 360);
            this.panel2.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Fournisseur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Recherche :";
            // 
            // textBoxRechercheFourni
            // 
            this.textBoxRechercheFourni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxRechercheFourni.Enabled = false;
            this.textBoxRechercheFourni.Location = new System.Drawing.Point(117, 54);
            this.textBoxRechercheFourni.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRechercheFourni.Name = "textBoxRechercheFourni";
            this.textBoxRechercheFourni.Size = new System.Drawing.Size(247, 27);
            this.textBoxRechercheFourni.TabIndex = 59;
            // 
            // listBoxFournisseur
            // 
            this.listBoxFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listBoxFournisseur.Enabled = false;
            this.listBoxFournisseur.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxFournisseur.FormattingEnabled = true;
            this.listBoxFournisseur.ItemHeight = 20;
            this.listBoxFournisseur.Location = new System.Drawing.Point(22, 83);
            this.listBoxFournisseur.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFournisseur.Name = "listBoxFournisseur";
            this.listBoxFournisseur.Size = new System.Drawing.Size(342, 244);
            this.listBoxFournisseur.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(22, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Veuillez choisir un fournisseur.";
            this.label4.Visible = false;
            // 
            // barreQuantite
            // 
            this.barreQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.barreQuantite.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barreQuantite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.barreQuantite.Location = new System.Drawing.Point(448, 235);
            this.barreQuantite.Name = "barreQuantite";
            this.barreQuantite.Size = new System.Drawing.Size(100, 29);
            this.barreQuantite.TabIndex = 69;
            // 
            // labelQuantiteStock
            // 
            this.labelQuantiteStock.AutoSize = true;
            this.labelQuantiteStock.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantiteStock.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantiteStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelQuantiteStock.Location = new System.Drawing.Point(460, 205);
            this.labelQuantiteStock.Name = "labelQuantiteStock";
            this.labelQuantiteStock.Size = new System.Drawing.Size(80, 20);
            this.labelQuantiteStock.TabIndex = 68;
            this.labelQuantiteStock.Text = "Quantité : ";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.labelProduit);
            this.panel1.Controls.Add(this.labelRechercheProd);
            this.panel1.Controls.Add(this.textBoxRecherchePrd);
            this.panel1.Controls.Add(this.listBoxProduits);
            this.panel1.Controls.Add(this.labelErreurListPrd);
            this.panel1.Location = new System.Drawing.Point(28, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 360);
            this.panel1.TabIndex = 74;
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
            this.listBoxProduits.SelectedIndexChanged += new System.EventHandler(this.listBoxProduits_SelectedIndexChanged);
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
            // buttonSelectionner
            // 
            this.buttonSelectionner.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectionner.Enabled = false;
            this.buttonSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectionner.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectionner.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSelectionner.Location = new System.Drawing.Point(439, 313);
            this.buttonSelectionner.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(122, 32);
            this.buttonSelectionner.TabIndex = 71;
            this.buttonSelectionner.Text = "Sélectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = false;
            this.buttonSelectionner.Click += new System.EventHandler(this.buttonSelectionner_Click);
            // 
            // labelErreurBarreQtt
            // 
            this.labelErreurBarreQtt.AutoSize = true;
            this.labelErreurBarreQtt.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurBarreQtt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurBarreQtt.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurBarreQtt.Location = new System.Drawing.Point(427, 268);
            this.labelErreurBarreQtt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErreurBarreQtt.Name = "labelErreurBarreQtt";
            this.labelErreurBarreQtt.Size = new System.Drawing.Size(143, 40);
            this.labelErreurBarreQtt.TabIndex = 70;
            this.labelErreurBarreQtt.Text = "Veuillez saisir la \r\nquantité de produit.";
            this.labelErreurBarreQtt.Visible = false;
            // 
            // ChoixProd_AND_FourniCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1001, 521);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barreQuantite);
            this.Controls.Add(this.labelQuantiteStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.labelErreurBarreQtt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChoixProd_AND_FourniCmd";
            this.Text = "ChoixProd_Fourni";
            this.backgroundBlock2.ResumeLayout(false);
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouterStock;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRechercheFourni;
        private System.Windows.Forms.ListBox listBoxFournisseur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown barreQuantite;
        private System.Windows.Forms.Label labelQuantiteStock;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRechercheProd;
        private System.Windows.Forms.TextBox textBoxRecherchePrd;
        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.Label labelErreurListPrd;
        private System.Windows.Forms.Button buttonSelectionner;
        private System.Windows.Forms.Label labelErreurBarreQtt;
    }
}