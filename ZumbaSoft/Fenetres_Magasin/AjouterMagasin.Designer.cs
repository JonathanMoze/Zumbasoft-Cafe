
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
            this.SuspendLayout();
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(291, 114);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(125, 27);
            this.textBoxMdp.TabIndex = 0;
            this.textBoxMdp.TextChanged += new System.EventHandler(this.textBoxMdp_TextChanged);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(180, 117);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(105, 20);
            this.labelMdp.TabIndex = 1;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // buttonOKmdp
            // 
            this.buttonOKmdp.Location = new System.Drawing.Point(291, 289);
            this.buttonOKmdp.Name = "buttonOKmdp";
            this.buttonOKmdp.Size = new System.Drawing.Size(94, 29);
            this.buttonOKmdp.TabIndex = 2;
            this.buttonOKmdp.Text = "OK";
            this.buttonOKmdp.UseVisualStyleBackColor = true;
            this.buttonOKmdp.Click += new System.EventHandler(this.buttonOKmdp_Click);
            // 
            // labelAdr
            // 
            this.labelAdr.AutoSize = true;
            this.labelAdr.Location = new System.Drawing.Point(217, 185);
            this.labelAdr.Name = "labelAdr";
            this.labelAdr.Size = new System.Drawing.Size(68, 20);
            this.labelAdr.TabIndex = 3;
            this.labelAdr.Text = "Adresse :";
            // 
            // buttonAdr
            // 
            this.buttonAdr.Location = new System.Drawing.Point(442, 180);
            this.buttonAdr.Name = "buttonAdr";
            this.buttonAdr.Size = new System.Drawing.Size(157, 29);
            this.buttonAdr.TabIndex = 4;
            this.buttonAdr.Text = "Nouvelle adresse";
            this.buttonAdr.UseVisualStyleBackColor = true;
            this.buttonAdr.Click += new System.EventHandler(this.buttonAdr_Click);
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Enabled = false;
            this.textBoxAdr.Location = new System.Drawing.Point(291, 182);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(125, 27);
            this.textBoxAdr.TabIndex = 5;
            this.textBoxAdr.TextChanged += new System.EventHandler(this.textBoxAdr_TextChanged);
            // 
            // labelErreurMdp
            // 
            this.labelErreurMdp.AutoSize = true;
            this.labelErreurMdp.Location = new System.Drawing.Point(442, 117);
            this.labelErreurMdp.Name = "labelErreurMdp";
            this.labelErreurMdp.Size = new System.Drawing.Size(254, 20);
            this.labelErreurMdp.TabIndex = 6;
            this.labelErreurMdp.Text = "Veuillez saisir un mot de passe valide";
            this.labelErreurMdp.Visible = false;
            // 
            // labelErreurAdr
            // 
            this.labelErreurAdr.AutoSize = true;
            this.labelErreurAdr.Location = new System.Drawing.Point(217, 223);
            this.labelErreurAdr.Name = "labelErreurAdr";
            this.labelErreurAdr.Size = new System.Drawing.Size(223, 20);
            this.labelErreurAdr.TabIndex = 7;
            this.labelErreurAdr.Text = "Veuillez saisir une adresse valide";
            this.labelErreurAdr.Visible = false;
            // 
            // AjouterMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelErreurAdr);
            this.Controls.Add(this.labelErreurMdp);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.buttonAdr);
            this.Controls.Add(this.labelAdr);
            this.Controls.Add(this.buttonOKmdp);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.textBoxMdp);
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
    }
}