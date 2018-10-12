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
    public partial class AjouterEditCategorie : Form
    {
        private Categorie categorieToUpdate;

        private bool modification = false;

        public AjouterEditCategorie()
        {
            InitializeComponent();
        }

        public AjouterEditCategorie(Categorie categorie)
        {
            InitializeComponent();
            modification = true;
            categorieToUpdate = categorie;
            
            tbx_intitule.Text = categorie.Intitule;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (tbx_intitule.Text == "")
            {
                MessageBox.Show("L'intitulé ne doit pas être vide");
                return;
            }
            if (modification)
            {
                categorieToUpdate.Intitule = tbx_intitule.Text;
                Connexion.UpdateCategorie(categorieToUpdate);
            }
            else
            {
                Categorie categorie = new Categorie(Categorie.IdMax + 1, tbx_intitule.Text);
                Connexion.InsererCategorie(categorie);
            }

            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
