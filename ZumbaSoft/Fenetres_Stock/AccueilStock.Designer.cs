
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilStock));
            this.labelListProdStock = new System.Windows.Forms.Label();
            this.buttonSuppStock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNouvelleCmd = new System.Windows.Forms.Button();
            this.buttonModifierCmd = new System.Windows.Forms.Button();
            this.tableauCommandes = new System.Windows.Forms.DataGridView();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValeurStk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAjouterStk = new System.Windows.Forms.Button();
            this.buttonSupprimerStk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNbArticle = new System.Windows.Forms.TextBox();
            this.tableauStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.programName = new System.Windows.Forms.Label();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.dbERROR = new System.Windows.Forms.PictureBox();
            this.dbOK = new System.Windows.Forms.PictureBox();
            this.magasinSelectionne = new System.Windows.Forms.Label();
            this.msgBDstatusERROR = new System.Windows.Forms.Label();
            this.msgBDstatusOK = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableauCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauStock)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelListProdStock
            // 
            this.labelListProdStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelListProdStock.BackColor = System.Drawing.Color.Transparent;
            this.labelListProdStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelListProdStock.Location = new System.Drawing.Point(38, 76);
            this.labelListProdStock.Name = "labelListProdStock";
            this.labelListProdStock.Size = new System.Drawing.Size(207, 20);
            this.labelListProdStock.TabIndex = 1;
            this.labelListProdStock.Text = "Liste des produits en stock :";
            // 
            // buttonSuppStock
            // 
            this.buttonSuppStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSuppStock.BackColor = System.Drawing.Color.Transparent;
            this.buttonSuppStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuppStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSuppStock.Location = new System.Drawing.Point(60, 201);
            this.buttonSuppStock.Margin = new System.Windows.Forms.Padding(8, 56, 8, 56);
            this.buttonSuppStock.Name = "buttonSuppStock";
            this.buttonSuppStock.Size = new System.Drawing.Size(107, 35);
            this.buttonSuppStock.TabIndex = 4;
            this.buttonSuppStock.Text = "Supprimer";
            this.buttonSuppStock.UseVisualStyleBackColor = false;
            this.buttonSuppStock.Click += new System.EventHandler(this.buttonSuppCmd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(735, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Liste des comandes :";
            // 
            // buttonNouvelleCmd
            // 
            this.buttonNouvelleCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNouvelleCmd.BackColor = System.Drawing.Color.Transparent;
            this.buttonNouvelleCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNouvelleCmd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNouvelleCmd.Location = new System.Drawing.Point(29, 124);
            this.buttonNouvelleCmd.Margin = new System.Windows.Forms.Padding(8, 56, 8, 56);
            this.buttonNouvelleCmd.Name = "buttonNouvelleCmd";
            this.buttonNouvelleCmd.Size = new System.Drawing.Size(172, 33);
            this.buttonNouvelleCmd.TabIndex = 34;
            this.buttonNouvelleCmd.Text = "Nouvelle Commande";
            this.buttonNouvelleCmd.UseVisualStyleBackColor = false;
            this.buttonNouvelleCmd.Click += new System.EventHandler(this.buttonNouvelleCmd_Click);
            // 
            // buttonModifierCmd
            // 
            this.buttonModifierCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModifierCmd.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifierCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierCmd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonModifierCmd.Location = new System.Drawing.Point(60, 290);
            this.buttonModifierCmd.Margin = new System.Windows.Forms.Padding(8, 40, 8, 40);
            this.buttonModifierCmd.Name = "buttonModifierCmd";
            this.buttonModifierCmd.Size = new System.Drawing.Size(107, 71);
            this.buttonModifierCmd.TabIndex = 35;
            this.buttonModifierCmd.Text = "Afficher \r\n/\r\n Modifier";
            this.buttonModifierCmd.UseVisualStyleBackColor = false;
            this.buttonModifierCmd.Click += new System.EventHandler(this.buttonModifierCmd_Click);
            // 
            // tableauCommandes
            // 
            this.tableauCommandes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableauCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauCommandes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableauCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.dateDeCommande,
            this.fournisseur,
            this.etat,
            this.prixTotalTTC});
            this.tableauCommandes.Location = new System.Drawing.Point(737, 104);
            this.tableauCommandes.Margin = new System.Windows.Forms.Padding(2);
            this.tableauCommandes.MultiSelect = false;
            this.tableauCommandes.Name = "tableauCommandes";
            this.tableauCommandes.ReadOnly = true;
            this.tableauCommandes.RowHeadersWidth = 62;
            this.tableauCommandes.RowTemplate.Height = 33;
            this.tableauCommandes.Size = new System.Drawing.Size(448, 556);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1436, 631);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Gestion des commandes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(49, 438);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Valeur des stocks :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxValeurStk
            // 
            this.textBoxValeurStk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxValeurStk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxValeurStk.Enabled = false;
            this.textBoxValeurStk.ForeColor = System.Drawing.Color.White;
            this.textBoxValeurStk.Location = new System.Drawing.Point(48, 473);
            this.textBoxValeurStk.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.textBoxValeurStk.Name = "textBoxValeurStk";
            this.textBoxValeurStk.Size = new System.Drawing.Size(128, 27);
            this.textBoxValeurStk.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(37, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gestion des stocks";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(39, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Infos sur les stocks";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAjouterStk
            // 
            this.buttonAjouterStk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjouterStk.BackColor = System.Drawing.Color.Transparent;
            this.buttonAjouterStk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterStk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAjouterStk.Location = new System.Drawing.Point(58, 99);
            this.buttonAjouterStk.Margin = new System.Windows.Forms.Padding(8, 32, 8, 32);
            this.buttonAjouterStk.Name = "buttonAjouterStk";
            this.buttonAjouterStk.Size = new System.Drawing.Size(104, 33);
            this.buttonAjouterStk.TabIndex = 2;
            this.buttonAjouterStk.Text = "Ajouter";
            this.buttonAjouterStk.UseVisualStyleBackColor = false;
            this.buttonAjouterStk.Click += new System.EventHandler(this.buttonAjouterStk_Click);
            // 
            // buttonSupprimerStk
            // 
            this.buttonSupprimerStk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSupprimerStk.BackColor = System.Drawing.Color.Transparent;
            this.buttonSupprimerStk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerStk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSupprimerStk.Location = new System.Drawing.Point(58, 176);
            this.buttonSupprimerStk.Margin = new System.Windows.Forms.Padding(8, 32, 8, 32);
            this.buttonSupprimerStk.Name = "buttonSupprimerStk";
            this.buttonSupprimerStk.Size = new System.Drawing.Size(104, 35);
            this.buttonSupprimerStk.TabIndex = 3;
            this.buttonSupprimerStk.Text = "Supprimer";
            this.buttonSupprimerStk.UseVisualStyleBackColor = false;
            this.buttonSupprimerStk.Click += new System.EventHandler(this.buttonSupprimerStk_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(48, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre d\'articles :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNbArticle
            // 
            this.textBoxNbArticle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNbArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxNbArticle.Enabled = false;
            this.textBoxNbArticle.ForeColor = System.Drawing.Color.White;
            this.textBoxNbArticle.Location = new System.Drawing.Point(49, 368);
            this.textBoxNbArticle.Margin = new System.Windows.Forms.Padding(2, 8, 2, 8);
            this.textBoxNbArticle.Name = "textBoxNbArticle";
            this.textBoxNbArticle.Size = new System.Drawing.Size(126, 27);
            this.textBoxNbArticle.TabIndex = 5;
            // 
            // tableauStock
            // 
            this.tableauStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableauStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableauStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableauStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nomArticle,
            this.dataGridViewTextBoxColumn2,
            this.quantite,
            this.prixUnitaire,
            this.dataGridViewTextBoxColumn3});
            this.tableauStock.Location = new System.Drawing.Point(38, 105);
            this.tableauStock.Margin = new System.Windows.Forms.Padding(2);
            this.tableauStock.MultiSelect = false;
            this.tableauStock.Name = "tableauStock";
            this.tableauStock.ReadOnly = true;
            this.tableauStock.RowHeadersWidth = 62;
            this.tableauStock.RowTemplate.Height = 33;
            this.tableauStock.Size = new System.Drawing.Size(449, 555);
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
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDate.Location = new System.Drawing.Point(1311, 63);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(109, 19);
            this.labelDate.TabIndex = 39;
            this.labelDate.Text = "JJ/MM/AAAA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.programName);
            this.panel4.Controls.Add(this.homeIcon);
            this.panel4.Controls.Add(this.dbERROR);
            this.panel4.Controls.Add(this.dbOK);
            this.panel4.Controls.Add(this.magasinSelectionne);
            this.panel4.Controls.Add(this.msgBDstatusERROR);
            this.panel4.Controls.Add(this.msgBDstatusOK);
            this.panel4.Location = new System.Drawing.Point(0, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1441, 49);
            this.panel4.TabIndex = 60;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(1284, 5);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(148, 38);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeIcon.Image = ((System.Drawing.Image)(resources.GetObject("homeIcon.Image")));
            this.homeIcon.Location = new System.Drawing.Point(317, 9);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(31, 30);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 14;
            this.homeIcon.TabStop = false;
            // 
            // dbERROR
            // 
            this.dbERROR.BackColor = System.Drawing.Color.Transparent;
            this.dbERROR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbERROR.Image = ((System.Drawing.Image)(resources.GetObject("dbERROR.Image")));
            this.dbERROR.Location = new System.Drawing.Point(21, 9);
            this.dbERROR.Name = "dbERROR";
            this.dbERROR.Size = new System.Drawing.Size(31, 30);
            this.dbERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dbERROR.TabIndex = 13;
            this.dbERROR.TabStop = false;
            this.dbERROR.Visible = false;
            // 
            // dbOK
            // 
            this.dbOK.BackColor = System.Drawing.Color.Transparent;
            this.dbOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbOK.Image = ((System.Drawing.Image)(resources.GetObject("dbOK.Image")));
            this.dbOK.Location = new System.Drawing.Point(21, 9);
            this.dbOK.Name = "dbOK";
            this.dbOK.Size = new System.Drawing.Size(31, 30);
            this.dbOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dbOK.TabIndex = 12;
            this.dbOK.TabStop = false;
            // 
            // magasinSelectionne
            // 
            this.magasinSelectionne.BackColor = System.Drawing.Color.Transparent;
            this.magasinSelectionne.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.magasinSelectionne.ForeColor = System.Drawing.Color.Snow;
            this.magasinSelectionne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.magasinSelectionne.Location = new System.Drawing.Point(354, 6);
            this.magasinSelectionne.Name = "magasinSelectionne";
            this.magasinSelectionne.Size = new System.Drawing.Size(188, 38);
            this.magasinSelectionne.TabIndex = 11;
            this.magasinSelectionne.Text = "Aucun magasin sélectionné";
            this.magasinSelectionne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msgBDstatusERROR
            // 
            this.msgBDstatusERROR.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusERROR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusERROR.ForeColor = System.Drawing.Color.Tomato;
            this.msgBDstatusERROR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusERROR.Location = new System.Drawing.Point(59, 5);
            this.msgBDstatusERROR.Name = "msgBDstatusERROR";
            this.msgBDstatusERROR.Size = new System.Drawing.Size(226, 38);
            this.msgBDstatusERROR.TabIndex = 10;
            this.msgBDstatusERROR.Text = "Base de données non connectée";
            this.msgBDstatusERROR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgBDstatusERROR.Visible = false;
            // 
            // msgBDstatusOK
            // 
            this.msgBDstatusOK.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusOK.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msgBDstatusOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusOK.Location = new System.Drawing.Point(59, 5);
            this.msgBDstatusOK.Name = "msgBDstatusOK";
            this.msgBDstatusOK.Size = new System.Drawing.Size(212, 38);
            this.msgBDstatusOK.TabIndex = 9;
            this.msgBDstatusOK.Text = "Connecté à la base de données";
            this.msgBDstatusOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel5.Controls.Add(this.goBackButton);
            this.panel5.Location = new System.Drawing.Point(0, 692);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1441, 49);
            this.panel5.TabIndex = 61;
            // 
            // goBackButton
            // 
            this.goBackButton.AutoSize = true;
            this.goBackButton.BackColor = System.Drawing.Color.Transparent;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goBackButton.Location = new System.Drawing.Point(547, 1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(328, 47);
            this.goBackButton.TabIndex = 8;
            this.goBackButton.Text = "RETOUR À L\'ACCUEIL";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(1183, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 24);
            this.label8.TabIndex = 62;
            this.label8.Text = "Stock datant du :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(37, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 50);
            this.label3.TabIndex = 63;
            this.label3.Text = "Gestion des commandes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.buttonAjouterStk);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxValeurStk);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonSupprimerStk);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxNbArticle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(485, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 555);
            this.panel1.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonSuppStock);
            this.panel2.Controls.Add(this.buttonModifierCmd);
            this.panel2.Controls.Add(this.buttonNouvelleCmd);
            this.panel2.Location = new System.Drawing.Point(1185, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 555);
            this.panel2.TabIndex = 65;
            // 
            // AccueilStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1442, 741);
            this.Controls.Add(this.tableauStock);
            this.Controls.Add(this.tableauCommandes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelListProdStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AccueilStock";
            this.Text = "Gestion des Stocks";
            ((System.ComponentModel.ISupportInitialize)(this.tableauCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauStock)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListProdStock;
        private System.Windows.Forms.Button buttonSuppStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNouvelleCmd;
        private System.Windows.Forms.Button buttonModifierCmd;
        private System.Windows.Forms.DataGridView tableauCommandes;
        private System.Windows.Forms.DataGridView tableauStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn fournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotalTTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValeurStk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAjouterStk;
        private System.Windows.Forms.Button buttonSupprimerStk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNbArticle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox dbERROR;
        private System.Windows.Forms.PictureBox dbOK;
        private System.Windows.Forms.Label magasinSelectionne;
        private System.Windows.Forms.Label msgBDstatusERROR;
        private System.Windows.Forms.Label msgBDstatusOK;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}