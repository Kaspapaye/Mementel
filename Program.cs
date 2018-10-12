using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repertoire_téléphonique
{
    /// <summary>
    /// Program initialise des données depuis la BDD et d'accéder aux listes de persistances
    /// </summary>
    static class Program
    {
        /// <summary>
        /// la liste de persistance permettant d'accéder dans toute l'application aux contacts.
        /// </summary>
        static List<Contact> listContact = new List<Contact>();

        /// <summary>
        /// la liste de persistance permettant d'accéder dans toute l'application aux catégories.
        /// </summary>
        static List<Categorie> listCategorie = new List<Categorie>();


        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Connexion.ChargerContact();
            Connexion.ChargerCategorie();
            Connexion.ChargerCategoriser();
            Connexion.ChargerHabiter();
            Connexion.ChargerNumero();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static List<Contact> ListContact
        {
            get { return listContact; }
        }

        public static List<Categorie> ListCategorie
        {
            get { return listCategorie; }
        }



        public static Contact retournerContactParID(int id)
        {
            foreach (Contact contact in ListContact)
            {
                if (contact.Id == id)
                {
                    return contact;
                }
            }
            return null;

        }

        public static Categorie retournerCategorieParID(int id)
        {
            foreach (Categorie categorie in ListCategorie)
            {
                if (categorie.Id == id)
                {
                    return categorie;
                }
            }

            return null;

        }

    }
}
