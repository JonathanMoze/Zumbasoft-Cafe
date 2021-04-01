
namespace ZumbaSoft.Fenetres_Ventes
{
    partial class AccueilVente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilVente));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnCB = new System.Windows.Forms.ColumnHeader();
            this.columnNomProduit = new System.Windows.Forms.ColumnHeader();
            this.columnPrixHT = new System.Windows.Forms.ColumnHeader();
            this.columnPrixTTC = new System.Windows.Forms.ColumnHeader();
            this.columnQuantite = new System.Windows.Forms.ColumnHeader();
            this.buttonCatalogueProd = new System.Windows.Forms.Button();
            this.labelCatalogue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRechercheClient = new System.Windows.Forms.TextBox();
            this.listBox1RechercheClient = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonNvClient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAnnulerCommand = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonFacture = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.labelPrixTotal = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.labelRuptureStock = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.programName = new System.Windows.Forms.Label();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.dbERROR = new System.Windows.Forms.PictureBox();
            this.dbOK = new System.Windows.Forms.PictureBox();
            this.magasinSelectionne = new System.Windows.Forms.Label();
            this.msgBDstatusERROR = new System.Windows.Forms.Label();
            this.msgBDstatusOK = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panier :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCB,
            this.columnNomProduit,
            this.columnPrixHT,
            this.columnPrixTTC,
            this.columnQuantite});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 55);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(478, 419);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnCB
            // 
            this.columnCB.Text = "Code Barre";
            this.columnCB.Width = 90;
            // 
            // columnNomProduit
            // 
            this.columnNomProduit.Text = "Nom du produit";
            this.columnNomProduit.Width = 150;
            // 
            // columnPrixHT
            // 
            this.columnPrixHT.Text = "Prix HT";
            this.columnPrixHT.Width = 70;
            // 
            // columnPrixTTC
            // 
            this.columnPrixTTC.Text = "Prix TTC";
            this.columnPrixTTC.Width = 70;
            // 
            // columnQuantite
            // 
            this.columnQuantite.Text = "Quantite";
            this.columnQuantite.Width = 70;
            // 
            // buttonCatalogueProd
            // 
            this.buttonCatalogueProd.BackColor = System.Drawing.Color.Transparent;
            this.buttonCatalogueProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatalogueProd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCatalogueProd.Location = new System.Drawing.Point(29, 83);
            this.buttonCatalogueProd.Name = "buttonCatalogueProd";
            this.buttonCatalogueProd.Size = new System.Drawing.Size(169, 42);
            this.buttonCatalogueProd.TabIndex = 3;
            this.buttonCatalogueProd.Text = "Catalogue produits";
            this.buttonCatalogueProd.UseVisualStyleBackColor = false;
            this.buttonCatalogueProd.Click += new System.EventHandler(this.buttonCatalogueProd_Click);
            // 
            // labelCatalogue
            // 
            this.labelCatalogue.BackColor = System.Drawing.Color.Transparent;
            this.labelCatalogue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCatalogue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCatalogue.Location = new System.Drawing.Point(29, 23);
            this.labelCatalogue.Name = "labelCatalogue";
            this.labelCatalogue.Size = new System.Drawing.Size(169, 40);
            this.labelCatalogue.TabIndex = 4;
            this.labelCatalogue.Text = "Ajouter un produit au panier : ";
            this.labelCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Commande effectuée par :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.labelNomClient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 114);
            this.panel1.TabIndex = 9;
            // 
            // labelNomClient
            // 
            this.labelNomClient.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNomClient.Location = new System.Drawing.Point(32, 64);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(185, 20);
            this.labelNomClient.TabIndex = 6;
            this.labelNomClient.Text = "-";
            this.labelNomClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.buttonCatalogueProd);
            this.panel2.Controls.Add(this.labelCatalogue);
            this.panel2.Location = new System.Drawing.Point(20, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 146);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(21, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 42);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(69, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client existant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // textBoxRechercheClient
            // 
            this.textBoxRechercheClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxRechercheClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxRechercheClient.Location = new System.Drawing.Point(21, 241);
            this.textBoxRechercheClient.Name = "textBoxRechercheClient";
            this.textBoxRechercheClient.PlaceholderText = "Recherche...";
            this.textBoxRechercheClient.Size = new System.Drawing.Size(250, 27);
            this.textBoxRechercheClient.TabIndex = 11;
            this.textBoxRechercheClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRechercheClient.TextChanged += new System.EventHandler(this.textBoxRechercheClient_TextChanged);
            // 
            // listBox1RechercheClient
            // 
            this.listBox1RechercheClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listBox1RechercheClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1RechercheClient.FormattingEnabled = true;
            this.listBox1RechercheClient.ItemHeight = 20;
            this.listBox1RechercheClient.Location = new System.Drawing.Point(21, 274);
            this.listBox1RechercheClient.Name = "listBox1RechercheClient";
            this.listBox1RechercheClient.Size = new System.Drawing.Size(250, 124);
            this.listBox1RechercheClient.TabIndex = 12;
            this.listBox1RechercheClient.SelectedIndexChanged += new System.EventHandler(this.listBox1RechercheClient_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel4.Controls.Add(this.buttonNvClient);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(21, 443);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 110);
            this.panel4.TabIndex = 11;
            // 
            // buttonNvClient
            // 
            this.buttonNvClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNvClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNvClient.Location = new System.Drawing.Point(50, 44);
            this.buttonNvClient.Name = "buttonNvClient";
            this.buttonNvClient.Size = new System.Drawing.Size(153, 51);
            this.buttonNvClient.TabIndex = 5;
            this.buttonNvClient.Text = "Enregistrer un nouveau client";
            this.buttonNvClient.UseVisualStyleBackColor = true;
            this.buttonNvClient.Click += new System.EventHandler(this.buttonNvClient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(69, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nouveau Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 5;
            // 
            // buttonAnnulerCommand
            // 
            this.buttonAnnulerCommand.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAnnulerCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerCommand.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnulerCommand.Location = new System.Drawing.Point(20, 525);
            this.buttonAnnulerCommand.Name = "buttonAnnulerCommand";
            this.buttonAnnulerCommand.Size = new System.Drawing.Size(228, 42);
            this.buttonAnnulerCommand.TabIndex = 5;
            this.buttonAnnulerCommand.Text = "Annuler la commande";
            this.buttonAnnulerCommand.UseVisualStyleBackColor = false;
            this.buttonAnnulerCommand.Click += new System.EventHandler(this.buttonAnnulerCommand_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel5.Controls.Add(this.buttonFacture);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(20, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 114);
            this.panel5.TabIndex = 11;
            // 
            // buttonFacture
            // 
            this.buttonFacture.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacture.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFacture.Location = new System.Drawing.Point(29, 53);
            this.buttonFacture.Name = "buttonFacture";
            this.buttonFacture.Size = new System.Drawing.Size(169, 42);
            this.buttonFacture.TabIndex = 3;
            this.buttonFacture.Text = "Valider le panier";
            this.buttonFacture.UseVisualStyleBackColor = false;
            this.buttonFacture.Click += new System.EventHandler(this.buttonFacture_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(49, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = " Valider le ticket";
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlus.Image")));
            this.buttonPlus.Location = new System.Drawing.Point(24, 517);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(50, 50);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Visible = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMoins
            // 
            this.buttonMoins.BackColor = System.Drawing.Color.Transparent;
            this.buttonMoins.FlatAppearance.BorderSize = 0;
            this.buttonMoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoins.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoins.Image")));
            this.buttonMoins.Location = new System.Drawing.Point(80, 517);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(50, 50);
            this.buttonMoins.TabIndex = 15;
            this.buttonMoins.UseVisualStyleBackColor = false;
            this.buttonMoins.Visible = false;
            this.buttonMoins.Click += new System.EventHandler(this.buttonMoins_Click);
            // 
            // labelPrixTotal
            // 
            this.labelPrixTotal.AutoSize = true;
            this.labelPrixTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelPrixTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPrixTotal.Location = new System.Drawing.Point(369, 487);
            this.labelPrixTotal.Name = "labelPrixTotal";
            this.labelPrixTotal.Size = new System.Drawing.Size(109, 20);
            this.labelPrixTotal.TabIndex = 16;
            this.labelPrixTotal.Text = "Montant total :";
            // 
            // labelErreur
            // 
            this.labelErreur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.labelErreur.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreur.Location = new System.Drawing.Point(20, 307);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(228, 68);
            this.labelErreur.TabIndex = 17;
            this.labelErreur.Text = "Erreur : veuillez vérifier qu\'un client a été selectionné et que le panier n\'est " +
    "pas vide";
            this.labelErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelErreur.Visible = false;
            // 
            // labelRuptureStock
            // 
            this.labelRuptureStock.AutoSize = true;
            this.labelRuptureStock.BackColor = System.Drawing.Color.Transparent;
            this.labelRuptureStock.ForeColor = System.Drawing.Color.Tomato;
            this.labelRuptureStock.Location = new System.Drawing.Point(69, 419);
            this.labelRuptureStock.Name = "labelRuptureStock";
            this.labelRuptureStock.Size = new System.Drawing.Size(131, 20);
            this.labelRuptureStock.TabIndex = 18;
            this.labelRuptureStock.Text = "Rupture de stock !";
            this.labelRuptureStock.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel6.Controls.Add(this.programName);
            this.panel6.Controls.Add(this.homeIcon);
            this.panel6.Controls.Add(this.dbERROR);
            this.panel6.Controls.Add(this.dbOK);
            this.panel6.Controls.Add(this.magasinSelectionne);
            this.panel6.Controls.Add(this.msgBDstatusERROR);
            this.panel6.Controls.Add(this.msgBDstatusOK);
            this.panel6.Location = new System.Drawing.Point(-1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1181, 49);
            this.panel6.TabIndex = 60;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(1021, 5);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(144, 38);
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel7.Controls.Add(this.goBackButton);
            this.panel7.Location = new System.Drawing.Point(0, 701);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1180, 49);
            this.panel7.TabIndex = 61;
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
            this.goBackButton.Location = new System.Drawing.Point(418, 1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(328, 47);
            this.goBackButton.TabIndex = 8;
            this.goBackButton.Text = "RETOUR À L\'ACCUEIL";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.textBoxRechercheClient);
            this.panel8.Controls.Add(this.listBox1RechercheClient);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Location = new System.Drawing.Point(20, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(294, 580);
            this.panel8.TabIndex = 66;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel9.Controls.Add(this.panel2);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.labelRuptureStock);
            this.panel9.Controls.Add(this.labelErreur);
            this.panel9.Controls.Add(this.buttonAnnulerCommand);
            this.panel9.Location = new System.Drawing.Point(884, 80);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(269, 580);
            this.panel9.TabIndex = 67;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel10.Controls.Add(this.labelQuantite);
            this.panel10.Controls.Add(this.labelPrixTotal);
            this.panel10.Controls.Add(this.buttonPlus);
            this.panel10.Controls.Add(this.buttonMoins);
            this.panel10.Controls.Add(this.listView1);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Location = new System.Drawing.Point(340, 80);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(523, 580);
            this.panel10.TabIndex = 68;
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelQuantite.Location = new System.Drawing.Point(24, 487);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(76, 20);
            this.labelQuantite.TabIndex = 17;
            this.labelQuantite.Text = "Quantité :";
            // 
            // AccueilVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1176, 750);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AccueilVente";
            this.Text = "AccueilVente";
            this.Load += new System.EventHandler(this.AccueilVentes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonCatalogueProd;
        private System.Windows.Forms.Label labelCatalogue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRechercheClient;
        private System.Windows.Forms.ListBox listBox1RechercheClient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAnnulerCommand;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonFacture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonNvClient;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.ColumnHeader columnCB;
        private System.Windows.Forms.ColumnHeader columnNomProduit;
        private System.Windows.Forms.ColumnHeader columnPrixHT;
        private System.Windows.Forms.ColumnHeader columnPrixTTC;
        private System.Windows.Forms.ColumnHeader columnQuantite;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMoins;
        private System.Windows.Forms.Label labelPrixTotal;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Label labelRuptureStock;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox dbERROR;
        private System.Windows.Forms.PictureBox dbOK;
        private System.Windows.Forms.Label magasinSelectionne;
        private System.Windows.Forms.Label msgBDstatusERROR;
        private System.Windows.Forms.Label msgBDstatusOK;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelQuantite;
    }
}