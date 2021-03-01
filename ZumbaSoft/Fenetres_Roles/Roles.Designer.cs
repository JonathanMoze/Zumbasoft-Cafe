
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
            this.erreurListevide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choixRoles = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmationAjout = new System.Windows.Forms.Label();
            this.erreurAjout = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ajouterRoles = new System.Windows.Forms.Button();
            this.nomRole = new System.Windows.Forms.TextBox();
            this.intituleRole = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.supprimerRole = new System.Windows.Forms.Button();
            this.ConfirmationSR = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.erreurListevide);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.choixRoles);
            this.panel1.Location = new System.Drawing.Point(30, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 204);
            this.panel1.TabIndex = 0;
            // 
            // erreurListevide
            // 
            this.erreurListevide.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurListevide.ForeColor = System.Drawing.Color.DarkGray;
            this.erreurListevide.Location = new System.Drawing.Point(10, 90);
            this.erreurListevide.Name = "erreurListevide";
            this.erreurListevide.Size = new System.Drawing.Size(247, 61);
            this.erreurListevide.TabIndex = 8;
            this.erreurListevide.Text = "Aucun rôle n\'est enregistré";
            this.erreurListevide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choix d\'un rôle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choixRoles
            // 
            this.choixRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.choixRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.choixRoles.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choixRoles.FormattingEnabled = true;
            this.choixRoles.ItemHeight = 30;
            this.choixRoles.Location = new System.Drawing.Point(16, 65);
            this.choixRoles.Name = "choixRoles";
            this.choixRoles.Size = new System.Drawing.Size(241, 120);
            this.choixRoles.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.confirmationAjout);
            this.panel2.Controls.Add(this.erreurAjout);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ajouterRoles);
            this.panel2.Controls.Add(this.nomRole);
            this.panel2.Controls.Add(this.intituleRole);
            this.panel2.Location = new System.Drawing.Point(346, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 204);
            this.panel2.TabIndex = 2;
            // 
            // confirmationAjout
            // 
            this.confirmationAjout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmationAjout.ForeColor = System.Drawing.Color.Lime;
            this.confirmationAjout.Location = new System.Drawing.Point(14, 101);
            this.confirmationAjout.Name = "confirmationAjout";
            this.confirmationAjout.Size = new System.Drawing.Size(247, 50);
            this.confirmationAjout.TabIndex = 7;
            this.confirmationAjout.Text = "Succès : Ajout effectué";
            this.confirmationAjout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmationAjout.Visible = false;
            // 
            // erreurAjout
            // 
            this.erreurAjout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erreurAjout.ForeColor = System.Drawing.Color.Red;
            this.erreurAjout.Location = new System.Drawing.Point(14, 101);
            this.erreurAjout.Name = "erreurAjout";
            this.erreurAjout.Size = new System.Drawing.Size(247, 50);
            this.erreurAjout.TabIndex = 4;
            this.erreurAjout.Text = "Erreur : nom incorrect";
            this.erreurAjout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.erreurAjout.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ajouter un rôle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ajouterRoles
            // 
            this.ajouterRoles.AutoSize = true;
            this.ajouterRoles.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ajouterRoles.Location = new System.Drawing.Point(64, 154);
            this.ajouterRoles.Name = "ajouterRoles";
            this.ajouterRoles.Size = new System.Drawing.Size(152, 40);
            this.ajouterRoles.TabIndex = 6;
            this.ajouterRoles.Text = "Ajouter";
            this.ajouterRoles.UseVisualStyleBackColor = true;
            this.ajouterRoles.Click += new System.EventHandler(this.ajouterRoles_Click);
            // 
            // nomRole
            // 
            this.nomRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomRole.Location = new System.Drawing.Point(95, 62);
            this.nomRole.Name = "nomRole";
            this.nomRole.Size = new System.Drawing.Size(166, 36);
            this.nomRole.TabIndex = 3;
            // 
            // intituleRole
            // 
            this.intituleRole.AutoSize = true;
            this.intituleRole.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intituleRole.Location = new System.Drawing.Point(14, 67);
            this.intituleRole.Name = "intituleRole";
            this.intituleRole.Size = new System.Drawing.Size(90, 30);
            this.intituleRole.TabIndex = 2;
            this.intituleRole.Text = "Intitulé :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.supprimerRole);
            this.panel3.Controls.Add(this.ConfirmationSR);
            this.panel3.Location = new System.Drawing.Point(660, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 204);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supprimer un rôle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supprimerRole
            // 
            this.supprimerRole.AutoSize = true;
            this.supprimerRole.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supprimerRole.Location = new System.Drawing.Point(63, 154);
            this.supprimerRole.Name = "supprimerRole";
            this.supprimerRole.Size = new System.Drawing.Size(152, 40);
            this.supprimerRole.TabIndex = 5;
            this.supprimerRole.Text = "Supprimer";
            this.supprimerRole.UseVisualStyleBackColor = true;
            this.supprimerRole.Click += new System.EventHandler(this.supprimerRole_Click);
            // 
            // ConfirmationSR
            // 
            this.ConfirmationSR.AutoSize = true;
            this.ConfirmationSR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationSR.Location = new System.Drawing.Point(22, 67);
            this.ConfirmationSR.Name = "ConfirmationSR";
            this.ConfirmationSR.Size = new System.Drawing.Size(240, 32);
            this.ConfirmationSR.TabIndex = 2;
            this.ConfirmationSR.Text = "Confirmer la procédure";
            this.ConfirmationSR.UseVisualStyleBackColor = true;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Roles";
            this.Text = "Gestion des rôles";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox choixRoles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label intituleRole;
        private System.Windows.Forms.TextBox nomRole;
        private System.Windows.Forms.Button supprimerRole;
        private System.Windows.Forms.CheckBox ConfirmationSR;
        private System.Windows.Forms.Button ajouterRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label erreurAjout;
        private System.Windows.Forms.Label confirmationAjout;
        private System.Windows.Forms.Label erreurListevide;
    }
}