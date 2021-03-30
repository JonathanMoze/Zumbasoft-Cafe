
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
            this.labelListProdStock = new System.Windows.Forms.Label();
            this.buttonSuppStock = new System.Windows.Forms.Button();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNouvelleCmd = new System.Windows.Forms.Button();
            this.buttonModifierCmd = new System.Windows.Forms.Button();
            this.tableauCommandes = new System.Windows.Forms.DataGridView();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableauStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValeurStk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAjouterStk = new System.Windows.Forms.Button();
            this.buttonSupprimerStk = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNbArticle = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMagasin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableauCommandes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauStock)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelListProdStock
            // 
            this.labelListProdStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelListProdStock.AutoSize = true;
            this.labelListProdStock.Location = new System.Drawing.Point(13, 113);
            this.labelListProdStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListProdStock.Name = "labelListProdStock";
            this.labelListProdStock.Size = new System.Drawing.Size(223, 25);
            this.labelListProdStock.TabIndex = 1;
            this.labelListProdStock.Text = "Liste des produits en stock";
            // 
            // buttonSuppStock
            // 
            this.buttonSuppStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuppStock.Location = new System.Drawing.Point(10, 511);
            this.buttonSuppStock.Margin = new System.Windows.Forms.Padding(10, 70, 10, 70);
            this.buttonSuppStock.Name = "buttonSuppStock";
            this.buttonSuppStock.Size = new System.Drawing.Size(125, 51);
            this.buttonSuppStock.TabIndex = 4;
            this.buttonSuppStock.Text = "Supprimer";
            this.buttonSuppStock.UseVisualStyleBackColor = true;
            this.buttonSuppStock.Click += new System.EventHandler(this.buttonSuppCmd_Click);
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(13, 786);
            this.buttonAccueil.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(118, 36);
            this.buttonAccueil.TabIndex = 5;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "Stock du ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Liste des comandes :";
            // 
            // buttonNouvelleCmd
            // 
            this.buttonNouvelleCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNouvelleCmd.Location = new System.Drawing.Point(10, 133);
            this.buttonNouvelleCmd.Margin = new System.Windows.Forms.Padding(10, 70, 10, 70);
            this.buttonNouvelleCmd.Name = "buttonNouvelleCmd";
            this.buttonNouvelleCmd.Size = new System.Drawing.Size(125, 49);
            this.buttonNouvelleCmd.TabIndex = 34;
            this.buttonNouvelleCmd.Text = "Nouvelle";
            this.buttonNouvelleCmd.UseVisualStyleBackColor = true;
            this.buttonNouvelleCmd.Click += new System.EventHandler(this.buttonNouvelleCmd_Click);
            // 
            // buttonModifierCmd
            // 
            this.buttonModifierCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModifierCmd.Location = new System.Drawing.Point(10, 302);
            this.buttonModifierCmd.Margin = new System.Windows.Forms.Padding(10, 50, 10, 50);
            this.buttonModifierCmd.Name = "buttonModifierCmd";
            this.buttonModifierCmd.Size = new System.Drawing.Size(125, 89);
            this.buttonModifierCmd.TabIndex = 35;
            this.buttonModifierCmd.Text = "Afficher \r\n/\r\nModifier";
            this.buttonModifierCmd.UseVisualStyleBackColor = true;
            this.buttonModifierCmd.Click += new System.EventHandler(this.buttonModifierCmd_Click);
            // 
            // tableauCommandes
            // 
            this.tableauCommandes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableauCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.dateDeCommande,
            this.fournisseur,
            this.etat,
            this.prixTotalTTC});
            this.tableauCommandes.Location = new System.Drawing.Point(834, 3);
            this.tableauCommandes.MultiSelect = false;
            this.tableauCommandes.Name = "tableauCommandes";
            this.tableauCommandes.ReadOnly = true;
            this.tableauCommandes.RowHeadersWidth = 62;
            this.tableauCommandes.RowTemplate.Height = 33;
            this.tableauCommandes.Size = new System.Drawing.Size(675, 632);
            this.tableauCommandes.TabIndex = 37;
            // 
            // reference
            // 
            this.reference.HeaderText = "Référence";
            this.reference.MinimumWidth = 8;
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            // 
            // dateDeCommande
            // 
            this.dateDeCommande.HeaderText = "Date de commande";
            this.dateDeCommande.MinimumWidth = 8;
            this.dateDeCommande.Name = "dateDeCommande";
            this.dateDeCommande.ReadOnly = true;
            // 
            // fournisseur
            // 
            this.fournisseur.HeaderText = "Fournisseur";
            this.fournisseur.MinimumWidth = 8;
            this.fournisseur.Name = "fournisseur";
            this.fournisseur.ReadOnly = true;
            // 
            // etat
            // 
            this.etat.HeaderText = "Etat";
            this.etat.MinimumWidth = 8;
            this.etat.Name = "etat";
            this.etat.ReadOnly = true;
            // 
            // prixTotalTTC
            // 
            this.prixTotalTTC.HeaderText = "Prix totale TTC";
            this.prixTotalTTC.MinimumWidth = 8;
            this.prixTotalTTC.Name = "prixTotalTTC";
            this.prixTotalTTC.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.Controls.Add(this.tableauCommandes, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableauStock, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 141);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1663, 638);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // tableauStock
            // 
            this.tableauStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableauStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nomArticle,
            this.dataGridViewTextBoxColumn2,
            this.quantite,
            this.prixUnitaire,
            this.dataGridViewTextBoxColumn3});
            this.tableauStock.Location = new System.Drawing.Point(3, 3);
            this.tableauStock.MultiSelect = false;
            this.tableauStock.Name = "tableauStock";
            this.tableauStock.ReadOnly = true;
            this.tableauStock.RowHeadersWidth = 62;
            this.tableauStock.RowTemplate.Height = 33;
            this.tableauStock.Size = new System.Drawing.Size(675, 632);
            this.tableauStock.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Identifiant";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomArticle
            // 
            this.nomArticle.HeaderText = "Article";
            this.nomArticle.MinimumWidth = 8;
            this.nomArticle.Name = "nomArticle";
            this.nomArticle.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fournisseur";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantité";
            this.quantite.MinimumWidth = 8;
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            // 
            // prixUnitaire
            // 
            this.prixUnitaire.HeaderText = "Prix unitaire TTC";
            this.prixUnitaire.MinimumWidth = 8;
            this.prixUnitaire.Name = "prixUnitaire";
            this.prixUnitaire.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Etat";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSuppStock, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonModifierCmd, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonNouvelleCmd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1515, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(145, 632);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 63);
            this.label1.TabIndex = 36;
            this.label1.Text = "Gestion des commandes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.buttonAjouterStk, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonSupprimerStk, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(684, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 632);
            this.tableLayoutPanel3.TabIndex = 40;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxValeurStk, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 507);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(138, 122);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 61);
            this.label7.TabIndex = 39;
            this.label7.Text = "Valeur des stocks :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxValeurStk
            // 
            this.textBoxValeurStk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValeurStk.Enabled = false;
            this.textBoxValeurStk.Location = new System.Drawing.Point(3, 71);
            this.textBoxValeurStk.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBoxValeurStk.Name = "textBoxValeurStk";
            this.textBoxValeurStk.Size = new System.Drawing.Size(132, 31);
            this.textBoxValeurStk.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gestion des stocks";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(3, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 63);
            this.label5.TabIndex = 1;
            this.label5.Text = "Infos sur les stocks";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAjouterStk
            // 
            this.buttonAjouterStk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouterStk.Location = new System.Drawing.Point(10, 103);
            this.buttonAjouterStk.Margin = new System.Windows.Forms.Padding(10, 40, 10, 40);
            this.buttonAjouterStk.Name = "buttonAjouterStk";
            this.buttonAjouterStk.Size = new System.Drawing.Size(124, 46);
            this.buttonAjouterStk.TabIndex = 2;
            this.buttonAjouterStk.Text = "Ajouter";
            this.buttonAjouterStk.UseVisualStyleBackColor = true;
            this.buttonAjouterStk.Click += new System.EventHandler(this.buttonAjouterStk_Click);
            // 
            // buttonSupprimerStk
            // 
            this.buttonSupprimerStk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSupprimerStk.Location = new System.Drawing.Point(10, 229);
            this.buttonSupprimerStk.Margin = new System.Windows.Forms.Padding(10, 40, 10, 40);
            this.buttonSupprimerStk.Name = "buttonSupprimerStk";
            this.buttonSupprimerStk.Size = new System.Drawing.Size(124, 46);
            this.buttonSupprimerStk.TabIndex = 3;
            this.buttonSupprimerStk.Text = "Supprimer";
            this.buttonSupprimerStk.UseVisualStyleBackColor = true;
            this.buttonSupprimerStk.Click += new System.EventHandler(this.buttonSupprimerStk_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxNbArticle, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 381);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(138, 120);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 60);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre d\'articles :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNbArticle
            // 
            this.textBoxNbArticle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNbArticle.Enabled = false;
            this.textBoxNbArticle.Location = new System.Drawing.Point(3, 70);
            this.textBoxNbArticle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBoxNbArticle.Name = "textBoxNbArticle";
            this.textBoxNbArticle.Size = new System.Drawing.Size(132, 31);
            this.textBoxNbArticle.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(149, 31);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(180, 38);
            this.labelDate.TabIndex = 39;
            this.labelDate.Text = "JJ/MM/AAAA";
            // 
            // labelMagasin
            // 
            this.labelMagasin.AutoSize = true;
            this.labelMagasin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMagasin.Location = new System.Drawing.Point(374, 31);
            this.labelMagasin.Name = "labelMagasin";
            this.labelMagasin.Size = new System.Drawing.Size(139, 38);
            this.labelMagasin.TabIndex = 40;
            this.labelMagasin.Text = "MAGASIN";
            // 
            // AccueilStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 835);
            this.Controls.Add(this.labelMagasin);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAccueil);
            this.Controls.Add(this.labelListProdStock);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccueilStock";
            this.Text = "AccueilStock";
            ((System.ComponentModel.ISupportInitialize)(this.tableauCommandes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableauStock)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListProdStock;
        private System.Windows.Forms.Button buttonSuppStock;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNouvelleCmd;
        private System.Windows.Forms.Button buttonModifierCmd;
        private System.Windows.Forms.DataGridView tableauCommandes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView tableauStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn fournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotalTTC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValeurStk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAjouterStk;
        private System.Windows.Forms.Button buttonSupprimerStk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNbArticle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMagasin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}