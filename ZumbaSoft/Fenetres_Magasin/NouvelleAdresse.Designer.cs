
namespace ZumbaSoft.Fenetres_Magasin
{
    partial class NouvelleAdresse
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
            this.buttonOKAdr = new System.Windows.Forms.Button();
            this.labelComplement = new System.Windows.Forms.Label();
            this.textBoxComplement = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.buttonAnnulerNewAdr = new System.Windows.Forms.Button();
            this.labelErreurAdr = new System.Windows.Forms.Label();
            this.labelErreurCP = new System.Windows.Forms.Label();
            this.labelErreurVille = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOKAdr
            // 
            this.buttonOKAdr.Location = new System.Drawing.Point(91, 386);
            this.buttonOKAdr.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOKAdr.Name = "buttonOKAdr";
            this.buttonOKAdr.Size = new System.Drawing.Size(118, 36);
            this.buttonOKAdr.TabIndex = 0;
            this.buttonOKAdr.Text = "OK";
            this.buttonOKAdr.UseVisualStyleBackColor = true;
            this.buttonOKAdr.Click += new System.EventHandler(this.buttonNewAdresse_Click);
            // 
            // labelComplement
            // 
            this.labelComplement.AutoSize = true;
            this.labelComplement.Location = new System.Drawing.Point(48, 316);
            this.labelComplement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComplement.Name = "labelComplement";
            this.labelComplement.Size = new System.Drawing.Size(124, 25);
            this.labelComplement.TabIndex = 1;
            this.labelComplement.Text = "Complément :";
            // 
            // textBoxComplement
            // 
            this.textBoxComplement.Location = new System.Drawing.Point(192, 307);
            this.textBoxComplement.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComplement.Name = "textBoxComplement";
            this.textBoxComplement.Size = new System.Drawing.Size(155, 31);
            this.textBoxComplement.TabIndex = 2;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(97, 247);
            this.labelVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(53, 25);
            this.labelVille.TabIndex = 3;
            this.labelVille.Text = "Ville :";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(192, 239);
            this.textBoxVille.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(155, 31);
            this.textBoxVille.TabIndex = 5;
            this.textBoxVille.TextChanged += new System.EventHandler(this.textBoxVille_TextChanged);
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.Location = new System.Drawing.Point(59, 169);
            this.labelCodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(117, 25);
            this.labelCodePostal.TabIndex = 4;
            this.labelCodePostal.Text = "Code postal :";
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.Location = new System.Drawing.Point(192, 165);
            this.textBoxCodePostal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(155, 31);
            this.textBoxCodePostal.TabIndex = 6;
            this.textBoxCodePostal.TextChanged += new System.EventHandler(this.textBoxCodePostal_TextChanged);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(192, 101);
            this.textBoxAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(155, 31);
            this.textBoxAdresse.TabIndex = 8;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.textBoxAdresse_TextChanged);
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(91, 105);
            this.labelAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(84, 25);
            this.labelAdresse.TabIndex = 7;
            this.labelAdresse.Text = "Adresse :";
            // 
            // buttonAnnulerNewAdr
            // 
            this.buttonAnnulerNewAdr.Location = new System.Drawing.Point(231, 386);
            this.buttonAnnulerNewAdr.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnnulerNewAdr.Name = "buttonAnnulerNewAdr";
            this.buttonAnnulerNewAdr.Size = new System.Drawing.Size(118, 36);
            this.buttonAnnulerNewAdr.TabIndex = 9;
            this.buttonAnnulerNewAdr.Text = "Annuler";
            this.buttonAnnulerNewAdr.UseVisualStyleBackColor = true;
            this.buttonAnnulerNewAdr.Click += new System.EventHandler(this.buttonAnnulerNewAdr_Click);
            // 
            // labelErreurAdr
            // 
            this.labelErreurAdr.AutoSize = true;
            this.labelErreurAdr.Location = new System.Drawing.Point(379, 105);
            this.labelErreurAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurAdr.Name = "labelErreurAdr";
            this.labelErreurAdr.Size = new System.Drawing.Size(264, 25);
            this.labelErreurAdr.TabIndex = 10;
            this.labelErreurAdr.Text = "Veuillez saisir une adresse valide";
            this.labelErreurAdr.Visible = false;
            // 
            // labelErreurCP
            // 
            this.labelErreurCP.AutoSize = true;
            this.labelErreurCP.Location = new System.Drawing.Point(379, 173);
            this.labelErreurCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurCP.Name = "labelErreurCP";
            this.labelErreurCP.Size = new System.Drawing.Size(288, 25);
            this.labelErreurCP.TabIndex = 11;
            this.labelErreurCP.Text = "Veuillez saisir un code postal valide";
            this.labelErreurCP.Visible = false;
            // 
            // labelErreurVille
            // 
            this.labelErreurVille.AutoSize = true;
            this.labelErreurVille.Location = new System.Drawing.Point(379, 247);
            this.labelErreurVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurVille.Name = "labelErreurVille";
            this.labelErreurVille.Size = new System.Drawing.Size(234, 25);
            this.labelErreurVille.TabIndex = 12;
            this.labelErreurVille.Text = "Veuillez saisir une ville valide";
            this.labelErreurVille.Visible = false;
            // 
            // NouvelleAdresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 463);
            this.Controls.Add(this.labelErreurVille);
            this.Controls.Add(this.labelErreurCP);
            this.Controls.Add(this.labelErreurAdr);
            this.Controls.Add(this.buttonAnnulerNewAdr);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.textBoxComplement);
            this.Controls.Add(this.labelComplement);
            this.Controls.Add(this.buttonOKAdr);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NouvelleAdresse";
            this.Text = "NouvelleAdresse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOKAdr;
        private System.Windows.Forms.Label labelComplement;
        private System.Windows.Forms.TextBox textBoxComplement;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label labelCodePostal;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Button buttonAnnulerNewAdr;
        private System.Windows.Forms.Label labelErreurAdr;
        private System.Windows.Forms.Label labelErreurCP;
        private System.Windows.Forms.Label labelErreurVille;
    }
}