
namespace ZumbaSoft.Fenetres_Stock
{
    partial class SupprimerStock
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
            this.buttonAnuuler = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTexte = new System.Windows.Forms.Label();
            this.barreQtt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.barreQtt)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnuuler
            // 
            this.buttonAnuuler.Location = new System.Drawing.Point(12, 215);
            this.buttonAnuuler.Name = "buttonAnuuler";
            this.buttonAnuuler.Size = new System.Drawing.Size(112, 34);
            this.buttonAnuuler.TabIndex = 0;
            this.buttonAnuuler.Text = "Annuler";
            this.buttonAnuuler.UseVisualStyleBackColor = true;
            this.buttonAnuuler.Click += new System.EventHandler(this.buttonAnuuler_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(254, 215);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(112, 34);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(326, 32);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Supprimer produit des stocks";
            // 
            // labelTexte
            // 
            this.labelTexte.AutoSize = true;
            this.labelTexte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTexte.Location = new System.Drawing.Point(12, 95);
            this.labelTexte.Name = "labelTexte";
            this.labelTexte.Size = new System.Drawing.Size(302, 25);
            this.labelTexte.TabIndex = 3;
            this.labelTexte.Text = "Veuillez saisir la quantité à supprimer";
            // 
            // barreQtt
            // 
            this.barreQtt.Location = new System.Drawing.Point(12, 143);
            this.barreQtt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.barreQtt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.barreQtt.Name = "barreQtt";
            this.barreQtt.Size = new System.Drawing.Size(180, 31);
            this.barreQtt.TabIndex = 4;
            this.barreQtt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SupprimerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.barreQtt);
            this.Controls.Add(this.labelTexte);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAnuuler);
            this.Name = "SupprimerStock";
            this.Text = "SupprimerStock";
            ((System.ComponentModel.ISupportInitialize)(this.barreQtt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnuuler;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTexte;
        private System.Windows.Forms.NumericUpDown barreQtt;
    }
}