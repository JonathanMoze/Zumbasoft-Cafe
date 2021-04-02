
namespace ZumbaSoft.Fenetres_Commande
{
    partial class ConfirmationSupressionCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationSupressionCommande));
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelTexte = new System.Windows.Forms.Label();
            this.backgroundBlock1.SuspendLayout();
            this.backgroundBlock2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.Tomato;
            this.backgroundBlock1.Controls.Add(this.label1);
            this.backgroundBlock1.Location = new System.Drawing.Point(-8, -1);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(524, 91);
            this.backgroundBlock1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppression";
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonSupprimer);
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Location = new System.Drawing.Point(-3, 189);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(524, 55);
            this.backgroundBlock2.TabIndex = 18;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSupprimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSupprimer.Location = new System.Drawing.Point(383, 14);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(125, 30);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnuler.Location = new System.Drawing.Point(235, 14);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(125, 30);
            this.buttonAnnuler.TabIndex = 0;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelTexte
            // 
            this.labelTexte.AutoSize = true;
            this.labelTexte.BackColor = System.Drawing.Color.Transparent;
            this.labelTexte.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTexte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTexte.Location = new System.Drawing.Point(27, 119);
            this.labelTexte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTexte.Name = "labelTexte";
            this.labelTexte.Size = new System.Drawing.Size(347, 38);
            this.labelTexte.TabIndex = 17;
            this.labelTexte.Text = "Voulez-vous vraiment supprimer la commande ?\r\nCette action est irréversible.";
            // 
            // ConfirmationSupressionCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 243);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.labelTexte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfirmationSupressionCommande";
            this.Text = "Confirmation de supression";
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.backgroundBlock2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelTexte;
    }
}