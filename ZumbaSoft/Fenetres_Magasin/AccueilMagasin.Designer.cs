
namespace ZumbaSoft.Fenetres_Magasin
{
    partial class AccueilMagasin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilMagasin));
            this.listMagasin = new System.Windows.Forms.ListBox();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.labelErreurAdr = new System.Windows.Forms.Label();
            this.labelErreurNewMdp = new System.Windows.Forms.Label();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.buttonAdr = new System.Windows.Forms.Button();
            this.labelAdr = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.labelMdp = new System.Windows.Forms.Label();
            this.textBoxNewMdp = new System.Windows.Forms.TextBox();
            this.listViewRapports = new System.Windows.Forms.ListView();
            this.listViewEmployes = new System.Windows.Forms.ListView();
            this.listViewCommandes = new System.Windows.Forms.ListView();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.labelErrorModifMdp = new System.Windows.Forms.Label();
            this.buttonModifMdp = new System.Windows.Forms.Button();
            this.buttonModifCmd = new System.Windows.Forms.Button();
            this.buttonModifEmpl = new System.Windows.Forms.Button();
            this.buttonModifRprt = new System.Windows.Forms.Button();
            this.buttonModifStock = new System.Windows.Forms.Button();
            this.labelCurrentAdresse = new System.Windows.Forms.Label();
            this.labelCurrentMdp = new System.Windows.Forms.Label();
            this.labelEmployes = new System.Windows.Forms.Label();
            this.labelCommande = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModifMdp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.programName = new System.Windows.Forms.Label();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.dbERROR = new System.Windows.Forms.PictureBox();
            this.dbOK = new System.Windows.Forms.PictureBox();
            this.magasinSelectionne = new System.Windows.Forms.Label();
            this.msgBDstatusERROR = new System.Windows.Forms.Label();
            this.msgBDstatusOK = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panelERROR = new System.Windows.Forms.Panel();
            this.buttonBackHome = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonContactAdmin = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelERROR.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMagasin
            // 
            this.listMagasin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listMagasin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMagasin.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMagasin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listMagasin.FormattingEnabled = true;
            this.listMagasin.ItemHeight = 27;
            this.listMagasin.Location = new System.Drawing.Point(0, 53);
            this.listMagasin.Name = "listMagasin";
            this.listMagasin.Size = new System.Drawing.Size(232, 243);
            this.listMagasin.TabIndex = 0;
            this.listMagasin.SelectedIndexChanged += new System.EventHandler(this.listMagasin_SelectedIndexChanged);
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(1751, 556);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(123, 37);
            this.buttonAccueil.TabIndex = 6;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // labelErreurAdr
            // 
            this.labelErreurAdr.AutoSize = true;
            this.labelErreurAdr.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurAdr.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurAdr.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurAdr.Location = new System.Drawing.Point(25, 220);
            this.labelErreurAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurAdr.Name = "labelErreurAdr";
            this.labelErreurAdr.Size = new System.Drawing.Size(252, 21);
            this.labelErreurAdr.TabIndex = 17;
            this.labelErreurAdr.Text = "Veuillez saisir une adresse valide";
            this.labelErreurAdr.Visible = false;
            // 
            // labelErreurNewMdp
            // 
            this.labelErreurNewMdp.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurNewMdp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurNewMdp.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurNewMdp.Location = new System.Drawing.Point(25, 222);
            this.labelErreurNewMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurNewMdp.Name = "labelErreurNewMdp";
            this.labelErreurNewMdp.Size = new System.Drawing.Size(225, 65);
            this.labelErreurNewMdp.TabIndex = 16;
            this.labelErreurNewMdp.Text = "Veuillez saisir un mot de passe valide\r\n(compris entre 8 et 32)";
            this.labelErreurNewMdp.Visible = false;
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxAdr.Enabled = false;
            this.textBoxAdr.ForeColor = System.Drawing.Color.White;
            this.textBoxAdr.Location = new System.Drawing.Point(25, 176);
            this.textBoxAdr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(174, 30);
            this.textBoxAdr.TabIndex = 15;
            // 
            // buttonAdr
            // 
            this.buttonAdr.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdr.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdr.Location = new System.Drawing.Point(221, 174);
            this.buttonAdr.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdr.Name = "buttonAdr";
            this.buttonAdr.Size = new System.Drawing.Size(178, 35);
            this.buttonAdr.TabIndex = 14;
            this.buttonAdr.Text = "Nouvelle adresse";
            this.buttonAdr.UseVisualStyleBackColor = false;
            this.buttonAdr.Click += new System.EventHandler(this.buttonAdr_Click);
            // 
            // labelAdr
            // 
            this.labelAdr.AutoSize = true;
            this.labelAdr.BackColor = System.Drawing.Color.Transparent;
            this.labelAdr.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdr.ForeColor = System.Drawing.Color.White;
            this.labelAdr.Location = new System.Drawing.Point(25, 148);
            this.labelAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(84, 24);
            this.labelAdr.TabIndex = 13;
            this.labelAdr.Text = "Adresse :";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Transparent;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAjouter.Location = new System.Drawing.Point(269, 250);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(130, 35);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.BackColor = System.Drawing.Color.Transparent;
            this.labelMdp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMdp.ForeColor = System.Drawing.Color.White;
            this.labelMdp.Location = new System.Drawing.Point(215, 68);
            this.labelMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(130, 24);
            this.labelMdp.TabIndex = 11;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // textBoxNewMdp
            // 
            this.textBoxNewMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxNewMdp.ForeColor = System.Drawing.Color.White;
            this.textBoxNewMdp.Location = new System.Drawing.Point(221, 104);
            this.textBoxNewMdp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewMdp.Name = "textBoxNewMdp";
            this.textBoxNewMdp.Size = new System.Drawing.Size(178, 30);
            this.textBoxNewMdp.TabIndex = 10;
            // 
            // listViewRapports
            // 
            this.listViewRapports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listViewRapports.ForeColor = System.Drawing.Color.White;
            this.listViewRapports.HideSelection = false;
            this.listViewRapports.Location = new System.Drawing.Point(26, 74);
            this.listViewRapports.Name = "listViewRapports";
            this.listViewRapports.Size = new System.Drawing.Size(230, 150);
            this.listViewRapports.TabIndex = 55;
            this.listViewRapports.UseCompatibleStateImageBehavior = false;
            // 
            // listViewEmployes
            // 
            this.listViewEmployes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listViewEmployes.ForeColor = System.Drawing.Color.White;
            this.listViewEmployes.HideSelection = false;
            this.listViewEmployes.Location = new System.Drawing.Point(26, 104);
            this.listViewEmployes.Name = "listViewEmployes";
            this.listViewEmployes.Size = new System.Drawing.Size(215, 120);
            this.listViewEmployes.TabIndex = 54;
            this.listViewEmployes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCommandes
            // 
            this.listViewCommandes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listViewCommandes.ForeColor = System.Drawing.Color.White;
            this.listViewCommandes.HideSelection = false;
            this.listViewCommandes.Location = new System.Drawing.Point(266, 104);
            this.listViewCommandes.Name = "listViewCommandes";
            this.listViewCommandes.Size = new System.Drawing.Size(215, 120);
            this.listViewCommandes.TabIndex = 53;
            this.listViewCommandes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStock
            // 
            this.listViewStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listViewStock.ForeColor = System.Drawing.Color.White;
            this.listViewStock.HideSelection = false;
            this.listViewStock.Location = new System.Drawing.Point(508, 104);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(215, 120);
            this.listViewStock.TabIndex = 52;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            // 
            // labelErrorModifMdp
            // 
            this.labelErrorModifMdp.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorModifMdp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorModifMdp.ForeColor = System.Drawing.Color.Tomato;
            this.labelErrorModifMdp.Location = new System.Drawing.Point(21, 199);
            this.labelErrorModifMdp.Name = "labelErrorModifMdp";
            this.labelErrorModifMdp.Size = new System.Drawing.Size(327, 48);
            this.labelErrorModifMdp.TabIndex = 51;
            this.labelErrorModifMdp.Text = "Veuillez saisir un mot de passe valide\r\n(compris entre 8 et 32)";
            this.labelErrorModifMdp.Visible = false;
            // 
            // buttonModifMdp
            // 
            this.buttonModifMdp.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifMdp.Enabled = false;
            this.buttonModifMdp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifMdp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifMdp.ForeColor = System.Drawing.Color.White;
            this.buttonModifMdp.Location = new System.Drawing.Point(178, 248);
            this.buttonModifMdp.Name = "buttonModifMdp";
            this.buttonModifMdp.Size = new System.Drawing.Size(140, 37);
            this.buttonModifMdp.TabIndex = 50;
            this.buttonModifMdp.Text = "Modifier";
            this.buttonModifMdp.UseVisualStyleBackColor = false;
            this.buttonModifMdp.Click += new System.EventHandler(this.buttonModifMdp_Click);
            // 
            // buttonModifCmd
            // 
            this.buttonModifCmd.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifCmd.Enabled = false;
            this.buttonModifCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifCmd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifCmd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonModifCmd.Location = new System.Drawing.Point(26, 229);
            this.buttonModifCmd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifCmd.Name = "buttonModifCmd";
            this.buttonModifCmd.Size = new System.Drawing.Size(215, 33);
            this.buttonModifCmd.TabIndex = 49;
            this.buttonModifCmd.Text = "Modifier";
            this.buttonModifCmd.UseVisualStyleBackColor = false;
            this.buttonModifCmd.Click += new System.EventHandler(this.buttonModifCmd_Click);
            // 
            // buttonModifEmpl
            // 
            this.buttonModifEmpl.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifEmpl.Enabled = false;
            this.buttonModifEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifEmpl.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifEmpl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonModifEmpl.Location = new System.Drawing.Point(266, 229);
            this.buttonModifEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifEmpl.Name = "buttonModifEmpl";
            this.buttonModifEmpl.Size = new System.Drawing.Size(215, 33);
            this.buttonModifEmpl.TabIndex = 48;
            this.buttonModifEmpl.Text = "Modifier";
            this.buttonModifEmpl.UseVisualStyleBackColor = false;
            this.buttonModifEmpl.Click += new System.EventHandler(this.buttonModifEmpl_Click);
            // 
            // buttonModifRprt
            // 
            this.buttonModifRprt.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifRprt.Enabled = false;
            this.buttonModifRprt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifRprt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifRprt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonModifRprt.Location = new System.Drawing.Point(26, 229);
            this.buttonModifRprt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifRprt.Name = "buttonModifRprt";
            this.buttonModifRprt.Size = new System.Drawing.Size(230, 33);
            this.buttonModifRprt.TabIndex = 47;
            this.buttonModifRprt.Text = "Modifier";
            this.buttonModifRprt.UseVisualStyleBackColor = false;
            this.buttonModifRprt.Click += new System.EventHandler(this.buttonModifRprt_Click);
            // 
            // buttonModifStock
            // 
            this.buttonModifStock.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifStock.Enabled = false;
            this.buttonModifStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifStock.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonModifStock.Location = new System.Drawing.Point(508, 229);
            this.buttonModifStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifStock.Name = "buttonModifStock";
            this.buttonModifStock.Size = new System.Drawing.Size(215, 33);
            this.buttonModifStock.TabIndex = 46;
            this.buttonModifStock.Text = "Modifier";
            this.buttonModifStock.UseVisualStyleBackColor = false;
            this.buttonModifStock.Click += new System.EventHandler(this.buttonModifStock_Click);
            // 
            // labelCurrentAdresse
            // 
            this.labelCurrentAdresse.AutoSize = true;
            this.labelCurrentAdresse.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentAdresse.ForeColor = System.Drawing.Color.White;
            this.labelCurrentAdresse.Location = new System.Drawing.Point(105, 66);
            this.labelCurrentAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentAdresse.Name = "labelCurrentAdresse";
            this.labelCurrentAdresse.Size = new System.Drawing.Size(75, 24);
            this.labelCurrentAdresse.TabIndex = 45;
            this.labelCurrentAdresse.Text = "Aucune";
            // 
            // labelCurrentMdp
            // 
            this.labelCurrentMdp.AutoSize = true;
            this.labelCurrentMdp.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentMdp.ForeColor = System.Drawing.Color.White;
            this.labelCurrentMdp.Location = new System.Drawing.Point(157, 103);
            this.labelCurrentMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentMdp.Name = "labelCurrentMdp";
            this.labelCurrentMdp.Size = new System.Drawing.Size(65, 24);
            this.labelCurrentMdp.TabIndex = 44;
            this.labelCurrentMdp.Text = "Aucun";
            // 
            // labelEmployes
            // 
            this.labelEmployes.AutoSize = true;
            this.labelEmployes.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployes.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmployes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelEmployes.Location = new System.Drawing.Point(82, 65);
            this.labelEmployes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployes.Name = "labelEmployes";
            this.labelEmployes.Size = new System.Drawing.Size(98, 27);
            this.labelEmployes.TabIndex = 42;
            this.labelEmployes.Text = "Employés";
            // 
            // labelCommande
            // 
            this.labelCommande.AutoSize = true;
            this.labelCommande.BackColor = System.Drawing.Color.Transparent;
            this.labelCommande.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCommande.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCommande.Location = new System.Drawing.Point(310, 65);
            this.labelCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommande.Name = "labelCommande";
            this.labelCommande.Size = new System.Drawing.Size(127, 27);
            this.labelCommande.TabIndex = 41;
            this.labelCommande.Text = "Commandes";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelStock.Location = new System.Drawing.Point(587, 65);
            this.labelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(61, 27);
            this.labelStock.TabIndex = 40;
            this.labelStock.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Adresse :";
            // 
            // textBoxModifMdp
            // 
            this.textBoxModifMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxModifMdp.ForeColor = System.Drawing.Color.White;
            this.textBoxModifMdp.Location = new System.Drawing.Point(23, 166);
            this.textBoxModifMdp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModifMdp.Name = "textBoxModifMdp";
            this.textBoxModifMdp.Size = new System.Drawing.Size(295, 30);
            this.textBoxModifMdp.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Mot de passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 24);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nouveau mot de passe :";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSupprimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSupprimer.Location = new System.Drawing.Point(23, 248);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(140, 37);
            this.buttonSupprimer.TabIndex = 58;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel5.Controls.Add(this.goBackButton);
            this.panel5.Location = new System.Drawing.Point(2, 700);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1116, 49);
            this.panel5.TabIndex = 60;
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
            this.goBackButton.Location = new System.Drawing.Point(403, 1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(328, 47);
            this.goBackButton.TabIndex = 8;
            this.goBackButton.Text = "RETOUR À L\'ACCUEIL";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
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
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1120, 49);
            this.panel4.TabIndex = 59;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(957, 1);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(159, 49);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeIcon.Image = ((System.Drawing.Image)(resources.GetObject("homeIcon.Image")));
            this.homeIcon.Location = new System.Drawing.Point(396, 8);
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
            this.dbERROR.Location = new System.Drawing.Point(46, 9);
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
            this.dbOK.Location = new System.Drawing.Point(45, 9);
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
            this.magasinSelectionne.Location = new System.Drawing.Point(424, 0);
            this.magasinSelectionne.Name = "magasinSelectionne";
            this.magasinSelectionne.Size = new System.Drawing.Size(245, 49);
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
            this.msgBDstatusERROR.Location = new System.Drawing.Point(72, 0);
            this.msgBDstatusERROR.Name = "msgBDstatusERROR";
            this.msgBDstatusERROR.Size = new System.Drawing.Size(299, 49);
            this.msgBDstatusERROR.TabIndex = 10;
            this.msgBDstatusERROR.Text = "Base de données non connectée";
            this.msgBDstatusERROR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgBDstatusERROR.Visible = false;
            this.msgBDstatusERROR.Click += new System.EventHandler(this.msgBDstatusERROR_Click);
            // 
            // msgBDstatusOK
            // 
            this.msgBDstatusOK.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusOK.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msgBDstatusOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusOK.Location = new System.Drawing.Point(72, 0);
            this.msgBDstatusOK.Name = "msgBDstatusOK";
            this.msgBDstatusOK.Size = new System.Drawing.Size(299, 49);
            this.msgBDstatusOK.TabIndex = 9;
            this.msgBDstatusOK.Text = "Connecté à la base de données";
            this.msgBDstatusOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.listMagasin);
            this.panel2.Location = new System.Drawing.Point(32, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 295);
            this.panel2.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 53);
            this.label6.TabIndex = 5;
            this.label6.Text = "Choix d\'un magasin";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modifier le magasin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonSupprimer);
            this.panel1.Controls.Add(this.textBoxModifMdp);
            this.panel1.Controls.Add(this.labelCurrentMdp);
            this.panel1.Controls.Add(this.buttonModifMdp);
            this.panel1.Controls.Add(this.labelErrorModifMdp);
            this.panel1.Controls.Add(this.labelCurrentAdresse);
            this.panel1.Location = new System.Drawing.Point(296, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 295);
            this.panel1.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.labelAdr);
            this.panel3.Controls.Add(this.textBoxAdr);
            this.panel3.Controls.Add(this.labelMdp);
            this.panel3.Controls.Add(this.textBoxNewMdp);
            this.panel3.Controls.Add(this.labelErreurAdr);
            this.panel3.Controls.Add(this.buttonAjouter);
            this.panel3.Controls.Add(this.buttonAdr);
            this.panel3.Controls.Add(this.labelErreurNewMdp);
            this.panel3.Location = new System.Drawing.Point(670, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 295);
            this.panel3.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom du magasin :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(25, 104);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 30);
            this.textBox1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 51);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ajouter un magasin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.listViewEmployes);
            this.panel6.Controls.Add(this.labelEmployes);
            this.panel6.Controls.Add(this.listViewStock);
            this.panel6.Controls.Add(this.buttonModifStock);
            this.panel6.Controls.Add(this.listViewCommandes);
            this.panel6.Controls.Add(this.labelStock);
            this.panel6.Controls.Add(this.buttonModifCmd);
            this.panel6.Controls.Add(this.buttonModifEmpl);
            this.panel6.Controls.Add(this.labelCommande);
            this.panel6.Location = new System.Drawing.Point(32, 399);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(750, 274);
            this.panel6.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(750, 51);
            this.label8.TabIndex = 5;
            this.label8.Text = "Modifier le magasin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(344, 246);
            this.label9.TabIndex = 5;
            this.label9.Text = "Modifier le magasin";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(18, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 24);
            this.label12.TabIndex = 56;
            this.label12.Text = "Nouveau mot de passe :";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(178, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 37);
            this.button2.TabIndex = 50;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 58;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Tomato;
            this.label14.Location = new System.Drawing.Point(21, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(327, 48);
            this.label14.TabIndex = 51;
            this.label14.Text = "Veuillez saisir un mot de passe valide\r\n(compris entre 8 et 32)";
            this.label14.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 166);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 31);
            this.textBox2.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(157, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 24);
            this.label13.TabIndex = 44;
            this.label13.Text = "Aucun";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "Mot de passe :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "Adresse :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.buttonModifRprt);
            this.panel7.Controls.Add(this.listViewRapports);
            this.panel7.Location = new System.Drawing.Point(813, 399);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 274);
            this.panel7.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(280, 51);
            this.label15.TabIndex = 56;
            this.label15.Text = "Rapports";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelERROR
            // 
            this.panelERROR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelERROR.Controls.Add(this.buttonBackHome);
            this.panelERROR.Controls.Add(this.label17);
            this.panelERROR.Controls.Add(this.label18);
            this.panelERROR.Controls.Add(this.buttonContactAdmin);
            this.panelERROR.Location = new System.Drawing.Point(2, 48);
            this.panelERROR.Name = "panelERROR";
            this.panelERROR.Size = new System.Drawing.Size(1120, 127);
            this.panelERROR.TabIndex = 63;
            this.panelERROR.Visible = false;
            // 
            // buttonBackHome
            // 
            this.buttonBackHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackHome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBackHome.Location = new System.Drawing.Point(850, 79);
            this.buttonBackHome.Name = "buttonBackHome";
            this.buttonBackHome.Size = new System.Drawing.Size(241, 37);
            this.buttonBackHome.TabIndex = 59;
            this.buttonBackHome.Text = "Retour à l\'accueil";
            this.buttonBackHome.UseVisualStyleBackColor = false;
            this.buttonBackHome.Click += new System.EventHandler(this.buttonBackHome_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(23, 43);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1084, 29);
            this.label17.TabIndex = 37;
            this.label17.Text = "La base de données rattachée au logiciel est introuvable. Contactez votre adminis" +
    "trateur si l\'erreur persiste après redémarrage.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(21, 13);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 25);
            this.label18.TabIndex = 39;
            this.label18.Text = "ERREUR 01";
            // 
            // buttonContactAdmin
            // 
            this.buttonContactAdmin.BackColor = System.Drawing.Color.Transparent;
            this.buttonContactAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContactAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContactAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonContactAdmin.Location = new System.Drawing.Point(590, 79);
            this.buttonContactAdmin.Name = "buttonContactAdmin";
            this.buttonContactAdmin.Size = new System.Drawing.Size(241, 37);
            this.buttonContactAdmin.TabIndex = 58;
            this.buttonContactAdmin.Text = "Contacter l\'administrateur";
            this.buttonContactAdmin.UseVisualStyleBackColor = false;
            this.buttonContactAdmin.Click += new System.EventHandler(this.buttonContactAdmin_Click);
            // 
            // AccueilMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1120, 750);
            this.Controls.Add(this.panelERROR);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonAccueil);
            this.Controls.Add(this.panel7);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AccueilMagasin";
            this.Text = "AccueilMagasin";
            this.Load += new System.EventHandler(this.AccueilMagasin_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panelERROR.ResumeLayout(false);
            this.panelERROR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listMagasin;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Label labelErreurAdr;
        private System.Windows.Forms.Label labelErreurNewMdp;
        private System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.Button buttonAdr;
        private System.Windows.Forms.Label labelAdr;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox textBoxNewMdp;
        private System.Windows.Forms.ListView listViewRapports;
        private System.Windows.Forms.ListView listViewEmployes;
        private System.Windows.Forms.ListView listViewCommandes;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.Label labelErrorModifMdp;
        private System.Windows.Forms.Button buttonModifMdp;
        private System.Windows.Forms.Button buttonModifCmd;
        private System.Windows.Forms.Button buttonModifEmpl;
        private System.Windows.Forms.Button buttonModifRprt;
        private System.Windows.Forms.Button buttonModifStock;
        private System.Windows.Forms.Label labelCurrentAdresse;
        private System.Windows.Forms.Label labelCurrentMdp;
        private System.Windows.Forms.Label labelEmployes;
        private System.Windows.Forms.Label labelCommande;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModifMdp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox dbERROR;
        private System.Windows.Forms.PictureBox dbOK;
        private System.Windows.Forms.Label magasinSelectionne;
        private System.Windows.Forms.Label msgBDstatusERROR;
        private System.Windows.Forms.Label msgBDstatusOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelERROR;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonContactAdmin;
        private System.Windows.Forms.Button buttonBackHome;
    }
}