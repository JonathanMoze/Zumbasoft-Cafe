
namespace ZumbaSoft.Fenetres_Magasin
{
    partial class AuthentificationMagasin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addresse = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.TextBox();
            this.validation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez votre identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrez le mot de passe :";
            // 
            // addresse
            // 
            this.addresse.Location = new System.Drawing.Point(213, 66);
            this.addresse.Name = "addresse";
            this.addresse.Size = new System.Drawing.Size(100, 23);
            this.addresse.TabIndex = 2;
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(213, 96);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(100, 23);
            this.mdp.TabIndex = 3;
            // 
            // validation
            // 
            this.validation.Location = new System.Drawing.Point(213, 138);
            this.validation.Name = "validation";
            this.validation.Size = new System.Drawing.Size(110, 23);
            this.validation.TabIndex = 4;
            this.validation.Text = "Authentification";
            this.validation.UseVisualStyleBackColor = true;
            this.validation.Click += new System.EventHandler(this.validation_Click);
            // 
            // AuthentificationMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validation);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.addresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AuthentificationMagasin";
            this.Text = "AuthentificationMagasin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addresse;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.Button validation;
    }
}