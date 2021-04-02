
namespace ZumbaSoft.Fenetres_Produit
{
    partial class ModifierFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierFournisseur));
            this.listViewCommandes = new System.Windows.Forms.ListView();
            this.listViewProduits = new System.Windows.Forms.ListView();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelErreurAdr = new System.Windows.Forms.Label();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.buttonAdr = new System.Windows.Forms.Button();
            this.labelAdr = new System.Windows.Forms.Label();
            this.textBoxNewTel = new System.Windows.Forms.TextBox();
            this.textBoxContrat = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEtatContratFourni = new System.Windows.Forms.Label();
            this.labelMailfourni = new System.Windows.Forms.Label();
            this.labelNomFournisseur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundBlock1.SuspendLayout();
            this.backgroundBlock2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCommandes
            // 
            this.listViewCommandes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listViewCommandes.HideSelection = false;
            this.listViewCommandes.Location = new System.Drawing.Point(424, 159);
            this.listViewCommandes.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCommandes.Name = "listViewCommandes";
            this.listViewCommandes.Size = new System.Drawing.Size(240, 233);
            this.listViewCommandes.TabIndex = 39;
            this.listViewCommandes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewProduits
            // 
            this.listViewProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.listViewProduits.HideSelection = false;
            this.listViewProduits.Location = new System.Drawing.Point(424, 431);
            this.listViewProduits.Margin = new System.Windows.Forms.Padding(2);
            this.listViewProduits.Name = "listViewProduits";
            this.listViewProduits.Size = new System.Drawing.Size(240, 143);
            this.listViewProduits.TabIndex = 38;
            this.listViewProduits.UseCompatibleStateImageBehavior = false;
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock1.Controls.Add(this.label1);
            this.backgroundBlock1.Location = new System.Drawing.Point(0, 0);
            this.backgroundBlock1.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(713, 95);
            this.backgroundBlock1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modification d\'un fournisseur";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnuler.Location = new System.Drawing.Point(449, 11);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(110, 30);
            this.buttonAnnuler.TabIndex = 8;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnulParamMag_Click);
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Controls.Add(this.buttonOK);
            this.backgroundBlock2.Location = new System.Drawing.Point(0, 621);
            this.backgroundBlock2.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(713, 50);
            this.backgroundBlock2.TabIndex = 60;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Transparent;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOK.Location = new System.Drawing.Point(580, 11);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(110, 30);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOKParamMag_Click);
            // 
            // labelErreurAdr
            // 
            this.labelErreurAdr.AutoSize = true;
            this.labelErreurAdr.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurAdr.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurAdr.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurAdr.Location = new System.Drawing.Point(43, 514);
            this.labelErreurAdr.Name = "labelErreurAdr";
            this.labelErreurAdr.Size = new System.Drawing.Size(210, 18);
            this.labelErreurAdr.TabIndex = 59;
            this.labelErreurAdr.Text = "Veuillez saisir une adresse valide";
            this.labelErreurAdr.Visible = false;
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxAdr.Enabled = false;
            this.textBoxAdr.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxAdr.Location = new System.Drawing.Point(43, 476);
            this.textBoxAdr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(290, 27);
            this.textBoxAdr.TabIndex = 58;
            // 
            // buttonAdr
            // 
            this.buttonAdr.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdr.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdr.Location = new System.Drawing.Point(43, 544);
            this.buttonAdr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdr.Name = "buttonAdr";
            this.buttonAdr.Size = new System.Drawing.Size(157, 30);
            this.buttonAdr.TabIndex = 57;
            this.buttonAdr.Text = "Nouvelle adresse";
            this.buttonAdr.UseVisualStyleBackColor = false;
            this.buttonAdr.Click += new System.EventHandler(this.buttonAdr_Click);
            // 
            // labelAdr
            // 
            this.labelAdr.AutoSize = true;
            this.labelAdr.BackColor = System.Drawing.Color.Transparent;
            this.labelAdr.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAdr.Location = new System.Drawing.Point(39, 447);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(69, 19);
            this.labelAdr.TabIndex = 56;
            this.labelAdr.Text = "Adresse :";
            // 
            // textBoxNewTel
            // 
            this.textBoxNewTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxNewTel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewTel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNewTel.Location = new System.Drawing.Point(43, 394);
            this.textBoxNewTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewTel.Name = "textBoxNewTel";
            this.textBoxNewTel.Size = new System.Drawing.Size(290, 27);
            this.textBoxNewTel.TabIndex = 55;
            // 
            // textBoxContrat
            // 
            this.textBoxContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxContrat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContrat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxContrat.Location = new System.Drawing.Point(43, 309);
            this.textBoxContrat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContrat.Name = "textBoxContrat";
            this.textBoxContrat.Size = new System.Drawing.Size(290, 27);
            this.textBoxContrat.TabIndex = 54;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEmail.Location = new System.Drawing.Point(43, 234);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(290, 27);
            this.textBoxEmail.TabIndex = 53;
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNom.Location = new System.Drawing.Point(43, 159);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(290, 27);
            this.textBoxNom.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(39, 365);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Numéro de téléphone :";
            // 
            // labelEtatContratFourni
            // 
            this.labelEtatContratFourni.AutoSize = true;
            this.labelEtatContratFourni.BackColor = System.Drawing.Color.Transparent;
            this.labelEtatContratFourni.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEtatContratFourni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelEtatContratFourni.Location = new System.Drawing.Point(39, 283);
            this.labelEtatContratFourni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEtatContratFourni.Name = "labelEtatContratFourni";
            this.labelEtatContratFourni.Size = new System.Drawing.Size(117, 19);
            this.labelEtatContratFourni.TabIndex = 50;
            this.labelEtatContratFourni.Text = "État du contrat :";
            // 
            // labelMailfourni
            // 
            this.labelMailfourni.AutoSize = true;
            this.labelMailfourni.BackColor = System.Drawing.Color.Transparent;
            this.labelMailfourni.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMailfourni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMailfourni.Location = new System.Drawing.Point(39, 208);
            this.labelMailfourni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMailfourni.Name = "labelMailfourni";
            this.labelMailfourni.Size = new System.Drawing.Size(52, 19);
            this.labelMailfourni.TabIndex = 49;
            this.labelMailfourni.Text = "Email :";
            // 
            // labelNomFournisseur
            // 
            this.labelNomFournisseur.AutoSize = true;
            this.labelNomFournisseur.BackColor = System.Drawing.Color.Transparent;
            this.labelNomFournisseur.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomFournisseur.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNomFournisseur.Location = new System.Drawing.Point(39, 135);
            this.labelNomFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(51, 19);
            this.labelNomFournisseur.TabIndex = 48;
            this.labelNomFournisseur.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(420, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Produits :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(421, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "Commandes :";
            // 
            // ModifierFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 671);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.labelErreurAdr);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.buttonAdr);
            this.Controls.Add(this.labelAdr);
            this.Controls.Add(this.textBoxNewTel);
            this.Controls.Add(this.textBoxContrat);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelEtatContratFourni);
            this.Controls.Add(this.labelMailfourni);
            this.Controls.Add(this.labelNomFournisseur);
            this.Controls.Add(this.listViewCommandes);
            this.Controls.Add(this.listViewProduits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierFournisseur";
            this.Text = "Modification d\'un fournisseur";
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.backgroundBlock2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCommandes;
        private System.Windows.Forms.ListView listViewProduits;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelErreurAdr;
        private System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.Button buttonAdr;
        private System.Windows.Forms.Label labelAdr;
        private System.Windows.Forms.TextBox textBoxNewTel;
        private System.Windows.Forms.TextBox textBoxContrat;
        private System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEtatContratFourni;
        private System.Windows.Forms.Label labelMailfourni;
        private System.Windows.Forms.Label labelNomFournisseur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}