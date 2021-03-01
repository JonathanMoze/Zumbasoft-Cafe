namespace ZumbaSoft
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGestionMag = new System.Windows.Forms.Button();
            this.RoleButton = new System.Windows.Forms.Button();
            this.buttonGestionStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accueil";
            // 
            // buttonGestionMag
            // 
            this.buttonGestionMag.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGestionMag.Location = new System.Drawing.Point(10, 126);
            this.buttonGestionMag.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGestionMag.Name = "buttonGestionMag";
            this.buttonGestionMag.Size = new System.Drawing.Size(158, 52);
            this.buttonGestionMag.TabIndex = 1;
            this.buttonGestionMag.Text = "Gestion des Magasins";
            this.buttonGestionMag.UseVisualStyleBackColor = true;
            this.buttonGestionMag.Click += new System.EventHandler(this.buttonGestionMag_Click);
            // 
            // RoleButton
            // 
            this.RoleButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoleButton.Location = new System.Drawing.Point(10, 194);
            this.RoleButton.Margin = new System.Windows.Forms.Padding(2);
            this.RoleButton.Name = "RoleButton";
            this.RoleButton.Size = new System.Drawing.Size(158, 52);
            this.RoleButton.TabIndex = 2;
            this.RoleButton.Text = "Gestion des Rôles";
            this.RoleButton.UseVisualStyleBackColor = true;
            this.RoleButton.Click += new System.EventHandler(this.RoleButton_Click);
            // 
            // buttonGestionStock
            // 
            this.buttonGestionStock.Location = new System.Drawing.Point(12, 267);
            this.buttonGestionStock.Name = "buttonGestionStock";
            this.buttonGestionStock.Size = new System.Drawing.Size(156, 48);
            this.buttonGestionStock.TabIndex = 3;
            this.buttonGestionStock.Text = "Gestion des Stocks";
            this.buttonGestionStock.UseVisualStyleBackColor = true;
            this.buttonGestionStock.Click += new System.EventHandler(this.buttonGestionStock_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.buttonGestionStock);
            this.Controls.Add(this.RoleButton);
            this.Controls.Add(this.buttonGestionMag);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accueil";
            this.Text = "ZumbaSoft - Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGestionMag;
        private System.Windows.Forms.Button RoleButton;
        private System.Windows.Forms.Button buttonGestionStock;
    }
}

