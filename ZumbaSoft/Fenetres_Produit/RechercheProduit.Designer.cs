
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RechercheProduit));
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.backgroundBlock1.SuspendLayout();
            this.backgroundBlock2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listBoxProduits.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxProduits.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.ItemHeight = 19;
            this.listBoxProduits.Location = new System.Drawing.Point(36, 165);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(366, 232);
            this.listBoxProduits.TabIndex = 0;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxRecherche.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRecherche.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxRecherche.Location = new System.Drawing.Point(36, 118);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.PlaceholderText = "Recherche...";
            this.textBoxRecherche.Size = new System.Drawing.Size(366, 27);
            this.textBoxRecherche.TabIndex = 2;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock1.Controls.Add(this.label1);
            this.backgroundBlock1.Location = new System.Drawing.Point(0, -2);
            this.backgroundBlock1.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(454, 95);
            this.backgroundBlock1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produits";
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonCancel);
            this.backgroundBlock2.Controls.Add(this.buttonOK);
            this.backgroundBlock2.Location = new System.Drawing.Point(0, 420);
            this.backgroundBlock2.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(454, 50);
            this.backgroundBlock2.TabIndex = 37;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancel.Location = new System.Drawing.Point(161, 11);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 28);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Transparent;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOK.Location = new System.Drawing.Point(310, 11);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(124, 28);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Ajouter";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // RechercheProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(451, 468);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.listBoxProduits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RechercheProduit";
            this.Text = "Recherche d\'un produit";
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.backgroundBlock2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}