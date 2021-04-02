
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
            this.labelComplement = new System.Windows.Forms.Label();
            this.textBoxComplement = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.labelCodePostal = new System.Windows.Forms.Label();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelErreurAdr = new System.Windows.Forms.Label();
            this.labelErreurCP = new System.Windows.Forms.Label();
            this.labelErreurVille = new System.Windows.Forms.Label();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundBlock2.SuspendLayout();
            this.backgroundBlock1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelComplement
            // 
            this.labelComplement.AutoSize = true;
            this.labelComplement.BackColor = System.Drawing.Color.Transparent;
            this.labelComplement.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComplement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelComplement.Location = new System.Drawing.Point(38, 299);
            this.labelComplement.Name = "labelComplement";
            this.labelComplement.Size = new System.Drawing.Size(97, 20);
            this.labelComplement.TabIndex = 1;
            this.labelComplement.Text = "Complément :";
            // 
            // textBoxComplement
            // 
            this.textBoxComplement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxComplement.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComplement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxComplement.Location = new System.Drawing.Point(154, 295);
            this.textBoxComplement.Name = "textBoxComplement";
            this.textBoxComplement.Size = new System.Drawing.Size(188, 27);
            this.textBoxComplement.TabIndex = 4;
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.BackColor = System.Drawing.Color.Transparent;
            this.labelVille.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVille.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelVille.Location = new System.Drawing.Point(78, 238);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(42, 20);
            this.labelVille.TabIndex = 3;
            this.labelVille.Text = "Ville :";
            // 
            // textBoxVille
            // 
            this.textBoxVille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxVille.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVille.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxVille.Location = new System.Drawing.Point(154, 232);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(188, 27);
            this.textBoxVille.TabIndex = 3;
            this.textBoxVille.TextChanged += new System.EventHandler(this.textBoxVille_TextChanged);
            // 
            // labelCodePostal
            // 
            this.labelCodePostal.AutoSize = true;
            this.labelCodePostal.BackColor = System.Drawing.Color.Transparent;
            this.labelCodePostal.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCodePostal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCodePostal.Location = new System.Drawing.Point(47, 172);
            this.labelCodePostal.Name = "labelCodePostal";
            this.labelCodePostal.Size = new System.Drawing.Size(91, 20);
            this.labelCodePostal.TabIndex = 4;
            this.labelCodePostal.Text = "Code postal :";
            // 
            // textBoxCodePostal
            // 
            this.textBoxCodePostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxCodePostal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCodePostal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCodePostal.Location = new System.Drawing.Point(154, 169);
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            this.textBoxCodePostal.Size = new System.Drawing.Size(82, 27);
            this.textBoxCodePostal.TabIndex = 2;
            this.textBoxCodePostal.TextChanged += new System.EventHandler(this.textBoxCodePostal_TextChanged);
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxAdresse.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdresse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxAdresse.Location = new System.Drawing.Point(154, 111);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(188, 27);
            this.textBoxAdresse.TabIndex = 1;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.textBoxAdresse_TextChanged);
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.BackColor = System.Drawing.Color.Transparent;
            this.labelAdresse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdresse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAdresse.Location = new System.Drawing.Point(73, 114);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(67, 20);
            this.labelAdresse.TabIndex = 7;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelErreurAdr
            // 
            this.labelErreurAdr.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurAdr.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurAdr.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurAdr.Location = new System.Drawing.Point(154, 139);
            this.labelErreurAdr.Name = "labelErreurAdr";
            this.labelErreurAdr.Size = new System.Drawing.Size(211, 20);
            this.labelErreurAdr.TabIndex = 10;
            this.labelErreurAdr.Text = "Veuillez saisir une adresse valide";
            this.labelErreurAdr.Visible = false;
            // 
            // labelErreurCP
            // 
            this.labelErreurCP.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurCP.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurCP.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurCP.Location = new System.Drawing.Point(154, 200);
            this.labelErreurCP.Name = "labelErreurCP";
            this.labelErreurCP.Size = new System.Drawing.Size(230, 20);
            this.labelErreurCP.TabIndex = 11;
            this.labelErreurCP.Text = "Veuillez saisir un code postal valide";
            this.labelErreurCP.Visible = false;
            // 
            // labelErreurVille
            // 
            this.labelErreurVille.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurVille.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurVille.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurVille.Location = new System.Drawing.Point(154, 263);
            this.labelErreurVille.Name = "labelErreurVille";
            this.labelErreurVille.Size = new System.Drawing.Size(187, 20);
            this.labelErreurVille.TabIndex = 12;
            this.labelErreurVille.Text = "Veuillez saisir une ville valide";
            this.labelErreurVille.Visible = false;
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Controls.Add(this.buttonOK);
            this.backgroundBlock2.Location = new System.Drawing.Point(-5, 361);
            this.backgroundBlock2.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(419, 50);
            this.backgroundBlock2.TabIndex = 17;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnuler.Location = new System.Drawing.Point(163, 11);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(110, 30);
            this.buttonAnnuler.TabIndex = 5;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Transparent;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOK.Location = new System.Drawing.Point(295, 11);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(110, 30);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Ajouter";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock1.Controls.Add(this.label1);
            this.backgroundBlock1.Location = new System.Drawing.Point(0, 1);
            this.backgroundBlock1.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(419, 80);
            this.backgroundBlock1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'une adresse";
            // 
            // NouvelleAdresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(414, 411);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.backgroundBlock1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NouvelleAdresse";
            this.Text = "Ajout d\'une adresse";
            this.backgroundBlock2.ResumeLayout(false);
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelComplement;
        public System.Windows.Forms.TextBox textBoxComplement;
        private System.Windows.Forms.Label labelVille;
        public System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label labelCodePostal;
        public System.Windows.Forms.TextBox textBoxCodePostal;
        public System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelErreurAdr;
        private System.Windows.Forms.Label labelErreurCP;
        private System.Windows.Forms.Label labelErreurVille;
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label label1;
    }
}