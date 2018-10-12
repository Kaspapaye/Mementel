namespace Repertoire_téléphonique
{
    partial class AjouterEditContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterEditContact));
            this.gbxDetail = new System.Windows.Forms.GroupBox();
            this.gbxProfessionnel = new System.Windows.Forms.GroupBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtFixePro = new System.Windows.Forms.TextBox();
            this.txtPortablePro = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtAdressePro = new System.Windows.Forms.RichTextBox();
            this.lblFixePro = new System.Windows.Forms.Label();
            this.lblAdressePro = new System.Windows.Forms.Label();
            this.lblPortablePro = new System.Windows.Forms.Label();
            this.cbx_estProfessionnel = new System.Windows.Forms.CheckBox();
            this.dtxDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtAdresse = new System.Windows.Forms.RichTextBox();
            this.txtPortable = new System.Windows.Forms.TextBox();
            this.txtFixe = new System.Windows.Forms.TextBox();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblPortable = new System.Windows.Forms.Label();
            this.lblFixe = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.gbxCategories = new System.Windows.Forms.GroupBox();
            this.lbxCategorie = new System.Windows.Forms.CheckedListBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblCheminPhoto = new System.Windows.Forms.Label();
            this.tbxCheminPhoto = new System.Windows.Forms.TextBox();
            this.btnCheminPhoto = new System.Windows.Forms.Button();
            this.picCheminPhoto = new System.Windows.Forms.PictureBox();
            this.gbxDetail.SuspendLayout();
            this.gbxProfessionnel.SuspendLayout();
            this.gbxCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheminPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDetail
            // 
            this.gbxDetail.Controls.Add(this.gbxProfessionnel);
            this.gbxDetail.Controls.Add(this.cbx_estProfessionnel);
            this.gbxDetail.Controls.Add(this.dtxDateNaissance);
            this.gbxDetail.Controls.Add(this.txtAdresse);
            this.gbxDetail.Controls.Add(this.txtPortable);
            this.gbxDetail.Controls.Add(this.txtFixe);
            this.gbxDetail.Controls.Add(this.txtPseudo);
            this.gbxDetail.Controls.Add(this.txtPrenom);
            this.gbxDetail.Controls.Add(this.txtNom);
            this.gbxDetail.Controls.Add(this.lblDate);
            this.gbxDetail.Controls.Add(this.lblAdresse);
            this.gbxDetail.Controls.Add(this.lblPortable);
            this.gbxDetail.Controls.Add(this.lblFixe);
            this.gbxDetail.Controls.Add(this.lblPseudo);
            this.gbxDetail.Controls.Add(this.lblPrenom);
            this.gbxDetail.Controls.Add(this.lblNom);
            this.gbxDetail.Location = new System.Drawing.Point(9, 10);
            this.gbxDetail.Name = "gbxDetail";
            this.gbxDetail.Size = new System.Drawing.Size(443, 576);
            this.gbxDetail.TabIndex = 0;
            this.gbxDetail.TabStop = false;
            this.gbxDetail.Text = "Détail du contact";
            // 
            // gbxProfessionnel
            // 
            this.gbxProfessionnel.Controls.Add(this.lblFax);
            this.gbxProfessionnel.Controls.Add(this.txtFixePro);
            this.gbxProfessionnel.Controls.Add(this.txtPortablePro);
            this.gbxProfessionnel.Controls.Add(this.txtFax);
            this.gbxProfessionnel.Controls.Add(this.txtAdressePro);
            this.gbxProfessionnel.Controls.Add(this.lblFixePro);
            this.gbxProfessionnel.Controls.Add(this.lblAdressePro);
            this.gbxProfessionnel.Controls.Add(this.lblPortablePro);
            this.gbxProfessionnel.Location = new System.Drawing.Point(6, 330);
            this.gbxProfessionnel.Name = "gbxProfessionnel";
            this.gbxProfessionnel.Size = new System.Drawing.Size(431, 240);
            this.gbxProfessionnel.TabIndex = 19;
            this.gbxProfessionnel.TabStop = false;
            this.gbxProfessionnel.Text = "Informations Professionnelles";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(88, 93);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(30, 13);
            this.lblFax.TabIndex = 26;
            this.lblFax.Text = "Fax :";
            // 
            // txtFixePro
            // 
            this.txtFixePro.Location = new System.Drawing.Point(129, 38);
            this.txtFixePro.Name = "txtFixePro";
            this.txtFixePro.Size = new System.Drawing.Size(287, 20);
            this.txtFixePro.TabIndex = 19;
            this.txtFixePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.champNumero_KeyPress);
            this.txtFixePro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.champNumero_KeyUp);
            // 
            // txtPortablePro
            // 
            this.txtPortablePro.Location = new System.Drawing.Point(129, 64);
            this.txtPortablePro.Name = "txtPortablePro";
            this.txtPortablePro.Size = new System.Drawing.Size(287, 20);
            this.txtPortablePro.TabIndex = 20;
            this.txtPortablePro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.champNumero_KeyPress);
            this.txtPortablePro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.champNumero_KeyUp);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(129, 90);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(288, 20);
            this.txtFax.TabIndex = 25;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.champNumero_KeyPress);
            this.txtFax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.champNumero_KeyUp);
            // 
            // txtAdressePro
            // 
            this.txtAdressePro.Location = new System.Drawing.Point(129, 118);
            this.txtAdressePro.MaxLength = 150;
            this.txtAdressePro.Name = "txtAdressePro";
            this.txtAdressePro.Size = new System.Drawing.Size(288, 111);
            this.txtAdressePro.TabIndex = 21;
            this.txtAdressePro.Text = "";
            // 
            // lblFixePro
            // 
            this.lblFixePro.AutoSize = true;
            this.lblFixePro.Location = new System.Drawing.Point(49, 41);
            this.lblFixePro.Name = "lblFixePro";
            this.lblFixePro.Size = new System.Drawing.Size(69, 13);
            this.lblFixePro.TabIndex = 22;
            this.lblFixePro.Text = "Tel Fixe Pro :";
            // 
            // lblAdressePro
            // 
            this.lblAdressePro.AutoSize = true;
            this.lblAdressePro.Location = new System.Drawing.Point(48, 121);
            this.lblAdressePro.Name = "lblAdressePro";
            this.lblAdressePro.Size = new System.Drawing.Size(70, 13);
            this.lblAdressePro.TabIndex = 24;
            this.lblAdressePro.Text = "Adresse Pro :";
            // 
            // lblPortablePro
            // 
            this.lblPortablePro.AutoSize = true;
            this.lblPortablePro.Location = new System.Drawing.Point(29, 67);
            this.lblPortablePro.Name = "lblPortablePro";
            this.lblPortablePro.Size = new System.Drawing.Size(89, 13);
            this.lblPortablePro.TabIndex = 23;
            this.lblPortablePro.Text = "Tel Portable Pro :";
            // 
            // cbx_estProfessionnel
            // 
            this.cbx_estProfessionnel.AutoSize = true;
            this.cbx_estProfessionnel.Location = new System.Drawing.Point(19, 306);
            this.cbx_estProfessionnel.Name = "cbx_estProfessionnel";
            this.cbx_estProfessionnel.Size = new System.Drawing.Size(89, 17);
            this.cbx_estProfessionnel.TabIndex = 18;
            this.cbx_estProfessionnel.Text = "Professionnel";
            this.cbx_estProfessionnel.UseVisualStyleBackColor = true;
            this.cbx_estProfessionnel.CheckedChanged += new System.EventHandler(this.cbx_estProfessionnel_CheckedChanged);
            // 
            // dtxDateNaissance
            // 
            this.dtxDateNaissance.Location = new System.Drawing.Point(135, 269);
            this.dtxDateNaissance.Name = "dtxDateNaissance";
            this.dtxDateNaissance.Size = new System.Drawing.Size(288, 20);
            this.dtxDateNaissance.TabIndex = 17;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(135, 167);
            this.txtAdresse.MaxLength = 150;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(287, 96);
            this.txtAdresse.TabIndex = 16;
            this.txtAdresse.Text = "";
            // 
            // txtPortable
            // 
            this.txtPortable.Location = new System.Drawing.Point(135, 140);
            this.txtPortable.Name = "txtPortable";
            this.txtPortable.Size = new System.Drawing.Size(287, 20);
            this.txtPortable.TabIndex = 12;
            this.txtPortable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.champNumero_KeyPress);
            this.txtPortable.KeyUp += new System.Windows.Forms.KeyEventHandler(this.champNumero_KeyUp);
            // 
            // txtFixe
            // 
            this.txtFixe.Location = new System.Drawing.Point(135, 114);
            this.txtFixe.Name = "txtFixe";
            this.txtFixe.Size = new System.Drawing.Size(287, 20);
            this.txtFixe.TabIndex = 11;
            this.txtFixe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.champNumero_KeyPress);
            this.txtFixe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.champNumero_KeyUp);
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(135, 88);
            this.txtPseudo.MaxLength = 50;
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(287, 20);
            this.txtPseudo.TabIndex = 10;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(135, 60);
            this.txtPrenom.MaxLength = 50;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(287, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(135, 34);
            this.txtNom.MaxLength = 50;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(287, 20);
            this.txtNom.TabIndex = 8;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 269);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(102, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date de naissance :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(73, 167);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblPortable
            // 
            this.lblPortable.AutoSize = true;
            this.lblPortable.Location = new System.Drawing.Point(19, 140);
            this.lblPortable.Name = "lblPortable";
            this.lblPortable.Size = new System.Drawing.Size(105, 13);
            this.lblPortable.TabIndex = 4;
            this.lblPortable.Text = "Téléphone portable :";
            // 
            // lblFixe
            // 
            this.lblFixe.AutoSize = true;
            this.lblFixe.Location = new System.Drawing.Point(38, 114);
            this.lblFixe.Name = "lblFixe";
            this.lblFixe.Size = new System.Drawing.Size(86, 13);
            this.lblFixe.TabIndex = 3;
            this.lblFixe.Text = "Téléphone Fixe :";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(75, 88);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(49, 13);
            this.lblPseudo.TabIndex = 2;
            this.lblPseudo.Text = "Pseudo :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(71, 60);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(53, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom* :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(85, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(39, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom* :";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // gbxCategories
            // 
            this.gbxCategories.Controls.Add(this.lbxCategorie);
            this.gbxCategories.Location = new System.Drawing.Point(459, 10);
            this.gbxCategories.Name = "gbxCategories";
            this.gbxCategories.Size = new System.Drawing.Size(213, 323);
            this.gbxCategories.TabIndex = 3;
            this.gbxCategories.TabStop = false;
            this.gbxCategories.Text = "Catégories";
            // 
            // lbxCategorie
            // 
            this.lbxCategorie.CheckOnClick = true;
            this.lbxCategorie.FormattingEnabled = true;
            this.lbxCategorie.Location = new System.Drawing.Point(7, 33);
            this.lbxCategorie.Name = "lbxCategorie";
            this.lbxCategorie.Size = new System.Drawing.Size(196, 274);
            this.lbxCategorie.TabIndex = 0;
            this.lbxCategorie.SelectedIndexChanged += new System.EventHandler(this.lbxCategorie_SelectedIndexChanged);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.Color.Red;
            this.btn_annuler.Location = new System.Drawing.Point(628, 592);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(45, 32);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "X";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.Color.Green;
            this.btn_valider.Location = new System.Drawing.Point(9, 592);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(51, 32);
            this.btn_valider.TabIndex = 5;
            this.btn_valider.Text = "✓";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image|*.png;*.jpg;*.bmp;*.jpeg";
            // 
            // lblCheminPhoto
            // 
            this.lblCheminPhoto.AutoSize = true;
            this.lblCheminPhoto.Location = new System.Drawing.Point(458, 340);
            this.lblCheminPhoto.Name = "lblCheminPhoto";
            this.lblCheminPhoto.Size = new System.Drawing.Size(79, 13);
            this.lblCheminPhoto.TabIndex = 6;
            this.lblCheminPhoto.Text = "Chemin Photo :";
            // 
            // tbxCheminPhoto
            // 
            this.tbxCheminPhoto.Enabled = false;
            this.tbxCheminPhoto.Location = new System.Drawing.Point(544, 340);
            this.tbxCheminPhoto.MaxLength = 150;
            this.tbxCheminPhoto.Name = "tbxCheminPhoto";
            this.tbxCheminPhoto.Size = new System.Drawing.Size(47, 20);
            this.tbxCheminPhoto.TabIndex = 7;
            // 
            // btnCheminPhoto
            // 
            this.btnCheminPhoto.Location = new System.Drawing.Point(598, 340);
            this.btnCheminPhoto.Name = "btnCheminPhoto";
            this.btnCheminPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnCheminPhoto.TabIndex = 8;
            this.btnCheminPhoto.Text = "Rechercher";
            this.btnCheminPhoto.UseVisualStyleBackColor = true;
            this.btnCheminPhoto.Click += new System.EventHandler(this.btnCheminPhoto_Click);
            // 
            // picCheminPhoto
            // 
            this.picCheminPhoto.Location = new System.Drawing.Point(466, 369);
            this.picCheminPhoto.Name = "picCheminPhoto";
            this.picCheminPhoto.Size = new System.Drawing.Size(207, 217);
            this.picCheminPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheminPhoto.TabIndex = 9;
            this.picCheminPhoto.TabStop = false;
            // 
            // AjouterEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 630);
            this.Controls.Add(this.picCheminPhoto);
            this.Controls.Add(this.btnCheminPhoto);
            this.Controls.Add(this.tbxCheminPhoto);
            this.Controls.Add(this.lblCheminPhoto);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.gbxCategories);
            this.Controls.Add(this.gbxDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterEditContact";
            this.Text = "Ajouter / éditer un contact";
            this.Load += new System.EventHandler(this.AjouterEditContact_Load);
            this.gbxDetail.ResumeLayout(false);
            this.gbxDetail.PerformLayout();
            this.gbxProfessionnel.ResumeLayout(false);
            this.gbxProfessionnel.PerformLayout();
            this.gbxCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCheminPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxCategories;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        protected System.Windows.Forms.GroupBox gbxDetail;
        protected System.Windows.Forms.RichTextBox txtAdresse;
        protected System.Windows.Forms.TextBox txtPortable;
        protected System.Windows.Forms.TextBox txtPseudo;
        protected System.Windows.Forms.TextBox txtPrenom;
        protected System.Windows.Forms.TextBox txtNom;
        protected System.Windows.Forms.Label lblDate;
        protected System.Windows.Forms.Label lblAdresse;
        protected System.Windows.Forms.Label lblPortable;
        protected System.Windows.Forms.Label lblFixe;
        protected System.Windows.Forms.Label lblPseudo;
        protected System.Windows.Forms.Label lblPrenom;
        protected System.Windows.Forms.Label lblNom;
        protected System.Windows.Forms.DateTimePicker dtxDateNaissance;
        private System.Windows.Forms.CheckedListBox lbxCategorie;
        private System.Windows.Forms.CheckBox cbx_estProfessionnel;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblAdressePro;
        private System.Windows.Forms.Label lblPortablePro;
        private System.Windows.Forms.Label lblFixePro;
        private System.Windows.Forms.RichTextBox txtAdressePro;
        private System.Windows.Forms.TextBox txtPortablePro;
        private System.Windows.Forms.TextBox txtFixePro;
        private System.Windows.Forms.GroupBox gbxProfessionnel;
        protected System.Windows.Forms.TextBox txtFixe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCheminPhoto;
        private System.Windows.Forms.TextBox tbxCheminPhoto;
        private System.Windows.Forms.Button btnCheminPhoto;
        private System.Windows.Forms.PictureBox picCheminPhoto;
    }
}