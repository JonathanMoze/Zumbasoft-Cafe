
namespace ZumbaSoft.Fenetres_Ventes
{
    partial class AccueilClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilClient));
            this.label2 = new System.Windows.Forms.Label();
            this.erreurListevide = new System.Windows.Forms.Label();
            this.listClient = new System.Windows.Forms.ListBox();
            this.backgroundBlock = new System.Windows.Forms.Panel();
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.buttonModifierClient = new System.Windows.Forms.Button();
            this.buttonSupprimerClient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.anonymousIcon = new System.Windows.Forms.PictureBox();
            this.userSelectionne = new System.Windows.Forms.Label();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.magasinSelectionne = new System.Windows.Forms.Label();
            this.dbERROR = new System.Windows.Forms.PictureBox();
            this.programName = new System.Windows.Forms.Label();
            this.dbOK = new System.Windows.Forms.PictureBox();
            this.msgBDstatusERROR = new System.Windows.Forms.Label();
            this.panelERROR = new System.Windows.Forms.Panel();
            this.buttonBackHome = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonContactAdmin = new System.Windows.Forms.Button();
            this.msgBDstatusOK = new System.Windows.Forms.Label();
            this.backgroundBlock.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anonymousIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).BeginInit();
            this.panelERROR.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choix d\'un client";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erreurListevide
            // 
            this.erreurListevide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.erreurListevide.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurListevide.ForeColor = System.Drawing.Color.Transparent;
            this.erreurListevide.Location = new System.Drawing.Point(37, 128);
            this.erreurListevide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurListevide.Name = "erreurListevide";
            this.erreurListevide.Size = new System.Drawing.Size(380, 312);
            this.erreurListevide.TabIndex = 16;
            this.erreurListevide.Text = "Aucun client n\'est enregistré";
            this.erreurListevide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listClient
            // 
            this.listClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.listClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClient.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listClient.FormattingEnabled = true;
            this.listClient.ItemHeight = 24;
            this.listClient.Location = new System.Drawing.Point(37, 128);
            this.listClient.Margin = new System.Windows.Forms.Padding(2);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(380, 312);
            this.listClient.TabIndex = 17;
            // 
            // backgroundBlock
            // 
            this.backgroundBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock.Controls.Add(this.buttonAjouterClient);
            this.backgroundBlock.Controls.Add(this.buttonModifierClient);
            this.backgroundBlock.Controls.Add(this.buttonSupprimerClient);
            this.backgroundBlock.Location = new System.Drawing.Point(435, 85);
            this.backgroundBlock.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock.Name = "backgroundBlock";
            this.backgroundBlock.Size = new System.Drawing.Size(465, 355);
            this.backgroundBlock.TabIndex = 18;
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.BackColor = System.Drawing.Color.Transparent;
            this.buttonAjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAjouterClient.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouterClient.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAjouterClient.Location = new System.Drawing.Point(33, 53);
            this.buttonAjouterClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(399, 67);
            this.buttonAjouterClient.TabIndex = 2;
            this.buttonAjouterClient.Text = "Ajouter un nouveau client";
            this.buttonAjouterClient.UseVisualStyleBackColor = false;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouterClient_Click);
            // 
            // buttonModifierClient
            // 
            this.buttonModifierClient.BackColor = System.Drawing.Color.Transparent;
            this.buttonModifierClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifierClient.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifierClient.ForeColor = System.Drawing.Color.Transparent;
            this.buttonModifierClient.Location = new System.Drawing.Point(33, 145);
            this.buttonModifierClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifierClient.Name = "buttonModifierClient";
            this.buttonModifierClient.Size = new System.Drawing.Size(399, 67);
            this.buttonModifierClient.TabIndex = 4;
            this.buttonModifierClient.Text = "Modifier le client sélectionné";
            this.buttonModifierClient.UseVisualStyleBackColor = false;
            this.buttonModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
            // 
            // buttonSupprimerClient
            // 
            this.buttonSupprimerClient.BackColor = System.Drawing.Color.Transparent;
            this.buttonSupprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupprimerClient.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSupprimerClient.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSupprimerClient.Location = new System.Drawing.Point(33, 237);
            this.buttonSupprimerClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimerClient.Name = "buttonSupprimerClient";
            this.buttonSupprimerClient.Size = new System.Drawing.Size(399, 67);
            this.buttonSupprimerClient.TabIndex = 3;
            this.buttonSupprimerClient.Text = "Supprimer le client sélectionné";
            this.buttonSupprimerClient.UseVisualStyleBackColor = false;
            this.buttonSupprimerClient.Click += new System.EventHandler(this.buttonSupprimerClient_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.buttonAccueil);
            this.panel2.Location = new System.Drawing.Point(-1, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 49);
            this.panel2.TabIndex = 23;
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.AutoSize = true;
            this.buttonAccueil.BackColor = System.Drawing.Color.Transparent;
            this.buttonAccueil.FlatAppearance.BorderSize = 0;
            this.buttonAccueil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAccueil.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAccueil.Location = new System.Drawing.Point(417, 2);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(144, 47);
            this.buttonAccueil.TabIndex = 8;
            this.buttonAccueil.Text = "RETOUR";
            this.buttonAccueil.UseVisualStyleBackColor = false;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.msgBDstatusOK);
            this.panel4.Controls.Add(this.anonymousIcon);
            this.panel4.Controls.Add(this.userSelectionne);
            this.panel4.Controls.Add(this.userIcon);
            this.panel4.Controls.Add(this.homeIcon);
            this.panel4.Controls.Add(this.magasinSelectionne);
            this.panel4.Controls.Add(this.dbERROR);
            this.panel4.Controls.Add(this.programName);
            this.panel4.Controls.Add(this.dbOK);
            this.panel4.Controls.Add(this.msgBDstatusERROR);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(940, 49);
            this.panel4.TabIndex = 24;
            // 
            // anonymousIcon
            // 
            this.anonymousIcon.BackColor = System.Drawing.Color.Transparent;
            this.anonymousIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.anonymousIcon.Image = ((System.Drawing.Image)(resources.GetObject("anonymousIcon.Image")));
            this.anonymousIcon.Location = new System.Drawing.Point(515, 7);
            this.anonymousIcon.Name = "anonymousIcon";
            this.anonymousIcon.Size = new System.Drawing.Size(33, 33);
            this.anonymousIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anonymousIcon.TabIndex = 32;
            this.anonymousIcon.TabStop = false;
            this.anonymousIcon.Visible = false;
            // 
            // userSelectionne
            // 
            this.userSelectionne.BackColor = System.Drawing.Color.Transparent;
            this.userSelectionne.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSelectionne.ForeColor = System.Drawing.Color.Snow;
            this.userSelectionne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userSelectionne.Location = new System.Drawing.Point(555, 11);
            this.userSelectionne.Name = "userSelectionne";
            this.userSelectionne.Size = new System.Drawing.Size(188, 25);
            this.userSelectionne.TabIndex = 31;
            this.userSelectionne.Text = "Non connecté";
            this.userSelectionne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.Transparent;
            this.userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.Location = new System.Drawing.Point(514, 7);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(33, 33);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIcon.TabIndex = 30;
            this.userIcon.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeIcon.Image = ((System.Drawing.Image)(resources.GetObject("homeIcon.Image")));
            this.homeIcon.Location = new System.Drawing.Point(286, 8);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(31, 30);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 29;
            this.homeIcon.TabStop = false;
            // 
            // magasinSelectionne
            // 
            this.magasinSelectionne.BackColor = System.Drawing.Color.Transparent;
            this.magasinSelectionne.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.magasinSelectionne.ForeColor = System.Drawing.Color.Snow;
            this.magasinSelectionne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.magasinSelectionne.Location = new System.Drawing.Point(323, 5);
            this.magasinSelectionne.Name = "magasinSelectionne";
            this.magasinSelectionne.Size = new System.Drawing.Size(188, 38);
            this.magasinSelectionne.TabIndex = 28;
            this.magasinSelectionne.Text = "Aucun magasin sélectionné";
            this.magasinSelectionne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dbERROR
            // 
            this.dbERROR.BackColor = System.Drawing.Color.Transparent;
            this.dbERROR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbERROR.Image = ((System.Drawing.Image)(resources.GetObject("dbERROR.Image")));
            this.dbERROR.Location = new System.Drawing.Point(15, 9);
            this.dbERROR.Name = "dbERROR";
            this.dbERROR.Size = new System.Drawing.Size(31, 30);
            this.dbERROR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dbERROR.TabIndex = 27;
            this.dbERROR.TabStop = false;
            this.dbERROR.Visible = false;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(784, 2);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(140, 39);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbOK
            // 
            this.dbOK.BackColor = System.Drawing.Color.Transparent;
            this.dbOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbOK.Image = ((System.Drawing.Image)(resources.GetObject("dbOK.Image")));
            this.dbOK.Location = new System.Drawing.Point(15, 9);
            this.dbOK.Name = "dbOK";
            this.dbOK.Size = new System.Drawing.Size(31, 30);
            this.dbOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dbOK.TabIndex = 26;
            this.dbOK.TabStop = false;
            // 
            // msgBDstatusERROR
            // 
            this.msgBDstatusERROR.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusERROR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusERROR.ForeColor = System.Drawing.Color.Tomato;
            this.msgBDstatusERROR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusERROR.Location = new System.Drawing.Point(53, 5);
            this.msgBDstatusERROR.Name = "msgBDstatusERROR";
            this.msgBDstatusERROR.Size = new System.Drawing.Size(226, 38);
            this.msgBDstatusERROR.TabIndex = 25;
            this.msgBDstatusERROR.Text = "Base de données non connectée";
            this.msgBDstatusERROR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msgBDstatusERROR.Visible = false;
            this.msgBDstatusERROR.Click += new System.EventHandler(this.msgBDstatusERROR_Click);
            // 
            // panelERROR
            // 
            this.panelERROR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelERROR.Controls.Add(this.buttonBackHome);
            this.panelERROR.Controls.Add(this.label17);
            this.panelERROR.Controls.Add(this.label18);
            this.panelERROR.Controls.Add(this.buttonContactAdmin);
            this.panelERROR.Location = new System.Drawing.Point(-1, 46);
            this.panelERROR.Name = "panelERROR";
            this.panelERROR.Size = new System.Drawing.Size(940, 127);
            this.panelERROR.TabIndex = 70;
            this.panelERROR.Visible = false;
            // 
            // buttonBackHome
            // 
            this.buttonBackHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackHome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBackHome.Location = new System.Drawing.Point(681, 79);
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
            this.buttonContactAdmin.Location = new System.Drawing.Point(423, 79);
            this.buttonContactAdmin.Name = "buttonContactAdmin";
            this.buttonContactAdmin.Size = new System.Drawing.Size(241, 37);
            this.buttonContactAdmin.TabIndex = 58;
            this.buttonContactAdmin.Text = "Contacter l\'administrateur";
            this.buttonContactAdmin.UseVisualStyleBackColor = false;
            this.buttonContactAdmin.Click += new System.EventHandler(this.buttonContactAdmin_Click);
            // 
            // msgBDstatusOK
            // 
            this.msgBDstatusOK.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusOK.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.msgBDstatusOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusOK.Location = new System.Drawing.Point(53, 3);
            this.msgBDstatusOK.Name = "msgBDstatusOK";
            this.msgBDstatusOK.Size = new System.Drawing.Size(212, 38);
            this.msgBDstatusOK.TabIndex = 71;
            this.msgBDstatusOK.Text = "Connecté à la base de données";
            this.msgBDstatusOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccueilClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(935, 533);
            this.Controls.Add(this.panelERROR);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.backgroundBlock);
            this.Controls.Add(this.erreurListevide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccueilClient";
            this.Text = "Gestion des clients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccueilClient_FormClosed);
            this.backgroundBlock.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anonymousIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).EndInit();
            this.panelERROR.ResumeLayout(false);
            this.panelERROR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label erreurListevide;
        public System.Windows.Forms.ListBox listClient;
        private System.Windows.Forms.Panel backgroundBlock;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Button buttonModifierClient;
        private System.Windows.Forms.Button buttonSupprimerClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.PictureBox dbERROR;
        private System.Windows.Forms.PictureBox dbOK;
        private System.Windows.Forms.Label msgBDstatusERROR;
        private System.Windows.Forms.PictureBox anonymousIcon;
        private System.Windows.Forms.Label userSelectionne;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.Label magasinSelectionne;
        private System.Windows.Forms.Panel panelERROR;
        private System.Windows.Forms.Button buttonBackHome;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonContactAdmin;
        private System.Windows.Forms.Label msgBDstatusOK;
    }
}