
namespace ZumbaSoft.Fenetres_Commande
{
    partial class AccueilCommande
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
            this.buttonNewCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewCmd
            // 
            this.buttonNewCmd.Location = new System.Drawing.Point(553, 221);
            this.buttonNewCmd.Name = "buttonNewCmd";
            this.buttonNewCmd.Size = new System.Drawing.Size(187, 34);
            this.buttonNewCmd.TabIndex = 0;
            this.buttonNewCmd.Text = "Nouvelle commande";
            this.buttonNewCmd.UseVisualStyleBackColor = true;
            this.buttonNewCmd.Click += new System.EventHandler(this.buttonNewCmd_Click);
            // 
            // AccueilCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewCmd);
            this.Name = "AccueilCommande";
            this.Text = "AccueilCommande";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewCmd;
    }
}