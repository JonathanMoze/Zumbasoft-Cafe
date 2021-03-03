
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
            this.listMagasin = new System.Windows.Forms.ListBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.boutonAjouter = new System.Windows.Forms.Button();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMagasin
            // 
            this.listMagasin.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMagasin.FormattingEnabled = true;
            this.listMagasin.ItemHeight = 24;
            this.listMagasin.Location = new System.Drawing.Point(10, 95);
            this.listMagasin.Margin = new System.Windows.Forms.Padding(2);
            this.listMagasin.Name = "listMagasin";
            this.listMagasin.Size = new System.Drawing.Size(398, 292);
            this.listMagasin.TabIndex = 0;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitre.Location = new System.Drawing.Point(10, 10);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(145, 36);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Magasins";
            // 
            // boutonAjouter
            // 
            this.boutonAjouter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boutonAjouter.Location = new System.Drawing.Point(442, 133);
            this.boutonAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.boutonAjouter.Name = "boutonAjouter";
            this.boutonAjouter.Size = new System.Drawing.Size(101, 31);
            this.boutonAjouter.TabIndex = 2;
            this.boutonAjouter.Text = "Ajouter";
            this.boutonAjouter.UseVisualStyleBackColor = true;
            this.boutonAjouter.Click += new System.EventHandler(this.boutonAjouter_Click);
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boutonSupprimer.Location = new System.Drawing.Point(442, 268);
            this.boutonSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(101, 31);
            this.boutonSupprimer.TabIndex = 3;
            this.boutonSupprimer.Text = "Supprimer";
            this.boutonSupprimer.UseVisualStyleBackColor = true;
            this.boutonSupprimer.Click += new System.EventHandler(this.boutonSupprimer_Click);
            // 
            // boutonModifier
            // 
            this.boutonModifier.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boutonModifier.Location = new System.Drawing.Point(442, 206);
            this.boutonModifier.Margin = new System.Windows.Forms.Padding(2);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(101, 30);
            this.boutonModifier.TabIndex = 4;
            this.boutonModifier.Text = "Modifier";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des magasins :";
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(442, 335);
            this.buttonAccueil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(101, 32);
            this.buttonAccueil.TabIndex = 6;
            this.buttonAccueil.Text = "Accueil";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // AccueilMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 405);
            this.Controls.Add(this.buttonAccueil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.boutonAjouter);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.listMagasin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccueilMagasin";
            this.Text = "AccueilMagasin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMagasin;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button boutonAjouter;
        private System.Windows.Forms.Button boutonSupprimer;
        private System.Windows.Forms.Button boutonModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccueil;
    }
}