
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
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.labelMdp = new System.Windows.Forms.Label();
            this.buttonOKmdp = new System.Windows.Forms.Button();
            this.labelAdr = new System.Windows.Forms.Label();
            this.buttonAdr = new System.Windows.Forms.Button();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.labelErreurMdp = new System.Windows.Forms.Label();
            this.labelErreurAdr = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(364, 142);
            this.textBoxMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(155, 31);
            this.textBoxMdp.TabIndex = 0;
            this.textBoxMdp.TextChanged += new System.EventHandler(this.textBoxMdp_TextChanged);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(225, 146);
            this.labelMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(129, 25);
            this.labelMdp.TabIndex = 1;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // buttonOKmdp
            // 
            this.buttonOKmdp.Location = new System.Drawing.Point(317, 360);
            this.buttonOKmdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOKmdp.Name = "buttonOKmdp";
            this.buttonOKmdp.Size = new System.Drawing.Size(118, 36);
            this.buttonOKmdp.TabIndex = 2;
            this.buttonOKmdp.Text = "OK";
            this.buttonOKmdp.UseVisualStyleBackColor = true;
            this.buttonOKmdp.Click += new System.EventHandler(this.buttonOKmdp_Click);
            // 
            // labelAdr
            // 
            this.labelAdr.AutoSize = true;
            this.labelAdr.Location = new System.Drawing.Point(271, 231);
            this.labelAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(84, 25);
            this.labelAdr.TabIndex = 3;
            this.labelAdr.Text = "Adresse :";
            // 
            // buttonAdr
            // 
            this.buttonAdr.Location = new System.Drawing.Point(552, 225);
            this.buttonAdr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdr.Name = "buttonAdr";
            this.buttonAdr.Size = new System.Drawing.Size(196, 36);
            this.buttonAdr.TabIndex = 4;
            this.buttonAdr.Text = "Nouvelle adresse";
            this.buttonAdr.UseVisualStyleBackColor = true;
            this.buttonAdr.Click += new System.EventHandler(this.buttonAdr_Click);
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Enabled = false;
            this.textBoxAdr.Location = new System.Drawing.Point(364, 228);
            this.textBoxAdr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(155, 31);
            this.textBoxAdr.TabIndex = 5;
            this.textBoxAdr.TextChanged += new System.EventHandler(this.textBoxAdr_TextChanged);
            // 
            // labelErreurMdp
            // 
            this.labelErreurMdp.AutoSize = true;
            this.labelErreurMdp.Location = new System.Drawing.Point(552, 146);
            this.labelErreurMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurMdp.Name = "labelErreurMdp";
            this.labelErreurMdp.Size = new System.Drawing.Size(303, 25);
            this.labelErreurMdp.TabIndex = 6;
            this.labelErreurMdp.Text = "Veuillez saisir un mot de passe valide";
            this.labelErreurMdp.Visible = false;
            // 
            // labelErreurAdr
            // 
            this.labelErreurAdr.AutoSize = true;
            this.labelErreurAdr.Location = new System.Drawing.Point(271, 279);
            this.labelErreurAdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErreurAdr.Name = "labelErreurAdr";
            this.labelErreurAdr.Size = new System.Drawing.Size(264, 25);
            this.labelErreurAdr.TabIndex = 7;
            this.labelErreurAdr.Text = "Veuillez saisir une adresse valide";
            this.labelErreurAdr.Visible = false;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(443, 360);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(118, 36);
            this.buttonAnnuler.TabIndex = 8;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // AjouterMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelErreurAdr);
            this.Controls.Add(this.labelErreurMdp);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.buttonAdr);
            this.Controls.Add(this.labelAdr);
            this.Controls.Add(this.buttonOKmdp);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.textBoxMdp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AjouterMagasin";
            this.Text = "AjouterMagasin";
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
    }
}