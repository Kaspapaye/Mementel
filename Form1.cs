using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repertoire_téléphonique
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// sources de données pour la gridview
        /// </summary>
        BindingSource bindingSource = new BindingSource();
        BindingSource bindingCategorie = new BindingSource();


        private void InitSource()
        {

            bindingSource.Clear();//relie les données au datagrid

            foreach (Contact contact in Program.ListContact)
            {

                bindingSource.Add(contact);

            }

            grv_contacts.DataSource = bindingSource;
            grv_contacts.Refresh();

            bindingCategorie.Clear();//relie les données au datagrid

            foreach (Categorie categorie in Program.ListCategorie)
            {

                bindingCategorie.Add(categorie);

            }

            grvCategories.DataSource = bindingCategorie;
            grvCategories.Refresh();
            //listbox qui permet de filtrer les contacts de la gridview par catégorie 
            lbxCategorie.Items.Clear();

            foreach (Categorie categorie in Program.ListCategorie)
            {

                lbxCategorie.Items.Add(categorie);

            }

            grv_contacts.Columns["ID"].Visible = false;
            grv_contacts.Columns["CheminPhoto"].Visible = false;
            grvCategories.Columns["ID"].Visible = false;
            grv_contacts.ReadOnly = true;
            grvCategories.ReadOnly = true;
            //quand on clique, c'est la ligne complète qui est sélectionnée
            grv_contacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //on ne pourra pas sélectionner plusieurs ligns en même temps
            grv_contacts.MultiSelect = false;
            grvCategories.MultiSelect = false;
        }

        public Form1()
        {
            InitializeComponent();
        }



        public void btn_Ajouter_Click(object sender, EventArgs e)
        {
            AjouterEditContact frmContact = new AjouterEditContact();
            frmContact.ShowDialog();
            InitSource();
        }

        /// <summary>
        /// Méthode appelée à la fin du chargement de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Entree_Load(object sender, EventArgs e)
        {
            InitSource();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (grv_contacts.CurrentRow != null)
            { //Recuperer l'id de ton contact
                Contact contact = (Contact)this.grv_contacts.CurrentRow.DataBoundItem;
                //Demander la confirmation de la suppression
                DialogResult confirmationSuppression = MessageBox.Show("Voulez vous supprimer le contact :" + contact.Nom, "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmationSuppression == DialogResult.Yes)
                {
                    Connexion.SupprimerContact(contact);
                    InitSource();

                }


            }

        }


        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            ModifierContactSelectionner();
        }

        private void ModifierContactSelectionner()
        {
            if (grv_contacts.CurrentRow != null)
            {
                Contact contact = (Contact)this.grv_contacts.CurrentRow.DataBoundItem;
                AjouterEditContact frmContactModifier = new AjouterEditContact(contact);
                frmContactModifier.ShowDialog();
                InitSource();
            }

        }
        
        /// <summary>
        /// Sélection des catégories filtrant les contacts affiliés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            grv_contacts.DataSource = null;
            grv_contacts.Rows.Clear();

            List<Contact> contactChecked = null;

            if (lbxCategorie.CheckedItems.Count > 0)
            {
                contactChecked = new List<Contact>();
                foreach (Categorie categorie in lbxCategorie.CheckedItems)
                {
                    foreach (Contact contact in categorie.ListContact)
                    {
                        if (contactChecked.Contains(contact) == false)
                        {
                            contactChecked.Add(contact);
                        }
                    }

                }

            }
            else
            {
                contactChecked = Program.ListContact;
            }

            foreach (Contact contact in contactChecked)
            {

                bindingSource.Add(contact);

            }

            grv_contacts.DataSource = bindingSource;
            grv_contacts.Refresh();
        }

        private void btn_ajouter2_Click(object sender, EventArgs e)
        {
            AjouterEditCategorie frmCategorie = new AjouterEditCategorie();
            frmCategorie.ShowDialog();
            InitSource();
        }

        private void btn_modifier2_Click(object sender, EventArgs e)
        {
            Categorie categorie = (Categorie)this.grvCategories.CurrentRow.DataBoundItem;
            AjouterEditCategorie frmCategorieModifier = new AjouterEditCategorie(categorie);
            frmCategorieModifier.ShowDialog();
            InitSource();
        }

        private void btn_supprimer2_Click(object sender, EventArgs e)
        {
            if (grvCategories.CurrentRow != null)
            {
                Categorie categorie = (Categorie)this.grvCategories.CurrentRow.DataBoundItem;
                //Demander la confirmation de la suppression
                DialogResult confirmationSuppressionCat = MessageBox.Show("Voulez vous supprimer la catégorie :" + categorie.Intitule, "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( confirmationSuppressionCat == DialogResult.Yes)
                {
                    Connexion.SupprimerCategorie(categorie);
                    InitSource();

                }


            }
        }

        private void grv_contacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModifierContactSelectionner();
        }
    }
}
