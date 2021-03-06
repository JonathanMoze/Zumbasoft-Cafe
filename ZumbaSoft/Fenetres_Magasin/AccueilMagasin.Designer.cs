
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
            this.listMagasin = new System.Windows.Forms.ListBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.bottonSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.labelRapports = new System.Windows.Forms.Label();
            this.labelEmployes = new System.Windows.Forms.Label();
            this.labelCommande = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModifMdp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMagasin
            // 
            this.listMagasin.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMagasin.FormattingEnabled = true;
            this.listMagasin.ItemHeight = 30;
            this.listMagasin.Location = new System.Drawing.Point(12, 119);
            this.listMagasin.Name = "listMagasin";
            this.listMagasin.Size = new System.Drawing.Size(497, 244);
            this.listMagasin.TabIndex = 0;
            this.listMagasin.SelectedIndexChanged += new System.EventHandler(this.listMagasin_SelectedIndexChanged);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.Location = new System.Drawing.Point(13, 13);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(170, 42);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Magasins";
            // 
            // bottonSupprimer
            // 
            this.bottonSupprimer.Location = new System.Drawing.Point(0, 0);
            this.bottonSupprimer.Name = "bottonSupprimer";
            this.bottonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.bottonSupprimer.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des magasins :";
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(1592, 579);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(112, 39);
            this.buttonAccueil.TabIndex = 6;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1176, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ajouter";
            // 
            // labelErreurAdr
            // 
            this.labelErreurAdr.AutoSize = true;
            this.labelErreurAdr.Location = new System.Drawing.Point(1177, 226);
            this.labelErreurAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurAdr.Name = "labelErreurAdr";
            this.labelErreurAdr.Size = new System.Drawing.Size(264, 25);
            this.labelErreurAdr.TabIndex = 17;
            this.labelErreurAdr.Text = "Veuillez saisir une adresse valide";
            this.labelErreurAdr.Visible = false;
            // 
            // labelErreurNewMdp
            // 
            this.labelErreurNewMdp.AutoSize = true;
            this.labelErreurNewMdp.Location = new System.Drawing.Point(1419, 91);
            this.labelErreurNewMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurNewMdp.Name = "labelErreurNewMdp";
            this.labelErreurNewMdp.Size = new System.Drawing.Size(303, 50);
            this.labelErreurNewMdp.TabIndex = 16;
            this.labelErreurNewMdp.Text = "Veuillez saisir un mot de passe valide\r\n(compris entre 8 et 32)";
            this.labelErreurNewMdp.Visible = false;
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Enabled = false;
            this.textBoxAdr.Location = new System.Drawing.Point(1177, 191);
            this.textBoxAdr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(235, 31);
            this.textBoxAdr.TabIndex = 15;
            // 
            // buttonAdr
            // 
            this.buttonAdr.Location = new System.Drawing.Point(1420, 186);
            this.buttonAdr.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdr.Name = "buttonAdr";
            this.buttonAdr.Size = new System.Drawing.Size(196, 36);
            this.buttonAdr.TabIndex = 14;
            this.buttonAdr.Text = "Nouvelle adresse";
            this.buttonAdr.UseVisualStyleBackColor = true;
            this.buttonAdr.Click += new System.EventHandler(this.buttonAdr_Click);
            // 
            // labelAdr
            // 
            this.labelAdr.AutoSize = true;
            this.labelAdr.Location = new System.Drawing.Point(1177, 162);
            this.labelAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(84, 25);
            this.labelAdr.TabIndex = 13;
            this.labelAdr.Text = "Adresse :";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(1176, 256);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(118, 36);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(1177, 81);
            this.labelMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(129, 25);
            this.labelMdp.TabIndex = 11;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // textBoxNewMdp
            // 
            this.textBoxNewMdp.Location = new System.Drawing.Point(1176, 110);
            this.textBoxNewMdp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewMdp.Name = "textBoxNewMdp";
            this.textBoxNewMdp.Size = new System.Drawing.Size(235, 31);
            this.textBoxNewMdp.TabIndex = 10;
            // 
            // listViewRapports
            // 
            this.listViewRapports.HideSelection = false;
            this.listViewRapports.Location = new System.Drawing.Point(931, 404);
            this.listViewRapports.Name = "listViewRapports";
            this.listViewRapports.Size = new System.Drawing.Size(299, 214);
            this.listViewRapports.TabIndex = 55;
            this.listViewRapports.UseCompatibleStateImageBehavior = false;
            // 
            // listViewEmployes
            // 
            this.listViewEmployes.HideSelection = false;
            this.listViewEmployes.Location = new System.Drawing.Point(626, 404);
            this.listViewEmployes.Name = "listViewEmployes";
            this.listViewEmployes.Size = new System.Drawing.Size(299, 211);
            this.listViewEmployes.TabIndex = 54;
            this.listViewEmployes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCommandes
            // 
            this.listViewCommandes.HideSelection = false;
            this.listViewCommandes.Location = new System.Drawing.Point(321, 404);
            this.listViewCommandes.Name = "listViewCommandes";
            this.listViewCommandes.Size = new System.Drawing.Size(299, 214);
            this.listViewCommandes.TabIndex = 53;
            this.listViewCommandes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStock
            // 
            this.listViewStock.HideSelection = false;
            this.listViewStock.Location = new System.Drawing.Point(15, 404);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(299, 214);
            this.listViewStock.TabIndex = 52;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            // 
            // labelErrorModifMdp
            // 
            this.labelErrorModifMdp.AutoSize = true;
            this.labelErrorModifMdp.Location = new System.Drawing.Point(652, 206);
            this.labelErrorModifMdp.Name = "labelErrorModifMdp";
            this.labelErrorModifMdp.Size = new System.Drawing.Size(303, 50);
            this.labelErrorModifMdp.TabIndex = 51;
            this.labelErrorModifMdp.Text = "Veuillez saisir un mot de passe valide\r\n(compris entre 8 et 32)";
            this.labelErrorModifMdp.Visible = false;
            // 
            // buttonModifMdp
            // 
            this.buttonModifMdp.Enabled = false;
            this.buttonModifMdp.Location = new System.Drawing.Point(515, 324);
            this.buttonModifMdp.Name = "buttonModifMdp";
            this.buttonModifMdp.Size = new System.Drawing.Size(112, 39);
            this.buttonModifMdp.TabIndex = 50;
            this.buttonModifMdp.Text = "Modifier";
            this.buttonModifMdp.UseVisualStyleBackColor = true;
            this.buttonModifMdp.Click += new System.EventHandler(this.buttonModifMdp_Click);
            // 
            // buttonModifCmd
            // 
            this.buttonModifCmd.Enabled = false;
            this.buttonModifCmd.Location = new System.Drawing.Point(713, 620);
            this.buttonModifCmd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifCmd.Name = "buttonModifCmd";
            this.buttonModifCmd.Size = new System.Drawing.Size(129, 34);
            this.buttonModifCmd.TabIndex = 49;
            this.buttonModifCmd.Text = "Modifier";
            this.buttonModifCmd.UseVisualStyleBackColor = true;
            this.buttonModifCmd.Click += new System.EventHandler(this.buttonModifCmd_Click);
            // 
            // buttonModifEmpl
            // 
            this.buttonModifEmpl.Enabled = false;
            this.buttonModifEmpl.Location = new System.Drawing.Point(400, 624);
            this.buttonModifEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifEmpl.Name = "buttonModifEmpl";
            this.buttonModifEmpl.Size = new System.Drawing.Size(129, 34);
            this.buttonModifEmpl.TabIndex = 48;
            this.buttonModifEmpl.Text = "Modifier";
            this.buttonModifEmpl.UseVisualStyleBackColor = true;
            this.buttonModifEmpl.Click += new System.EventHandler(this.buttonModifEmpl_Click);
            // 
            // buttonModifRprt
            // 
            this.buttonModifRprt.Enabled = false;
            this.buttonModifRprt.Location = new System.Drawing.Point(1026, 620);
            this.buttonModifRprt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifRprt.Name = "buttonModifRprt";
            this.buttonModifRprt.Size = new System.Drawing.Size(132, 34);
            this.buttonModifRprt.TabIndex = 47;
            this.buttonModifRprt.Text = "Modifier";
            this.buttonModifRprt.UseVisualStyleBackColor = true;
            this.buttonModifRprt.Click += new System.EventHandler(this.buttonModifRprt_Click);
            // 
            // buttonModifStock
            // 
            this.buttonModifStock.Enabled = false;
            this.buttonModifStock.Location = new System.Drawing.Point(92, 623);
            this.buttonModifStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifStock.Name = "buttonModifStock";
            this.buttonModifStock.Size = new System.Drawing.Size(132, 36);
            this.buttonModifStock.TabIndex = 46;
            this.buttonModifStock.Text = "Modifier";
            this.buttonModifStock.UseVisualStyleBackColor = true;
            this.buttonModifStock.Click += new System.EventHandler(this.buttonModifStock_Click);
            // 
            // labelCurrentAdresse
            // 
            this.labelCurrentAdresse.AutoSize = true;
            this.labelCurrentAdresse.Location = new System.Drawing.Point(631, 267);
            this.labelCurrentAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentAdresse.Name = "labelCurrentAdresse";
            this.labelCurrentAdresse.Size = new System.Drawing.Size(71, 25);
            this.labelCurrentAdresse.TabIndex = 45;
            this.labelCurrentAdresse.Text = "Aucune";
            // 
            // labelCurrentMdp
            // 
            this.labelCurrentMdp.AutoSize = true;
            this.labelCurrentMdp.Location = new System.Drawing.Point(739, 119);
            this.labelCurrentMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentMdp.Name = "labelCurrentMdp";
            this.labelCurrentMdp.Size = new System.Drawing.Size(62, 25);
            this.labelCurrentMdp.TabIndex = 44;
            this.labelCurrentMdp.Text = "Aucun";
            // 
            // labelRapports
            // 
            this.labelRapports.AutoSize = true;
            this.labelRapports.Location = new System.Drawing.Point(943, 375);
            this.labelRapports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRapports.Name = "labelRapports";
            this.labelRapports.Size = new System.Drawing.Size(85, 25);
            this.labelRapports.TabIndex = 43;
            this.labelRapports.Text = "Rapports";
            // 
            // labelEmployes
            // 
            this.labelEmployes.AutoSize = true;
            this.labelEmployes.Location = new System.Drawing.Point(631, 375);
            this.labelEmployes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployes.Name = "labelEmployes";
            this.labelEmployes.Size = new System.Drawing.Size(89, 25);
            this.labelEmployes.TabIndex = 42;
            this.labelEmployes.Text = "Employés";
            // 
            // labelCommande
            // 
            this.labelCommande.AutoSize = true;
            this.labelCommande.Location = new System.Drawing.Point(317, 375);
            this.labelCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommande.Name = "labelCommande";
            this.labelCommande.Size = new System.Drawing.Size(113, 25);
            this.labelCommande.TabIndex = 41;
            this.labelCommande.Text = "Commandes";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(17, 375);
            this.labelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(55, 25);
            this.labelStock.TabIndex = 40;
            this.labelStock.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Adresse :";
            // 
            // textBoxModifMdp
            // 
            this.textBoxModifMdp.Location = new System.Drawing.Point(739, 162);
            this.textBoxModifMdp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModifMdp.Name = "textBoxModifMdp";
            this.textBoxModifMdp.Size = new System.Drawing.Size(220, 31);
            this.textBoxModifMdp.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Mot de passe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nouveau mot de passe :";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(633, 324);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(112, 39);
            this.buttonSupprimer.TabIndex = 58;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // AccueilMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 670);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewRapports);
            this.Controls.Add(this.listViewEmployes);
            this.Controls.Add(this.listViewCommandes);
            this.Controls.Add(this.listViewStock);
            this.Controls.Add(this.labelErrorModifMdp);
            this.Controls.Add(this.buttonModifMdp);
            this.Controls.Add(this.buttonModifCmd);
            this.Controls.Add(this.buttonModifEmpl);
            this.Controls.Add(this.buttonModifRprt);
            this.Controls.Add(this.buttonModifStock);
            this.Controls.Add(this.labelCurrentAdresse);
            this.Controls.Add(this.labelCurrentMdp);
            this.Controls.Add(this.labelRapports);
            this.Controls.Add(this.labelEmployes);
            this.Controls.Add(this.labelCommande);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxModifMdp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelErreurAdr);
            this.Controls.Add(this.labelErreurNewMdp);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.buttonAdr);
            this.Controls.Add(this.labelAdr);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.textBoxNewMdp);
            this.Controls.Add(this.buttonAccueil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bottonSupprimer);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.listMagasin);
            this.Name = "AccueilMagasin";
            this.Text = "AccueilMagasin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMagasin;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button bottonSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label labelRapports;
        private System.Windows.Forms.Label labelEmployes;
        private System.Windows.Forms.Label labelCommande;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModifMdp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}