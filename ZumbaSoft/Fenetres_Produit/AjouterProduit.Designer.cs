
namespace ZumbaSoft.Fenetres_Produit
{
    partial class AjouterProduit
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
            this.TitreAjoutProduit = new System.Windows.Forms.Label();
            this.LabelInfoGeneral = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelRef = new System.Windows.Forms.Label();
            this.labelCodeB = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelMarque = new System.Windows.Forms.Label();
            this.labelCouleur = new System.Windows.Forms.Label();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.labelAHT = new System.Windows.Forms.Label();
            this.ATTC = new System.Windows.Forms.Label();
            this.labelVHT = new System.Windows.Forms.Label();
            this.VTTC = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.textBoxCodeB = new System.Windows.Forms.TextBox();
            this.numericUpDownVHT = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAHT = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownATTC = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVTTC = new System.Windows.Forms.NumericUpDown();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.textBoxMarque = new System.Windows.Forms.TextBox();
            this.textBoxCouleur = new System.Windows.Forms.TextBox();
            this.comboBoxFournisseur = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownATTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVTTC)).BeginInit();
            this.SuspendLayout();
            // 
            // TitreAjoutProduit
            // 
            this.TitreAjoutProduit.AutoSize = true;
            this.TitreAjoutProduit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitreAjoutProduit.Location = new System.Drawing.Point(12, 9);
            this.TitreAjoutProduit.Name = "TitreAjoutProduit";
            this.TitreAjoutProduit.Size = new System.Drawing.Size(264, 38);
            this.TitreAjoutProduit.TabIndex = 2;
            this.TitreAjoutProduit.Text = "Ajouter un Produit";
            // 
            // LabelInfoGeneral
            // 
            this.LabelInfoGeneral.AutoSize = true;
            this.LabelInfoGeneral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelInfoGeneral.Location = new System.Drawing.Point(30, 71);
            this.LabelInfoGeneral.Name = "LabelInfoGeneral";
            this.LabelInfoGeneral.Size = new System.Drawing.Size(211, 28);
            this.LabelInfoGeneral.TabIndex = 3;
            this.LabelInfoGeneral.Text = "Informations générales";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(590, 71);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(112, 28);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrix.Location = new System.Drawing.Point(23, 249);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(44, 28);
            this.labelPrix.TabIndex = 5;
            this.labelPrix.Text = "Prix";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(24, 125);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(49, 20);
            this.labelNom.TabIndex = 6;
            this.labelNom.Text = "Nom :";
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.Location = new System.Drawing.Point(24, 165);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(82, 20);
            this.labelRef.TabIndex = 7;
            this.labelRef.Text = "Référence :";
            // 
            // labelCodeB
            // 
            this.labelCodeB.AutoSize = true;
            this.labelCodeB.Location = new System.Drawing.Point(24, 202);
            this.labelCodeB.Name = "labelCodeB";
            this.labelCodeB.Size = new System.Drawing.Size(92, 20);
            this.labelCodeB.TabIndex = 8;
            this.labelCodeB.Text = "Code-Barre :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(596, 141);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(106, 20);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Type d\'Article :";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(601, 272);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(55, 20);
            this.labelGenre.TabIndex = 10;
            this.labelGenre.Text = "Genre :";
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(601, 180);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(67, 20);
            this.labelMarque.TabIndex = 11;
            this.labelMarque.Text = "Marque :";
            // 
            // labelCouleur
            // 
            this.labelCouleur.AutoSize = true;
            this.labelCouleur.Location = new System.Drawing.Point(601, 227);
            this.labelCouleur.Name = "labelCouleur";
            this.labelCouleur.Size = new System.Drawing.Size(67, 20);
            this.labelCouleur.TabIndex = 12;
            this.labelCouleur.Text = "Couleur :";
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Location = new System.Drawing.Point(601, 308);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(90, 20);
            this.labelFournisseur.TabIndex = 13;
            this.labelFournisseur.Text = "Fournisseur :";
            // 
            // labelAHT
            // 
            this.labelAHT.AutoSize = true;
            this.labelAHT.Location = new System.Drawing.Point(23, 291);
            this.labelAHT.Name = "labelAHT";
            this.labelAHT.Size = new System.Drawing.Size(105, 20);
            this.labelAHT.TabIndex = 14;
            this.labelAHT.Text = "Prix Achat HT :";
            // 
            // ATTC
            // 
            this.ATTC.AutoSize = true;
            this.ATTC.Location = new System.Drawing.Point(24, 332);
            this.ATTC.Name = "ATTC";
            this.ATTC.Size = new System.Drawing.Size(110, 20);
            this.ATTC.TabIndex = 15;
            this.ATTC.Text = "Prix Achat TTC :";
            // 
            // labelVHT
            // 
            this.labelVHT.AutoSize = true;
            this.labelVHT.Location = new System.Drawing.Point(24, 374);
            this.labelVHT.Name = "labelVHT";
            this.labelVHT.Size = new System.Drawing.Size(104, 20);
            this.labelVHT.TabIndex = 16;
            this.labelVHT.Text = "Prix Vente HT :";
            // 
            // VTTC
            // 
            this.VTTC.AutoSize = true;
            this.VTTC.Location = new System.Drawing.Point(23, 413);
            this.VTTC.Name = "VTTC";
            this.VTTC.Size = new System.Drawing.Size(109, 20);
            this.VTTC.TabIndex = 17;
            this.VTTC.Text = "Prix Vente TTC :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(79, 122);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(125, 27);
            this.textBoxNom.TabIndex = 18;
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(112, 158);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(125, 27);
            this.textBoxRef.TabIndex = 19;
            // 
            // textBoxCodeB
            // 
            this.textBoxCodeB.Location = new System.Drawing.Point(122, 199);
            this.textBoxCodeB.Name = "textBoxCodeB";
            this.textBoxCodeB.Size = new System.Drawing.Size(125, 27);
            this.textBoxCodeB.TabIndex = 20;
            // 
            // numericUpDownVHT
            // 
            this.numericUpDownVHT.DecimalPlaces = 2;
            this.numericUpDownVHT.Location = new System.Drawing.Point(135, 372);
            this.numericUpDownVHT.Name = "numericUpDownVHT";
            this.numericUpDownVHT.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownVHT.TabIndex = 22;
            // 
            // numericUpDownAHT
            // 
            this.numericUpDownAHT.DecimalPlaces = 2;
            this.numericUpDownAHT.Location = new System.Drawing.Point(134, 289);
            this.numericUpDownAHT.Name = "numericUpDownAHT";
            this.numericUpDownAHT.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownAHT.TabIndex = 23;
            // 
            // numericUpDownATTC
            // 
            this.numericUpDownATTC.DecimalPlaces = 2;
            this.numericUpDownATTC.Location = new System.Drawing.Point(135, 331);
            this.numericUpDownATTC.Name = "numericUpDownATTC";
            this.numericUpDownATTC.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownATTC.TabIndex = 24;
            // 
            // numericUpDownVTTC
            // 
            this.numericUpDownVTTC.DecimalPlaces = 2;
            this.numericUpDownVTTC.Location = new System.Drawing.Point(134, 413);
            this.numericUpDownVTTC.Name = "numericUpDownVTTC";
            this.numericUpDownVTTC.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownVTTC.TabIndex = 25;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(708, 138);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(125, 27);
            this.textBoxType.TabIndex = 26;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(662, 264);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(151, 28);
            this.comboBoxGenre.TabIndex = 27;
            // 
            // textBoxMarque
            // 
            this.textBoxMarque.Location = new System.Drawing.Point(674, 177);
            this.textBoxMarque.Name = "textBoxMarque";
            this.textBoxMarque.Size = new System.Drawing.Size(125, 27);
            this.textBoxMarque.TabIndex = 28;
            // 
            // textBoxCouleur
            // 
            this.textBoxCouleur.Location = new System.Drawing.Point(674, 224);
            this.textBoxCouleur.Name = "textBoxCouleur";
            this.textBoxCouleur.Size = new System.Drawing.Size(125, 27);
            this.textBoxCouleur.TabIndex = 29;
            // 
            // comboBoxFournisseur
            // 
            this.comboBoxFournisseur.FormattingEnabled = true;
            this.comboBoxFournisseur.Location = new System.Drawing.Point(697, 308);
            this.comboBoxFournisseur.Name = "comboBoxFournisseur";
            this.comboBoxFournisseur.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFournisseur.TabIndex = 30;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(787, 455);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnuler.TabIndex = 31;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(662, 455);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(94, 29);
            this.buttonValider.TabIndex = 32;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 534);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.comboBoxFournisseur);
            this.Controls.Add(this.textBoxCouleur);
            this.Controls.Add(this.textBoxMarque);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.numericUpDownVTTC);
            this.Controls.Add(this.numericUpDownATTC);
            this.Controls.Add(this.numericUpDownAHT);
            this.Controls.Add(this.numericUpDownVHT);
            this.Controls.Add(this.textBoxCodeB);
            this.Controls.Add(this.textBoxRef);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.VTTC);
            this.Controls.Add(this.labelVHT);
            this.Controls.Add(this.ATTC);
            this.Controls.Add(this.labelAHT);
            this.Controls.Add(this.labelFournisseur);
            this.Controls.Add(this.labelCouleur);
            this.Controls.Add(this.labelMarque);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelCodeB);
            this.Controls.Add(this.labelRef);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.LabelInfoGeneral);
            this.Controls.Add(this.TitreAjoutProduit);
            this.Name = "AjouterProduit";
            this.Text = "AjouterProduit";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownATTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVTTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreAjoutProduit;
        private System.Windows.Forms.Label LabelInfoGeneral;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.Label labelCodeB;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label labelCouleur;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.Label labelAHT;
        private System.Windows.Forms.Label ATTC;
        private System.Windows.Forms.Label labelVHT;
        private System.Windows.Forms.Label VTTC;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.TextBox textBoxCodeB;
        private System.Windows.Forms.NumericUpDown numericUpDownVHT;
        private System.Windows.Forms.NumericUpDown numericUpDownAHT;
        private System.Windows.Forms.NumericUpDown numericUpDownATTC;
        private System.Windows.Forms.NumericUpDown numericUpDownVTTC;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.TextBox textBoxMarque;
        private System.Windows.Forms.TextBox textBoxCouleur;
        private System.Windows.Forms.ComboBox comboBoxFournisseur;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
    }
}