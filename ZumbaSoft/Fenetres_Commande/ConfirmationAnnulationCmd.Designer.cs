
namespace ZumbaSoft.Fenetres_Commande
{
    partial class ConfirmationAnnulationCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationAnnulationCmd));
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonConfirmer = new System.Windows.Forms.Button();
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
            this.backgroundBlock1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Annulation";
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonConfirmer);
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Location = new System.Drawing.Point(-3, 189);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(524, 55);
            this.backgroundBlock2.TabIndex = 17;
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonConfirmer.Location = new System.Drawing.Point(383, 14);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(125, 30);
            this.buttonConfirmer.TabIndex = 1;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = true;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
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
            this.labelTexte.Location = new System.Drawing.Point(27, 122);
            this.labelTexte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTexte.Name = "labelTexte";
            this.labelTexte.Size = new System.Drawing.Size(360, 38);
            this.labelTexte.TabIndex = 19;
            this.labelTexte.Text = "Voulez-vous vraiment abandonner la commande ?\r\nCette action est irréversible.";
            // 
            // ConfirmationAnnulationCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 243);
            this.Controls.Add(this.labelTexte);
            this.Controls.Add(this.backgroundBlock1);
            this.Controls.Add(this.backgroundBlock2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfirmationAnnulationCmd";
            this.Text = "Confirmation d\'annulation";
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
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelTexte;
    }
}