
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
            this.programName = new System.Windows.Forms.Label();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.dbERROR = new System.Windows.Forms.PictureBox();
            this.dbOK = new System.Windows.Forms.PictureBox();
            this.magasinSelectionne = new System.Windows.Forms.Label();
            this.msgBDstatusERROR = new System.Windows.Forms.Label();
            this.msgBDstatusOK = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajouterRoles
            // 
            this.ajouterRoles.AutoSize = true;
            this.ajouterRoles.FlatAppearance.BorderSize = 0;
            this.ajouterRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ajouterRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.supprimerRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.panel1.Size = new System.Drawing.Size(951, 204);
            this.panel1.TabIndex = 0;
            // 
            // erreurListevide
            // 
            this.erreurListevide.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurListevide.ForeColor = System.Drawing.Color.Transparent;
            this.erreurListevide.Location = new System.Drawing.Point(0, 56);
            this.erreurListevide.Name = "erreurListevide";
            this.erreurListevide.Size = new System.Drawing.Size(951, 147);
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
            this.choixRoles.ItemHeight = 25;
            this.choixRoles.Location = new System.Drawing.Point(0, 59);
            this.choixRoles.Name = "choixRoles";
            this.choixRoles.Size = new System.Drawing.Size(951, 125);
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
            this.nomRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomRole.ForeColor = System.Drawing.Color.White;
            this.nomRole.Location = new System.Drawing.Point(117, 67);
            this.nomRole.Name = "nomRole";
            this.nomRole.Size = new System.Drawing.Size(309, 36);
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
            this.intituleRole.Size = new System.Drawing.Size(68, 21);
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
            this.ConfirmationSR.Location = new System.Drawing.Point(135, 93);
            this.ConfirmationSR.Name = "ConfirmationSR";
            this.ConfirmationSR.Size = new System.Drawing.Size(210, 25);
            this.ConfirmationSR.TabIndex = 2;
            this.ConfirmationSR.Text = "Confirmer la procédure";
            this.ConfirmationSR.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
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
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(794, 0);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(203, 49);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE v.0";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeIcon.Image = ((System.Drawing.Image)(resources.GetObject("homeIcon.Image")));
            this.homeIcon.Location = new System.Drawing.Point(396, 8);
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
            this.dbERROR.Location = new System.Drawing.Point(46, 9);
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
            this.dbOK.Location = new System.Drawing.Point(45, 9);
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
            this.magasinSelectionne.Location = new System.Drawing.Point(424, 0);
            this.magasinSelectionne.Name = "magasinSelectionne";
            this.magasinSelectionne.Size = new System.Drawing.Size(245, 49);
            this.magasinSelectionne.TabIndex = 11;
            this.magasinSelectionne.Text = "Aucun magasin sélectionné";
            this.magasinSelectionne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msgBDstatusERROR
            // 
            this.msgBDstatusERROR.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusERROR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusERROR.ForeColor = System.Drawing.Color.Tomato;
            this.msgBDstatusERROR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusERROR.Location = new System.Drawing.Point(72, 0);
            this.msgBDstatusERROR.Name = "msgBDstatusERROR";
            this.msgBDstatusERROR.Size = new System.Drawing.Size(299, 49);
            this.msgBDstatusERROR.TabIndex = 10;
            this.msgBDstatusERROR.Text = "Base de données non connectée";
            this.msgBDstatusERROR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgBDstatusERROR.Visible = false;
            // 
            // msgBDstatusOK
            // 
            this.msgBDstatusOK.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusOK.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msgBDstatusOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusOK.Location = new System.Drawing.Point(72, 0);
            this.msgBDstatusOK.Name = "msgBDstatusOK";
            this.msgBDstatusOK.Size = new System.Drawing.Size(299, 49);
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
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1042, 620);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Roles";
            this.Text = "Gestion des rôles";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox choixRoles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label intituleRole;
        private System.Windows.Forms.TextBox nomRole;
        private System.Windows.Forms.Button supprimerRole;
        private System.Windows.Forms.CheckBox ConfirmationSR;
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
    }
}