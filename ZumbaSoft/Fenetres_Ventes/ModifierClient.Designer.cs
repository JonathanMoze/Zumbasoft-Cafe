
namespace ZumbaSoft.Fenetres_Ventes
{
    partial class ModifierClient
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
            this.TitreNomClient = new System.Windows.Forms.Label();
            this.buttonValidModifs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.BackColor = System.Drawing.Color.Transparent;
            this.labelErreur.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreur.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreur.Location = new System.Drawing.Point(143, 358);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(257, 18);
            this.labelErreur.TabIndex = 48;
            this.labelErreur.Text = "Un ou plusieurs champs sont incorrects";
            this.labelErreur.Visible = false;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(589, 409);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(94, 29);
            this.buttonValider.TabIndex = 47;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(459, 409);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnuler.TabIndex = 46;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonNvAdresse
            // 
            this.buttonNvAdresse.Location = new System.Drawing.Point(367, 299);
            this.buttonNvAdresse.Name = "buttonNvAdresse";
            this.buttonNvAdresse.Size = new System.Drawing.Size(131, 29);
            this.buttonNvAdresse.TabIndex = 45;
            this.buttonNvAdresse.Text = "Nouvelle adresse";
            this.buttonNvAdresse.UseVisualStyleBackColor = true;
            this.buttonNvAdresse.Click += new System.EventHandler(this.buttonNvAdresse_Click);
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Enabled = false;
            this.textBoxAdr.Location = new System.Drawing.Point(124, 301);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(206, 27);
            this.textBoxAdr.TabIndex = 44;
            // 
            // dateTimeNaissance
            // 
            this.dateTimeNaissance.Location = new System.Drawing.Point(195, 243);
            this.dateTimeNaissance.Name = "dateTimeNaissance";
            this.dateTimeNaissance.Size = new System.Drawing.Size(250, 27);
            this.dateTimeNaissance.TabIndex = 43;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(336, 194);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(125, 27);
            this.textBoxMail.TabIndex = 42;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(134, 190);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(125, 27);
            this.textBoxTel.TabIndex = 41;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(320, 139);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(125, 27);
            this.textBoxPrenom.TabIndex = 40;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(98, 139);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(125, 27);
            this.textBoxNom.TabIndex = 39;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(43, 304);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(68, 20);
            this.labelAdresse.TabIndex = 38;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(43, 248);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(136, 20);
            this.labelDateNaissance.TabIndex = 37;
            this.labelDateNaissance.Text = "Date de naissance :";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(277, 197);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(53, 20);
            this.labelMail.TabIndex = 36;
            this.labelMail.Text = "Email :";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(43, 197);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(85, 20);
            this.labelTel.TabIndex = 35;
            this.labelTel.Text = "Téléphone :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(247, 142);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(67, 20);
            this.labelPrenom.TabIndex = 34;
            this.labelPrenom.Text = "Prenom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(43, 142);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(49, 20);
            this.labelNom.TabIndex = 33;
            this.labelNom.Text = "Nom :";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(367, 88);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(100, 28);
            this.comboBoxStatus.TabIndex = 32;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(286, 91);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 31;
            this.labelStatus.Text = "Status :";
            // 
            // comboBoxCivilité
            // 
            this.comboBoxCivilité.FormattingEnabled = true;
            this.comboBoxCivilité.Location = new System.Drawing.Point(124, 88);
            this.comboBoxCivilité.Name = "comboBoxCivilité";
            this.comboBoxCivilité.Size = new System.Drawing.Size(100, 28);
            this.comboBoxCivilité.TabIndex = 30;
            // 
            // labelCivilite
            // 
            this.labelCivilite.AutoSize = true;
            this.labelCivilite.Location = new System.Drawing.Point(43, 91);
            this.labelCivilite.Name = "labelCivilite";
            this.labelCivilite.Size = new System.Drawing.Size(61, 20);
            this.labelCivilite.TabIndex = 29;
            this.labelCivilite.Text = "Civilité :";
            // 
            // TitreNomClient
            // 
            this.TitreNomClient.AutoSize = true;
            this.TitreNomClient.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitreNomClient.Location = new System.Drawing.Point(39, 26);
            this.TitreNomClient.Name = "TitreNomClient";
            this.TitreNomClient.Size = new System.Drawing.Size(166, 38);
            this.TitreNomClient.TabIndex = 49;
            this.TitreNomClient.Text = "Nom Client";
            // 
            // buttonValidModifs
            // 
            this.buttonValidModifs.Location = new System.Drawing.Point(538, 164);
            this.buttonValidModifs.Name = "buttonValidModifs";
            this.buttonValidModifs.Size = new System.Drawing.Size(133, 57);
            this.buttonValidModifs.TabIndex = 65;
            this.buttonValidModifs.Text = "Valider les modifications";
            this.buttonValidModifs.UseVisualStyleBackColor = true;
            this.buttonValidModifs.Click += new System.EventHandler(this.buttonValidModifs_Click);
            // 
            // ModifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.buttonValidModifs);
            this.Controls.Add(this.TitreNomClient);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierClient";
            this.Text = "ModifierClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonNvAdresse;
        private System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.DateTimePicker dateTimeNaissance;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxCivilité;
        private System.Windows.Forms.Label labelCivilite;
        private System.Windows.Forms.Label TitreNomClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonValidModifs;
    }
}