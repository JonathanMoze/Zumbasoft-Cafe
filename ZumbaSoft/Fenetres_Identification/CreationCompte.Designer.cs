
namespace ZumbaSoft.Fenetres_Identification
{
    partial class CreationCompte
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
            this.labelErreur = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonNvAdresse = new System.Windows.Forms.Button();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.dateTimeNaissance = new System.Windows.Forms.DateTimePicker();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxCivilité = new System.Windows.Forms.ComboBox();
            this.labelCivilite = new System.Windows.Forms.Label();
            this.labelNvUtilisateur = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErreur
            // 
            this.labelErreur.BackColor = System.Drawing.Color.Transparent;
            this.labelErreur.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreur.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreur.Location = new System.Drawing.Point(80, 437);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(358, 18);
            this.labelErreur.TabIndex = 47;
            this.labelErreur.Text = "Un ou plusieurs champs sont incorrects";
            this.labelErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelErreur.Visible = false;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(299, 482);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(94, 29);
            this.buttonValider.TabIndex = 46;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(104, 482);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnuler.TabIndex = 45;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonNvAdresse
            // 
            this.buttonNvAdresse.Location = new System.Drawing.Point(360, 336);
            this.buttonNvAdresse.Name = "buttonNvAdresse";
            this.buttonNvAdresse.Size = new System.Drawing.Size(131, 29);
            this.buttonNvAdresse.TabIndex = 44;
            this.buttonNvAdresse.Text = "Nouvelle adresse";
            this.buttonNvAdresse.UseVisualStyleBackColor = true;
            this.buttonNvAdresse.Click += new System.EventHandler(this.buttonNvAdresse_Click);
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Enabled = false;
            this.textBoxAdr.Location = new System.Drawing.Point(117, 338);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(206, 27);
            this.textBoxAdr.TabIndex = 43;
            // 
            // dateTimeNaissance
            // 
            this.dateTimeNaissance.Location = new System.Drawing.Point(188, 280);
            this.dateTimeNaissance.Name = "dateTimeNaissance";
            this.dateTimeNaissance.Size = new System.Drawing.Size(250, 27);
            this.dateTimeNaissance.TabIndex = 42;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(329, 227);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(125, 27);
            this.textBoxMail.TabIndex = 41;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(127, 227);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(125, 27);
            this.textBoxTel.TabIndex = 40;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(313, 176);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(125, 27);
            this.textBoxPrenom.TabIndex = 39;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(91, 176);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(125, 27);
            this.textBoxNom.TabIndex = 38;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(36, 341);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(68, 20);
            this.labelAdresse.TabIndex = 37;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(36, 285);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(136, 20);
            this.labelDateNaissance.TabIndex = 36;
            this.labelDateNaissance.Text = "Date de naissance :";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(270, 234);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(53, 20);
            this.labelMail.TabIndex = 35;
            this.labelMail.Text = "Email :";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(36, 234);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(85, 20);
            this.labelTel.TabIndex = 34;
            this.labelTel.Text = "Téléphone :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(240, 179);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(67, 20);
            this.labelPrenom.TabIndex = 33;
            this.labelPrenom.Text = "Prenom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(36, 179);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(49, 20);
            this.labelNom.TabIndex = 32;
            this.labelNom.Text = "Nom :";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(360, 89);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(100, 28);
            this.comboBoxStatus.TabIndex = 31;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(279, 92);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 30;
            this.labelStatus.Text = "Status :";
            // 
            // comboBoxCivilité
            // 
            this.comboBoxCivilité.FormattingEnabled = true;
            this.comboBoxCivilité.Location = new System.Drawing.Point(117, 89);
            this.comboBoxCivilité.Name = "comboBoxCivilité";
            this.comboBoxCivilité.Size = new System.Drawing.Size(100, 28);
            this.comboBoxCivilité.TabIndex = 29;
            // 
            // labelCivilite
            // 
            this.labelCivilite.AutoSize = true;
            this.labelCivilite.Location = new System.Drawing.Point(36, 92);
            this.labelCivilite.Name = "labelCivilite";
            this.labelCivilite.Size = new System.Drawing.Size(61, 20);
            this.labelCivilite.TabIndex = 28;
            this.labelCivilite.Text = "Civilité :";
            // 
            // labelNvUtilisateur
            // 
            this.labelNvUtilisateur.AutoSize = true;
            this.labelNvUtilisateur.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNvUtilisateur.Location = new System.Drawing.Point(12, 9);
            this.labelNvUtilisateur.Name = "labelNvUtilisateur";
            this.labelNvUtilisateur.Size = new System.Drawing.Size(184, 38);
            this.labelNvUtilisateur.TabIndex = 48;
            this.labelNvUtilisateur.Text = "S\'enregistrer";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(91, 133);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(125, 27);
            this.textBoxLogin.TabIndex = 50;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(36, 136);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 20);
            this.labelLogin.TabIndex = 49;
            this.labelLogin.Text = "Login :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(327, 133);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxPassword.TabIndex = 52;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(244, 136);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 20);
            this.labelPassword.TabIndex = 51;
            this.labelPassword.Text = "Password :";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(176, 389);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(229, 28);
            this.comboBoxRole.TabIndex = 54;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(95, 392);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(46, 20);
            this.labelRole.TabIndex = 53;
            this.labelRole.Text = "Rôle :";
            // 
            // CreationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 542);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelNvUtilisateur);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonNvAdresse);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.dateTimeNaissance);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelDateNaissance);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxCivilité);
            this.Controls.Add(this.labelCivilite);
            this.Name = "CreationCompte";
            this.Text = "CreationCompte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonNvAdresse;
        public System.Windows.Forms.TextBox textBoxAdr;
        public System.Windows.Forms.DateTimePicker dateTimeNaissance;
        public System.Windows.Forms.TextBox textBoxMail;
        public System.Windows.Forms.TextBox textBoxTel;
        public System.Windows.Forms.TextBox textBoxPrenom;
        public System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        public System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.ComboBox comboBoxCivilité;
        private System.Windows.Forms.Label labelCivilite;
        private System.Windows.Forms.Label labelNvUtilisateur;
        public System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        public System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        public System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelRole;
    }
}