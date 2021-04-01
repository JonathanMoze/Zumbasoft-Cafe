
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
            this.programName = new System.Windows.Forms.Label();
            this.backgroundBlock.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.erreurListevide.Size = new System.Drawing.Size(292, 312);
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
            this.listClient.Size = new System.Drawing.Size(292, 312);
            this.listClient.TabIndex = 17;
            // 
            // backgroundBlock
            // 
            this.backgroundBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock.Controls.Add(this.buttonAjouterClient);
            this.backgroundBlock.Controls.Add(this.buttonModifierClient);
            this.backgroundBlock.Controls.Add(this.buttonSupprimerClient);
            this.backgroundBlock.Location = new System.Drawing.Point(352, 85);
            this.backgroundBlock.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundBlock.Name = "backgroundBlock";
            this.backgroundBlock.Size = new System.Drawing.Size(464, 355);
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
            this.panel2.Size = new System.Drawing.Size(848, 49);
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
            this.buttonAccueil.Location = new System.Drawing.Point(356, 1);
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
            this.panel4.Controls.Add(this.programName);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 49);
            this.panel4.TabIndex = 24;
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
            // AccueilClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 533);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.backgroundBlock);
            this.Controls.Add(this.erreurListevide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listClient);
            this.Name = "AccueilClient";
            this.Text = "AccueilClient";
            this.backgroundBlock.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label erreurListevide;
        private System.Windows.Forms.ListBox listClient;
        private System.Windows.Forms.Panel backgroundBlock;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Button buttonModifierClient;
        private System.Windows.Forms.Button buttonSupprimerClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label programName;
    }
}