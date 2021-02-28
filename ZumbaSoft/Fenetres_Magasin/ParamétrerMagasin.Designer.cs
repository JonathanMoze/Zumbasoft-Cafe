
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
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelCommande = new System.Windows.Forms.Label();
            this.labelEmployes = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelRapports = new System.Windows.Forms.Label();
            this.labelCurrentMdp = new System.Windows.Forms.Label();
            this.labelCurrentAdresse = new System.Windows.Forms.Label();
            this.listViewStock = new System.Windows.Forms.ListView();
            this.ListViewCommande = new System.Windows.Forms.ListView();
            this.listViewEmployes = new System.Windows.Forms.ListView();
            this.listViewRapports = new System.Windows.Forms.ListView();
            this.buttonModifStock = new System.Windows.Forms.Button();
            this.buttonModifRprt = new System.Windows.Forms.Button();
            this.buttonModifEmpl = new System.Windows.Forms.Button();
            this.buttonModifCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infosMag
            // 
            this.infosMag.AutoSize = true;
            this.infosMag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infosMag.Location = new System.Drawing.Point(10, 36);
            this.infosMag.Name = "infosMag";
            this.infosMag.Size = new System.Drawing.Size(155, 28);
            this.infosMag.TabIndex = 0;
            this.infosMag.Text = "INFORMATIONS";
            // 
            // buttonOKParamMag
            // 
            this.buttonOKParamMag.Location = new System.Drawing.Point(895, 547);
            this.buttonOKParamMag.Name = "buttonOKParamMag";
            this.buttonOKParamMag.Size = new System.Drawing.Size(94, 30);
            this.buttonOKParamMag.TabIndex = 1;
            this.buttonOKParamMag.Text = "OK";
            this.buttonOKParamMag.UseVisualStyleBackColor = true;
            this.buttonOKParamMag.Click += new System.EventHandler(this.buttonOKParamMag_Click);
            // 
            // buttonAnnulParamMag
            // 
            this.buttonAnnulParamMag.Location = new System.Drawing.Point(895, 583);
            this.buttonAnnulParamMag.Name = "buttonAnnulParamMag";
            this.buttonAnnulParamMag.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnulParamMag.TabIndex = 2;
            this.buttonAnnulParamMag.Text = "Annuler";
            this.buttonAnnulParamMag.UseVisualStyleBackColor = true;
            this.buttonAnnulParamMag.Click += new System.EventHandler(this.buttonAnnulParamMag_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(10, 82);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(105, 20);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "Mot de passe :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(308, 80);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(121, 27);
            this.textBoxNom.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adresse :";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(11, 210);
            this.labelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(45, 20);
            this.labelStock.TabIndex = 7;
            this.labelStock.Text = "Stock";
            // 
            // labelCommande
            // 
            this.labelCommande.AutoSize = true;
            this.labelCommande.Location = new System.Drawing.Point(251, 210);
            this.labelCommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommande.Name = "labelCommande";
            this.labelCommande.Size = new System.Drawing.Size(92, 20);
            this.labelCommande.TabIndex = 8;
            this.labelCommande.Text = "Commandes";
            // 
            // labelEmployes
            // 
            this.labelEmployes.AutoSize = true;
            this.labelEmployes.Location = new System.Drawing.Point(502, 210);
            this.labelEmployes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployes.Name = "labelEmployes";
            this.labelEmployes.Size = new System.Drawing.Size(73, 20);
            this.labelEmployes.TabIndex = 9;
            this.labelEmployes.Text = "Employés";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(308, 131);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 27);
            this.textBox3.TabIndex = 12;
            // 
            // labelRapports
            // 
            this.labelRapports.AutoSize = true;
            this.labelRapports.Location = new System.Drawing.Point(752, 210);
            this.labelRapports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRapports.Name = "labelRapports";
            this.labelRapports.Size = new System.Drawing.Size(69, 20);
            this.labelRapports.TabIndex = 18;
            this.labelRapports.Text = "Rapports";
            // 
            // labelCurrentMdp
            // 
            this.labelCurrentMdp.AutoSize = true;
            this.labelCurrentMdp.Location = new System.Drawing.Point(159, 82);
            this.labelCurrentMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentMdp.Name = "labelCurrentMdp";
            this.labelCurrentMdp.Size = new System.Drawing.Size(50, 20);
            this.labelCurrentMdp.TabIndex = 20;
            this.labelCurrentMdp.Text = "Aucun";
            // 
            // labelCurrentAdresse
            // 
            this.labelCurrentAdresse.AutoSize = true;
            this.labelCurrentAdresse.Location = new System.Drawing.Point(159, 131);
            this.labelCurrentAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentAdresse.Name = "labelCurrentAdresse";
            this.labelCurrentAdresse.Size = new System.Drawing.Size(58, 20);
            this.labelCurrentAdresse.TabIndex = 21;
            this.labelCurrentAdresse.Text = "Aucune";
            // 
            // listViewStock
            // 
            this.listViewStock.HideSelection = false;
            this.listViewStock.Location = new System.Drawing.Point(11, 234);
            this.listViewStock.Margin = new System.Windows.Forms.Padding(2);
            this.listViewStock.Name = "listViewStock";
            this.listViewStock.Size = new System.Drawing.Size(229, 213);
            this.listViewStock.TabIndex = 22;
            this.listViewStock.UseCompatibleStateImageBehavior = false;
            // 
            // ListViewCommande
            // 
            this.ListViewCommande.HideSelection = false;
            this.ListViewCommande.Location = new System.Drawing.Point(254, 234);
            this.ListViewCommande.Margin = new System.Windows.Forms.Padding(2);
            this.ListViewCommande.Name = "ListViewCommande";
            this.ListViewCommande.Size = new System.Drawing.Size(235, 213);
            this.ListViewCommande.TabIndex = 23;
            this.ListViewCommande.UseCompatibleStateImageBehavior = false;
            // 
            // listViewEmployes
            // 
            this.listViewEmployes.HideSelection = false;
            this.listViewEmployes.Location = new System.Drawing.Point(502, 234);
            this.listViewEmployes.Margin = new System.Windows.Forms.Padding(2);
            this.listViewEmployes.Name = "listViewEmployes";
            this.listViewEmployes.Size = new System.Drawing.Size(235, 213);
            this.listViewEmployes.TabIndex = 24;
            this.listViewEmployes.UseCompatibleStateImageBehavior = false;
            // 
            // listViewRapports
            // 
            this.listViewRapports.HideSelection = false;
            this.listViewRapports.Location = new System.Drawing.Point(752, 234);
            this.listViewRapports.Margin = new System.Windows.Forms.Padding(2);
            this.listViewRapports.Name = "listViewRapports";
            this.listViewRapports.Size = new System.Drawing.Size(237, 213);
            this.listViewRapports.TabIndex = 25;
            this.listViewRapports.UseCompatibleStateImageBehavior = false;
            // 
            // buttonModifStock
            // 
            this.buttonModifStock.Location = new System.Drawing.Point(70, 464);
            this.buttonModifStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifStock.Name = "buttonModifStock";
            this.buttonModifStock.Size = new System.Drawing.Size(106, 29);
            this.buttonModifStock.TabIndex = 26;
            this.buttonModifStock.Text = "Modifier";
            this.buttonModifStock.UseVisualStyleBackColor = true;
            // 
            // buttonModifRprt
            // 
            this.buttonModifRprt.Location = new System.Drawing.Point(824, 466);
            this.buttonModifRprt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifRprt.Name = "buttonModifRprt";
            this.buttonModifRprt.Size = new System.Drawing.Size(106, 27);
            this.buttonModifRprt.TabIndex = 27;
            this.buttonModifRprt.Text = "Modifier";
            this.buttonModifRprt.UseVisualStyleBackColor = true;
            // 
            // buttonModifEmpl
            // 
            this.buttonModifEmpl.Location = new System.Drawing.Point(314, 466);
            this.buttonModifEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifEmpl.Name = "buttonModifEmpl";
            this.buttonModifEmpl.Size = new System.Drawing.Size(103, 27);
            this.buttonModifEmpl.TabIndex = 28;
            this.buttonModifEmpl.Text = "Modifier";
            this.buttonModifEmpl.UseVisualStyleBackColor = true;
            // 
            // buttonModifCmd
            // 
            this.buttonModifCmd.Location = new System.Drawing.Point(568, 465);
            this.buttonModifCmd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifCmd.Name = "buttonModifCmd";
            this.buttonModifCmd.Size = new System.Drawing.Size(103, 27);
            this.buttonModifCmd.TabIndex = 29;
            this.buttonModifCmd.Text = "Modifier";
            this.buttonModifCmd.UseVisualStyleBackColor = true;
            // 
            // ParamétrerMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 639);
            this.Controls.Add(this.buttonModifCmd);
            this.Controls.Add(this.buttonModifEmpl);
            this.Controls.Add(this.buttonModifRprt);
            this.Controls.Add(this.buttonModifStock);
            this.Controls.Add(this.listViewRapports);
            this.Controls.Add(this.listViewEmployes);
            this.Controls.Add(this.ListViewCommande);
            this.Controls.Add(this.listViewStock);
            this.Controls.Add(this.labelCurrentAdresse);
            this.Controls.Add(this.labelCurrentMdp);
            this.Controls.Add(this.labelRapports);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelEmployes);
            this.Controls.Add(this.labelCommande);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonAnnulParamMag);
            this.Controls.Add(this.buttonOKParamMag);
            this.Controls.Add(this.infosMag);
            this.Name = "ParamétrerMagasin";
            this.Text = "te";
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
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelCommande;
        private System.Windows.Forms.Label labelEmployes;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelRapports;
        private System.Windows.Forms.Label labelCurrentMdp;
        private System.Windows.Forms.Label labelCurrentAdresse;
        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.ListView ListViewCommande;
        private System.Windows.Forms.ListView listViewEmployes;
        private System.Windows.Forms.ListView listViewRapports;
        private System.Windows.Forms.Button buttonModifStock;
        private System.Windows.Forms.Button buttonModifRprt;
        private System.Windows.Forms.Button buttonModifEmpl;
        private System.Windows.Forms.Button buttonModifCmd;
    }
}