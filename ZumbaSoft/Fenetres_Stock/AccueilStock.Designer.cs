
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
            this.buttonModifierStock = new System.Windows.Forms.Button();
            this.buttonSuppStock = new System.Windows.Forms.Button();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listStock
            // 
            this.listStock.FormattingEnabled = true;
            this.listStock.ItemHeight = 20;
            this.listStock.Location = new System.Drawing.Point(52, 120);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(382, 284);
            this.listStock.TabIndex = 0;
            // 
            // labelListProdStock
            // 
            this.labelListProdStock.AutoSize = true;
            this.labelListProdStock.Location = new System.Drawing.Point(52, 81);
            this.labelListProdStock.Name = "labelListProdStock";
            this.labelListProdStock.Size = new System.Drawing.Size(183, 20);
            this.labelListProdStock.TabIndex = 1;
            this.labelListProdStock.Text = "Liste des produits en stock";
            // 
            // buttonAjouterStock
            // 
            this.buttonAjouterStock.Location = new System.Drawing.Point(515, 141);
            this.buttonAjouterStock.Name = "buttonAjouterStock";
            this.buttonAjouterStock.Size = new System.Drawing.Size(94, 29);
            this.buttonAjouterStock.TabIndex = 2;
            this.buttonAjouterStock.Text = "Ajouter";
            this.buttonAjouterStock.UseVisualStyleBackColor = true;
            this.buttonAjouterStock.Click += new System.EventHandler(this.buttonAjouterStock_Click);
            // 
            // buttonModifierStock
            // 
            this.buttonModifierStock.Location = new System.Drawing.Point(515, 209);
            this.buttonModifierStock.Name = "buttonModifierStock";
            this.buttonModifierStock.Size = new System.Drawing.Size(94, 29);
            this.buttonModifierStock.TabIndex = 3;
            this.buttonModifierStock.Text = "Modifier";
            this.buttonModifierStock.UseVisualStyleBackColor = true;
            this.buttonModifierStock.Click += new System.EventHandler(this.buttonModifierStock_Click);
            // 
            // buttonSuppStock
            // 
            this.buttonSuppStock.Location = new System.Drawing.Point(515, 280);
            this.buttonSuppStock.Name = "buttonSuppStock";
            this.buttonSuppStock.Size = new System.Drawing.Size(94, 29);
            this.buttonSuppStock.TabIndex = 4;
            this.buttonSuppStock.Text = "Supprimer";
            this.buttonSuppStock.UseVisualStyleBackColor = true;
            this.buttonSuppStock.Click += new System.EventHandler(this.buttonSuppStock_Click);
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(515, 345);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(94, 29);
            this.buttonAccueil.TabIndex = 5;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // AccueilStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.buttonAccueil);
            this.Controls.Add(this.buttonSuppStock);
            this.Controls.Add(this.buttonModifierStock);
            this.Controls.Add(this.buttonAjouterStock);
            this.Controls.Add(this.labelListProdStock);
            this.Controls.Add(this.listStock);
            this.Name = "AccueilStock";
            this.Text = "AccueilStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listStock;
        private System.Windows.Forms.Label labelListProdStock;
        private System.Windows.Forms.Button buttonAjouterStock;
        private System.Windows.Forms.Button buttonModifierStock;
        private System.Windows.Forms.Button buttonSuppStock;
        private System.Windows.Forms.Button buttonAccueil;
    }
}