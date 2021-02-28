
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
            this.labelModifMag = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // infosMag
            // 
            this.infosMag.AutoSize = true;
            this.infosMag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infosMag.Location = new System.Drawing.Point(115, 45);
            this.infosMag.Name = "infosMag";
            this.infosMag.Size = new System.Drawing.Size(155, 28);
            this.infosMag.TabIndex = 0;
            this.infosMag.Text = "INFORMATIONS";
            // 
            // buttonOKParamMag
            // 
            this.buttonOKParamMag.Location = new System.Drawing.Point(268, 351);
            this.buttonOKParamMag.Name = "buttonOKParamMag";
            this.buttonOKParamMag.Size = new System.Drawing.Size(94, 29);
            this.buttonOKParamMag.TabIndex = 1;
            this.buttonOKParamMag.Text = "OK";
            this.buttonOKParamMag.UseVisualStyleBackColor = true;
            this.buttonOKParamMag.Click += new System.EventHandler(this.buttonOKParamMag_Click);
            // 
            // buttonAnnulParamMag
            // 
            this.buttonAnnulParamMag.Location = new System.Drawing.Point(400, 351);
            this.buttonAnnulParamMag.Name = "buttonAnnulParamMag";
            this.buttonAnnulParamMag.Size = new System.Drawing.Size(94, 29);
            this.buttonAnnulParamMag.TabIndex = 2;
            this.buttonAnnulParamMag.Text = "Annuler";
            this.buttonAnnulParamMag.UseVisualStyleBackColor = true;
            this.buttonAnnulParamMag.Click += new System.EventHandler(this.buttonAnnulParamMag_Click);
            // 
            // labelModifMag
            // 
            this.labelModifMag.AutoSize = true;
            this.labelModifMag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModifMag.Location = new System.Drawing.Point(487, 45);
            this.labelModifMag.Name = "labelModifMag";
            this.labelModifMag.Size = new System.Drawing.Size(159, 28);
            this.labelModifMag.TabIndex = 3;
            this.labelModifMag.Text = "MODIFICATIONS";
            // 
            // ParamétrerMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelModifMag);
            this.Controls.Add(this.buttonAnnulParamMag);
            this.Controls.Add(this.buttonOKParamMag);
            this.Controls.Add(this.infosMag);
            this.Name = "ParamétrerMagasin";
            this.Text = "ParamétrerMagasin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infosMag;
        private System.Windows.Forms.Button buttonOKParamMag;
        private System.Windows.Forms.Button buttonAnnulParamMag;
        private System.Windows.Forms.Label labelModifMag;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
    }
}