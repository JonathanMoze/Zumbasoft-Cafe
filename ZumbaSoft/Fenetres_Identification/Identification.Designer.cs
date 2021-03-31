
namespace ZumbaSoft.Fenetres_Identification
{
    partial class Identification
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
            this.connection_button = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreationCompte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connection_button
            // 
            this.connection_button.Location = new System.Drawing.Point(107, 238);
            this.connection_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connection_button.Name = "connection_button";
            this.connection_button.Size = new System.Drawing.Size(150, 31);
            this.connection_button.TabIndex = 0;
            this.connection_button.Text = "Se connecter";
            this.connection_button.UseVisualStyleBackColor = true;
            this.connection_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(186, 90);
            this.loginField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(153, 27);
            this.loginField.TabIndex = 1;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(186, 145);
            this.passwordField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(151, 27);
            this.passwordField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "mot de passe";
            // 
            // buttonCreationCompte
            // 
            this.buttonCreationCompte.Location = new System.Drawing.Point(189, 13);
            this.buttonCreationCompte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreationCompte.Name = "buttonCreationCompte";
            this.buttonCreationCompte.Size = new System.Drawing.Size(150, 31);
            this.buttonCreationCompte.TabIndex = 5;
            this.buttonCreationCompte.Text = "Creer un compte";
            this.buttonCreationCompte.UseVisualStyleBackColor = true;
            this.buttonCreationCompte.Click += new System.EventHandler(this.buttonCreationCompte_Click);
            // 
            // Identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 307);
            this.Controls.Add(this.buttonCreationCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.connection_button);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Identification";
            this.Text = "Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connection_button;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCreationCompte;
    }
}