
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierClient));
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.TitreNomClient = new System.Windows.Forms.Label();
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.labelErreur = new System.Windows.Forms.Label();
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
            this.buttonNvAdresse = new System.Windows.Forms.Button();
            this.backgroundBlock2.SuspendLayout();
            this.backgroundBlock1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.Transparent;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAjouter.Location = new System.Drawing.Point(319, 12);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(110, 29);
            this.buttonAjouter.TabIndex = 6;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Controls.Add(this.buttonAjouter);
            this.backgroundBlock2.Location = new System.Drawing.Point(-17, 700);
            this.backgroundBlock2.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(463, 51);
            this.backgroundBlock2.TabIndex = 85;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnuler.Location = new System.Drawing.Point(194, 12);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(110, 29);
            this.buttonAnnuler.TabIndex = 5;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // TitreNomClient
            // 
            this.TitreNomClient.AutoSize = true;
            this.TitreNomClient.BackColor = System.Drawing.Color.Transparent;
            this.TitreNomClient.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitreNomClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TitreNomClient.Location = new System.Drawing.Point(25, 22);
            this.TitreNomClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitreNomClient.Name = "TitreNomClient";
            this.TitreNomClient.Size = new System.Drawing.Size(243, 36);
            this.TitreNomClient.TabIndex = 0;
            this.TitreNomClient.Text = "Ajout d\'un client";
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock1.Controls.Add(this.TitreNomClient);
            this.backgroundBlock1.Location = new System.Drawing.Point(-6, -1);
            this.backgroundBlock1.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(434, 80);
            this.backgroundBlock1.TabIndex = 84;
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.BackColor = System.Drawing.Color.Transparent;
            this.labelErreur.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErreur.ForeColor = System.Drawing.Color.Tomato;
            this.labelErreur.Location = new System.Drawing.Point(77, 662);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(257, 18);
            this.labelErreur.TabIndex = 83;
            this.labelErreur.Text = "Un ou plusieurs champs sont incorrects";
            this.labelErreur.Visible = false;
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxAdr.Enabled = false;
            this.textBoxAdr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxAdr.Location = new System.Drawing.Point(155, 576);
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(206, 27);
            this.textBoxAdr.TabIndex = 81;
            // 
            // dateTimeNaissance
            // 
            this.dateTimeNaissance.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.dateTimeNaissance.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.dateTimeNaissance.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeNaissance.Location = new System.Drawing.Point(155, 512);
            this.dateTimeNaissance.Name = "dateTimeNaissance";
            this.dateTimeNaissance.Size = new System.Drawing.Size(169, 27);
            this.dateTimeNaissance.TabIndex = 80;
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMail.Location = new System.Drawing.Point(155, 448);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(201, 27);
            this.textBoxMail.TabIndex = 79;
            // 
            // textBoxTel
            // 
            this.textBoxTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxTel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTel.Location = new System.Drawing.Point(155, 379);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(153, 27);
            this.textBoxTel.TabIndex = 78;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxPrenom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPrenom.Location = new System.Drawing.Point(155, 308);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(201, 27);
            this.textBoxPrenom.TabIndex = 77;
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.textBoxNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNom.Location = new System.Drawing.Point(155, 237);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(201, 27);
            this.textBoxNom.TabIndex = 76;
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.BackColor = System.Drawing.Color.Transparent;
            this.labelAdresse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdresse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAdresse.Location = new System.Drawing.Point(76, 579);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(69, 20);
            this.labelAdresse.TabIndex = 75;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.BackColor = System.Drawing.Color.Transparent;
            this.labelDateNaissance.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateNaissance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDateNaissance.Location = new System.Drawing.Point(8, 517);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(138, 20);
            this.labelDateNaissance.TabIndex = 74;
            this.labelDateNaissance.Text = "Date de naissance :";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMail.Location = new System.Drawing.Point(91, 451);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(52, 20);
            this.labelMail.TabIndex = 73;
            this.labelMail.Text = "Email :";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.BackColor = System.Drawing.Color.Transparent;
            this.labelTel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTel.Location = new System.Drawing.Point(59, 382);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(88, 20);
            this.labelTel.TabIndex = 72;
            this.labelTel.Text = "Téléphone :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrenom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPrenom.Location = new System.Drawing.Point(77, 311);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(70, 20);
            this.labelPrenom.TabIndex = 71;
            this.labelPrenom.Text = "Prenom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNom.Location = new System.Drawing.Point(95, 240);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(50, 20);
            this.labelNom.TabIndex = 70;
            this.labelNom.Text = "Nom :";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.comboBoxStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(155, 172);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(86, 28);
            this.comboBoxStatus.TabIndex = 69;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelStatus.Location = new System.Drawing.Point(88, 175);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(58, 20);
            this.labelStatus.TabIndex = 68;
            this.labelStatus.Text = "Status :";
            // 
            // comboBoxCivilité
            // 
            this.comboBoxCivilité.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.comboBoxCivilité.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxCivilité.FormattingEnabled = true;
            this.comboBoxCivilité.Location = new System.Drawing.Point(155, 111);
            this.comboBoxCivilité.Name = "comboBoxCivilité";
            this.comboBoxCivilité.Size = new System.Drawing.Size(133, 28);
            this.comboBoxCivilité.TabIndex = 67;
            // 
            // labelCivilite
            // 
            this.labelCivilite.AutoSize = true;
            this.labelCivilite.BackColor = System.Drawing.Color.Transparent;
            this.labelCivilite.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCivilite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCivilite.Location = new System.Drawing.Point(83, 114);
            this.labelCivilite.Name = "labelCivilite";
            this.labelCivilite.Size = new System.Drawing.Size(59, 20);
            this.labelCivilite.TabIndex = 66;
            this.labelCivilite.Text = "Civilité :";
            // 
            // buttonNvAdresse
            // 
            this.buttonNvAdresse.BackColor = System.Drawing.Color.Transparent;
            this.buttonNvAdresse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNvAdresse.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNvAdresse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNvAdresse.Location = new System.Drawing.Point(155, 609);
            this.buttonNvAdresse.Name = "buttonNvAdresse";
            this.buttonNvAdresse.Size = new System.Drawing.Size(207, 29);
            this.buttonNvAdresse.TabIndex = 18;
            this.buttonNvAdresse.Text = "Nouvelle adresse";
            this.buttonNvAdresse.UseVisualStyleBackColor = false;
            this.buttonNvAdresse.Click += new System.EventHandler(this.buttonNvAdresse_Click);
            // 
            // ModifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(428, 751);
            this.Controls.Add(this.buttonNvAdresse);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.labelErreur);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifierClient";
            this.Text = "Modification d\'un client";
            this.backgroundBlock2.ResumeLayout(false);
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Label TitreNomClient;
        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.TextBox textBoxAdr;
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
        private System.Windows.Forms.Button buttonNvAdresse;
    }
}