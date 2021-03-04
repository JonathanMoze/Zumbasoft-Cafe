
namespace ZumbaSoft.Fenetres_Magasin
{
    partial class AjouterMagasin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterMagasin));
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.labelMdp = new System.Windows.Forms.Label();
            this.buttonOKmdp = new System.Windows.Forms.Button();
            this.labelAdr = new System.Windows.Forms.Label();
            this.buttonAdr = new System.Windows.Forms.Button();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.labelErreurMdp = new System.Windows.Forms.Label();
            this.labelErreurAdr = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNomMagasin = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.backgroundBlock1.SuspendLayout();
            this.backgroundBlock2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxMdp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMdp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMdp.Location = new System.Drawing.Point(78, 321);
            this.textBoxMdp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(361, 30);
            this.textBoxMdp.TabIndex = 0;
            this.textBoxMdp.TextChanged += new System.EventHandler(this.textBoxMdp_TextChanged);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.BackColor = System.Drawing.Color.Transparent;
            this.labelMdp.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMdp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMdp.Location = new System.Drawing.Point(78, 284);
            this.labelMdp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(130, 23);
            this.labelMdp.TabIndex = 1;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // buttonOKmdp
            // 
            this.buttonOKmdp.BackColor = System.Drawing.Color.Transparent;
            this.buttonOKmdp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOKmdp.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOKmdp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOKmdp.Location = new System.Drawing.Point(373, 14);
            this.buttonOKmdp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOKmdp.Name = "buttonOKmdp";
            this.buttonOKmdp.Size = new System.Drawing.Size(138, 37);
            this.buttonOKmdp.TabIndex = 2;
            this.buttonOKmdp.Text = "OK";
            this.buttonOKmdp.UseVisualStyleBackColor = false;
            this.buttonOKmdp.Click += new System.EventHandler(this.buttonOKmdp_Click);
            // 
            // labelAdr
            // 
            this.labelAdr.AutoSize = true;
            this.labelAdr.BackColor = System.Drawing.Color.Transparent;
            this.labelAdr.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAdr.Location = new System.Drawing.Point(79, 439);
            this.labelAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(84, 23);
            this.labelAdr.TabIndex = 3;
            this.labelAdr.Text = "Adresse :";
            // 
            // buttonAdr
            // 
            this.buttonAdr.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdr.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdr.Location = new System.Drawing.Point(79, 551);
            this.buttonAdr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdr.Name = "buttonAdr";
            this.buttonAdr.Size = new System.Drawing.Size(196, 37);
            this.buttonAdr.TabIndex = 4;
            this.buttonAdr.Text = "Nouvelle adresse";
            this.buttonAdr.UseVisualStyleBackColor = false;
            this.buttonAdr.Click += new System.EventHandler(this.buttonAdr_Click);
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxAdr.Enabled = false;
            this.textBoxAdr.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxAdr.Location = new System.Drawing.Point(79, 474);
            this.textBoxAdr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(361, 30);
            this.textBoxAdr.TabIndex = 5;
            this.textBoxAdr.TextChanged += new System.EventHandler(this.textBoxAdr_TextChanged);
            // 
            // labelErreurMdp
            // 
            this.labelErreurMdp.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurMdp.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurMdp.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurMdp.Location = new System.Drawing.Point(78, 364);
            this.labelErreurMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurMdp.Name = "labelErreurMdp";
            this.labelErreurMdp.Size = new System.Drawing.Size(361, 46);
            this.labelErreurMdp.TabIndex = 6;
            this.labelErreurMdp.Text = "Veuillez saisir un mot de passe valide\r\n(compris entre 8 et 32)";
            this.labelErreurMdp.Visible = false;
            // 
            // labelErreurAdr
            // 
            this.labelErreurAdr.AutoSize = true;
            this.labelErreurAdr.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurAdr.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreurAdr.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreurAdr.Location = new System.Drawing.Point(79, 517);
            this.labelErreurAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurAdr.Name = "labelErreurAdr";
            this.labelErreurAdr.Size = new System.Drawing.Size(250, 20);
            this.labelErreurAdr.TabIndex = 7;
            this.labelErreurAdr.Text = "Veuillez saisir une adresse valide";
            this.labelErreurAdr.Visible = false;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnuler.Location = new System.Drawing.Point(209, 14);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(138, 37);
            this.buttonAnnuler.TabIndex = 8;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ajouter";
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNom.Location = new System.Drawing.Point(78, 189);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(361, 30);
            this.textBoxNom.TabIndex = 9;
            // 
            // labelNomMagasin
            // 
            this.labelNomMagasin.AutoSize = true;
            this.labelNomMagasin.BackColor = System.Drawing.Color.Transparent;
            this.labelNomMagasin.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomMagasin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNomMagasin.Location = new System.Drawing.Point(78, 151);
            this.labelNomMagasin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNomMagasin.Name = "labelNomMagasin";
            this.labelNomMagasin.Size = new System.Drawing.Size(160, 23);
            this.labelNomMagasin.TabIndex = 10;
            this.labelNomMagasin.Text = "Nom du magasin :";
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
            this.labelTitle.Size = new System.Drawing.Size(360, 46);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Ajout d\'un magasin";
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock1.Controls.Add(this.labelTitle);
            this.backgroundBlock1.Location = new System.Drawing.Point(0, -2);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(524, 117);
            this.backgroundBlock1.TabIndex = 12;
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Controls.Add(this.buttonOKmdp);
            this.backgroundBlock2.Location = new System.Drawing.Point(0, 625);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(524, 63);
            this.backgroundBlock2.TabIndex = 13;
            // 
            // AjouterMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(524, 688);
            this.Controls.Add(this.labelNomMagasin);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelErreurAdr);
            this.Controls.Add(this.labelErreurMdp);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.buttonAdr);
            this.Controls.Add(this.labelAdr);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.backgroundBlock2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AjouterMagasin";
            this.Text = "AjouterMagasin";
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.backgroundBlock2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Button buttonOKmdp;
        private System.Windows.Forms.Label labelAdr;
        private System.Windows.Forms.Button buttonAdr;
        private System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.Label labelErreurMdp;
        private System.Windows.Forms.Label labelErreurAdr;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNomMagasin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Panel backgroundBlock2;
    }
}