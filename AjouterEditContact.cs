using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Repertoire_téléphonique
{
    public partial class AjouterEditContact : Form
    {
        private Contact contactToUpdate;
                
        private bool modification = false;

        public AjouterEditContact()
        {
            InitializeComponent();
            initialisation();
            gbxProfessionnel.Hide();
            modification = false;
            
        }
        /// <summary>
        /// Surcharge du constucteur
        /// </summary>
        /// <param name="contact">le contact à modifier</param>
        public AjouterEditContact(Contact contact)
        {
            InitializeComponent();
            initialisation();
            modification = true;
            contactToUpdate = contact;

            if (contactToUpdate.EstProfessionnel)
            {
                cbx_estProfessionnel.Checked = true;
            }
            else
            {
                gbxProfessionnel.Hide();
            }

            foreach (Categorie categorie in contact.ListCategorie)
            {
                int index = lbxCategorie.Items.IndexOf(categorie);
                lbxCategorie.SetItemChecked(index, true);
            }

            txtNom.Text = contact.Nom;
            txtPrenom.Text = contact.Prenom;
            txtPseudo.Text = contact.Pseudo;
            dtxDateNaissance.Value = contact.DateNaissance;
            //txtc.Text = contact.CheminPhoto;
            foreach (Habiter habiter in contact.ListHabiter)
            {
                if (habiter.EnumTypeAdresse == EnumTypeAdresse.AdressePerso)
                {
                    txtAdresse.Text = habiter.Adresse;
                }
                else
                {
                    txtAdressePro.Text = habiter.Adresse;
                }

            }
            foreach (Posseder posseder in contact.ListPosseder)
            {
                switch (posseder.EnumTypeNumero)
                {
                    case EnumTypeNumero.Fax:
                        txtFax.Text = posseder.Numero;
                        break;
                    case EnumTypeNumero.FixePerso:
                        txtFixe.Text = posseder.Numero;
                        break;
                    case EnumTypeNumero.FixePro:
                        txtFixePro.Text = posseder.Numero;
                        break;
                    case EnumTypeNumero.PortablePerso:
                        txtPortable.Text = posseder.Numero;
                        break;
                    case EnumTypeNumero.PortablePro:
                        txtPortablePro.Text = posseder.Numero;
                        break;
                }
            }

            cbx_estProfessionnel.Checked = contact.EstProfessionnel;
            tbxCheminPhoto.Text = contact.CheminPhoto;
            try
            {
                picCheminPhoto.Image = Image.FromFile(contact.CheminPhoto);
            }
            catch (Exception e)
            {

            }
        }

        private void initialisation()
        {
            foreach (Categorie categorie in Program.ListCategorie)
            {
                lbxCategorie.Items.Add(categorie);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {

            if (txtNom.Text == "")
            {
                MessageBox.Show("Le nom ne doit pas être vide");
                return;
            }
            if (txtPrenom.Text == "")
            {
                MessageBox.Show("Le prénom ne doit pas être vide");
                return;
            }

            if (modification)
            {
                contactToUpdate.Nom = txtNom.Text;
                contactToUpdate.Prenom = txtPrenom.Text;
                contactToUpdate.Pseudo = txtPseudo.Text;
                contactToUpdate.DateNaissance = dtxDateNaissance.Value.Date;
                contactToUpdate.CheminPhoto = tbxCheminPhoto.Text;
                contactToUpdate.EstProfessionnel = cbx_estProfessionnel.Checked;


                Connexion.UpdateContact(contactToUpdate);

                Connexion.SupprimerHabiter(contactToUpdate);
                Connexion.SupprimerNumero(contactToUpdate);


            }
            else
            {
                contactToUpdate = new Contact(Contact.IdMax + 1, txtNom.Text, txtPrenom.Text, txtPseudo.Text, dtxDateNaissance.Value.Date, tbxCheminPhoto.Text, cbx_estProfessionnel.Checked);
                Connexion.InsererContact(contactToUpdate);
            }

            Habiter habiter = new Habiter(contactToUpdate, EnumTypeAdresse.AdressePerso, txtAdresse.Text);
            contactToUpdate.ListHabiter.Add(habiter);
            string adressePro = "";
            string fixePro = "";
            string portablePro = "";
            string fax = "";
            if (cbx_estProfessionnel.Checked)
            {
                adressePro = txtAdressePro.Text;
                fax = txtFax.Text;
                fixePro = txtFixePro.Text;
                portablePro = txtPortablePro.Text;
            }
            Habiter habiterPro = new Habiter(contactToUpdate, EnumTypeAdresse.AdressePro, adressePro);
            contactToUpdate.ListHabiter.Add(habiterPro);
            Connexion.InsererHabiter(contactToUpdate);

            contactToUpdate.ListPosseder.Add(new Posseder(contactToUpdate, EnumTypeNumero.Fax, fax));
            contactToUpdate.ListPosseder.Add(new Posseder(contactToUpdate, EnumTypeNumero.FixePerso, txtFixe.Text));
            contactToUpdate.ListPosseder.Add(new Posseder(contactToUpdate, EnumTypeNumero.FixePro, fixePro));
            contactToUpdate.ListPosseder.Add(new Posseder(contactToUpdate, EnumTypeNumero.PortablePerso, txtPortable.Text));
            contactToUpdate.ListPosseder.Add(new Posseder(contactToUpdate, EnumTypeNumero.PortablePro, portablePro));
            Connexion.InsererNumero(contactToUpdate);

            Connexion.InsererCategoriser(contactToUpdate, lbxCategorie.CheckedItems.Cast<Categorie>().ToList());

            this.Close();


        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnValiderModif_Click(object sender, EventArgs e)
        {

        }

        private void lbxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Events non attribués (pas nécessaire)

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void AjouterEditContact_Load(object sender, EventArgs e)
        {

        }

        private void cbx_estProfessionnel_CheckedChanged(object sender, EventArgs e)
        {
            this.gbxProfessionnel.Visible = this.cbx_estProfessionnel.Checked;
        }

        private void champNumero_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length > 10)
            {
                int position = textBox.SelectionStart;
                textBox.Text = textBox.Text.Substring(0, 10);
                textBox.SelectionStart = position;
            }
            
        }

        private void champNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            int val = 0;
            if (int.TryParse(e.KeyChar.ToString(), out val)==false)
            {
                e.Handled = true;
            }            
        }

        private void btnCheminPhoto_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
           if( dialogResult == DialogResult.OK)
            {
                tbxCheminPhoto.Text = openFileDialog1.FileName;
                picCheminPhoto.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
