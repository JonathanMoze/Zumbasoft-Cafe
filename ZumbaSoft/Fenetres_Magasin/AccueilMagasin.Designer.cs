
namespace ZumbaSoft.Fenetres_Magasin
{
    partial class AccueilMagasin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilMagasin));
            this.listMagasin = new System.Windows.Forms.ListBox();
            this.buttonAjouterMagasin = new System.Windows.Forms.Button();
            this.buttonSupprimerMagasin = new System.Windows.Forms.Button();
            this.buttonModifierMagasin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.programName = new System.Windows.Forms.Label();
            this.dbERROR = new System.Windows.Forms.PictureBox();
            this.dbOK = new System.Windows.Forms.PictureBox();
            this.msgBDstatusERROR = new System.Windows.Forms.Label();
            this.msgBDstatusOK = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.erreurListevide = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundBlock = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).BeginInit();
            this.panel1.SuspendLayout();
            this.backgroundBlock.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMagasin
            // 
            this.listMagasin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.listMagasin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMagasin.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMagasin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listMagasin.FormattingEnabled = true;
            this.listMagasin.ItemHeight = 30;
            this.listMagasin.Location = new System.Drawing.Point(0, 54);
            this.listMagasin.Margin = new System.Windows.Forms.Padding(2);
            this.listMagasin.Name = "listMagasin";
            this.listMagasin.Size = new System.Drawing.Size(365, 210);
            this.listMagasin.TabIndex = 0;
            // 
            // buttonAjouterMagasin
            // 
            this.buttonAjouterMagasin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAjouterMagasin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouterMagasin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAjouterMagasin.Location = new System.Drawing.Point(41, 35);
            this.buttonAjouterMagasin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterMagasin.Name = "buttonAjouterMagasin";
            this.buttonAjouterMagasin.Size = new System.Drawing.Size(429, 47);
            this.buttonAjouterMagasin.TabIndex = 2;
            this.buttonAjouterMagasin.Text = "Ajouter un nouveau magasin";
            this.buttonAjouterMagasin.UseVisualStyleBackColor = true;
            this.buttonAjouterMagasin.Click += new System.EventHandler(this.boutonAjouter_Click);
            // 
            // buttonSupprimerMagasin
            // 
            this.buttonSupprimerMagasin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupprimerMagasin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSupprimerMagasin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSupprimerMagasin.Location = new System.Drawing.Point(41, 189);
            this.buttonSupprimerMagasin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimerMagasin.Name = "buttonSupprimerMagasin";
            this.buttonSupprimerMagasin.Size = new System.Drawing.Size(429, 47);
            this.buttonSupprimerMagasin.TabIndex = 3;
            this.buttonSupprimerMagasin.Text = "Supprimer le magasin sélectionné";
            this.buttonSupprimerMagasin.UseVisualStyleBackColor = true;
            this.buttonSupprimerMagasin.Click += new System.EventHandler(this.boutonSupprimer_Click);
            // 
            // buttonModifierMagasin
            // 
            this.buttonModifierMagasin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifierMagasin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifierMagasin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonModifierMagasin.Location = new System.Drawing.Point(41, 113);
            this.buttonModifierMagasin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifierMagasin.Name = "buttonModifierMagasin";
            this.buttonModifierMagasin.Size = new System.Drawing.Size(429, 47);
            this.buttonModifierMagasin.TabIndex = 4;
            this.buttonModifierMagasin.Text = "Modifier le magasin sélectionné";
            this.buttonModifierMagasin.UseVisualStyleBackColor = true;
            this.buttonModifierMagasin.Click += new System.EventHandler(this.boutonModifier_Click);
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
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 49);
            this.panel4.TabIndex = 7;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(839, 1);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(203, 49);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE v.0";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // msgBDstatusERROR
            // 
            this.msgBDstatusERROR.BackColor = System.Drawing.Color.Transparent;
            this.msgBDstatusERROR.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBDstatusERROR.ForeColor = System.Drawing.Color.Tomato;
            this.msgBDstatusERROR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msgBDstatusERROR.Location = new System.Drawing.Point(72, 5);
            this.msgBDstatusERROR.Name = "msgBDstatusERROR";
            this.msgBDstatusERROR.Size = new System.Drawing.Size(299, 37);
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
            this.msgBDstatusOK.Location = new System.Drawing.Point(72, 2);
            this.msgBDstatusOK.Name = "msgBDstatusOK";
            this.msgBDstatusOK.Size = new System.Drawing.Size(299, 42);
            this.msgBDstatusOK.TabIndex = 9;
            this.msgBDstatusOK.Text = "Connecté à la base de données";
            this.msgBDstatusOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.erreurListevide);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listMagasin);
            this.panel1.Location = new System.Drawing.Point(69, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 264);
            this.panel1.TabIndex = 8;
            // 
            // erreurListevide
            // 
            this.erreurListevide.BackColor = System.Drawing.Color.Transparent;
            this.erreurListevide.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurListevide.ForeColor = System.Drawing.Color.Transparent;
            this.erreurListevide.Location = new System.Drawing.Point(0, 54);
            this.erreurListevide.Name = "erreurListevide";
            this.erreurListevide.Size = new System.Drawing.Size(365, 210);
            this.erreurListevide.TabIndex = 8;
            this.erreurListevide.Text = "Aucun magasin n\'est enregistré";
            this.erreurListevide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(0, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choix d\'un magasin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundBlock
            // 
            this.backgroundBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock.Controls.Add(this.buttonAjouterMagasin);
            this.backgroundBlock.Controls.Add(this.buttonModifierMagasin);
            this.backgroundBlock.Controls.Add(this.buttonSupprimerMagasin);
            this.backgroundBlock.Location = new System.Drawing.Point(472, 106);
            this.backgroundBlock.Name = "backgroundBlock";
            this.backgroundBlock.Size = new System.Drawing.Size(512, 264);
            this.backgroundBlock.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel5.Controls.Add(this.goBackButton);
            this.panel5.Location = new System.Drawing.Point(2, 587);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1045, 49);
            this.panel5.TabIndex = 10;
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
            // AccueilMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1048, 637);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.backgroundBlock);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccueilMagasin";
            this.Text = "Gestion des magasins";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbERROR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.backgroundBlock.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listMagasin;
        private System.Windows.Forms.Button buttonAjouterMagasin;
        private System.Windows.Forms.Button buttonSupprimerMagasin;
        private System.Windows.Forms.Button buttonModifierMagasin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.PictureBox dbERROR;
        private System.Windows.Forms.PictureBox dbOK;
        private System.Windows.Forms.Label msgBDstatusERROR;
        private System.Windows.Forms.Label msgBDstatusOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label erreurListevide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel backgroundBlock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button goBackButton;
    }
}