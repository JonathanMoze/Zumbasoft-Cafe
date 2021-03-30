
namespace ZumbaSoft.Fenetres_Ventes
{
    partial class HistoriqueVentes
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
            this.listViewProduitsPanier = new System.Windows.Forms.ListView();
            this.listViewVentesPassees = new System.Windows.Forms.ListView();
            this.NumeroVente = new System.Windows.Forms.ColumnHeader();
            this.columnClient = new System.Windows.Forms.ColumnHeader();
            this.columnPrix = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historique des ventes effectuées ";
            // 
            // listViewProduitsPanier
            // 
            this.listViewProduitsPanier.HideSelection = false;
            this.listViewProduitsPanier.Location = new System.Drawing.Point(569, 207);
            this.listViewProduitsPanier.Name = "listViewProduitsPanier";
            this.listViewProduitsPanier.Size = new System.Drawing.Size(221, 193);
            this.listViewProduitsPanier.TabIndex = 2;
            this.listViewProduitsPanier.UseCompatibleStateImageBehavior = false;
            // 
            // listViewVentesPassees
            // 
            this.listViewVentesPassees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeroVente,
            this.columnClient,
            this.columnPrix});
            this.listViewVentesPassees.HideSelection = false;
            this.listViewVentesPassees.Location = new System.Drawing.Point(55, 104);
            this.listViewVentesPassees.Name = "listViewVentesPassees";
            this.listViewVentesPassees.Size = new System.Drawing.Size(390, 435);
            this.listViewVentesPassees.TabIndex = 3;
            this.listViewVentesPassees.UseCompatibleStateImageBehavior = false;
            // 
            // NumeroVente
            // 
            this.NumeroVente.Text = "Numéro de Vente";
            this.NumeroVente.Width = 140;
            // 
            // columnClient
            // 
            this.columnClient.Text = "Client concerné";
            this.columnClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnClient.Width = 120;
            // 
            // columnPrix
            // 
            this.columnPrix.Text = "Montant total";
            this.columnPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrix.Width = 130;
            // 
            // HistoriqueVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZumbaSoft.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.listViewVentesPassees);
            this.Controls.Add(this.listViewProduitsPanier);
            this.Controls.Add(this.label1);
            this.Name = "HistoriqueVentes";
            this.Text = "HistoriqueVentes";
            this.Load += new System.EventHandler(this.HistoriqueVentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewProduitsPanier;
        private System.Windows.Forms.ListView listViewVentesPassees;
        public System.Windows.Forms.ColumnHeader NumeroVente;
        public System.Windows.Forms.ColumnHeader columnClient;
        public System.Windows.Forms.ColumnHeader columnPrix;
    }
}