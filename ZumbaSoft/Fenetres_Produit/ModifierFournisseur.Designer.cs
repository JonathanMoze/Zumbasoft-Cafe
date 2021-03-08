
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
            this.labelCurrentNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentTelephone = new System.Windows.Forms.Label();
            this.textBoxNewTel = new System.Windows.Forms.TextBox();
            this.buttonModifTel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAnnulParamMag = new System.Windows.Forms.Button();
            this.buttonOKParamMag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCommandes
            // 
            this.listViewCommandes.HideSelection = false;
            this.listViewCommandes.Location = new System.Drawing.Point(320, 199);
            this.listViewCommandes.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCommandes.Name = "listViewCommandes";
            this.listViewCommandes.Size = new System.Drawing.Size(240, 228);
            this.listViewCommandes.TabIndex = 39;
            this.listViewCommandes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewProduits
            // 
            this.listViewProduits.HideSelection = false;
            this.listViewProduits.Location = new System.Drawing.Point(30, 199);
            this.listViewProduits.Margin = new System.Windows.Forms.Padding(2);
            this.listViewProduits.Name = "listViewProduits";
            this.listViewProduits.Size = new System.Drawing.Size(240, 228);
            this.listViewProduits.TabIndex = 38;
            this.listViewProduits.UseCompatibleStateImageBehavior = false;
            // 
            // buttonModifEmpl
            // 
            this.buttonModifEmpl.Location = new System.Drawing.Point(387, 434);
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
            this.buttonModifProduits.Location = new System.Drawing.Point(92, 433);
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
            this.labelCommande.Location = new System.Drawing.Point(322, 176);
            this.labelCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommande.Name = "labelCommande";
            this.labelCommande.Size = new System.Drawing.Size(92, 20);
            this.labelCommande.TabIndex = 35;
            this.labelCommande.Text = "Commandes";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(31, 176);
            this.labelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(63, 20);
            this.labelStock.TabIndex = 34;
            this.labelStock.Text = "Produits";
            // 
            // labelCurrentNom
            // 
            this.labelCurrentNom.AutoSize = true;
            this.labelCurrentNom.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentNom.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCurrentNom.Location = new System.Drawing.Point(90, 31);
            this.labelCurrentNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentNom.Name = "labelCurrentNom";
            this.labelCurrentNom.Size = new System.Drawing.Size(65, 19);
            this.labelCurrentNom.TabIndex = 41;
            this.labelCurrentNom.Text = "Inconnu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nom :";
            // 
            // labelCurrentTelephone
            // 
            this.labelCurrentTelephone.AutoSize = true;
            this.labelCurrentTelephone.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTelephone.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentTelephone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCurrentTelephone.Location = new System.Drawing.Point(272, 78);
            this.labelCurrentTelephone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCurrentTelephone.Name = "labelCurrentTelephone";
            this.labelCurrentTelephone.Size = new System.Drawing.Size(53, 19);
            this.labelCurrentTelephone.TabIndex = 45;
            this.labelCurrentTelephone.Text = "Aucun";
            // 
            // textBoxNewTel
            // 
            this.textBoxNewTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxNewTel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewTel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNewTel.Location = new System.Drawing.Point(131, 108);
            this.textBoxNewTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewTel.Name = "textBoxNewTel";
            this.textBoxNewTel.PlaceholderText = "veuillez entrer le nouvel numéro";
            this.textBoxNewTel.Size = new System.Drawing.Size(250, 27);
            this.textBoxNewTel.TabIndex = 44;
            // 
            // buttonModifTel
            // 
            this.buttonModifTel.Location = new System.Drawing.Point(34, 108);
            this.buttonModifTel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifTel.Name = "buttonModifTel";
            this.buttonModifTel.Size = new System.Drawing.Size(90, 27);
            this.buttonModifTel.TabIndex = 43;
            this.buttonModifTel.Text = "Modifier";
            this.buttonModifTel.UseVisualStyleBackColor = true;
            this.buttonModifTel.Click += new System.EventHandler(this.buttonModifTel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Téléphone actuel du fournisseur :";
            // 
            // buttonAnnulParamMag
            // 
            this.buttonAnnulParamMag.Location = new System.Drawing.Point(585, 532);
            this.buttonAnnulParamMag.Name = "buttonAnnulParamMag";
            this.buttonAnnulParamMag.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnulParamMag.TabIndex = 47;
            this.buttonAnnulParamMag.Text = "Annuler";
            this.buttonAnnulParamMag.UseVisualStyleBackColor = true;
            this.buttonAnnulParamMag.Click += new System.EventHandler(this.buttonAnnulParamMag_Click);
            // 
            // buttonOKParamMag
            // 
            this.buttonOKParamMag.Location = new System.Drawing.Point(585, 477);
            this.buttonOKParamMag.Name = "buttonOKParamMag";
            this.buttonOKParamMag.Size = new System.Drawing.Size(94, 30);
            this.buttonOKParamMag.TabIndex = 46;
            this.buttonOKParamMag.Text = "OK";
            this.buttonOKParamMag.UseVisualStyleBackColor = true;
            this.buttonOKParamMag.Click += new System.EventHandler(this.buttonOKParamMag_Click);
            // 
            // ModifierFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 582);
            this.Controls.Add(this.buttonAnnulParamMag);
            this.Controls.Add(this.buttonOKParamMag);
            this.Controls.Add(this.labelCurrentTelephone);
            this.Controls.Add(this.textBoxNewTel);
            this.Controls.Add(this.buttonModifTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCurrentNom);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label labelCurrentNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentTelephone;
        private System.Windows.Forms.TextBox textBoxNewTel;
        private System.Windows.Forms.Button buttonModifTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAnnulParamMag;
        private System.Windows.Forms.Button buttonOKParamMag;
    }
}