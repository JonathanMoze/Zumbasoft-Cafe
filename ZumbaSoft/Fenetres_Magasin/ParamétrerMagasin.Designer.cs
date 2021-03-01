
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Magasin
{
    partial class ParamétrerMagasin
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
            this.infosMag = new System.Windows.Forms.Label();
            this.buttonOKParamMag = new System.Windows.Forms.Button();
            this.buttonAnnulParamMag = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.labelMdp = new System.Windows.Forms.Label();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelCommande = new System.Windows.Forms.Label();
            this.labelEmployes = new System.Windows.Forms.Label();
            this.labelRapports = new System.Windows.Forms.Label();
            this.labelCurrentMdp = new System.Windows.Forms.Label();
            this.labelCurrentAdresse = new System.Windows.Forms.Label();
            this.buttonModifStock = new System.Windows.Forms.Button();
            this.buttonModifRprt = new System.Windows.Forms.Button();
            this.buttonModifEmpl = new System.Windows.Forms.Button();
            this.buttonModifCmd = new System.Windows.Forms.Button();
            this.buttonModifMdp = new System.Windows.Forms.Button();
            this.labelErrorMdp = new System.Windows.Forms.Label();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.listViewCommandes = new System.Windows.Forms.ListView();
            this.listViewEmployes = new System.Windows.Forms.ListView();
            this.listViewRapports = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // infosMag
            // 
            this.infosMag.AutoSize = true;
            this.infosMag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infosMag.Location = new System.Drawing.Point(12, 45);
            this.infosMag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infosMag.Name = "infosMag";
            this.infosMag.Size = new System.Drawing.Size(185, 32);
            this.infosMag.TabIndex = 0;
            this.infosMag.Text = "INFORMATIONS";
            // 
            // buttonOKParamMag
            // 
            this.buttonOKParamMag.Location = new System.Drawing.Point(1119, 684);
            this.buttonOKParamMag.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOKParamMag.Name = "buttonOKParamMag";
            this.buttonOKParamMag.Size = new System.Drawing.Size(118, 38);
            this.buttonOKParamMag.TabIndex = 1;
            this.buttonOKParamMag.Text = "OK";
            this.buttonOKParamMag.UseVisualStyleBackColor = true;
            this.buttonOKParamMag.Click += new System.EventHandler(this.buttonOKParamMag_Click);
            // 
            // buttonAnnulParamMag
            // 
            this.buttonAnnulParamMag.Location = new System.Drawing.Point(1119, 729);
            this.buttonAnnulParamMag.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnnulParamMag.Name = "buttonAnnulParamMag";
            this.buttonAnnulParamMag.Size = new System.Drawing.Size(118, 36);
            this.buttonAnnulParamMag.TabIndex = 2;
            this.buttonAnnulParamMag.Text = "Annuler";
            this.buttonAnnulParamMag.UseVisualStyleBackColor = true;
            this.buttonAnnulParamMag.Click += new System.EventHandler(this.buttonAnnulParamMag_Click);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(12, 102);
            this.labelMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(129, 25);
            this.labelMdp.TabIndex = 4;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(318, 145);
            this.textBoxMdp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(150, 31);
            this.textBoxMdp.TabIndex = 5;
            this.textBoxMdp.Visible = false;
            this.textBoxMdp.TextChanged += new System.EventHandler(this.textBoxMdp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adresse :";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(14, 262);
            this.labelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(55, 25);
            this.labelStock.TabIndex = 7;
            this.labelStock.Text = "Stock";
            // 
            // labelCommande
            // 
            this.labelCommande.AutoSize = true;
            this.labelCommande.Location = new System.Drawing.Point(314, 262);
            this.labelCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommande.Name = "labelCommande";
            this.labelCommande.Size = new System.Drawing.Size(113, 25);
            this.labelCommande.TabIndex = 8;
            this.labelCommande.Text = "Commandes";
            // 
            // labelEmployes
            // 
            this.labelEmployes.AutoSize = true;
            this.labelEmployes.Location = new System.Drawing.Point(628, 262);
            this.labelEmployes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployes.Name = "labelEmployes";
            this.labelEmployes.Size = new System.Drawing.Size(89, 25);
            this.labelEmployes.TabIndex = 9;
            this.labelEmployes.Text = "Employés";
            // 
            // labelRapports
            // 
            this.labelRapports.AutoSize = true;
            this.labelRapports.Location = new System.Drawing.Point(940, 262);
            this.labelRapports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRapports.Name = "labelRapports";
            this.labelRapports.Size = new System.Drawing.Size(85, 25);
            this.labelRapports.TabIndex = 18;
            this.labelRapports.Text = "Rapports";
            // 
            // labelCurrentMdp
            // 
            this.labelCurrentMdp.AutoSize = true;
            this.labelCurrentMdp.Location = new System.Drawing.Point(199, 102);
            this.labelCurrentMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentMdp.Name = "labelCurrentMdp";
            this.labelCurrentMdp.Size = new System.Drawing.Size(62, 25);
            this.labelCurrentMdp.TabIndex = 20;
            this.labelCurrentMdp.Text = "Aucun";
            // 
            // labelCurrentAdresse
            // 
            this.labelCurrentAdresse.AutoSize = true;
            this.labelCurrentAdresse.Location = new System.Drawing.Point(199, 201);
            this.labelCurrentAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentAdresse.Name = "labelCurrentAdresse";
            this.labelCurrentAdresse.Size = new System.Drawing.Size(71, 25);
            this.labelCurrentAdresse.TabIndex = 21;
            this.labelCurrentAdresse.Text = "Aucune";
            // 
            // buttonModifStock
            // 
            this.buttonModifStock.Location = new System.Drawing.Point(88, 580);
            this.buttonModifStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifStock.Name = "buttonModifStock";
            this.buttonModifStock.Size = new System.Drawing.Size(132, 36);
            this.buttonModifStock.TabIndex = 26;
            this.buttonModifStock.Text = "Modifier";
            this.buttonModifStock.UseVisualStyleBackColor = true;
            this.buttonModifStock.Click += new System.EventHandler(this.buttonModifStock_Click);
            // 
            // buttonModifRprt
            // 
            this.buttonModifRprt.Location = new System.Drawing.Point(1030, 582);
            this.buttonModifRprt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifRprt.Name = "buttonModifRprt";
            this.buttonModifRprt.Size = new System.Drawing.Size(132, 34);
            this.buttonModifRprt.TabIndex = 27;
            this.buttonModifRprt.Text = "Modifier";
            this.buttonModifRprt.UseVisualStyleBackColor = true;
            this.buttonModifRprt.Click += new System.EventHandler(this.buttonModifRprt_Click);
            // 
            // buttonModifEmpl
            // 
            this.buttonModifEmpl.Location = new System.Drawing.Point(392, 582);
            this.buttonModifEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifEmpl.Name = "buttonModifEmpl";
            this.buttonModifEmpl.Size = new System.Drawing.Size(129, 34);
            this.buttonModifEmpl.TabIndex = 28;
            this.buttonModifEmpl.Text = "Modifier";
            this.buttonModifEmpl.UseVisualStyleBackColor = true;
            this.buttonModifEmpl.Click += new System.EventHandler(this.buttonModifEmpl_Click);
            // 
            // buttonModifCmd
            // 
            this.buttonModifCmd.Location = new System.Drawing.Point(710, 581);
            this.buttonModifCmd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifCmd.Name = "buttonModifCmd";
            this.buttonModifCmd.Size = new System.Drawing.Size(129, 34);
            this.buttonModifCmd.TabIndex = 29;
            this.buttonModifCmd.Text = "Modifier";
            this.buttonModifCmd.UseVisualStyleBackColor = true;
            this.buttonModifCmd.Click += new System.EventHandler(this.buttonModifCmd_Click);
            // 
            // buttonModifMdp
            // 
            this.buttonModifMdp.Location = new System.Drawing.Point(199, 145);
            this.buttonModifMdp.Name = "buttonModifMdp";
            this.buttonModifMdp.Size = new System.Drawing.Size(112, 34);
            this.buttonModifMdp.TabIndex = 30;
            this.buttonModifMdp.Text = "Modifier";
            this.buttonModifMdp.UseVisualStyleBackColor = true;
            this.buttonModifMdp.Click += new System.EventHandler(this.buttonModifMdp_Click);
            // 
            // labelErrorMdp
            // 
            this.labelErrorMdp.AutoSize = true;
            this.labelErrorMdp.Location = new System.Drawing.Point(473, 148);
            this.labelErrorMdp.Name = "labelErrorMdp";
            this.labelErrorMdp.Size = new System.Drawing.Size(307, 25);
            this.labelErrorMdp.TabIndex = 31;
            this.labelErrorMdp.Text = "Veuillez saisir un mot de passe valide.";
            this.labelErrorMdp.Visible = false;
            // 
            // listViewStock
            // 
            this.listViewStock.HideSelection = false;
            this.listViewStock.Location = new System.Drawing.Point(12, 291);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(299, 284);
            this.listViewStock.TabIndex = 32;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCommandes
            // 
            this.listViewCommandes.HideSelection = false;
            this.listViewCommandes.Location = new System.Drawing.Point(318, 291);
            this.listViewCommandes.Name = "listViewCommandes";
            this.listViewCommandes.Size = new System.Drawing.Size(299, 284);
            this.listViewCommandes.TabIndex = 33;
            this.listViewCommandes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewEmployes
            // 
            this.listViewEmployes.HideSelection = false;
            this.listViewEmployes.Location = new System.Drawing.Point(623, 291);
            this.listViewEmployes.Name = "listViewEmployes";
            this.listViewEmployes.Size = new System.Drawing.Size(299, 284);
            this.listViewEmployes.TabIndex = 34;
            this.listViewEmployes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewRapports
            // 
            this.listViewRapports.HideSelection = false;
            this.listViewRapports.Location = new System.Drawing.Point(928, 291);
            this.listViewRapports.Name = "listViewRapports";
            this.listViewRapports.Size = new System.Drawing.Size(299, 284);
            this.listViewRapports.TabIndex = 35;
            this.listViewRapports.UseCompatibleStateImageBehavior = false;
            // 
            // ParamétrerMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 799);
            this.Controls.Add(this.listViewRapports);
            this.Controls.Add(this.listViewEmployes);
            this.Controls.Add(this.listViewCommandes);
            this.Controls.Add(this.listViewStock);
            this.Controls.Add(this.labelErrorMdp);
            this.Controls.Add(this.buttonModifMdp);
            this.Controls.Add(this.buttonModifCmd);
            this.Controls.Add(this.buttonModifEmpl);
            this.Controls.Add(this.buttonModifRprt);
            this.Controls.Add(this.buttonModifStock);
            this.Controls.Add(this.labelCurrentAdresse);
            this.Controls.Add(this.labelCurrentMdp);
            this.Controls.Add(this.labelRapports);
            this.Controls.Add(this.labelEmployes);
            this.Controls.Add(this.labelCommande);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.buttonAnnulParamMag);
            this.Controls.Add(this.buttonOKParamMag);
            this.Controls.Add(this.infosMag);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParamétrerMagasin";
            this.Text = "ZumbaSoft - Magasin";
            this.Load += new System.EventHandler(this.ParamétrerMagasin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infosMag;
        private System.Windows.Forms.Button buttonOKParamMag;
        private System.Windows.Forms.Button buttonAnnulParamMag;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelCommande;
        private System.Windows.Forms.Label labelEmployes;
        private System.Windows.Forms.Label labelRapports;
        private System.Windows.Forms.Label labelCurrentMdp;
        private System.Windows.Forms.Label labelCurrentAdresse;
        private System.Windows.Forms.Button buttonModifStock;
        private System.Windows.Forms.Button buttonModifRprt;
        private System.Windows.Forms.Button buttonModifEmpl;
        private System.Windows.Forms.Button buttonModifCmd;
        private System.Windows.Forms.Button buttonModifMdp;
        private System.Windows.Forms.Label labelErrorMdp;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.ListView listViewCommandes;
        private System.Windows.Forms.ListView listViewEmployes;
        private System.Windows.Forms.ListView listViewRapports;
    }
}