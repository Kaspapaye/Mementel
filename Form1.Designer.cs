namespace Repertoire_téléphonique
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_Contacts = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbx_Filtre = new System.Windows.Forms.GroupBox();
            this.lbxCategorie = new System.Windows.Forms.CheckedListBox();
            this.gbx_Actions = new System.Windows.Forms.GroupBox();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Editer = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.grv_contacts = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbx_Action2 = new System.Windows.Forms.GroupBox();
            this.btn_supprimer2 = new System.Windows.Forms.Button();
            this.btn_modifier2 = new System.Windows.Forms.Button();
            this.btn_ajouter2 = new System.Windows.Forms.Button();
            this.grvCategories = new System.Windows.Forms.DataGridView();
            this.tab_Contacts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbx_Filtre.SuspendLayout();
            this.gbx_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_contacts)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbx_Action2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Contacts
            // 
            this.tab_Contacts.Controls.Add(this.tabPage1);
            this.tab_Contacts.Controls.Add(this.tabPage2);
            this.tab_Contacts.Location = new System.Drawing.Point(12, 13);
            this.tab_Contacts.Name = "tab_Contacts";
            this.tab_Contacts.SelectedIndex = 0;
            this.tab_Contacts.Size = new System.Drawing.Size(1160, 537);
            this.tab_Contacts.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbx_Filtre);
            this.tabPage1.Controls.Add(this.gbx_Actions);
            this.tabPage1.Controls.Add(this.grv_contacts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1152, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contacts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbx_Filtre
            // 
            this.gbx_Filtre.Controls.Add(this.lbxCategorie);
            this.gbx_Filtre.Location = new System.Drawing.Point(1020, 156);
            this.gbx_Filtre.Name = "gbx_Filtre";
            this.gbx_Filtre.Size = new System.Drawing.Size(126, 349);
            this.gbx_Filtre.TabIndex = 2;
            this.gbx_Filtre.TabStop = false;
            this.gbx_Filtre.Text = "Filtrer par catégorie";
            // 
            // lbxCategorie
            // 
            this.lbxCategorie.CheckOnClick = true;
            this.lbxCategorie.FormattingEnabled = true;
            this.lbxCategorie.Location = new System.Drawing.Point(6, 20);
            this.lbxCategorie.Name = "lbxCategorie";
            this.lbxCategorie.Size = new System.Drawing.Size(114, 319);
            this.lbxCategorie.TabIndex = 0;
            this.lbxCategorie.SelectedIndexChanged += new System.EventHandler(this.lbxCategorie_SelectedIndexChanged);
            // 
            // gbx_Actions
            // 
            this.gbx_Actions.Controls.Add(this.btn_Supprimer);
            this.gbx_Actions.Controls.Add(this.btn_Editer);
            this.gbx_Actions.Controls.Add(this.btn_Ajouter);
            this.gbx_Actions.Location = new System.Drawing.Point(1020, 6);
            this.gbx_Actions.Name = "gbx_Actions";
            this.gbx_Actions.Size = new System.Drawing.Size(126, 144);
            this.gbx_Actions.TabIndex = 1;
            this.gbx_Actions.TabStop = false;
            this.gbx_Actions.Text = "Actions";
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supprimer.ForeColor = System.Drawing.Color.Red;
            this.btn_Supprimer.Location = new System.Drawing.Point(44, 62);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(40, 32);
            this.btn_Supprimer.TabIndex = 2;
            this.btn_Supprimer.Text = "-";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Editer
            // 
            this.btn_Editer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_Editer.Location = new System.Drawing.Point(44, 100);
            this.btn_Editer.Name = "btn_Editer";
            this.btn_Editer.Size = new System.Drawing.Size(40, 37);
            this.btn_Editer.TabIndex = 1;
            this.btn_Editer.Text = "Edit";
            this.btn_Editer.UseVisualStyleBackColor = true;
            this.btn_Editer.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.ForeColor = System.Drawing.Color.Green;
            this.btn_Ajouter.Location = new System.Drawing.Point(44, 19);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(40, 37);
            this.btn_Ajouter.TabIndex = 0;
            this.btn_Ajouter.Text = "+";
            this.btn_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // grv_contacts
            // 
            this.grv_contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_contacts.Location = new System.Drawing.Point(7, 6);
            this.grv_contacts.Name = "grv_contacts";
            this.grv_contacts.Size = new System.Drawing.Size(1007, 499);
            this.grv_contacts.TabIndex = 0;
            this.grv_contacts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_contacts_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbx_Action2);
            this.tabPage2.Controls.Add(this.grvCategories);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1152, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Catégories";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbx_Action2
            // 
            this.gbx_Action2.Controls.Add(this.btn_supprimer2);
            this.gbx_Action2.Controls.Add(this.btn_modifier2);
            this.gbx_Action2.Controls.Add(this.btn_ajouter2);
            this.gbx_Action2.Location = new System.Drawing.Point(1026, 6);
            this.gbx_Action2.Name = "gbx_Action2";
            this.gbx_Action2.Size = new System.Drawing.Size(120, 145);
            this.gbx_Action2.TabIndex = 1;
            this.gbx_Action2.TabStop = false;
            this.gbx_Action2.Text = "Actions";
            // 
            // btn_supprimer2
            // 
            this.btn_supprimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer2.ForeColor = System.Drawing.Color.Red;
            this.btn_supprimer2.Location = new System.Drawing.Point(41, 59);
            this.btn_supprimer2.Name = "btn_supprimer2";
            this.btn_supprimer2.Size = new System.Drawing.Size(43, 35);
            this.btn_supprimer2.TabIndex = 2;
            this.btn_supprimer2.Text = "-";
            this.btn_supprimer2.UseVisualStyleBackColor = true;
            this.btn_supprimer2.Click += new System.EventHandler(this.btn_supprimer2_Click);
            // 
            // btn_modifier2
            // 
            this.btn_modifier2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_modifier2.Location = new System.Drawing.Point(41, 100);
            this.btn_modifier2.Name = "btn_modifier2";
            this.btn_modifier2.Size = new System.Drawing.Size(43, 36);
            this.btn_modifier2.TabIndex = 1;
            this.btn_modifier2.Text = "Edit";
            this.btn_modifier2.UseVisualStyleBackColor = true;
            this.btn_modifier2.Click += new System.EventHandler(this.btn_modifier2_Click);
            // 
            // btn_ajouter2
            // 
            this.btn_ajouter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter2.ForeColor = System.Drawing.Color.Green;
            this.btn_ajouter2.Location = new System.Drawing.Point(41, 19);
            this.btn_ajouter2.Name = "btn_ajouter2";
            this.btn_ajouter2.Size = new System.Drawing.Size(43, 34);
            this.btn_ajouter2.TabIndex = 0;
            this.btn_ajouter2.Text = "+";
            this.btn_ajouter2.UseVisualStyleBackColor = true;
            this.btn_ajouter2.Click += new System.EventHandler(this.btn_ajouter2_Click);
            // 
            // grvCategories
            // 
            this.grvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCategories.Location = new System.Drawing.Point(6, 6);
            this.grvCategories.Name = "grvCategories";
            this.grvCategories.Size = new System.Drawing.Size(1014, 499);
            this.grvCategories.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.tab_Contacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mémen \' Tel";
            this.Load += new System.EventHandler(this.frm_Entree_Load);
            this.tab_Contacts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbx_Filtre.ResumeLayout(false);
            this.gbx_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_contacts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbx_Action2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Contacts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbx_Filtre;
        private System.Windows.Forms.GroupBox gbx_Actions;
        private System.Windows.Forms.DataGridView grv_contacts;
        private System.Windows.Forms.DataGridView grvCategories;
        private System.Windows.Forms.GroupBox gbx_Action2;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Editer;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_supprimer2;
        private System.Windows.Forms.Button btn_modifier2;
        private System.Windows.Forms.Button btn_ajouter2;
        private System.Windows.Forms.CheckedListBox lbxCategorie;
    }
}

