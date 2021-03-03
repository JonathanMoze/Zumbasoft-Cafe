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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGestionMag = new System.Windows.Forms.Button();
            this.RoleButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGestionStock = new System.Windows.Forms.Button();
            this.buttonSeConnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(402, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accueil";
            // 
            // buttonGestionMag
            // 
            this.buttonGestionMag.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGestionMag.Location = new System.Drawing.Point(128, 404);
            this.buttonGestionMag.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGestionMag.Name = "buttonGestionMag";
            this.buttonGestionMag.Size = new System.Drawing.Size(190, 81);
            this.buttonGestionMag.TabIndex = 1;
            this.buttonGestionMag.Text = "Gestion des Magasins";
            this.buttonGestionMag.UseVisualStyleBackColor = true;
            this.buttonGestionMag.Click += new System.EventHandler(this.buttonGestionMag_Click);
            // 
            // RoleButton
            // 
            this.RoleButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoleButton.Location = new System.Drawing.Point(361, 404);
            this.RoleButton.Margin = new System.Windows.Forms.Padding(2);
            this.RoleButton.Name = "RoleButton";
            this.RoleButton.Size = new System.Drawing.Size(198, 81);
            this.RoleButton.TabIndex = 2;
            this.RoleButton.Text = "Gestion des Rôles";
            this.RoleButton.UseVisualStyleBackColor = true;
            this.RoleButton.Click += new System.EventHandler(this.RoleButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.Gainsboro;
            this.title.Location = new System.Drawing.Point(245, 138);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(417, 79);
            this.title.TabIndex = 3;
            this.title.Text = "OUATELSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(361, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "ZUMBASOFT";
            // 
            // buttonGestionStock
            // 
            this.buttonGestionStock.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGestionStock.Location = new System.Drawing.Point(604, 404);
            this.buttonGestionStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGestionStock.Name = "buttonGestionStock";
            this.buttonGestionStock.Size = new System.Drawing.Size(198, 81);
            this.buttonGestionStock.TabIndex = 5;
            this.buttonGestionStock.Text = "Gestion des Stock";
            this.buttonGestionStock.UseVisualStyleBackColor = true;
            this.buttonGestionStock.Click += new System.EventHandler(this.buttonGestionStock_Click);
            // 
            // buttonSeConnecter
            // 
            this.buttonSeConnecter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSeConnecter.Location = new System.Drawing.Point(361, 520);
            this.buttonSeConnecter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSeConnecter.Name = "buttonSeConnecter";
            this.buttonSeConnecter.Size = new System.Drawing.Size(198, 45);
            this.buttonSeConnecter.TabIndex = 6;
            this.buttonSeConnecter.Text = "Se connecter";
            this.buttonSeConnecter.UseVisualStyleBackColor = true;
            this.buttonSeConnecter.Click += new System.EventHandler(this.buttonSeConnecter_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(919, 595);
            this.Controls.Add(this.buttonSeConnecter);
            this.Controls.Add(this.buttonGestionStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
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
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGestionStock;
        private System.Windows.Forms.Button buttonSeConnecter;
    }
}

