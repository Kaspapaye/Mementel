namespace Repertoire_téléphonique
{
    partial class AjouterEditCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterEditCategorie));
            this.lbl_intitule = new System.Windows.Forms.Label();
            this.tbx_intitule = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_intitule
            // 
            this.lbl_intitule.AutoSize = true;
            this.lbl_intitule.Location = new System.Drawing.Point(12, 15);
            this.lbl_intitule.Name = "lbl_intitule";
            this.lbl_intitule.Size = new System.Drawing.Size(48, 13);
            this.lbl_intitule.TabIndex = 0;
            this.lbl_intitule.Text = "Intitulé* :";
            // 
            // tbx_intitule
            // 
            this.tbx_intitule.Location = new System.Drawing.Point(66, 12);
            this.tbx_intitule.Name = "tbx_intitule";
            this.tbx_intitule.Size = new System.Drawing.Size(233, 20);
            this.tbx_intitule.TabIndex = 1;
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.Color.Green;
            this.btn_valider.Location = new System.Drawing.Point(15, 38);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(33, 30);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "✓\r\n";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.Color.Red;
            this.btn_annuler.Location = new System.Drawing.Point(265, 38);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(34, 30);
            this.btn_annuler.TabIndex = 3;
            this.btn_annuler.Text = "X";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // AjouterEditCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 74);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.tbx_intitule);
            this.Controls.Add(this.lbl_intitule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterEditCategorie";
            this.Text = "Ajouter / éditer une catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_intitule;
        private System.Windows.Forms.TextBox tbx_intitule;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
    }
}