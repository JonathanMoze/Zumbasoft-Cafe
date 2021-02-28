
namespace ZumbaSoft.Fenetres_Roles
{
    partial class Roles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.choixRoles = new System.Windows.Forms.ListBox();
            this.ChoixRole = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ajouterRoles = new System.Windows.Forms.Button();
            this.nomRole = new System.Windows.Forms.TextBox();
            this.intituleRole = new System.Windows.Forms.Label();
            this.AjoutRole = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.supprimerRole = new System.Windows.Forms.Button();
            this.ConfirmationSR = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.choixRoles);
            this.panel1.Controls.Add(this.ChoixRole);
            this.panel1.Location = new System.Drawing.Point(30, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 183);
            this.panel1.TabIndex = 0;
            // 
            // choixRoles
            // 
            this.choixRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.choixRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.choixRoles.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choixRoles.FormattingEnabled = true;
            this.choixRoles.ItemHeight = 25;
            this.choixRoles.Location = new System.Drawing.Point(16, 54);
            this.choixRoles.Name = "choixRoles";
            this.choixRoles.Size = new System.Drawing.Size(230, 75);
            this.choixRoles.TabIndex = 2;
            // 
            // ChoixRole
            // 
            this.ChoixRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ChoixRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChoixRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChoixRole.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ChoixRole.Location = new System.Drawing.Point(0, 0);
            this.ChoixRole.Margin = new System.Windows.Forms.Padding(0);
            this.ChoixRole.Multiline = true;
            this.ChoixRole.Name = "ChoixRole";
            this.ChoixRole.Size = new System.Drawing.Size(275, 40);
            this.ChoixRole.TabIndex = 1;
            this.ChoixRole.Text = "Choix D\'un Rôle";
            this.ChoixRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.ajouterRoles);
            this.panel2.Controls.Add(this.nomRole);
            this.panel2.Controls.Add(this.intituleRole);
            this.panel2.Controls.Add(this.AjoutRole);
            this.panel2.Location = new System.Drawing.Point(346, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 183);
            this.panel2.TabIndex = 2;
            // 
            // ajouterRoles
            // 
            this.ajouterRoles.AutoSize = true;
            this.ajouterRoles.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ajouterRoles.Location = new System.Drawing.Point(77, 118);
            this.ajouterRoles.Name = "ajouterRoles";
            this.ajouterRoles.Size = new System.Drawing.Size(111, 35);
            this.ajouterRoles.TabIndex = 6;
            this.ajouterRoles.Text = "Ajouter";
            this.ajouterRoles.UseVisualStyleBackColor = true;
            this.ajouterRoles.Click += new System.EventHandler(this.ajouterRoles_Click);
            // 
            // nomRole
            // 
            this.nomRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomRole.Location = new System.Drawing.Point(95, 51);
            this.nomRole.Name = "nomRole";
            this.nomRole.Size = new System.Drawing.Size(166, 31);
            this.nomRole.TabIndex = 3;
            // 
            // intituleRole
            // 
            this.intituleRole.AutoSize = true;
            this.intituleRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intituleRole.Location = new System.Drawing.Point(14, 54);
            this.intituleRole.Name = "intituleRole";
            this.intituleRole.Size = new System.Drawing.Size(75, 25);
            this.intituleRole.TabIndex = 2;
            this.intituleRole.Text = "Intitulé :";
            // 
            // AjoutRole
            // 
            this.AjoutRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.AjoutRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AjoutRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AjoutRole.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AjoutRole.Location = new System.Drawing.Point(0, 0);
            this.AjoutRole.Margin = new System.Windows.Forms.Padding(0);
            this.AjoutRole.Multiline = true;
            this.AjoutRole.Name = "AjoutRole";
            this.AjoutRole.Size = new System.Drawing.Size(275, 40);
            this.AjoutRole.TabIndex = 1;
            this.AjoutRole.Text = "Ajouter un rôle";
            this.AjoutRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel3.Controls.Add(this.supprimerRole);
            this.panel3.Controls.Add(this.ConfirmationSR);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(660, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 183);
            this.panel3.TabIndex = 3;
            // 
            // supprimerRole
            // 
            this.supprimerRole.AutoSize = true;
            this.supprimerRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supprimerRole.Location = new System.Drawing.Point(78, 118);
            this.supprimerRole.Name = "supprimerRole";
            this.supprimerRole.Size = new System.Drawing.Size(111, 35);
            this.supprimerRole.TabIndex = 5;
            this.supprimerRole.Text = "Supprimer";
            this.supprimerRole.UseVisualStyleBackColor = true;
            this.supprimerRole.Click += new System.EventHandler(this.supprimerRole_Click);
            // 
            // ConfirmationSR
            // 
            this.ConfirmationSR.AutoSize = true;
            this.ConfirmationSR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationSR.Location = new System.Drawing.Point(22, 54);
            this.ConfirmationSR.Name = "ConfirmationSR";
            this.ConfirmationSR.Size = new System.Drawing.Size(236, 32);
            this.ConfirmationSR.TabIndex = 2;
            this.ConfirmationSR.Text = "Confirmer la procédure";
            this.ConfirmationSR.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Supprimer un rôle";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Roles";
            this.Text = "Roles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ChoixRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AjoutRole;
        private System.Windows.Forms.ListBox choixRoles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label intituleRole;
        private System.Windows.Forms.TextBox nomRole;
        private System.Windows.Forms.Button supprimerRole;
        private System.Windows.Forms.CheckBox ConfirmationSR;
        private System.Windows.Forms.Button ajouterRoles;
    }
}