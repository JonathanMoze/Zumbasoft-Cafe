
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.labelRef = new System.Windows.Forms.Label();
            this.tableauProd = new System.Windows.Forms.DataGridView();
            this.id_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaire_TTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotale_TTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAnnulerCmd = new System.Windows.Forms.Button();
            this.buttonAjouterProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalTTC = new System.Windows.Forms.TextBox();
            this.buttonEnregisterCmd = new System.Windows.Forms.Button();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.textBoxFournisseur = new System.Windows.Forms.TextBox();
            this.buttonPlusPrd = new System.Windows.Forms.Button();
            this.buttonMoinsPrd = new System.Windows.Forms.Button();
            this.buttonSupprimerPrd = new System.Windows.Forms.Button();
            this.labelEtat = new System.Windows.Forms.Label();
            this.checkBoxCommande = new System.Windows.Forms.CheckBox();
            this.checkBoxLivre = new System.Windows.Forms.CheckBox();
            this.checkBoxRecept = new System.Windows.Forms.CheckBox();
            this.labelDateCmd = new System.Windows.Forms.Label();
            this.textBoxCmdLe = new System.Windows.Forms.TextBox();
            this.labelMag = new System.Windows.Forms.Label();
            this.textBoxRecep = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableauProd)).BeginInit();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(13, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Commande";
            // 
            // textBoxRef
            // 
            this.textBoxRef.Enabled = false;
            this.textBoxRef.Location = new System.Drawing.Point(150, 69);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(150, 31);
            this.textBoxRef.TabIndex = 1;
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.Location = new System.Drawing.Point(13, 72);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(97, 25);
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
            this.tableauProd.Location = new System.Drawing.Point(12, 233);
            this.tableauProd.Name = "tableauProd";
            this.tableauProd.RowHeadersWidth = 62;
            this.tableauProd.RowTemplate.Height = 33;
            this.tableauProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauProd.Size = new System.Drawing.Size(755, 340);
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
            // buttonAnnulerCmd
            // 
            this.buttonAnnulerCmd.Location = new System.Drawing.Point(432, 3);
            this.buttonAnnulerCmd.Name = "buttonAnnulerCmd";
            this.buttonAnnulerCmd.Size = new System.Drawing.Size(247, 34);
            this.buttonAnnulerCmd.TabIndex = 14;
            this.buttonAnnulerCmd.Text = "Annuler la commande";
            this.buttonAnnulerCmd.UseVisualStyleBackColor = true;
            this.buttonAnnulerCmd.Click += new System.EventHandler(this.buttonAnnulerCmd_Click);
            // 
            // buttonAjouterProd
            // 
            this.buttonAjouterProd.Location = new System.Drawing.Point(210, 3);
            this.buttonAjouterProd.Name = "buttonAjouterProd";
            this.buttonAjouterProd.Size = new System.Drawing.Size(216, 34);
            this.buttonAjouterProd.TabIndex = 15;
            this.buttonAjouterProd.Text = "Ajouter des produits";
            this.buttonAjouterProd.UseVisualStyleBackColor = true;
            this.buttonAjouterProd.Click += new System.EventHandler(this.buttonAjouterProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(773, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total TTC :";
            // 
            // textBoxTotalTTC
            // 
            this.textBoxTotalTTC.Enabled = false;
            this.textBoxTotalTTC.Location = new System.Drawing.Point(774, 495);
            this.textBoxTotalTTC.Name = "textBoxTotalTTC";
            this.textBoxTotalTTC.Size = new System.Drawing.Size(150, 31);
            this.textBoxTotalTTC.TabIndex = 17;
            // 
            // buttonEnregisterCmd
            // 
            this.buttonEnregisterCmd.Enabled = false;
            this.buttonEnregisterCmd.Location = new System.Drawing.Point(685, 3);
            this.buttonEnregisterCmd.Name = "buttonEnregisterCmd";
            this.buttonEnregisterCmd.Size = new System.Drawing.Size(238, 34);
            this.buttonEnregisterCmd.TabIndex = 18;
            this.buttonEnregisterCmd.Text = "Enregistrer la commande";
            this.buttonEnregisterCmd.UseVisualStyleBackColor = true;
            this.buttonEnregisterCmd.Click += new System.EventHandler(this.buttonEnregisterCmd_Click);
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Location = new System.Drawing.Point(12, 148);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(103, 25);
            this.labelFournisseur.TabIndex = 19;
            this.labelFournisseur.Text = "Fournisseur";
            // 
            // textBoxFournisseur
            // 
            this.textBoxFournisseur.Enabled = false;
            this.textBoxFournisseur.Location = new System.Drawing.Point(150, 145);
            this.textBoxFournisseur.Name = "textBoxFournisseur";
            this.textBoxFournisseur.Size = new System.Drawing.Size(150, 31);
            this.textBoxFournisseur.TabIndex = 20;
            // 
            // buttonPlusPrd
            // 
            this.buttonPlusPrd.Enabled = false;
            this.buttonPlusPrd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlusPrd.Location = new System.Drawing.Point(875, 232);
            this.buttonPlusPrd.Name = "buttonPlusPrd";
            this.buttonPlusPrd.Size = new System.Drawing.Size(71, 69);
            this.buttonPlusPrd.TabIndex = 22;
            this.buttonPlusPrd.Text = "+";
            this.buttonPlusPrd.UseVisualStyleBackColor = true;
            this.buttonPlusPrd.Click += new System.EventHandler(this.buttonPlusPrd_Click);
            // 
            // buttonMoinsPrd
            // 
            this.buttonMoinsPrd.Enabled = false;
            this.buttonMoinsPrd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoinsPrd.Location = new System.Drawing.Point(786, 232);
            this.buttonMoinsPrd.Name = "buttonMoinsPrd";
            this.buttonMoinsPrd.Size = new System.Drawing.Size(71, 69);
            this.buttonMoinsPrd.TabIndex = 23;
            this.buttonMoinsPrd.Text = "-";
            this.buttonMoinsPrd.UseVisualStyleBackColor = true;
            this.buttonMoinsPrd.Click += new System.EventHandler(this.buttonMoinsPrd_Click);
            // 
            // buttonSupprimerPrd
            // 
            this.buttonSupprimerPrd.Enabled = false;
            this.buttonSupprimerPrd.Location = new System.Drawing.Point(786, 307);
            this.buttonSupprimerPrd.Name = "buttonSupprimerPrd";
            this.buttonSupprimerPrd.Size = new System.Drawing.Size(160, 34);
            this.buttonSupprimerPrd.TabIndex = 24;
            this.buttonSupprimerPrd.Text = "Supprimer";
            this.buttonSupprimerPrd.UseVisualStyleBackColor = true;
            this.buttonSupprimerPrd.Click += new System.EventHandler(this.buttonSupprimerPrd_Click);
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(404, 68);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(51, 25);
            this.labelEtat.TabIndex = 5;
            this.labelEtat.Text = "Etat :";
            // 
            // checkBoxCommande
            // 
            this.checkBoxCommande.AutoSize = true;
            this.checkBoxCommande.Enabled = false;
            this.checkBoxCommande.Location = new System.Drawing.Point(461, 68);
            this.checkBoxCommande.Name = "checkBoxCommande";
            this.checkBoxCommande.Size = new System.Drawing.Size(131, 29);
            this.checkBoxCommande.TabIndex = 6;
            this.checkBoxCommande.Text = "Commandé";
            this.checkBoxCommande.UseVisualStyleBackColor = true;
            this.checkBoxCommande.CheckedChanged += new System.EventHandler(this.checkBoxCommande_CheckedChanged);
            // 
            // checkBoxLivre
            // 
            this.checkBoxLivre.AutoSize = true;
            this.checkBoxLivre.Enabled = false;
            this.checkBoxLivre.Location = new System.Drawing.Point(598, 68);
            this.checkBoxLivre.Name = "checkBoxLivre";
            this.checkBoxLivre.Size = new System.Drawing.Size(74, 29);
            this.checkBoxLivre.TabIndex = 7;
            this.checkBoxLivre.Text = "Livré";
            this.checkBoxLivre.UseVisualStyleBackColor = true;
            this.checkBoxLivre.CheckedChanged += new System.EventHandler(this.checkBoxLivre_CheckedChanged);
            // 
            // checkBoxRecept
            // 
            this.checkBoxRecept.AutoSize = true;
            this.checkBoxRecept.Enabled = false;
            this.checkBoxRecept.Location = new System.Drawing.Point(678, 68);
            this.checkBoxRecept.Name = "checkBoxRecept";
            this.checkBoxRecept.Size = new System.Drawing.Size(135, 29);
            this.checkBoxRecept.TabIndex = 8;
            this.checkBoxRecept.Text = "Réceptionné";
            this.checkBoxRecept.UseVisualStyleBackColor = true;
            this.checkBoxRecept.CheckedChanged += new System.EventHandler(this.checkBoxRecept_CheckedChanged);
            // 
            // labelDateCmd
            // 
            this.labelDateCmd.AutoSize = true;
            this.labelDateCmd.Location = new System.Drawing.Point(351, 109);
            this.labelDateCmd.Name = "labelDateCmd";
            this.labelDateCmd.Size = new System.Drawing.Size(132, 25);
            this.labelDateCmd.TabIndex = 9;
            this.labelDateCmd.Text = "Commandé le :";
            // 
            // textBoxCmdLe
            // 
            this.textBoxCmdLe.Enabled = false;
            this.textBoxCmdLe.Location = new System.Drawing.Point(489, 106);
            this.textBoxCmdLe.Name = "textBoxCmdLe";
            this.textBoxCmdLe.Size = new System.Drawing.Size(150, 31);
            this.textBoxCmdLe.TabIndex = 11;
            // 
            // labelMag
            // 
            this.labelMag.AutoSize = true;
            this.labelMag.Location = new System.Drawing.Point(13, 109);
            this.labelMag.Name = "labelMag";
            this.labelMag.Size = new System.Drawing.Size(117, 25);
            this.labelMag.TabIndex = 4;
            this.labelMag.Text = "Réception le :";
            // 
            // textBoxRecep
            // 
            this.textBoxRecep.Enabled = false;
            this.textBoxRecep.Location = new System.Drawing.Point(150, 106);
            this.textBoxRecep.Name = "textBoxRecep";
            this.textBoxRecep.Size = new System.Drawing.Size(150, 31);
            this.textBoxRecep.TabIndex = 2;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAnnuler);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAjouterProd);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAnnulerCmd);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonEnregisterCmd);
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(12, 579);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(941, 40);
            this.flowLayoutPanelButtons.TabIndex = 25;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(3, 3);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(201, 34);
            this.buttonAnnuler.TabIndex = 19;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Produits :";
            // 
            // GestionDeLaCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanelButtons);
            this.Controls.Add(this.buttonSupprimerPrd);
            this.Controls.Add(this.buttonMoinsPrd);
            this.Controls.Add(this.buttonPlusPrd);
            this.Controls.Add(this.textBoxFournisseur);
            this.Controls.Add(this.labelFournisseur);
            this.Controls.Add(this.textBoxTotalTTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableauProd);
            this.Controls.Add(this.textBoxCmdLe);
            this.Controls.Add(this.labelDateCmd);
            this.Controls.Add(this.checkBoxRecept);
            this.Controls.Add(this.checkBoxLivre);
            this.Controls.Add(this.checkBoxCommande);
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.labelMag);
            this.Controls.Add(this.labelRef);
            this.Controls.Add(this.textBoxRecep);
            this.Controls.Add(this.textBoxRef);
            this.Controls.Add(this.labelTitle);
            this.Name = "GestionDeLaCommande";
            this.Text = "Gestion Commande";
            ((System.ComponentModel.ISupportInitialize)(this.tableauProd)).EndInit();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.DataGridView tableauProd;
        private System.Windows.Forms.Button buttonAnnulerCmd;
        private System.Windows.Forms.Button buttonAjouterProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalTTC;
        private System.Windows.Forms.Button buttonEnregisterCmd;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.TextBox textBoxFournisseur;
        private System.Windows.Forms.Button buttonPlusPrd;
        private System.Windows.Forms.Button buttonMoinsPrd;
        private System.Windows.Forms.Button buttonSupprimerPrd;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.CheckBox checkBoxCommande;
        private System.Windows.Forms.CheckBox checkBoxLivre;
        private System.Windows.Forms.CheckBox checkBoxRecept;
        private System.Windows.Forms.Label labelDateCmd;
        private System.Windows.Forms.TextBox textBoxCmdLe;
        private System.Windows.Forms.Label labelMag;
        private System.Windows.Forms.TextBox textBoxRecep;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaire_TTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotale_TTC;
    }
}