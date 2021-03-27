
namespace ZumbaSoft.Fenetres_Stock
{
    partial class AccueilStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilStock));
            this.listStock = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.programName = new System.Windows.Forms.Label();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.dbERROR = new System.Windows.Forms.PictureBox();
            this.dbOK = new System.Windows.Forms.PictureBox();
            this.magasinSelectionne = new System.Windows.Forms.Label();
            this.msgBDstatusERROR = new System.Windows.Forms.Label();
            this.msgBDstatusOK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundBlock = new System.Windows.Forms.Panel();
            this.buttonAjouterStock = new System.Windows.Forms.Button();
            this.buttonModifierStock = new System.Windows.Forms.Button();
            this.buttonSuppStock = new System.Windows.Forms.Button();
            this.erreurListeVide = new System.Windows.Forms.Label();
            this.panelERROR = new System.Windows.Forms.Panel();
            this.buttonBackHome = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonContactAdmin = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).BeginInit();
            this.backgroundBlock.SuspendLayout();
            this.panelERROR.SuspendLayout();
            this.SuspendLayout();
            // 
            // listStock
            // 
            this.listStock.FormattingEnabled = true;
            this.listStock.ItemHeight = 20;
            this.listStock.Location = new System.Drawing.Point(36, 141);
            this.listStock.Name = "listStock";
            this.listStock.Size = new System.Drawing.Size(934, 504);
            this.listStock.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel5.Controls.Add(this.goBackButton);
            this.panel5.Location = new System.Drawing.Point(2, 700);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1118, 49);
            this.panel5.TabIndex = 63;
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
            this.goBackButton.Location = new System.Drawing.Point(403, 1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(328, 47);
            this.goBackButton.TabIndex = 8;
            this.goBackButton.Text = "RETOUR À L\'ACCUEIL";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
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
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1120, 49);
            this.panel4.TabIndex = 62;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(980, 6);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(140, 38);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeIcon.Image = ((System.Drawing.Image)(resources.GetObject("homeIcon.Image")));
            this.homeIcon.Location = new System.Drawing.Point(294, 9);
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
            this.dbERROR.Location = new System.Drawing.Point(12, 9);
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
            this.dbOK.Location = new System.Drawing.Point(12, 9);
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
            this.magasinSelectionne.Location = new System.Drawing.Point(335, 13);
            this.magasinSelectionne.Name = "magasinSelectionne";
            this.magasinSelectionne.Size = new System.Drawing.Size(189, 25);
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
            this.msgBDstatusERROR.Location = new System.Drawing.Point(49, 9);
            this.msgBDstatusERROR.Name = "msgBDstatusERROR";
            this.msgBDstatusERROR.Size = new System.Drawing.Size(223, 32);
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
            this.msgBDstatusOK.Location = new System.Drawing.Point(49, 6);
            this.msgBDstatusOK.Name = "msgBDstatusOK";
            this.msgBDstatusOK.Size = new System.Drawing.Size(223, 38);
            this.msgBDstatusOK.TabIndex = 9;
            this.msgBDstatusOK.Text = "Connecté à la base de données";
            this.msgBDstatusOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(933, 43);
            this.label2.TabIndex = 64;
            this.label2.Text = "Liste du stock des produits";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundBlock
            // 
            this.backgroundBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock.Controls.Add(this.buttonAjouterStock);
            this.backgroundBlock.Controls.Add(this.buttonModifierStock);
            this.backgroundBlock.Controls.Add(this.buttonSuppStock);
            this.backgroundBlock.Location = new System.Drawing.Point(1000, 98);
            this.backgroundBlock.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock.Name = "backgroundBlock";
            this.backgroundBlock.Size = new System.Drawing.Size(84, 547);
            this.backgroundBlock.TabIndex = 65;
            // 
            // buttonAjouterStock
            // 
            this.buttonAjouterStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAjouterStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAjouterStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouterStock.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAjouterStock.Image = ((System.Drawing.Image)(resources.GetObject("buttonAjouterStock.Image")));
            this.buttonAjouterStock.Location = new System.Drawing.Point(17, 20);
            this.buttonAjouterStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterStock.Name = "buttonAjouterStock";
            this.buttonAjouterStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAjouterStock.Size = new System.Drawing.Size(50, 50);
            this.buttonAjouterStock.TabIndex = 2;
            this.buttonAjouterStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAjouterStock.UseVisualStyleBackColor = true;
            this.buttonAjouterStock.Click += new System.EventHandler(this.buttonAjouterStock_Click);
            // 
            // buttonModifierStock
            // 
            this.buttonModifierStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifierStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifierStock.ForeColor = System.Drawing.Color.Transparent;
            this.buttonModifierStock.Image = ((System.Drawing.Image)(resources.GetObject("buttonModifierStock.Image")));
            this.buttonModifierStock.Location = new System.Drawing.Point(17, 95);
            this.buttonModifierStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifierStock.Name = "buttonModifierStock";
            this.buttonModifierStock.Size = new System.Drawing.Size(50, 50);
            this.buttonModifierStock.TabIndex = 4;
            this.buttonModifierStock.UseVisualStyleBackColor = true;
            this.buttonModifierStock.Click += new System.EventHandler(this.buttonModifierStock_Click);
            // 
            // buttonSuppStock
            // 
            this.buttonSuppStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSuppStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSuppStock.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSuppStock.Image = ((System.Drawing.Image)(resources.GetObject("buttonSuppStock.Image")));
            this.buttonSuppStock.Location = new System.Drawing.Point(17, 169);
            this.buttonSuppStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSuppStock.Name = "buttonSuppStock";
            this.buttonSuppStock.Size = new System.Drawing.Size(50, 50);
            this.buttonSuppStock.TabIndex = 3;
            this.buttonSuppStock.UseVisualStyleBackColor = true;
            this.buttonSuppStock.Click += new System.EventHandler(this.buttonSuppStock_Click);
            // 
            // erreurListeVide
            // 
            this.erreurListeVide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.erreurListeVide.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurListeVide.ForeColor = System.Drawing.Color.Transparent;
            this.erreurListeVide.Location = new System.Drawing.Point(37, 141);
            this.erreurListeVide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurListeVide.Name = "erreurListeVide";
            this.erreurListeVide.Size = new System.Drawing.Size(933, 504);
            this.erreurListeVide.TabIndex = 66;
            this.erreurListeVide.Text = "Aucun produit n\'est enregistré";
            this.erreurListeVide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelERROR
            // 
            this.panelERROR.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelERROR.Controls.Add(this.buttonBackHome);
            this.panelERROR.Controls.Add(this.label17);
            this.panelERROR.Controls.Add(this.label18);
            this.panelERROR.Controls.Add(this.buttonContactAdmin);
            this.panelERROR.Location = new System.Drawing.Point(0, 47);
            this.panelERROR.Name = "panelERROR";
            this.panelERROR.Size = new System.Drawing.Size(1120, 127);
            this.panelERROR.TabIndex = 67;
            this.panelERROR.Visible = false;
            // 
            // buttonBackHome
            // 
            this.buttonBackHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackHome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBackHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBackHome.Location = new System.Drawing.Point(858, 79);
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
            this.buttonContactAdmin.Location = new System.Drawing.Point(600, 79);
            this.buttonContactAdmin.Name = "buttonContactAdmin";
            this.buttonContactAdmin.Size = new System.Drawing.Size(241, 37);
            this.buttonContactAdmin.TabIndex = 58;
            this.buttonContactAdmin.Text = "Contacter l\'administrateur";
            this.buttonContactAdmin.UseVisualStyleBackColor = false;
            this.buttonContactAdmin.Click += new System.EventHandler(this.buttonContactAdmin_Click);
            // 
            // AccueilStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1120, 750);
            this.Controls.Add(this.panelERROR);
            this.Controls.Add(this.erreurListeVide);
            this.Controls.Add(this.backgroundBlock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AccueilStock";
            this.Text = "AccueilStock";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).EndInit();
            this.backgroundBlock.ResumeLayout(false);
            this.panelERROR.ResumeLayout(false);
            this.panelERROR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listStock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox dbERROR;
        private System.Windows.Forms.PictureBox dbOK;
        private System.Windows.Forms.Label magasinSelectionne;
        private System.Windows.Forms.Label msgBDstatusERROR;
        private System.Windows.Forms.Label msgBDstatusOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel backgroundBlock;
        private System.Windows.Forms.Button buttonAjouterStock;
        private System.Windows.Forms.Button buttonModifierStock;
        private System.Windows.Forms.Button buttonSuppStock;
        private System.Windows.Forms.Label erreurListeVide;
        private System.Windows.Forms.Panel panelERROR;
        private System.Windows.Forms.Button buttonBackHome;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonContactAdmin;
    }
}