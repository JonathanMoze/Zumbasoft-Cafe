
namespace ZumbaSoft
{
    partial class ConnexionMagasin
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelNomMagasin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.labelErreur = new System.Windows.Forms.Label();
            this.buttonConnexionAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(12, 20);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(190, 20);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Bienvenue Dans Zumbasoft";
            // 
            // labelNomMagasin
            // 
            this.labelNomMagasin.AutoSize = true;
            this.labelNomMagasin.Location = new System.Drawing.Point(135, 108);
            this.labelNomMagasin.Name = "labelNomMagasin";
            this.labelNomMagasin.Size = new System.Drawing.Size(45, 20);
            this.labelNomMagasin.TabIndex = 1;
            this.labelNomMagasin.Text = "Ville :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe :";
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(186, 105);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(125, 27);
            this.textBoxVille.TabIndex = 3;
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(200, 159);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(125, 27);
            this.textBoxMdp.TabIndex = 4;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(117, 269);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(260, 29);
            this.buttonConnexion.TabIndex = 5;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(100, 222);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(303, 20);
            this.labelErreur.TabIndex = 6;
            this.labelErreur.Text = "Erreur : Mot de passe ou identifiant incorrect";
            this.labelErreur.Visible = false;
            // 
            // buttonConnexionAdmin
            // 
            this.buttonConnexionAdmin.Location = new System.Drawing.Point(338, 11);
            this.buttonConnexionAdmin.Name = "buttonConnexionAdmin";
            this.buttonConnexionAdmin.Size = new System.Drawing.Size(145, 29);
            this.buttonConnexionAdmin.TabIndex = 7;
            this.buttonConnexionAdmin.Text = "Connexion Admin";
            this.buttonConnexionAdmin.UseVisualStyleBackColor = true;
            this.buttonConnexionAdmin.Click += new System.EventHandler(this.buttonConnexionAdmin_Click);
            // 
            // ConnexionMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 332);
            this.Controls.Add(this.buttonConnexionAdmin);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNomMagasin);
            this.Controls.Add(this.labelNom);
            this.Name = "ConnexionMagasin";
            this.Text = "ConnexionMagasin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelNomMagasin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button buttonConnexionAdmin;
    }
}