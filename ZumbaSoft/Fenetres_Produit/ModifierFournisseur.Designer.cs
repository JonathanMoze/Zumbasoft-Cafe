
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
            this.buttonModifEmpl = new System.Windows.Forms.Button();
            this.buttonModifProduits = new System.Windows.Forms.Button();
            this.labelCommande = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNewTel = new System.Windows.Forms.TextBox();
            this.buttonModifs = new System.Windows.Forms.Button();
            this.labelTel = new System.Windows.Forms.Label();
            this.buttonAnnulParamMag = new System.Windows.Forms.Button();
            this.buttonOKParamMag = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxContrat = new System.Windows.Forms.TextBox();
            this.labelContrat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCommandes
            // 
            this.listViewCommandes.HideSelection = false;
            this.listViewCommandes.Location = new System.Drawing.Point(320, 245);
            this.listViewCommandes.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCommandes.Name = "listViewCommandes";
            this.listViewCommandes.Size = new System.Drawing.Size(240, 228);
            this.listViewCommandes.TabIndex = 39;
            this.listViewCommandes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewProduits
            // 
            this.listViewProduits.HideSelection = false;
            this.listViewProduits.Location = new System.Drawing.Point(30, 245);
            this.listViewProduits.Margin = new System.Windows.Forms.Padding(2);
            this.listViewProduits.Name = "listViewProduits";
            this.listViewProduits.Size = new System.Drawing.Size(240, 228);
            this.listViewProduits.TabIndex = 38;
            this.listViewProduits.UseCompatibleStateImageBehavior = false;
            // 
            // buttonModifEmpl
            // 
            this.buttonModifEmpl.Location = new System.Drawing.Point(387, 480);
            this.buttonModifEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifEmpl.Name = "buttonModifEmpl";
            this.buttonModifEmpl.Size = new System.Drawing.Size(103, 27);
            this.buttonModifEmpl.TabIndex = 37;
            this.buttonModifEmpl.Text = "Modifier";
            this.buttonModifEmpl.UseVisualStyleBackColor = true;
            this.buttonModifEmpl.Click += new System.EventHandler(this.buttonModifEmpl_Click);
            // 
            // buttonModifProduits
            // 
            this.buttonModifProduits.Location = new System.Drawing.Point(92, 479);
            this.buttonModifProduits.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifProduits.Name = "buttonModifProduits";
            this.buttonModifProduits.Size = new System.Drawing.Size(106, 29);
            this.buttonModifProduits.TabIndex = 36;
            this.buttonModifProduits.Text = "Modifier";
            this.buttonModifProduits.UseVisualStyleBackColor = true;
            this.buttonModifProduits.Click += new System.EventHandler(this.buttonModifProduits_Click);
            // 
            // labelCommande
            // 
            this.labelCommande.AutoSize = true;
            this.labelCommande.Location = new System.Drawing.Point(322, 222);
            this.labelCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommande.Name = "labelCommande";
            this.labelCommande.Size = new System.Drawing.Size(92, 20);
            this.labelCommande.TabIndex = 35;
            this.labelCommande.Text = "Commandes";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(31, 222);
            this.labelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(63, 20);
            this.labelStock.TabIndex = 34;
            this.labelStock.Text = "Produits";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNom.Location = new System.Drawing.Point(35, 31);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(51, 19);
            this.labelNom.TabIndex = 40;
            this.labelNom.Text = "Nom :";
            // 
            // textBoxNewTel
            // 
            this.textBoxNewTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxNewTel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewTel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNewTel.Location = new System.Drawing.Point(128, 65);
            this.textBoxNewTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewTel.Name = "textBoxNewTel";
            this.textBoxNewTel.Size = new System.Drawing.Size(250, 27);
            this.textBoxNewTel.TabIndex = 44;
            // 
            // buttonModifs
            // 
            this.buttonModifs.Location = new System.Drawing.Point(519, 69);
            this.buttonModifs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifs.Name = "buttonModifs";
            this.buttonModifs.Size = new System.Drawing.Size(169, 62);
            this.buttonModifs.TabIndex = 43;
            this.buttonModifs.Text = "Valider les modifications";
            this.buttonModifs.UseVisualStyleBackColor = true;
            this.buttonModifs.Click += new System.EventHandler(this.buttonModifs_Click);
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.BackColor = System.Drawing.Color.Transparent;
            this.labelTel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTel.Location = new System.Drawing.Point(30, 69);
            this.labelTel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(90, 19);
            this.labelTel.TabIndex = 42;
            this.labelTel.Text = " Téléphone :";
            // 
            // buttonAnnulParamMag
            // 
            this.buttonAnnulParamMag.Location = new System.Drawing.Point(669, 486);
            this.buttonAnnulParamMag.Name = "buttonAnnulParamMag";
            this.buttonAnnulParamMag.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnulParamMag.TabIndex = 47;
            this.buttonAnnulParamMag.Text = "Annuler";
            this.buttonAnnulParamMag.UseVisualStyleBackColor = true;
            this.buttonAnnulParamMag.Click += new System.EventHandler(this.buttonAnnulParamMag_Click);
            // 
            // buttonOKParamMag
            // 
            this.buttonOKParamMag.Location = new System.Drawing.Point(669, 431);
            this.buttonOKParamMag.Name = "buttonOKParamMag";
            this.buttonOKParamMag.Size = new System.Drawing.Size(94, 30);
            this.buttonOKParamMag.TabIndex = 46;
            this.buttonOKParamMag.Text = "OK";
            this.buttonOKParamMag.UseVisualStyleBackColor = true;
            this.buttonOKParamMag.Click += new System.EventHandler(this.buttonOKParamMag_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNom.Location = new System.Drawing.Point(92, 27);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(250, 27);
            this.textBoxNom.TabIndex = 48;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEmail.Location = new System.Drawing.Point(92, 104);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 27);
            this.textBoxEmail.TabIndex = 50;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMail.Location = new System.Drawing.Point(35, 112);
            this.labelMail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(52, 19);
            this.labelMail.TabIndex = 49;
            this.labelMail.Text = "Email :";
            // 
            // textBoxContrat
            // 
            this.textBoxContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxContrat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContrat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxContrat.Location = new System.Drawing.Point(110, 140);
            this.textBoxContrat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContrat.Name = "textBoxContrat";
            this.textBoxContrat.Size = new System.Drawing.Size(250, 27);
            this.textBoxContrat.TabIndex = 52;
            // 
            // labelContrat
            // 
            this.labelContrat.AutoSize = true;
            this.labelContrat.BackColor = System.Drawing.Color.Transparent;
            this.labelContrat.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContrat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelContrat.Location = new System.Drawing.Point(34, 144);
            this.labelContrat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelContrat.Name = "labelContrat";
            this.labelContrat.Size = new System.Drawing.Size(68, 19);
            this.labelContrat.TabIndex = 51;
            this.labelContrat.Text = "Contrat :";
            // 
            // ModifierFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 582);
            this.Controls.Add(this.textBoxContrat);
            this.Controls.Add(this.labelContrat);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonAnnulParamMag);
            this.Controls.Add(this.buttonOKParamMag);
            this.Controls.Add(this.textBoxNewTel);
            this.Controls.Add(this.buttonModifs);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.listViewCommandes);
            this.Controls.Add(this.listViewProduits);
            this.Controls.Add(this.buttonModifEmpl);
            this.Controls.Add(this.buttonModifProduits);
            this.Controls.Add(this.labelCommande);
            this.Controls.Add(this.labelStock);
            this.Name = "ModifierFournisseur";
            this.Text = "ModifierFournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCommandes;
        private System.Windows.Forms.ListView listViewProduits;
        private System.Windows.Forms.Button buttonModifEmpl;
        private System.Windows.Forms.Button buttonModifProduits;
        private System.Windows.Forms.Label labelCommande;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.ListView l;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNewTel;
        private System.Windows.Forms.Button buttonModifs;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Button buttonAnnulParamMag;
        private System.Windows.Forms.Button buttonOKParamMag;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxContrat;
        private System.Windows.Forms.Label labelContrat;
    }
}