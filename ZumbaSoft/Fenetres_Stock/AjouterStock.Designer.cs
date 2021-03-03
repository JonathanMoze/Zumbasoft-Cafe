
namespace ZumbaSoft.Fenetres_Stock
{
    partial class AjouterStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuantiteStock = new System.Windows.Forms.Label();
            this.barreQuantite = new System.Windows.Forms.NumericUpDown();
            this.buttonOKstock = new System.Windows.Forms.Button();
            this.buttonAnnulerStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ajouter";
            // 
            // labelQuantiteStock
            // 
            this.labelQuantiteStock.AutoSize = true;
            this.labelQuantiteStock.Location = new System.Drawing.Point(53, 112);
            this.labelQuantiteStock.Name = "labelQuantiteStock";
            this.labelQuantiteStock.Size = new System.Drawing.Size(77, 20);
            this.labelQuantiteStock.TabIndex = 11;
            this.labelQuantiteStock.Text = "Quantité : ";
            // 
            // barreQuantite
            // 
            this.barreQuantite.Location = new System.Drawing.Point(171, 110);
            this.barreQuantite.Name = "barreQuantite";
            this.barreQuantite.Size = new System.Drawing.Size(100, 27);
            this.barreQuantite.TabIndex = 12;
            // 
            // buttonOKstock
            // 
            this.buttonOKstock.Location = new System.Drawing.Point(648, 341);
            this.buttonOKstock.Name = "buttonOKstock";
            this.buttonOKstock.Size = new System.Drawing.Size(94, 29);
            this.buttonOKstock.TabIndex = 13;
            this.buttonOKstock.Text = "OK";
            this.buttonOKstock.UseVisualStyleBackColor = true;
            this.buttonOKstock.Click += new System.EventHandler(this.buttonOKstock_Click);
            // 
            // buttonAnnulerStock
            // 
            this.buttonAnnulerStock.Location = new System.Drawing.Point(648, 389);
            this.buttonAnnulerStock.Name = "buttonAnnulerStock";
            this.buttonAnnulerStock.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnulerStock.TabIndex = 14;
            this.buttonAnnulerStock.Text = "Annuler";
            this.buttonAnnulerStock.UseVisualStyleBackColor = true;
            this.buttonAnnulerStock.Click += new System.EventHandler(this.buttonAnnulerStock_Click);
            // 
            // AjouterStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnnulerStock);
            this.Controls.Add(this.buttonOKstock);
            this.Controls.Add(this.barreQuantite);
            this.Controls.Add(this.labelQuantiteStock);
            this.Controls.Add(this.label1);
            this.Name = "AjouterStock";
            this.Text = "AjouterStock";
            ((System.ComponentModel.ISupportInitialize)(this.barreQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuantiteStock;
        private System.Windows.Forms.NumericUpDown barreQuantite;
        private System.Windows.Forms.Button buttonOKstock;
        private System.Windows.Forms.Button buttonAnnulerStock;
    }
}