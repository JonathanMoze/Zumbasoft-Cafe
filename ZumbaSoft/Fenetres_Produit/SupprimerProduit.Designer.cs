
namespace ZumbaSoft.Fenetres_Produit
{
    partial class SupprimerProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprimerProduit));
            this.backgroundBlock1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSuppproduit = new System.Windows.Forms.Label();
            this.backgroundBlock2 = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.backgroundBlock1.SuspendLayout();
            this.backgroundBlock2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundBlock1
            // 
            this.backgroundBlock1.BackColor = System.Drawing.Color.Tomato;
            this.backgroundBlock1.Controls.Add(this.label1);
            this.backgroundBlock1.Location = new System.Drawing.Point(0, 1);
            this.backgroundBlock1.Name = "backgroundBlock1";
            this.backgroundBlock1.Size = new System.Drawing.Size(524, 91);
            this.backgroundBlock1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmation de suppression";
            // 
            // labelSuppproduit
            // 
            this.labelSuppproduit.AutoSize = true;
            this.labelSuppproduit.BackColor = System.Drawing.Color.Transparent;
            this.labelSuppproduit.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSuppproduit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelSuppproduit.Location = new System.Drawing.Point(29, 135);
            this.labelSuppproduit.Name = "labelSuppproduit";
            this.labelSuppproduit.Size = new System.Drawing.Size(334, 19);
            this.labelSuppproduit.TabIndex = 16;
            this.labelSuppproduit.Text = "Êtes vous sur de vouloir supprimer le produit ?";
            // 
            // backgroundBlock2
            // 
            this.backgroundBlock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.backgroundBlock2.Controls.Add(this.buttonAnnuler);
            this.backgroundBlock2.Controls.Add(this.buttonSupprimer);
            this.backgroundBlock2.Location = new System.Drawing.Point(0, 195);
            this.backgroundBlock2.Name = "backgroundBlock2";
            this.backgroundBlock2.Size = new System.Drawing.Size(524, 63);
            this.backgroundBlock2.TabIndex = 17;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnuler.Location = new System.Drawing.Point(204, 14);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(138, 37);
            this.buttonAnnuler.TabIndex = 3;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSupprimer.Location = new System.Drawing.Point(369, 14);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(138, 37);
            this.buttonSupprimer.TabIndex = 2;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // SupprimerProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(524, 258);
            this.Controls.Add(this.backgroundBlock2);
            this.Controls.Add(this.labelSuppproduit);
            this.Controls.Add(this.backgroundBlock1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupprimerProduit";
            this.Text = "Confirmation de suppression";
            this.backgroundBlock1.ResumeLayout(false);
            this.backgroundBlock1.PerformLayout();
            this.backgroundBlock2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backgroundBlock1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSuppproduit;
        private System.Windows.Forms.Panel backgroundBlock2;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonSupprimer;
    }
}