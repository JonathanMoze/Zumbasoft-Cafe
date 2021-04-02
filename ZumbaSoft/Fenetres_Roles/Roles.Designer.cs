
namespace ZumbaSoft.Fenetres_Roles
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.ajouterRoles = new System.Windows.Forms.Button();
            this.supprimerRole = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.erreurListevide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choixRoles = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmationAjout = new System.Windows.Forms.Label();
            this.erreurAjout = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomRole = new System.Windows.Forms.TextBox();
            this.intituleRole = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmationSR = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.anonymousIcon = new System.Windows.Forms.PictureBox();
            this.userSelectionne = new System.Windows.Forms.Label();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.programName = new System.Windows.Forms.Label();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.dbERROR = new System.Windows.Forms.PictureBox();
            this.dbOK = new System.Windows.Forms.PictureBox();
            this.magasinSelectionne = new System.Windows.Forms.Label();
            this.msgBDstatusERROR = new System.Windows.Forms.Label();
            this.msgBDstatusOK = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panelERROR = new System.Windows.Forms.Panel();
            this.buttonBackHome = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonContactAdmin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anonymousIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelERROR.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajouterRoles
            // 
            this.ajouterRoles.AutoSize = true;
            this.ajouterRoles.FlatAppearance.BorderSize = 0;
            this.ajouterRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ajouterRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterRoles.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ajouterRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ajouterRoles.Location = new System.Drawing.Point(117, 152);
            this.ajouterRoles.Name = "ajouterRoles";
            this.ajouterRoles.Size = new System.Drawing.Size(208, 42);
            this.ajouterRoles.TabIndex = 6;
            this.ajouterRoles.Text = "Ajouter";
            this.ajouterRoles.UseVisualStyleBackColor = true;
            this.ajouterRoles.Click += new System.EventHandler(this.ajouterRoles_Click);
            // 
            // supprimerRole
            // 
            this.supprimerRole.AutoSize = true;
            this.supprimerRole.FlatAppearance.BorderSize = 0;
            this.supprimerRole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.supprimerRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerRole.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supprimerRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.supprimerRole.Location = new System.Drawing.Point(135, 151);
            this.supprimerRole.Name = "supprimerRole";
            this.supprimerRole.Size = new System.Drawing.Size(208, 42);
            this.supprimerRole.TabIndex = 5;
            this.supprimerRole.Text = "Supprimer";
            this.supprimerRole.UseVisualStyleBackColor = true;
            this.supprimerRole.Click += new System.EventHandler(this.supprimerRole_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.erreurListevide);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.choixRoles);
            this.panel1.Location = new System.Drawing.Point(45, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 212);
            this.panel1.TabIndex = 0;
            // 
            // erreurListevide
            // 
            this.erreurListevide.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurListevide.ForeColor = System.Drawing.Color.Transparent;
            this.erreurListevide.Location = new System.Drawing.Point(-1, 56);
            this.erreurListevide.Name = "erreurListevide";
            this.erreurListevide.Size = new System.Drawing.Size(951, 153);
            this.erreurListevide.TabIndex = 8;
            this.erreurListevide.Text = "Aucun rôle n\'est enregistré";
            this.erreurListevide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(951, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choix d\'un rôle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choixRoles
            // 
            this.choixRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.choixRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.choixRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choixRoles.ForeColor = System.Drawing.Color.White;
            this.choixRoles.FormattingEnabled = true;
            this.choixRoles.ItemHeight = 20;
            this.choixRoles.Location = new System.Drawing.Point(0, 59);
            this.choixRoles.Name = "choixRoles";
            this.choixRoles.Size = new System.Drawing.Size(951, 140);
            this.choixRoles.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.confirmationAjout);
            this.panel2.Controls.Add(this.erreurAjout);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ajouterRoles);
            this.panel2.Controls.Add(this.nomRole);
            this.panel2.Controls.Add(this.intituleRole);
            this.panel2.Location = new System.Drawing.Point(45, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 204);
            this.panel2.TabIndex = 2;
            // 
            // confirmationAjout
            // 
            this.confirmationAjout.BackColor = System.Drawing.Color.Transparent;
            this.confirmationAjout.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmationAjout.ForeColor = System.Drawing.Color.Lime;
            this.confirmationAjout.Location = new System.Drawing.Point(94, 110);
            this.confirmationAjout.Name = "confirmationAjout";
            this.confirmationAjout.Size = new System.Drawing.Size(258, 35);
            this.confirmationAjout.TabIndex = 7;
            this.confirmationAjout.Text = "Succès : Ajout effectué";
            this.confirmationAjout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmationAjout.Visible = false;
            // 
            // erreurAjout
            // 
            this.erreurAjout.BackColor = System.Drawing.Color.Transparent;
            this.erreurAjout.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurAjout.ForeColor = System.Drawing.Color.Tomato;
            this.erreurAjout.Location = new System.Drawing.Point(94, 102);
            this.erreurAjout.Name = "erreurAjout";
            this.erreurAjout.Size = new System.Drawing.Size(247, 50);
            this.erreurAjout.TabIndex = 4;
            this.erreurAjout.Text = "Erreur : nom incorrect";
            this.erreurAjout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.erreurAjout.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ajouter un rôle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomRole
            // 
            this.nomRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.nomRole.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomRole.ForeColor = System.Drawing.Color.White;
            this.nomRole.Location = new System.Drawing.Point(117, 67);
            this.nomRole.Name = "nomRole";
            this.nomRole.Size = new System.Drawing.Size(309, 31);
            this.nomRole.TabIndex = 3;
            // 
            // intituleRole
            // 
            this.intituleRole.AutoSize = true;
            this.intituleRole.BackColor = System.Drawing.Color.Transparent;
            this.intituleRole.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intituleRole.ForeColor = System.Drawing.SystemColors.Control;
            this.intituleRole.Location = new System.Drawing.Point(42, 77);
            this.intituleRole.Name = "intituleRole";
            this.intituleRole.Size = new System.Drawing.Size(57, 20);
            this.intituleRole.TabIndex = 2;
            this.intituleRole.Text = "Intitulé :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.supprimerRole);
            this.panel3.Controls.Add(this.ConfirmationSR);
            this.panel3.Location = new System.Drawing.Point(532, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 204);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supprimer un rôle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmationSR
            // 
            this.ConfirmationSR.AutoSize = true;
            this.ConfirmationSR.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmationSR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationSR.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmationSR.Location = new System.Drawing.Point(155, 93);
            this.ConfirmationSR.Name = "ConfirmationSR";
            this.ConfirmationSR.Size = new System.Drawing.Size(178, 24);
            this.ConfirmationSR.TabIndex = 2;
            this.ConfirmationSR.Text = "Confirmer la procédure";
            this.ConfirmationSR.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.anonymousIcon);
            this.panel4.Controls.Add(this.userSelectionne);
            this.panel4.Controls.Add(this.userIcon);
            this.panel4.Controls.Add(this.programName);
            this.panel4.Controls.Add(this.homeIcon);
            this.panel4.Controls.Add(this.dbERROR);
            this.panel4.Controls.Add(this.dbOK);
            this.panel4.Controls.Add(this.magasinSelectionne);
            this.panel4.Controls.Add(this.msgBDstatusERROR);
            this.panel4.Controls.Add(this.msgBDstatusOK);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1045, 49);
            this.panel4.TabIndex = 4;
            // 
            // anonymousIcon
            // 
            this.anonymousIcon.BackColor = System.Drawing.Color.Transparent;
            this.anonymousIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.anonymousIcon.Image = ((System.Drawing.Image)(resources.GetObject("anonymousIcon.Image")));
            this.anonymousIcon.Location = new System.Drawing.Point(522, 7);
            this.anonymousIcon.Name = "anonymousIcon";
            this.anonymousIcon.Size = new System.Drawing.Size(33, 33);
            this.anonymousIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anonymousIcon.TabIndex = 18;
            this.anonymousIcon.TabStop = false;
            this.anonymousIcon.Visible = false;
            // 
            // userSelectionne
            // 
            this.userSelectionne.BackColor = System.Drawing.Color.Transparent;
            this.userSelectionne.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSelectionne.ForeColor = System.Drawing.Color.Snow;
            this.userSelectionne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userSelectionne.Location = new System.Drawing.Point(562, 11);
            this.userSelectionne.Name = "userSelectionne";
            this.userSelectionne.Size = new System.Drawing.Size(188, 25);
            this.userSelectionne.TabIndex = 17;
            this.userSelectionne.Text = "Non connecté";
            this.userSelectionne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.Transparent;
            this.userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.Location = new System.Drawing.Point(521, 7);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(33, 33);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIcon.TabIndex = 16;
            this.userIcon.TabStop = false;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(905, 0);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(140, 49);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeIcon.Image = ((System.Drawing.Image)(resources.GetObject("homeIcon.Image")));
            this.homeIcon.Location = new System.Drawing.Point(290, 8);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(31, 30);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 14;
            this.homeIcon.TabStop = false;
            // 
            // dbERROR
            // 
            this.dbERROR.BackColor = System.Drawing.Color.Transparent;
            this.dbERROR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbERROR.Image = ((System.Drawing.Image)(resources.GetObject("dbERROR.Image")));
            this.dbERROR.Location = new System.Drawing.Point(13, 9);
            this.dbERROR.Name = "dbERROR";
            this.dbERROR.Size = new System.Drawing.Size(31, 30);
            this.dbERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dbERROR.TabIndex = 13;
            this.dbERROR.TabStop = false;
            this.dbERROR.Visible = false;
            // 
            // dbOK
            // 
            this.dbOK.BackColor = System.Drawing.Color.Transparent;
            this.dbOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbOK.Image = ((System.Drawing.Image)(resources.GetObject("dbOK.Image")));
            this.dbOK.Location = new System.Drawing.Point(13, 8);
            this.dbOK.Name = "dbOK";
            this.dbOK.Size = new System.Drawing.Size(31, 30);
            this.dbOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dbOK.TabIndex = 12;
            this.dbOK.TabStop = false;
            // 
            // magasinSelectionne
            // 
            this.magasinSelectionne.BackColor = System.Drawing.Color.Transparent;
            this.magasinSelectionne.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.magasinSelectionne.ForeColor = System.Drawing.Color.Snow;
            this.magasinSelectionne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.magasinSelectionne.Location = new System.Drawing.Point(327, 11);
            this.magasinSelectionne.Name = "magasinSelectionne";
            this.magasinSelectionne.Size = new System.Drawing.Size(188, 25);
            this.magasinSelectionne.TabIndex = 11;
            this.magasinSelectionne.Text = "Aucun magasin sélectionné";
            this.magasinSelectionne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msgBDstatusERROR
            // 
            this.msgBDstatusERROR.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusERROR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusERROR.ForeColor = System.Drawing.Color.Tomato;
            this.msgBDstatusERROR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusERROR.Location = new System.Drawing.Point(50, 8);
            this.msgBDstatusERROR.Name = "msgBDstatusERROR";
            this.msgBDstatusERROR.Size = new System.Drawing.Size(217, 30);
            this.msgBDstatusERROR.TabIndex = 10;
            this.msgBDstatusERROR.Text = "Base de données non connectée";
            this.msgBDstatusERROR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgBDstatusERROR.Visible = false;
            this.msgBDstatusERROR.Click += new System.EventHandler(this.msgBDstatusERROR_Click);
            // 
            // msgBDstatusOK
            // 
            this.msgBDstatusOK.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusOK.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msgBDstatusOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusOK.Location = new System.Drawing.Point(50, 8);
            this.msgBDstatusOK.Name = "msgBDstatusOK";
            this.msgBDstatusOK.Size = new System.Drawing.Size(211, 30);
            this.msgBDstatusOK.TabIndex = 9;
            this.msgBDstatusOK.Text = "Connecté à la base de données";
            this.msgBDstatusOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel5.Controls.Add(this.goBackButton);
            this.panel5.Location = new System.Drawing.Point(-1, 571);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1045, 49);
            this.panel5.TabIndex = 5;
            // 
            // goBackButton
            // 
            this.goBackButton.AutoSize = true;
            this.goBackButton.BackColor = System.Drawing.Color.Transparent;
            this.goBackButton.FlatAppearance.BorderSize = 0;
            this.goBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.goBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goBackButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.goBackButton.Location = new System.Drawing.Point(361, 0);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(328, 47);
            this.goBackButton.TabIndex = 8;
            this.goBackButton.Text = "RETOUR À L\'ACCUEIL";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // panelERROR
            // 
            this.panelERROR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelERROR.Controls.Add(this.buttonBackHome);
            this.panelERROR.Controls.Add(this.label17);
            this.panelERROR.Controls.Add(this.label18);
            this.panelERROR.Controls.Add(this.buttonContactAdmin);
            this.panelERROR.Location = new System.Drawing.Point(-2, 47);
            this.panelERROR.Name = "panelERROR";
            this.panelERROR.Size = new System.Drawing.Size(1046, 127);
            this.panelERROR.TabIndex = 64;
            this.panelERROR.Visible = false;
            // 
            // buttonBackHome
            // 
            this.buttonBackHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackHome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBackHome.Location = new System.Drawing.Point(781, 79);
            this.buttonBackHome.Name = "buttonBackHome";
            this.buttonBackHome.Size = new System.Drawing.Size(241, 37);
            this.buttonBackHome.TabIndex = 59;
            this.buttonBackHome.Text = "Retour à l\'accueil";
            this.buttonBackHome.UseVisualStyleBackColor = false;
            this.buttonBackHome.Click += new System.EventHandler(this.buttonBackHome_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(23, 43);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(990, 33);
            this.label17.TabIndex = 37;
            this.label17.Text = "La base de données rattachée au logiciel est introuvable. Contactez votre adminis" +
    "trateur si l\'erreur persiste après redémarrage.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(21, 13);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 19);
            this.label18.TabIndex = 39;
            this.label18.Text = "ERREUR 01";
            // 
            // buttonContactAdmin
            // 
            this.buttonContactAdmin.BackColor = System.Drawing.Color.Transparent;
            this.buttonContactAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContactAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContactAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonContactAdmin.Location = new System.Drawing.Point(523, 79);
            this.buttonContactAdmin.Name = "buttonContactAdmin";
            this.buttonContactAdmin.Size = new System.Drawing.Size(241, 37);
            this.buttonContactAdmin.TabIndex = 58;
            this.buttonContactAdmin.Text = "Contacter l\'administrateur";
            this.buttonContactAdmin.UseVisualStyleBackColor = false;
            this.buttonContactAdmin.Click += new System.EventHandler(this.buttonContactAdmin_Click);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1042, 620);
            this.Controls.Add(this.panelERROR);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Roles";
            this.Text = "Gestion des rôles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Roles_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anonymousIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelERROR.ResumeLayout(false);
            this.panelERROR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox choixRoles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label intituleRole;
        public System.Windows.Forms.TextBox nomRole;
        private System.Windows.Forms.Button supprimerRole;
        public System.Windows.Forms.CheckBox ConfirmationSR;
        private System.Windows.Forms.Button ajouterRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label erreurAjout;
        private System.Windows.Forms.Label confirmationAjout;
        private System.Windows.Forms.Label erreurListevide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label msgBDstatusOK;
        private System.Windows.Forms.Label msgBDstatusERROR;
        private System.Windows.Forms.Label magasinSelectionne;
        private System.Windows.Forms.PictureBox dbOK;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox dbERROR;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panelERROR;
        private System.Windows.Forms.Button buttonBackHome;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonContactAdmin;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox anonymousIcon;
        private System.Windows.Forms.Label userSelectionne;
    }
}