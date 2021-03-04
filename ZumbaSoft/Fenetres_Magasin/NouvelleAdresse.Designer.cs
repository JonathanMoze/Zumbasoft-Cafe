
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NouvelleAdresse));
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
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.backgroundBlock2.SuspendLayout();
            this.backgroundBlock1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOKAdr
            // 
            this.buttonOKAdr.BackColor = System.Drawing.Color.Transparent;
            this.buttonOKAdr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOKAdr.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOKAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOKAdr.Location = new System.Drawing.Point(373, 14);
            this.buttonOKAdr.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOKAdr.Name = "buttonOKAdr";
            this.buttonOKAdr.Size = new System.Drawing.Size(138, 36);
            this.buttonOKAdr.TabIndex = 0;
            this.buttonOKAdr.Text = "OK";
            this.buttonOKAdr.UseVisualStyleBackColor = false;
            this.buttonOKAdr.Click += new System.EventHandler(this.buttonNewAdresse_Click);
            // 
            // labelComplement
            // 
            this.labelComplement.AutoSize = true;
            this.labelComplement.BackColor = System.Drawing.Color.Transparent;
            this.labelComplement.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComplement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelComplement.Location = new System.Drawing.Point(50, 422);
            this.labelComplement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComplement.Name = "labelComplement";
            this.labelComplement.Size = new System.Drawing.Size(125, 23);
            this.labelComplement.TabIndex = 1;
            this.labelComplement.Text = "Complément :";
            // 
            // textBoxComplement
            // 
            this.textBoxComplement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxComplement.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComplement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxComplement.Location = new System.Drawing.Point(50, 458);
            this.textBoxComplement.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComplement.Name = "textBoxComplement";
            this.textBoxComplement.Size = new System.Drawing.Size(419, 30);
            this.textBoxComplement.TabIndex = 2;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.BackColor = System.Drawing.Color.Transparent;
            this.labelVille.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVille.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelVille.Location = new System.Drawing.Point(212, 286);
            this.labelVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(53, 23);
            this.labelVille.TabIndex = 3;
            this.labelVille.Text = "Ville :";
            // 
            // textBoxVille
            // 
            this.textBoxVille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxVille.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVille.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxVille.Location = new System.Drawing.Point(212, 324);
            this.textBoxVille.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(257, 30);
            this.textBoxVille.TabIndex = 5;
            this.textBoxVille.TextChanged += new System.EventHandler(this.textBoxVille_TextChanged);
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.BackColor = System.Drawing.Color.Transparent;
            this.labelCodePostal.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCodePostal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCodePostal.Location = new System.Drawing.Point(43, 286);
            this.labelCodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(118, 23);
            this.labelCodePostal.TabIndex = 4;
            this.labelCodePostal.Text = "Code postal :";
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxCodePostal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCodePostal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCodePostal.Location = new System.Drawing.Point(50, 324);
            this.textBoxCodePostal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(134, 30);
            this.textBoxCodePostal.TabIndex = 6;
            this.textBoxCodePostal.TextChanged += new System.EventHandler(this.textBoxCodePostal_TextChanged);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxAdresse.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdresse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxAdresse.Location = new System.Drawing.Point(50, 184);
            this.textBoxAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(426, 30);
            this.textBoxAdresse.TabIndex = 8;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.textBoxAdresse_TextChanged);
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.BackColor = System.Drawing.Color.Transparent;
            this.labelAdresse.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdresse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAdresse.Location = new System.Drawing.Point(50, 143);
            this.labelAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(84, 23);
            this.labelAdresse.TabIndex = 7;
            this.labelAdresse.Text = "Adresse :";
            // 
            // buttonAnnulerNewAdr
            // 
            this.buttonAnnulerNewAdr.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnulerNewAdr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnnulerNewAdr.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnulerNewAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnulerNewAdr.Location = new System.Drawing.Point(212, 14);
            this.buttonAnnulerNewAdr.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnnulerNewAdr.Name = "buttonAnnulerNewAdr";
            this.buttonAnnulerNewAdr.Size = new System.Drawing.Size(138, 36);
            this.buttonAnnulerNewAdr.TabIndex = 9;
            this.buttonAnnulerNewAdr.Text = "Annuler";
            this.buttonAnnulerNewAdr.UseVisualStyleBackColor = false;
            this.buttonAnnulerNewAdr.Click += new System.EventHandler(this.buttonAnnulerNewAdr_Click);
            // 
            // labelErreurAdr
            // 
            this.labelErreurAdr.AutoSize = true;
            this.labelErreurAdr.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurAdr.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurAdr.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurAdr.Location = new System.Drawing.Point(50, 228);
            this.labelErreurAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurAdr.Name = "labelErreurAdr";
            this.labelErreurAdr.Size = new System.Drawing.Size(273, 23);
            this.labelErreurAdr.TabIndex = 10;
            this.labelErreurAdr.Text = "Veuillez saisir une adresse valide";
            this.labelErreurAdr.Visible = false;
            // 
            // labelErreurCP
            // 
            this.labelErreurCP.AutoSize = true;
            this.labelErreurCP.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurCP.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurCP.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurCP.Location = new System.Drawing.Point(50, 369);
            this.labelErreurCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurCP.Name = "labelErreurCP";
            this.labelErreurCP.Size = new System.Drawing.Size(296, 23);
            this.labelErreurCP.TabIndex = 11;
            this.labelErreurCP.Text = "Veuillez saisir un code postal valide";
            this.labelErreurCP.Visible = false;
            // 
            // labelErreurVille
            // 
            this.labelErreurVille.AutoSize = true;
            this.labelErreurVille.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurVille.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurVille.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurVille.Location = new System.Drawing.Point(50, 369);
            this.labelErreurVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurVille.Name = "labelErreurVille";
            this.labelErreurVille.Size = new System.Drawing.Size(241, 23);
            this.labelErreurVille.TabIndex = 12;
            this.labelErreurVille.Text = "Veuillez saisir une ville valide";
            this.labelErreurVille.Visible = false;
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonAnnulerNewAdr);
            this.backgroundBlock2.Controls.Add(this.buttonOKAdr);
            this.backgroundBlock2.Location = new System.Drawing.Point(0, 531);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(524, 63);
            this.backgroundBlock2.TabIndex = 14;
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock1.Controls.Add(this.labelTitle);
            this.backgroundBlock1.Location = new System.Drawing.Point(0, 1);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(524, 117);
            this.backgroundBlock1.TabIndex = 15;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(78, 38);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(367, 46);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Ajout d\'une adresse";
            // 
            // NouvelleAdresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(524, 594);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.labelErreurVille);
            this.Controls.Add(this.labelErreurCP);
            this.Controls.Add(this.labelErreurAdr);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxCodePostal);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.labelCodePostal);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.textBoxComplement);
            this.Controls.Add(this.labelComplement);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NouvelleAdresse";
            this.Text = "NouvelleAdresse";
            this.backgroundBlock2.ResumeLayout(false);
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
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
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label labelTitle;
    }
}