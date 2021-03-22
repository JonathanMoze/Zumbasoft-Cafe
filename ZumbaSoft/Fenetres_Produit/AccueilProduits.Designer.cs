
namespace ZumbaSoft.Fenetres_Produit
{
    partial class AccueilProduits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilProduits));
            this.panel4 = new System.Windows.Forms.Panel();
            this.programName = new System.Windows.Forms.Label();
            this.dbERROR = new System.Windows.Forms.PictureBox();
            this.dbOK = new System.Windows.Forms.PictureBox();
            this.msgBDstatusERROR = new System.Windows.Forms.Label();
            this.msgBDstatusOK = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRetourAccueil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.erreurListevide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundBlock = new System.Windows.Forms.Panel();
            this.buttonAjouterProduit = new System.Windows.Forms.Button();
            this.buttonModifierProduit = new System.Windows.Forms.Button();
            this.buttonSupprimerProduit = new System.Windows.Forms.Button();
            this.listProduits = new System.Windows.Forms.ListBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).BeginInit();
            this.panel1.SuspendLayout();
            this.backgroundBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.programName);
            this.panel4.Controls.Add(this.dbERROR);
            this.panel4.Controls.Add(this.dbOK);
            this.panel4.Controls.Add(this.msgBDstatusERROR);
            this.panel4.Controls.Add(this.msgBDstatusOK);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(801, 39);
            this.panel4.TabIndex = 13;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(639, 5);
            this.programName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(162, 29);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE v.0";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbERROR
            // 
            this.dbERROR.BackColor = System.Drawing.Color.Transparent;
            this.dbERROR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbERROR.Image = ((System.Drawing.Image)(resources.GetObject("dbERROR.Image")));
            this.dbERROR.Location = new System.Drawing.Point(37, 7);
            this.dbERROR.Margin = new System.Windows.Forms.Padding(2);
            this.dbERROR.Name = "dbERROR";
            this.dbERROR.Size = new System.Drawing.Size(25, 24);
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
            this.dbOK.Location = new System.Drawing.Point(36, 7);
            this.dbOK.Margin = new System.Windows.Forms.Padding(2);
            this.dbOK.Name = "dbOK";
            this.dbOK.Size = new System.Drawing.Size(25, 24);
            this.dbOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dbOK.TabIndex = 12;
            this.dbOK.TabStop = false;
            // 
            // msgBDstatusERROR
            // 
            this.msgBDstatusERROR.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusERROR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusERROR.ForeColor = System.Drawing.Color.Tomato;
            this.msgBDstatusERROR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusERROR.Location = new System.Drawing.Point(58, 4);
            this.msgBDstatusERROR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgBDstatusERROR.Name = "msgBDstatusERROR";
            this.msgBDstatusERROR.Size = new System.Drawing.Size(239, 30);
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
            this.msgBDstatusOK.Location = new System.Drawing.Point(58, 2);
            this.msgBDstatusOK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgBDstatusOK.Name = "msgBDstatusOK";
            this.msgBDstatusOK.Size = new System.Drawing.Size(239, 34);
            this.msgBDstatusOK.TabIndex = 9;
            this.msgBDstatusOK.Text = "Connecté à la base de données";
            this.msgBDstatusOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.buttonRetourAccueil);
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 39);
            this.panel1.TabIndex = 14;
            // 
            // buttonRetourAccueil
            // 
            this.buttonRetourAccueil.AutoSize = true;
            this.buttonRetourAccueil.BackColor = System.Drawing.Color.Transparent;
            this.buttonRetourAccueil.FlatAppearance.BorderSize = 0;
            this.buttonRetourAccueil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonRetourAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetourAccueil.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRetourAccueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRetourAccueil.Location = new System.Drawing.Point(269, 0);
            this.buttonRetourAccueil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetourAccueil.Name = "buttonRetourAccueil";
            this.buttonRetourAccueil.Size = new System.Drawing.Size(262, 39);
            this.buttonRetourAccueil.TabIndex = 8;
            this.buttonRetourAccueil.Text = "RETOUR À L\'ACCUEIL";
            this.buttonRetourAccueil.UseVisualStyleBackColor = false;
            this.buttonRetourAccueil.Click += new System.EventHandler(this.buttonRetourAccueil_Click);
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
            this.label2.Size = new System.Drawing.Size(292, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choix d\'un produit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // erreurListevide
            // 
            this.erreurListevide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.erreurListevide.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurListevide.ForeColor = System.Drawing.Color.Transparent;
            this.erreurListevide.Location = new System.Drawing.Point(254, 132);
            this.erreurListevide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurListevide.Name = "erreurListevide";
            this.erreurListevide.Size = new System.Drawing.Size(292, 168);
            this.erreurListevide.TabIndex = 17;
            this.erreurListevide.Text = "Aucun genre n\'est enregistré";
            this.erreurListevide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 168);
            this.label1.TabIndex = 16;
            this.label1.Text = "Aucun produit n\'est enregistré";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundBlock
            // 
            this.backgroundBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock.Controls.Add(this.buttonAjouterProduit);
            this.backgroundBlock.Controls.Add(this.buttonModifierProduit);
            this.backgroundBlock.Controls.Add(this.buttonSupprimerProduit);
            this.backgroundBlock.Location = new System.Drawing.Point(351, 98);
            this.backgroundBlock.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock.Name = "backgroundBlock";
            this.backgroundBlock.Size = new System.Drawing.Size(410, 211);
            this.backgroundBlock.TabIndex = 17;
            // 
            // buttonAjouterProduit
            // 
            this.buttonAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAjouterProduit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouterProduit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAjouterProduit.Location = new System.Drawing.Point(33, 28);
            this.buttonAjouterProduit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterProduit.Name = "buttonAjouterProduit";
            this.buttonAjouterProduit.Size = new System.Drawing.Size(343, 38);
            this.buttonAjouterProduit.TabIndex = 2;
            this.buttonAjouterProduit.Text = "Ajouter un nouveau produit";
            this.buttonAjouterProduit.UseVisualStyleBackColor = true;
            this.buttonAjouterProduit.Click += new System.EventHandler(this.buttonAjouterProduit_Click);
            // 
            // buttonModifierProduit
            // 
            this.buttonModifierProduit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifierProduit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifierProduit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonModifierProduit.Location = new System.Drawing.Point(33, 90);
            this.buttonModifierProduit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifierProduit.Name = "buttonModifierProduit";
            this.buttonModifierProduit.Size = new System.Drawing.Size(343, 38);
            this.buttonModifierProduit.TabIndex = 4;
            this.buttonModifierProduit.Text = "Modifier le produit sélectionné";
            this.buttonModifierProduit.UseVisualStyleBackColor = true;
            this.buttonModifierProduit.Click += new System.EventHandler(this.buttonModifierProduit_Click);
            // 
            // buttonSupprimerProduit
            // 
            this.buttonSupprimerProduit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupprimerProduit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSupprimerProduit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSupprimerProduit.Location = new System.Drawing.Point(33, 151);
            this.buttonSupprimerProduit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimerProduit.Name = "buttonSupprimerProduit";
            this.buttonSupprimerProduit.Size = new System.Drawing.Size(343, 38);
            this.buttonSupprimerProduit.TabIndex = 3;
            this.buttonSupprimerProduit.Text = "Supprimer le produit sélectionné";
            this.buttonSupprimerProduit.UseVisualStyleBackColor = true;
            this.buttonSupprimerProduit.Click += new System.EventHandler(this.buttonSupprimerProduit_Click);
            // 
            // listProduits
            // 
            this.listProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.listProduits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProduits.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listProduits.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listProduits.FormattingEnabled = true;
            this.listProduits.ItemHeight = 24;
            this.listProduits.Location = new System.Drawing.Point(36, 141);
            this.listProduits.Margin = new System.Windows.Forms.Padding(2);
            this.listProduits.Name = "listProduits";
            this.listProduits.Size = new System.Drawing.Size(292, 168);
            this.listProduits.TabIndex = 18;
            // 
            // AccueilProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.backgroundBlock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listProduits);
            this.Name = "AccueilProduits";
            this.Text = "AccueilProduits";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.backgroundBlock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.PictureBox dbERROR;
        private System.Windows.Forms.PictureBox dbOK;
        private System.Windows.Forms.Label msgBDstatusERROR;
        private System.Windows.Forms.Label msgBDstatusOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRetourAccueil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label erreurListevide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel backgroundBlock;
        private System.Windows.Forms.Button buttonAjouterProduit;
        private System.Windows.Forms.Button buttonModifierProduit;
        private System.Windows.Forms.Button buttonSupprimerProduit;
        private System.Windows.Forms.Button ue;
        private System.Windows.Forms.ListBox listProduits;
    }
}