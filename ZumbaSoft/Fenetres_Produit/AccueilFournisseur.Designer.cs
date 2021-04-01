
namespace ZumbaSoft.Fenetres_Produit
{
    partial class AccueilFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilFournisseur));
            this.label2 = new System.Windows.Forms.Label();
            this.listFournisseur = new System.Windows.Forms.ListBox();
            this.erreurListevide = new System.Windows.Forms.Label();
            this.backgroundBlock = new System.Windows.Forms.Panel();
            this.buttonAjouterGenre = new System.Windows.Forms.Button();
            this.buttonModifierGenre = new System.Windows.Forms.Button();
            this.buttonSupprimerGenre = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.programName = new System.Windows.Forms.Label();
            this.backgroundBlock.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.label2.Size = new System.Drawing.Size(292, 43);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choix d\'un fournisseur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listFournisseur
            // 
            this.listFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.listFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFournisseur.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listFournisseur.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listFournisseur.FormattingEnabled = true;
            this.listFournisseur.ItemHeight = 24;
            this.listFournisseur.Location = new System.Drawing.Point(37, 128);
            this.listFournisseur.Margin = new System.Windows.Forms.Padding(2);
            this.listFournisseur.Name = "listFournisseur";
            this.listFournisseur.Size = new System.Drawing.Size(292, 312);
            this.listFournisseur.TabIndex = 15;
            // 
            // erreurListevide
            // 
            this.erreurListevide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.erreurListevide.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurListevide.ForeColor = System.Drawing.Color.Transparent;
            this.erreurListevide.Location = new System.Drawing.Point(37, 128);
            this.erreurListevide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurListevide.Name = "erreurListevide";
            this.erreurListevide.Size = new System.Drawing.Size(292, 312);
            this.erreurListevide.TabIndex = 16;
            this.erreurListevide.Text = "Aucun fournisseur n\'est enregistré";
            this.erreurListevide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundBlock
            // 
            this.backgroundBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock.Controls.Add(this.buttonAjouterGenre);
            this.backgroundBlock.Controls.Add(this.buttonModifierGenre);
            this.backgroundBlock.Controls.Add(this.buttonSupprimerGenre);
            this.backgroundBlock.Location = new System.Drawing.Point(352, 85);
            this.backgroundBlock.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock.Name = "backgroundBlock";
            this.backgroundBlock.Size = new System.Drawing.Size(464, 355);
            this.backgroundBlock.TabIndex = 18;
            // 
            // buttonAjouterGenre
            // 
            this.buttonAjouterGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterGenre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouterGenre.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAjouterGenre.Location = new System.Drawing.Point(33, 53);
            this.buttonAjouterGenre.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterGenre.Name = "buttonAjouterGenre";
            this.buttonAjouterGenre.Size = new System.Drawing.Size(399, 67);
            this.buttonAjouterGenre.TabIndex = 2;
            this.buttonAjouterGenre.Text = "Ajouter un nouveau fournisseur";
            this.buttonAjouterGenre.UseVisualStyleBackColor = true;
            this.buttonAjouterGenre.Click += new System.EventHandler(this.buttonAjouterFournisseur_Click);
            // 
            // buttonModifierGenre
            // 
            this.buttonModifierGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierGenre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModifierGenre.ForeColor = System.Drawing.Color.Transparent;
            this.buttonModifierGenre.Location = new System.Drawing.Point(33, 145);
            this.buttonModifierGenre.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifierGenre.Name = "buttonModifierGenre";
            this.buttonModifierGenre.Size = new System.Drawing.Size(399, 67);
            this.buttonModifierGenre.TabIndex = 4;
            this.buttonModifierGenre.Text = "Modifier le fournisseur sélectionné";
            this.buttonModifierGenre.UseVisualStyleBackColor = true;
            this.buttonModifierGenre.Click += new System.EventHandler(this.buttonModifierFournisseur_Click);
            // 
            // buttonSupprimerGenre
            // 
            this.buttonSupprimerGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerGenre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSupprimerGenre.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSupprimerGenre.Location = new System.Drawing.Point(33, 237);
            this.buttonSupprimerGenre.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimerGenre.Name = "buttonSupprimerGenre";
            this.buttonSupprimerGenre.Size = new System.Drawing.Size(399, 67);
            this.buttonSupprimerGenre.TabIndex = 3;
            this.buttonSupprimerGenre.Text = "Supprimer le fournisseur sélectionné";
            this.buttonSupprimerGenre.UseVisualStyleBackColor = true;
            this.buttonSupprimerGenre.Click += new System.EventHandler(this.buttonSupprimerFournisseur_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel5.Controls.Add(this.goBackButton);
            this.panel5.Location = new System.Drawing.Point(-1, 484);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(848, 49);
            this.panel5.TabIndex = 20;
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
            this.goBackButton.Location = new System.Drawing.Point(356, 1);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(144, 47);
            this.goBackButton.TabIndex = 8;
            this.goBackButton.Text = "RETOUR";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.programName);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 49);
            this.panel4.TabIndex = 19;
            // 
            // programName
            // 
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programName.ForeColor = System.Drawing.Color.Snow;
            this.programName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programName.Location = new System.Drawing.Point(708, 5);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(140, 39);
            this.programName.TabIndex = 15;
            this.programName.Text = "OUATELSE";
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccueilFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 533);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.backgroundBlock);
            this.Controls.Add(this.erreurListevide);
            this.Controls.Add(this.listFournisseur);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AccueilFournisseur";
            this.Text = "Gestion des fournisseurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccueilFournisseur_FormClosed);
            this.backgroundBlock.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listFournisseur;
        private System.Windows.Forms.Label erreurListevide;
        private System.Windows.Forms.Panel backgroundBlock;
        private System.Windows.Forms.Button buttonAjouterGenre;
        private System.Windows.Forms.Button buttonModifierGenre;
        private System.Windows.Forms.Button buttonSupprimerGenre;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label programName;
    }
}