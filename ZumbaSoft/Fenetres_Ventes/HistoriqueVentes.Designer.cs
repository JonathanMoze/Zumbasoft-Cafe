
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriqueVentes));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewProduitsPanier = new System.Windows.Forms.ListView();
            this.listViewVentesPassees = new System.Windows.Forms.ListView();
            this.NumeroVente = new System.Windows.Forms.ColumnHeader();
            this.columnClient = new System.Windows.Forms.ColumnHeader();
            this.columnPrix = new System.Windows.Forms.ColumnHeader();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.programName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundBlock2.SuspendLayout();
            this.backgroundBlock1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historique des ventes effectuées ";
            // 
            // listViewProduitsPanier
            // 
            this.listViewProduitsPanier.HideSelection = false;
            this.listViewProduitsPanier.Location = new System.Drawing.Point(532, 162);
            this.listViewProduitsPanier.Name = "listViewProduitsPanier";
            this.listViewProduitsPanier.Size = new System.Drawing.Size(373, 377);
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
            this.listViewVentesPassees.Location = new System.Drawing.Point(44, 162);
            this.listViewVentesPassees.Name = "listViewVentesPassees";
            this.listViewVentesPassees.Size = new System.Drawing.Size(390, 377);
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
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.backgroundBlock2.Controls.Add(this.button1);
            this.backgroundBlock2.Location = new System.Drawing.Point(0, 571);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(950, 49);
            this.backgroundBlock2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(422, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "RETOUR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.backgroundBlock1.Controls.Add(this.programName);
            this.backgroundBlock1.Location = new System.Drawing.Point(0, 0);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(950, 49);
            this.backgroundBlock1.TabIndex = 24;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(798, 5);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(140, 39);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(39, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Paniers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(527, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Produits du panier";
            // 
            // HistoriqueVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(950, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.listViewVentesPassees);
            this.Controls.Add(this.listViewProduitsPanier);
            this.Controls.Add(this.label1);
            this.Name = "HistoriqueVentes";
            this.Text = "HistoriqueVentes";
            this.Load += new System.EventHandler(this.HistoriqueVentes_Load);
            this.backgroundBlock2.ResumeLayout(false);
            this.backgroundBlock2.PerformLayout();
            this.backgroundBlock1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}