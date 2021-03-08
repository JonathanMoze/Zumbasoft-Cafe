
namespace ZumbaSoft.Fenetres_Commande
{
    partial class NouvelleCommandes
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
            this.textBoxRecep = new System.Windows.Forms.TextBox();
            this.labelRef = new System.Windows.Forms.Label();
            this.labelMag = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.checkBoxCommande = new System.Windows.Forms.CheckBox();
            this.checkBoxLivre = new System.Windows.Forms.CheckBox();
            this.checkBoxRecept = new System.Windows.Forms.CheckBox();
            this.labelDateCmd = new System.Windows.Forms.Label();
            this.labelReglement = new System.Windows.Forms.Label();
            this.textBoxCmdLe = new System.Windows.Forms.TextBox();
            this.textBoxRegl = new System.Windows.Forms.TextBox();
            this.tableauProd = new System.Windows.Forms.DataGridView();
            this.buttonAnnulerCmd = new System.Windows.Forms.Button();
            this.buttonAjouterProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEnregisterCmd = new System.Windows.Forms.Button();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.textBoxFournisseur = new System.Windows.Forms.TextBox();
            this.buttonSearchFournisseur = new System.Windows.Forms.Button();
            this.buttonPlusPrd = new System.Windows.Forms.Button();
            this.buttonMoinsPrd = new System.Windows.Forms.Button();
            this.buttonSupprimerPrd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableauProd)).BeginInit();
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
            // textBoxRecep
            // 
            this.textBoxRecep.Enabled = false;
            this.textBoxRecep.Location = new System.Drawing.Point(150, 106);
            this.textBoxRecep.Name = "textBoxRecep";
            this.textBoxRecep.Size = new System.Drawing.Size(150, 31);
            this.textBoxRecep.TabIndex = 2;
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
            // labelMag
            // 
            this.labelMag.AutoSize = true;
            this.labelMag.Location = new System.Drawing.Point(13, 109);
            this.labelMag.Name = "labelMag";
            this.labelMag.Size = new System.Drawing.Size(113, 25);
            this.labelMag.TabIndex = 4;
            this.labelMag.Text = "Réception à :";
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
            this.checkBoxCommande.Location = new System.Drawing.Point(461, 68);
            this.checkBoxCommande.Name = "checkBoxCommande";
            this.checkBoxCommande.Size = new System.Drawing.Size(131, 29);
            this.checkBoxCommande.TabIndex = 6;
            this.checkBoxCommande.Text = "Commandé";
            this.checkBoxCommande.UseVisualStyleBackColor = true;
            // 
            // checkBoxLivre
            // 
            this.checkBoxLivre.AutoSize = true;
            this.checkBoxLivre.Location = new System.Drawing.Point(598, 68);
            this.checkBoxLivre.Name = "checkBoxLivre";
            this.checkBoxLivre.Size = new System.Drawing.Size(74, 29);
            this.checkBoxLivre.TabIndex = 7;
            this.checkBoxLivre.Text = "Livré";
            this.checkBoxLivre.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecept
            // 
            this.checkBoxRecept.AutoSize = true;
            this.checkBoxRecept.Location = new System.Drawing.Point(678, 68);
            this.checkBoxRecept.Name = "checkBoxRecept";
            this.checkBoxRecept.Size = new System.Drawing.Size(135, 29);
            this.checkBoxRecept.TabIndex = 8;
            this.checkBoxRecept.Text = "Réceptionné";
            this.checkBoxRecept.UseVisualStyleBackColor = true;
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
            // labelReglement
            // 
            this.labelReglement.AutoSize = true;
            this.labelReglement.Location = new System.Drawing.Point(645, 109);
            this.labelReglement.Name = "labelReglement";
            this.labelReglement.Size = new System.Drawing.Size(82, 25);
            this.labelReglement.TabIndex = 10;
            this.labelReglement.Text = "Reglé le :";
            // 
            // textBoxCmdLe
            // 
            this.textBoxCmdLe.Location = new System.Drawing.Point(489, 106);
            this.textBoxCmdLe.Name = "textBoxCmdLe";
            this.textBoxCmdLe.Size = new System.Drawing.Size(150, 31);
            this.textBoxCmdLe.TabIndex = 11;
            this.textBoxCmdLe.Text = "JJ/MM/AAAA";
            // 
            // textBoxRegl
            // 
            this.textBoxRegl.Location = new System.Drawing.Point(725, 106);
            this.textBoxRegl.Name = "textBoxRegl";
            this.textBoxRegl.Size = new System.Drawing.Size(150, 31);
            this.textBoxRegl.TabIndex = 12;
            this.textBoxRegl.Text = "JJ/MM/AAAA";
            // 
            // tableauProd
            // 
            this.tableauProd.AllowUserToAddRows = false;
            this.tableauProd.AllowUserToDeleteRows = false;
            this.tableauProd.AllowUserToResizeColumns = false;
            this.tableauProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauProd.Location = new System.Drawing.Point(12, 194);
            this.tableauProd.Name = "tableauProd";
            this.tableauProd.RowHeadersWidth = 62;
            this.tableauProd.RowTemplate.Height = 33;
            this.tableauProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableauProd.Size = new System.Drawing.Size(755, 340);
            this.tableauProd.TabIndex = 13;
            // 
            // buttonAnnulerCmd
            // 
            this.buttonAnnulerCmd.Location = new System.Drawing.Point(12, 540);
            this.buttonAnnulerCmd.Name = "buttonAnnulerCmd";
            this.buttonAnnulerCmd.Size = new System.Drawing.Size(196, 34);
            this.buttonAnnulerCmd.TabIndex = 14;
            this.buttonAnnulerCmd.Text = "Annuler la commande";
            this.buttonAnnulerCmd.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterProd
            // 
            this.buttonAjouterProd.Location = new System.Drawing.Point(214, 540);
            this.buttonAjouterProd.Name = "buttonAjouterProd";
            this.buttonAjouterProd.Size = new System.Drawing.Size(190, 34);
            this.buttonAjouterProd.TabIndex = 15;
            this.buttonAjouterProd.Text = "Ajouter des produits";
            this.buttonAjouterProd.UseVisualStyleBackColor = true;
            this.buttonAjouterProd.Click += new System.EventHandler(this.buttonAjouterProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(773, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total TTC :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(774, 457);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 17;
            // 
            // buttonEnregisterCmd
            // 
            this.buttonEnregisterCmd.Location = new System.Drawing.Point(725, 540);
            this.buttonEnregisterCmd.Name = "buttonEnregisterCmd";
            this.buttonEnregisterCmd.Size = new System.Drawing.Size(221, 34);
            this.buttonEnregisterCmd.TabIndex = 18;
            this.buttonEnregisterCmd.Text = "Enregistrer la commande";
            this.buttonEnregisterCmd.UseVisualStyleBackColor = true;
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
            // buttonSearchFournisseur
            // 
            this.buttonSearchFournisseur.Location = new System.Drawing.Point(306, 145);
            this.buttonSearchFournisseur.Name = "buttonSearchFournisseur";
            this.buttonSearchFournisseur.Size = new System.Drawing.Size(34, 31);
            this.buttonSearchFournisseur.TabIndex = 21;
            this.buttonSearchFournisseur.Text = "...";
            this.buttonSearchFournisseur.UseVisualStyleBackColor = true;
            // 
            // buttonPlusPrd
            // 
            this.buttonPlusPrd.Enabled = false;
            this.buttonPlusPrd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlusPrd.Location = new System.Drawing.Point(875, 194);
            this.buttonPlusPrd.Name = "buttonPlusPrd";
            this.buttonPlusPrd.Size = new System.Drawing.Size(71, 69);
            this.buttonPlusPrd.TabIndex = 22;
            this.buttonPlusPrd.Text = "+";
            this.buttonPlusPrd.UseVisualStyleBackColor = true;
            // 
            // buttonMoinsPrd
            // 
            this.buttonMoinsPrd.Enabled = false;
            this.buttonMoinsPrd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMoinsPrd.Location = new System.Drawing.Point(786, 194);
            this.buttonMoinsPrd.Name = "buttonMoinsPrd";
            this.buttonMoinsPrd.Size = new System.Drawing.Size(71, 69);
            this.buttonMoinsPrd.TabIndex = 23;
            this.buttonMoinsPrd.Text = "-";
            this.buttonMoinsPrd.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerPrd
            // 
            this.buttonSupprimerPrd.Enabled = false;
            this.buttonSupprimerPrd.Location = new System.Drawing.Point(786, 269);
            this.buttonSupprimerPrd.Name = "buttonSupprimerPrd";
            this.buttonSupprimerPrd.Size = new System.Drawing.Size(160, 34);
            this.buttonSupprimerPrd.TabIndex = 24;
            this.buttonSupprimerPrd.Text = "Supprimer";
            this.buttonSupprimerPrd.UseVisualStyleBackColor = true;
            // 
            // NouvelleCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 589);
            this.Controls.Add(this.buttonSupprimerPrd);
            this.Controls.Add(this.buttonMoinsPrd);
            this.Controls.Add(this.buttonPlusPrd);
            this.Controls.Add(this.buttonSearchFournisseur);
            this.Controls.Add(this.textBoxFournisseur);
            this.Controls.Add(this.labelFournisseur);
            this.Controls.Add(this.buttonEnregisterCmd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAjouterProd);
            this.Controls.Add(this.buttonAnnulerCmd);
            this.Controls.Add(this.tableauProd);
            this.Controls.Add(this.textBoxRegl);
            this.Controls.Add(this.textBoxCmdLe);
            this.Controls.Add(this.labelReglement);
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
            this.Name = "NouvelleCommandes";
            this.Text = "NouvelleCommandes";
            ((System.ComponentModel.ISupportInitialize)(this.tableauProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.TextBox textBoxRecep;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.Label labelMag;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.CheckBox checkBoxCommande;
        private System.Windows.Forms.CheckBox checkBoxLivre;
        private System.Windows.Forms.CheckBox checkBoxRecept;
        private System.Windows.Forms.Label labelDateCmd;
        private System.Windows.Forms.Label labelReglement;
        private System.Windows.Forms.TextBox textBoxCmdLe;
        private System.Windows.Forms.TextBox textBoxRegl;
        private System.Windows.Forms.DataGridView tableauProd;
        private System.Windows.Forms.Button buttonAnnulerCmd;
        private System.Windows.Forms.Button buttonAjouterProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonEnregisterCmd;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.TextBox textBoxFournisseur;
        private System.Windows.Forms.Button buttonSearchFournisseur;
        private System.Windows.Forms.Button buttonPlusPrd;
        private System.Windows.Forms.Button buttonMoinsPrd;
        private System.Windows.Forms.Button buttonSupprimerPrd;
    }
}