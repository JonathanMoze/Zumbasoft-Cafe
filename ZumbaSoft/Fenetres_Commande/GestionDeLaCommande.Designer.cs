
namespace ZumbaSoft.Fenetres_Commande
{
    partial class GestionDeLaCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeLaCommande));
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.labelRef = new System.Windows.Forms.Label();
            this.tableauProd = new System.Windows.Forms.DataGridView();
            this.id_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaire_TTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotale_TTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterProd_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalTTC = new System.Windows.Forms.TextBox();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.textBoxFournisseur = new System.Windows.Forms.TextBox();
            this.buttonPlusPrd = new System.Windows.Forms.Button();
            this.buttonMoinsPrd = new System.Windows.Forms.Button();
            this.buttonSupprimerPrd = new System.Windows.Forms.Button();
            this.checkBoxCommande = new System.Windows.Forms.CheckBox();
            this.checkBoxLivre = new System.Windows.Forms.CheckBox();
            this.checkBoxRecept = new System.Windows.Forms.CheckBox();
            this.labelDateCmd = new System.Windows.Forms.Label();
            this.textBoxCmdLe = new System.Windows.Forms.TextBox();
            this.labelMag = new System.Windows.Forms.Label();
            this.textBoxRecep = new System.Windows.Forms.TextBox();
            this.backgroundBlock = new System.Windows.Forms.Panel();
            this.backgroundBlock4 = new System.Windows.Forms.Panel();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonAnnulerCmd = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonEnregisterCmd = new System.Windows.Forms.Button();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.backgroundBlock3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableauProd)).BeginInit();
            this.backgroundBlock.SuspendLayout();
            this.backgroundBlock4.SuspendLayout();
            this.backgroundBlock2.SuspendLayout();
            this.backgroundBlock1.SuspendLayout();
            this.backgroundBlock3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRef
            // 
            this.textBoxRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxRef.Enabled = false;
            this.textBoxRef.ForeColor = System.Drawing.Color.White;
            this.textBoxRef.Location = new System.Drawing.Point(179, 143);
            this.textBoxRef.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(198, 27);
            this.textBoxRef.TabIndex = 1;
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.BackColor = System.Drawing.Color.Transparent;
            this.labelRef.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRef.Location = new System.Drawing.Point(38, 32);
            this.labelRef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(83, 20);
            this.labelRef.TabIndex = 3;
            this.labelRef.Text = "Référence :";
            // 
            // tableauProd
            // 
            this.tableauProd.AllowUserToAddRows = false;
            this.tableauProd.AllowUserToDeleteRows = false;
            this.tableauProd.AllowUserToResizeColumns = false;
            this.tableauProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produit,
            this.nom_produit,
            this.quantite_produit,
            this.prixUnitaire_TTC,
            this.prixTotale_TTC});
            this.tableauProd.Location = new System.Drawing.Point(31, 280);
            this.tableauProd.Margin = new System.Windows.Forms.Padding(2);
            this.tableauProd.Name = "tableauProd";
            this.tableauProd.RowHeadersWidth = 62;
            this.tableauProd.RowTemplate.Height = 33;
            this.tableauProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauProd.Size = new System.Drawing.Size(814, 325);
            this.tableauProd.TabIndex = 13;
            // 
            // id_produit
            // 
            this.id_produit.HeaderText = "Identifiant";
            this.id_produit.MinimumWidth = 8;
            this.id_produit.Name = "id_produit";
            this.id_produit.Width = 150;
            // 
            // nom_produit
            // 
            this.nom_produit.HeaderText = "Nom";
            this.nom_produit.MinimumWidth = 8;
            this.nom_produit.Name = "nom_produit";
            this.nom_produit.Width = 150;
            // 
            // quantite_produit
            // 
            this.quantite_produit.HeaderText = "Quantité";
            this.quantite_produit.MinimumWidth = 8;
            this.quantite_produit.Name = "quantite_produit";
            this.quantite_produit.Width = 150;
            // 
            // prixUnitaire_TTC
            // 
            this.prixUnitaire_TTC.HeaderText = "Prix unitaire TTC";
            this.prixUnitaire_TTC.MinimumWidth = 8;
            this.prixUnitaire_TTC.Name = "prixUnitaire_TTC";
            this.prixUnitaire_TTC.Width = 150;
            // 
            // prixTotale_TTC
            // 
            this.prixTotale_TTC.HeaderText = "Prix totale TTC";
            this.prixTotale_TTC.MinimumWidth = 8;
            this.prixTotale_TTC.Name = "prixTotale_TTC";
            this.prixTotale_TTC.Width = 150;
            // 
            // buttonAjouterProd_1
            // 
            this.buttonAjouterProd_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterProd_1.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAjouterProd_1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAjouterProd_1.Image")));
            this.buttonAjouterProd_1.Location = new System.Drawing.Point(14, 175);
            this.buttonAjouterProd_1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterProd_1.Name = "buttonAjouterProd_1";
            this.buttonAjouterProd_1.Size = new System.Drawing.Size(50, 51);
            this.buttonAjouterProd_1.TabIndex = 15;
            this.buttonAjouterProd_1.UseVisualStyleBackColor = true;
            this.buttonAjouterProd_1.Click += new System.EventHandler(this.buttonAjouterProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(551, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total TTC :";
            // 
            // textBoxTotalTTC
            // 
            this.textBoxTotalTTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxTotalTTC.Enabled = false;
            this.textBoxTotalTTC.ForeColor = System.Drawing.Color.White;
            this.textBoxTotalTTC.Location = new System.Drawing.Point(669, 12);
            this.textBoxTotalTTC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalTTC.Name = "textBoxTotalTTC";
            this.textBoxTotalTTC.Size = new System.Drawing.Size(125, 27);
            this.textBoxTotalTTC.TabIndex = 17;
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.BackColor = System.Drawing.Color.Transparent;
            this.labelFournisseur.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelFournisseur.Location = new System.Drawing.Point(33, 74);
            this.labelFournisseur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(98, 20);
            this.labelFournisseur.TabIndex = 19;
            this.labelFournisseur.Text = " Fournisseur :";
            // 
            // textBoxFournisseur
            // 
            this.textBoxFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxFournisseur.Enabled = false;
            this.textBoxFournisseur.ForeColor = System.Drawing.Color.White;
            this.textBoxFournisseur.Location = new System.Drawing.Point(179, 183);
            this.textBoxFournisseur.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFournisseur.Name = "textBoxFournisseur";
            this.textBoxFournisseur.Size = new System.Drawing.Size(198, 27);
            this.textBoxFournisseur.TabIndex = 20;
            // 
            // buttonPlusPrd
            // 
            this.buttonPlusPrd.Enabled = false;
            this.buttonPlusPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusPrd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlusPrd.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPlusPrd.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlusPrd.Image")));
            this.buttonPlusPrd.Location = new System.Drawing.Point(14, 16);
            this.buttonPlusPrd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlusPrd.MaximumSize = new System.Drawing.Size(200, 200);
            this.buttonPlusPrd.Name = "buttonPlusPrd";
            this.buttonPlusPrd.Size = new System.Drawing.Size(50, 51);
            this.buttonPlusPrd.TabIndex = 22;
            this.buttonPlusPrd.UseVisualStyleBackColor = true;
            this.buttonPlusPrd.Click += new System.EventHandler(this.buttonPlusPrd_Click);
            // 
            // buttonMoinsPrd
            // 
            this.buttonMoinsPrd.Enabled = false;
            this.buttonMoinsPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoinsPrd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoinsPrd.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMoinsPrd.Image = ((System.Drawing.Image)(resources.GetObject("buttonMoinsPrd.Image")));
            this.buttonMoinsPrd.Location = new System.Drawing.Point(14, 97);
            this.buttonMoinsPrd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoinsPrd.MaximumSize = new System.Drawing.Size(200, 200);
            this.buttonMoinsPrd.Name = "buttonMoinsPrd";
            this.buttonMoinsPrd.Size = new System.Drawing.Size(50, 51);
            this.buttonMoinsPrd.TabIndex = 23;
            this.buttonMoinsPrd.UseVisualStyleBackColor = true;
            this.buttonMoinsPrd.Click += new System.EventHandler(this.buttonMoinsPrd_Click);
            // 
            // buttonSupprimerPrd
            // 
            this.buttonSupprimerPrd.Enabled = false;
            this.buttonSupprimerPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerPrd.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSupprimerPrd.Image = ((System.Drawing.Image)(resources.GetObject("buttonSupprimerPrd.Image")));
            this.buttonSupprimerPrd.Location = new System.Drawing.Point(14, 256);
            this.buttonSupprimerPrd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimerPrd.MaximumSize = new System.Drawing.Size(200, 200);
            this.buttonSupprimerPrd.Name = "buttonSupprimerPrd";
            this.buttonSupprimerPrd.Size = new System.Drawing.Size(50, 51);
            this.buttonSupprimerPrd.TabIndex = 24;
            this.buttonSupprimerPrd.UseVisualStyleBackColor = true;
            this.buttonSupprimerPrd.Click += new System.EventHandler(this.buttonSupprimerPrd_Click);
            // 
            // checkBoxCommande
            // 
            this.checkBoxCommande.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxCommande.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCommande.Enabled = false;
            this.checkBoxCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCommande.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxCommande.Location = new System.Drawing.Point(760, 16);
            this.checkBoxCommande.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCommande.Name = "checkBoxCommande";
            this.checkBoxCommande.Size = new System.Drawing.Size(110, 30);
            this.checkBoxCommande.TabIndex = 6;
            this.checkBoxCommande.Text = "Commandé";
            this.checkBoxCommande.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCommande.UseVisualStyleBackColor = false;
            this.checkBoxCommande.CheckedChanged += new System.EventHandler(this.checkBoxCommande_CheckedChanged);
            // 
            // checkBoxLivre
            // 
            this.checkBoxLivre.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxLivre.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLivre.Enabled = false;
            this.checkBoxLivre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLivre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxLivre.Location = new System.Drawing.Point(760, 51);
            this.checkBoxLivre.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLivre.Name = "checkBoxLivre";
            this.checkBoxLivre.Size = new System.Drawing.Size(110, 30);
            this.checkBoxLivre.TabIndex = 7;
            this.checkBoxLivre.Text = "Livré";
            this.checkBoxLivre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxLivre.UseVisualStyleBackColor = false;
            this.checkBoxLivre.CheckedChanged += new System.EventHandler(this.checkBoxLivre_CheckedChanged);
            // 
            // checkBoxRecept
            // 
            this.checkBoxRecept.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxRecept.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRecept.Enabled = false;
            this.checkBoxRecept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRecept.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxRecept.Location = new System.Drawing.Point(760, 86);
            this.checkBoxRecept.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRecept.Name = "checkBoxRecept";
            this.checkBoxRecept.Size = new System.Drawing.Size(110, 30);
            this.checkBoxRecept.TabIndex = 8;
            this.checkBoxRecept.Text = "Réceptionné";
            this.checkBoxRecept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRecept.UseVisualStyleBackColor = false;
            this.checkBoxRecept.CheckedChanged += new System.EventHandler(this.checkBoxRecept_CheckedChanged);
            // 
            // labelDateCmd
            // 
            this.labelDateCmd.AutoSize = true;
            this.labelDateCmd.BackColor = System.Drawing.Color.Transparent;
            this.labelDateCmd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDateCmd.Location = new System.Drawing.Point(414, 34);
            this.labelDateCmd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateCmd.Name = "labelDateCmd";
            this.labelDateCmd.Size = new System.Drawing.Size(111, 20);
            this.labelDateCmd.TabIndex = 9;
            this.labelDateCmd.Text = "Commandé le :";
            // 
            // textBoxCmdLe
            // 
            this.textBoxCmdLe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxCmdLe.Enabled = false;
            this.textBoxCmdLe.ForeColor = System.Drawing.Color.White;
            this.textBoxCmdLe.Location = new System.Drawing.Point(554, 31);
            this.textBoxCmdLe.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCmdLe.Name = "textBoxCmdLe";
            this.textBoxCmdLe.Size = new System.Drawing.Size(121, 27);
            this.textBoxCmdLe.TabIndex = 11;
            // 
            // labelMag
            // 
            this.labelMag.AutoSize = true;
            this.labelMag.BackColor = System.Drawing.Color.Transparent;
            this.labelMag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMag.Location = new System.Drawing.Point(414, 74);
            this.labelMag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMag.Name = "labelMag";
            this.labelMag.Size = new System.Drawing.Size(99, 20);
            this.labelMag.TabIndex = 4;
            this.labelMag.Text = "Réception le :";
            // 
            // textBoxRecep
            // 
            this.textBoxRecep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxRecep.Enabled = false;
            this.textBoxRecep.ForeColor = System.Drawing.Color.White;
            this.textBoxRecep.Location = new System.Drawing.Point(554, 71);
            this.textBoxRecep.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRecep.Name = "textBoxRecep";
            this.textBoxRecep.Size = new System.Drawing.Size(121, 27);
            this.textBoxRecep.TabIndex = 2;
            // 
            // backgroundBlock
            // 
            this.backgroundBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock.Controls.Add(this.buttonPlusPrd);
            this.backgroundBlock.Controls.Add(this.buttonAjouterProd_1);
            this.backgroundBlock.Controls.Add(this.buttonMoinsPrd);
            this.backgroundBlock.Controls.Add(this.buttonSupprimerPrd);
            this.backgroundBlock.Location = new System.Drawing.Point(867, 280);
            this.backgroundBlock.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock.Name = "backgroundBlock";
            this.backgroundBlock.Size = new System.Drawing.Size(78, 325);
            this.backgroundBlock.TabIndex = 27;
            // 
            // backgroundBlock4
            // 
            this.backgroundBlock4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock4.Controls.Add(this.label1);
            this.backgroundBlock4.Controls.Add(this.textBoxTotalTTC);
            this.backgroundBlock4.Location = new System.Drawing.Point(31, 626);
            this.backgroundBlock4.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock4.Name = "backgroundBlock4";
            this.backgroundBlock4.Size = new System.Drawing.Size(814, 51);
            this.backgroundBlock4.TabIndex = 28;
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonAnnulerCmd);
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Controls.Add(this.buttonEnregisterCmd);
            this.backgroundBlock2.Location = new System.Drawing.Point(0, 702);
            this.backgroundBlock2.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(976, 54);
            this.backgroundBlock2.TabIndex = 75;
            // 
            // buttonAnnulerCmd
            // 
            this.buttonAnnulerCmd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnulerCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerCmd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnulerCmd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnulerCmd.Location = new System.Drawing.Point(523, 13);
            this.buttonAnnulerCmd.Name = "buttonAnnulerCmd";
            this.buttonAnnulerCmd.Size = new System.Drawing.Size(197, 29);
            this.buttonAnnulerCmd.TabIndex = 64;
            this.buttonAnnulerCmd.Text = "Annuler la commande";
            this.buttonAnnulerCmd.UseVisualStyleBackColor = false;
            this.buttonAnnulerCmd.Click += new System.EventHandler(this.buttonAnnulerCmd_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnuler.Location = new System.Drawing.Point(31, 13);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(105, 29);
            this.buttonAnnuler.TabIndex = 63;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonEnregisterCmd
            // 
            this.buttonEnregisterCmd.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnregisterCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnregisterCmd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEnregisterCmd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEnregisterCmd.Location = new System.Drawing.Point(739, 13);
            this.buttonEnregisterCmd.Name = "buttonEnregisterCmd";
            this.buttonEnregisterCmd.Size = new System.Drawing.Size(216, 29);
            this.buttonEnregisterCmd.TabIndex = 47;
            this.buttonEnregisterCmd.Text = "Enregistrer la commande";
            this.buttonEnregisterCmd.UseVisualStyleBackColor = false;
            this.buttonEnregisterCmd.Click += new System.EventHandler(this.buttonEnregisterCmd_Click);
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock1.Controls.Add(this.labelTitle);
            this.backgroundBlock1.Location = new System.Drawing.Point(0, -1);
            this.backgroundBlock1.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(976, 84);
            this.backgroundBlock1.TabIndex = 76;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(24, 24);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(368, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Gestion d\'une commande";
            // 
            // backgroundBlock3
            // 
            this.backgroundBlock3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock3.Controls.Add(this.labelRef);
            this.backgroundBlock3.Controls.Add(this.labelMag);
            this.backgroundBlock3.Controls.Add(this.labelFournisseur);
            this.backgroundBlock3.Controls.Add(this.labelDateCmd);
            this.backgroundBlock3.Controls.Add(this.textBoxRecep);
            this.backgroundBlock3.Controls.Add(this.textBoxCmdLe);
            this.backgroundBlock3.Controls.Add(this.checkBoxRecept);
            this.backgroundBlock3.Controls.Add(this.checkBoxCommande);
            this.backgroundBlock3.Controls.Add(this.checkBoxLivre);
            this.backgroundBlock3.Location = new System.Drawing.Point(31, 112);
            this.backgroundBlock3.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock3.Name = "backgroundBlock3";
            this.backgroundBlock3.Size = new System.Drawing.Size(914, 132);
            this.backgroundBlock3.TabIndex = 77;
            // 
            // GestionDeLaCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 754);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.textBoxFournisseur);
            this.Controls.Add(this.tableauProd);
            this.Controls.Add(this.textBoxRef);
            this.Controls.Add(this.backgroundBlock);
            this.Controls.Add(this.backgroundBlock4);
            this.Controls.Add(this.backgroundBlock3);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionDeLaCommande";
            this.Text = "Gestion Commande";
            ((System.ComponentModel.ISupportInitialize)(this.tableauProd)).EndInit();
            this.backgroundBlock.ResumeLayout(false);
            this.backgroundBlock4.ResumeLayout(false);
            this.backgroundBlock4.PerformLayout();
            this.backgroundBlock2.ResumeLayout(false);
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.backgroundBlock3.ResumeLayout(false);
            this.backgroundBlock3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.DataGridView tableauProd;
        private System.Windows.Forms.Button buttonAjouterProd_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalTTC;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.TextBox textBoxFournisseur;
        private System.Windows.Forms.Button buttonPlusPrd;
        private System.Windows.Forms.Button buttonMoinsPrd;
        private System.Windows.Forms.Button buttonSupprimerPrd;
        private System.Windows.Forms.CheckBox checkBoxCommande;
        private System.Windows.Forms.CheckBox checkBoxLivre;
        private System.Windows.Forms.CheckBox checkBoxRecept;
        private System.Windows.Forms.Label labelDateCmd;
        private System.Windows.Forms.TextBox textBoxCmdLe;
        private System.Windows.Forms.Label labelMag;
        private System.Windows.Forms.TextBox textBoxRecep;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaire_TTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotale_TTC;
        private System.Windows.Forms.Panel backgroundBlock;
        private System.Windows.Forms.Panel backgroundBlock4;
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonEnregisterCmd;
        private System.Windows.Forms.Button buttonAnnulerCmd;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel backgroundBlock3;
    }
}