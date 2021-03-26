
namespace ZumbaSoft.Fenetres_Ventes
{
    partial class AccueilVente
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonCatalogueProd = new System.Windows.Forms.Button();
            this.labelCatalogue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRechercheClient = new System.Windows.Forms.TextBox();
            this.listBox1RechercheClient = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.buttonEnregistrerClient = new System.Windows.Forms.Button();
            this.buttonAnnulerCommand = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonFacture = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contenu de la commande (panier)";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(354, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(499, 497);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonCatalogueProd
            // 
            this.buttonCatalogueProd.Location = new System.Drawing.Point(39, 53);
            this.buttonCatalogueProd.Name = "buttonCatalogueProd";
            this.buttonCatalogueProd.Size = new System.Drawing.Size(169, 42);
            this.buttonCatalogueProd.TabIndex = 3;
            this.buttonCatalogueProd.Text = "Catalogue produits";
            this.buttonCatalogueProd.UseVisualStyleBackColor = true;
            // 
            // labelCatalogue
            // 
            this.labelCatalogue.AutoSize = true;
            this.labelCatalogue.Location = new System.Drawing.Point(24, 19);
            this.labelCatalogue.Name = "labelCatalogue";
            this.labelCatalogue.Size = new System.Drawing.Size(208, 20);
            this.labelCatalogue.TabIndex = 4;
            this.labelCatalogue.Text = "Ajouter un produit au panier : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Commande effectuée par :";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Location = new System.Drawing.Point(70, 63);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(100, 20);
            this.labelNomClient.TabIndex = 6;
            this.labelNomClient.Text = "nom du client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.labelNomClient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(41, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 114);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.buttonCatalogueProd);
            this.panel2.Controls.Add(this.labelCatalogue);
            this.panel2.Location = new System.Drawing.Point(875, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 114);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(41, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 42);
            this.panel3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client existant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // textBoxRechercheClient
            // 
            this.textBoxRechercheClient.Location = new System.Drawing.Point(41, 219);
            this.textBoxRechercheClient.Name = "textBoxRechercheClient";
            this.textBoxRechercheClient.PlaceholderText = "Recherche...";
            this.textBoxRechercheClient.Size = new System.Drawing.Size(250, 27);
            this.textBoxRechercheClient.TabIndex = 11;
            this.textBoxRechercheClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1RechercheClient
            // 
            this.listBox1RechercheClient.FormattingEnabled = true;
            this.listBox1RechercheClient.ItemHeight = 20;
            this.listBox1RechercheClient.Location = new System.Drawing.Point(41, 257);
            this.listBox1RechercheClient.Name = "listBox1RechercheClient";
            this.listBox1RechercheClient.Size = new System.Drawing.Size(250, 124);
            this.listBox1RechercheClient.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(41, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 42);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nouveau Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 5;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(41, 465);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.PlaceholderText = "Nom";
            this.textBoxNom.Size = new System.Drawing.Size(250, 27);
            this.textBoxNom.TabIndex = 13;
            this.textBoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(41, 498);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.PlaceholderText = "Prénom";
            this.textBoxPrenom.Size = new System.Drawing.Size(250, 27);
            this.textBoxPrenom.TabIndex = 14;
            this.textBoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(41, 532);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.PlaceholderText = "Ville";
            this.textBoxVille.Size = new System.Drawing.Size(151, 27);
            this.textBoxVille.TabIndex = 15;
            this.textBoxVille.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(198, 532);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.PlaceholderText = "Code Postal";
            this.textBoxCP.Size = new System.Drawing.Size(93, 27);
            this.textBoxCP.TabIndex = 16;
            this.textBoxCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(41, 565);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.PlaceholderText = "Téléphone";
            this.textBoxTel.Size = new System.Drawing.Size(250, 27);
            this.textBoxTel.TabIndex = 17;
            this.textBoxTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonEnregistrerClient
            // 
            this.buttonEnregistrerClient.Location = new System.Drawing.Point(73, 600);
            this.buttonEnregistrerClient.Name = "buttonEnregistrerClient";
            this.buttonEnregistrerClient.Size = new System.Drawing.Size(185, 31);
            this.buttonEnregistrerClient.TabIndex = 5;
            this.buttonEnregistrerClient.Text = "Enregistrer le client";
            this.buttonEnregistrerClient.UseVisualStyleBackColor = true;
            // 
            // buttonAnnulerCommand
            // 
            this.buttonAnnulerCommand.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAnnulerCommand.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnnulerCommand.Location = new System.Drawing.Point(912, 511);
            this.buttonAnnulerCommand.Name = "buttonAnnulerCommand";
            this.buttonAnnulerCommand.Size = new System.Drawing.Size(169, 42);
            this.buttonAnnulerCommand.TabIndex = 5;
            this.buttonAnnulerCommand.Text = "Annuler la commande";
            this.buttonAnnulerCommand.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.buttonFacture);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(875, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 114);
            this.panel5.TabIndex = 11;
            // 
            // buttonFacture
            // 
            this.buttonFacture.Location = new System.Drawing.Point(39, 53);
            this.buttonFacture.Name = "buttonFacture";
            this.buttonFacture.Size = new System.Drawing.Size(169, 42);
            this.buttonFacture.TabIndex = 3;
            this.buttonFacture.Text = "Générer la facture";
            this.buttonFacture.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = " Valider le ticket";
            // 
            // AccueilVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 644);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonAnnulerCommand);
            this.Controls.Add(this.buttonEnregistrerClient);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listBox1RechercheClient);
            this.Controls.Add(this.textBoxRechercheClient);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AccueilVente";
            this.Text = "AccueilVente";
            this.Load += new System.EventHandler(this.AccueilVentes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonCatalogueProd;
        private System.Windows.Forms.Label labelCatalogue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRechercheClient;
        private System.Windows.Forms.ListBox listBox1RechercheClient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Button buttonEnregistrerClient;
        private System.Windows.Forms.Button buttonAnnulerCommand;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonFacture;
        private System.Windows.Forms.Label label7;
    }
}