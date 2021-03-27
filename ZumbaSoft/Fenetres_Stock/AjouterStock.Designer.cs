
namespace ZumbaSoft.Fenetres_Stock
{
    partial class AjouterStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuantiteStock = new System.Windows.Forms.Label();
            this.barreQuantite = new System.Windows.Forms.NumericUpDown();
            this.buttonOKstock = new System.Windows.Forms.Button();
            this.buttonAnnulerStock = new System.Windows.Forms.Button();
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.labelProduit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRechercheProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ajouter";
            // 
            // labelQuantiteStock
            // 
            this.labelQuantiteStock.AutoSize = true;
            this.labelQuantiteStock.Location = new System.Drawing.Point(18, 75);
            this.labelQuantiteStock.Name = "labelQuantiteStock";
            this.labelQuantiteStock.Size = new System.Drawing.Size(77, 20);
            this.labelQuantiteStock.TabIndex = 11;
            this.labelQuantiteStock.Text = "Quantité : ";
            // 
            // barreQuantite
            // 
            this.barreQuantite.Location = new System.Drawing.Point(146, 75);
            this.barreQuantite.Name = "barreQuantite";
            this.barreQuantite.Size = new System.Drawing.Size(100, 27);
            this.barreQuantite.TabIndex = 12;
            // 
            // buttonOKstock
            // 
            this.buttonOKstock.Location = new System.Drawing.Point(534, 297);
            this.buttonOKstock.Name = "buttonOKstock";
            this.buttonOKstock.Size = new System.Drawing.Size(94, 29);
            this.buttonOKstock.TabIndex = 13;
            this.buttonOKstock.Text = "OK";
            this.buttonOKstock.UseVisualStyleBackColor = true;
            this.buttonOKstock.Click += new System.EventHandler(this.buttonOKstock_Click);
            // 
            // buttonAnnulerStock
            // 
            this.buttonAnnulerStock.Location = new System.Drawing.Point(534, 353);
            this.buttonAnnulerStock.Name = "buttonAnnulerStock";
            this.buttonAnnulerStock.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnulerStock.TabIndex = 14;
            this.buttonAnnulerStock.Text = "Annuler";
            this.buttonAnnulerStock.UseVisualStyleBackColor = true;
            this.buttonAnnulerStock.Click += new System.EventHandler(this.buttonAnnulerStock_Click);
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.ItemHeight = 20;
            this.listBoxProduits.Location = new System.Drawing.Point(146, 182);
            this.listBoxProduits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(342, 244);
            this.listBoxProduits.TabIndex = 15;
            // 
            // labelProduit
            // 
            this.labelProduit.AutoSize = true;
            this.labelProduit.Location = new System.Drawing.Point(18, 138);
            this.labelProduit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProduit.Name = "labelProduit";
            this.labelProduit.Size = new System.Drawing.Size(64, 20);
            this.labelProduit.TabIndex = 16;
            this.labelProduit.Text = "Produit :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 150);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 27);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelRechercheProd
            // 
            this.labelRechercheProd.AutoSize = true;
            this.labelRechercheProd.Location = new System.Drawing.Point(146, 153);
            this.labelRechercheProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRechercheProd.Name = "labelRechercheProd";
            this.labelRechercheProd.Size = new System.Drawing.Size(84, 20);
            this.labelRechercheProd.TabIndex = 18;
            this.labelRechercheProd.Text = "Recherche :";
            // 
            // AjouterStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRechercheProd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelProduit);
            this.Controls.Add(this.listBoxProduits);
            this.Controls.Add(this.buttonAnnulerStock);
            this.Controls.Add(this.buttonOKstock);
            this.Controls.Add(this.barreQuantite);
            this.Controls.Add(this.labelQuantiteStock);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterStock";
            this.Text = "AjouterStock";
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuantiteStock;
        private System.Windows.Forms.NumericUpDown barreQuantite;
        private System.Windows.Forms.Button buttonOKstock;
        private System.Windows.Forms.Button buttonAnnulerStock;
        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.Label labelProduit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRechercheProd;
    }
}