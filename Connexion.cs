using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repertoire_téléphonique
{

    static class Connexion
    {
        /// connexion à la base de données

        private static MySqlConnection cnx = null;
        private static string _ConnectionString = "Database=repertoire;Data Source=localhost;User Id=root;Password=";

        /// <summary>
        /// initialise et retourne la connexion à la base de donnée
        /// </summary>
        /// <returns>instance de connexion à la base de donnée</returns>
        public static MySqlConnection GetConnexion()
        {
            //Améliore la performance et sécurise l'ouverture de la connexion
            if (cnx == null)
            {
                cnx = new MySqlConnection();
                cnx.ConnectionString = _ConnectionString;

                cnx.Open();
            }
            return cnx;
        }

        /// <summary>
        /// cloture la connexion
        /// </summary>
        public static void CloseConnexion()
        {
            cnx.Close();
            cnx = null;
        }

        /// <summary>
        /// initialise tous les contacts depuis la base de données
        /// </summary>

        public static void ChargerContact()
        {
            //efface la liste suite à suppression
            Program.ListContact.Clear();

            string requete = "SELECT * FROM contact";
            //créée la commande de requête avec l'instance de connexion à la BDD
            MySqlCommand commande = new MySqlCommand(requete, GetConnexion());
            //Appel de la méthode ExecuteReader de la variable Commande de typeMySQLCommande et qui retourne une instance de MySQLDataReader qui sera déclaré
            // dans la variable DataReader
            MySqlDataReader dataReader = commande.ExecuteReader();

            //parcourt de toutes les lignes retournées par la requête
            while (dataReader.Read())
            {
                //déclare toutes les variables correspondantes aux champs d'une ligne
                int id = dataReader.GetInt32("ID");
                string nom = dataReader.GetString("nom");
                string prenom = dataReader.GetString("prenom");
                string pseudo = dataReader.GetString("pseudo");
                DateTime dateNaissance = dataReader.GetDateTime("dateNaissance");
                string cheminPhoto = dataReader.GetString("chemin_photo");
                bool estProfessionnel = dataReader.GetBoolean("estProfessionnel");

                //instanciation d'un nouveau contact avec les données de la ligne 
                Contact contact = new Contact(id, nom, prenom, pseudo, dateNaissance, cheminPhoto, estProfessionnel);

                //on ajoute l'instance créée dans la liste de persistance
                Program.ListContact.Add(contact);

            }
            //ferme la requête
            dataReader.Close();
            //cloture la connexion
            CloseConnexion();

        }
               
        /// <summary>
        /// on insère en BDD et dans la liste de persistance un nouveau contact
        /// </summary>
        /// <param name="contact"> le nouveau contact à insérer </param>
        public static void InsererContact(Contact contact)
        {
            GetConnexion();
            //création d'une nouvelle commande depuis MySQLConnexion
            MySqlCommand comm = cnx.CreateCommand();
            //définit la ligne de commande qui correspond à l'insertion d'un contact
            comm.CommandText = "INSERT INTO contact(ID, nom, prenom, pseudo, dateNaissance, chemin_photo, estProfessionnel ) VALUES(@ID, @nom, @prenom, @pseudo, @dateNaissance, @chemin_photo, @estProfessionnel )";
            //définit tous les paramètres de la requête paramétrée
            comm.Parameters.AddWithValue("@ID", contact.Id);
            comm.Parameters.AddWithValue("@nom", contact.Nom);
            comm.Parameters.AddWithValue("@prenom", contact.Prenom);
            comm.Parameters.AddWithValue("@pseudo", contact.Pseudo);
            comm.Parameters.AddWithValue("@dateNaissance", contact.DateNaissance);
            comm.Parameters.AddWithValue("@chemin_photo", contact.CheminPhoto);
            comm.Parameters.AddWithValue("@estProfessionnel", contact.EstProfessionnel);
            //éxécute l'instruction précédente
            comm.ExecuteNonQuery();
            //accède à la liste des contacts et lui ajoute le contact qui vient d'être inséré
            Program.ListContact.Add(contact);
        }

        /// <summary>
        /// Met à jour le contact dans la BDD
        /// </summary>
        /// <param name="contact">le contact à mettre à jour</param>
        public static void UpdateContact(Contact contact)
        {
            GetConnexion();
            MySqlCommand comm = cnx.CreateCommand();
            //définit la ligne de commande d'Update des champs du contact
            comm.CommandText = "UPDATE contact SET nom = @nom, prenom = @prenom, pseudo=@pseudo, " +
                "dateNaissance=@dateNaissance, chemin_photo=@chemin_photo, estProfessionnel=@estProfessionnel WHERE ID=@ID";
            //définit les paramètres de la requête paramétrée
            comm.Parameters.AddWithValue("@ID", contact.Id);
            comm.Parameters.AddWithValue("@nom", contact.Nom);
            comm.Parameters.AddWithValue("@prenom", contact.Prenom);
            comm.Parameters.AddWithValue("@pseudo", contact.Pseudo);
            comm.Parameters.AddWithValue("@dateNaissance", contact.DateNaissance);
            comm.Parameters.AddWithValue("@chemin_photo", contact.CheminPhoto);
            comm.Parameters.AddWithValue("@estProfessionnel", contact.EstProfessionnel);

            comm.ExecuteNonQuery();
            CloseConnexion();
        }

        /// <summary>
        /// Supprime le contact de la BDD et de la liste de persistance
        /// </summary>
        /// <param name="contact">le contact à supprimer</param>
        public static void SupprimerContact(Contact contact)
        {
            //Obligation de suppression des relations avec l'occurence du contact qui sera supprimé
            SupprimerCategoriser(contact);
            SupprimerHabiter(contact);
            SupprimerNumero(contact);
            GetConnexion();
            MySqlCommand comm = cnx.CreateCommand();
            comm.CommandText = "DELETE FROM contact WHERE ID=@ID";
            comm.Parameters.AddWithValue("@ID", contact.Id);


            comm.ExecuteNonQuery();
            CloseConnexion();
            //on accède à la liste de persistance des contacts pour supprimer le contact
            Program.ListContact.Remove(contact);
        }

        /// connexion Categorie 

        public static void ChargerCategorie()
        {
            Program.ListCategorie.Clear();// supprime les catégories de la liste de persistance suite à suppression de catégorie

            string requete = "SELECT * FROM categorie";
            MySqlCommand commande = new MySqlCommand(requete, GetConnexion());
            MySqlDataReader dataReader = commande.ExecuteReader();
            //suite à l'execution de la requete on va lire chaque ligne du résultat de la requete contenu dans le datareader
            while (dataReader.Read())
            {
                //correspond au nom de colonne de la table catégorie
                int id = dataReader.GetInt32("ID");
                string intitule = dataReader.GetString("intitule");


                Categorie categorie = new Categorie(id, intitule);

                //accède à la liste de catégorie et ajoute la catégorie qui vient d'être insérée
                Program.ListCategorie.Add(categorie);

            }
            dataReader.Close();

        }

        public static void InsererCategorie(Categorie categorie)
        {
            GetConnexion();
            MySqlCommand comm = cnx.CreateCommand();
            comm.CommandText = "INSERT INTO categorie(ID, intitule) VALUES(@ID, @intitule)";
            comm.Parameters.AddWithValue("@ID", categorie.Id);
            comm.Parameters.AddWithValue("@intitule", categorie.Intitule);

            comm.ExecuteNonQuery();
            Program.ListCategorie.Add(categorie);
        }

        public static void UpdateCategorie(Categorie categorie)
        {
            GetConnexion();
            MySqlCommand comm = cnx.CreateCommand();
            comm.CommandText = "UPDATE categorie SET intitule = @intitule WHERE ID=@ID";
            comm.Parameters.AddWithValue("@ID", categorie.Id);
            comm.Parameters.AddWithValue("@intitule", categorie.Intitule);

            comm.ExecuteNonQuery();
            CloseConnexion();
        }

        public static void SupprimerCategorie(Categorie categorie)
        {
            SupprimerCategoriser(categorie);
            GetConnexion();
            MySqlCommand comm = cnx.CreateCommand();
            comm.CommandText = "DELETE FROM categorie WHERE ID=@ID";
            comm.Parameters.AddWithValue("@ID", categorie.Id);


            comm.ExecuteNonQuery();
            CloseConnexion();
            Program.ListCategorie.Remove(categorie);
        }

        /// connexion Categoriser 

        private static void SupprimerCategoriser(Categorie categorie)
        {
            GetConnexion();
            MySqlCommand comm = cnx.CreateCommand();
            comm.CommandText = "DELETE FROM categoriser WHERE ID_Categorie=@ID";
            comm.Parameters.AddWithValue("@ID", categorie.Id);


            comm.ExecuteNonQuery();
            CloseConnexion();

            foreach (Contact contact in Program.ListContact)
            {
                contact.ListCategorie.Remove(categorie);
            }
           
           
        }

        public static void ChargerCategoriser()
        {
            string requete = "SELECT * FROM categoriser";
            MySqlCommand commande = new MySqlCommand(requete, GetConnexion());
            MySqlDataReader dataReader = commande.ExecuteReader();
            while (dataReader.Read())
            {

                int id_Contact = dataReader.GetInt32("ID");
                int id_Categorie = dataReader.GetInt32("ID_Categorie");


                Contact contact = Program.retournerContactParID(id_Contact);
                Categorie categorie = Program.retournerCategorieParID(id_Categorie);
                contact.ListCategorie.Add(categorie);
                categorie.ListContact.Add(contact);

            }
            dataReader.Close();


        }

        public static void InsererCategoriser(Contact contact, List<Categorie> tabCategorie)
        {
            SupprimerCategoriser(contact);

            GetConnexion();
            foreach (Categorie categorie in tabCategorie)
            {

                MySqlCommand comm = cnx.CreateCommand();
                comm.CommandText = "INSERT INTO categoriser(ID, ID_Categorie) VALUES(@ID, @ID_Categorie)";
                comm.Parameters.AddWithValue("@ID", contact.Id);
                comm.Parameters.AddWithValue("@ID_Categorie", categorie.Id);

                comm.ExecuteNonQuery();
                contact.ListCategorie.Add(categorie);
                categorie.ListContact.Add(contact);
            }

        }

        public static void SupprimerCategoriser(Contact contact)
        {
            if (contact.ListCategorie.Count > 0)
            {
                GetConnexion();
                MySqlCommand comm = cnx.CreateCommand();
                comm.CommandText = "DELETE FROM categoriser WHERE ID=@ID";
                comm.Parameters.AddWithValue("@ID", contact.Id);


                comm.ExecuteNonQuery();
                CloseConnexion();
                //pour chaque catégorie dans la liste des catégories de contact, on enlève le contact de la liste des contacts de la catégorie parcourue
                foreach (Categorie categorie in contact.ListCategorie)
                {
                    categorie.ListContact.Remove(contact);
                }
                contact.ListCategorie.Clear();
            }


        }

        /// connexion Habiter
        public static void SupprimerHabiter(Contact contact)
        {
            if (contact.ListHabiter.Count > 0)
            {
                GetConnexion();
                MySqlCommand comm = cnx.CreateCommand();
                comm.CommandText = "DELETE FROM habiter WHERE ID_contact=@ID_contact";
                comm.Parameters.AddWithValue("@ID_contact", contact.Id);

                comm.ExecuteNonQuery();
                CloseConnexion();
                contact.ListHabiter.Clear();
            }
        }

        public static void ChargerHabiter()
        {
            //dans la table Habiter on récupère tous les champs
            string requete = "SELECT * FROM habiter";
            MySqlCommand commande = new MySqlCommand(requete, GetConnexion());
            MySqlDataReader dataReader = commande.ExecuteReader();
            //on va parcourir chacune des lignes du DataReader
            while (dataReader.Read())
            {

                int id_type_adresse = dataReader.GetInt32("ID_type_adresse");
                int id_contact = dataReader.GetInt32("ID_contact");
                string adresse = dataReader.GetString("adresse");

                //retourne le contact par son ID
                Contact contact = Program.retournerContactParID(id_contact);
                //instantiation de la classe de type Habiter avec comme paramètre : le contact, l'enum type adresse par l'ID et l'adresse
                Habiter habiter = new Habiter(contact, (EnumTypeAdresse)id_type_adresse, adresse);
                contact.ListHabiter.Add(habiter);

            }
            dataReader.Close();

        }

        public static void InsererHabiter(Contact contact)
        {
            GetConnexion();
            
            foreach (Habiter habiter in contact.ListHabiter)
            {
                MySqlCommand comm = cnx.CreateCommand();
                comm.CommandText = "INSERT INTO habiter(ID_contact , ID_type_adresse , adresse) VALUES(@ID_contact , @ID_type_adresse, @adresse )";
                comm.Parameters.AddWithValue("@ID_contact", habiter.Contact.Id);
                comm.Parameters.AddWithValue("@ID_type_adresse", (int)habiter.EnumTypeAdresse);
                comm.Parameters.AddWithValue("@adresse", habiter.Adresse);

                comm.ExecuteNonQuery();
            }

        }
               

        public static void UpdateHabiter(Contact contact, Habiter habiter)
        {
            GetConnexion();
            MySqlCommand comm = cnx.CreateCommand();
            comm.CommandText = "UPDATE habiter SET adresse = @adresse WHERE ID=@ID";
            comm.Parameters.AddWithValue("@ID", contact.Id);
            comm.Parameters.AddWithValue("@intitule", habiter.Adresse);

            comm.ExecuteNonQuery();
            CloseConnexion();
        }

        /// connexion Posseder

        public static void ChargerNumero()
        {
            string requete = "SELECT * FROM posseder";
            MySqlCommand commande = new MySqlCommand(requete, GetConnexion());
            MySqlDataReader dataReader = commande.ExecuteReader();
            while (dataReader.Read())
            {

                int id_contact = dataReader.GetInt32("ID_contact");
                int id_type_numero = dataReader.GetInt32("ID_type_numero");
                string numero = dataReader.GetString("numero");


                Contact contact = Program.retournerContactParID(id_contact);
                Posseder posseder = new Posseder(contact, (EnumTypeNumero)id_type_numero, numero);
                contact.ListPosseder.Add(posseder);

            }
            dataReader.Close();

        }

        public static void InsererNumero(Contact contact)
        {
            GetConnexion();
            
            foreach (Posseder posseder in contact.ListPosseder)
            {
                MySqlCommand comm = cnx.CreateCommand();
                comm.CommandText = "INSERT INTO posseder(ID_contact , ID_type_numero , numero) VALUES(@ID_contact , @ID_type_numero , @numero )";
                comm.Parameters.AddWithValue("@ID_contact", posseder.Contact.Id);
                comm.Parameters.AddWithValue("@ID_type_numero", (int)posseder.EnumTypeNumero);
                comm.Parameters.AddWithValue("@numero", posseder.Numero);

                comm.ExecuteNonQuery();
            }

        }

        public static void SupprimerNumero(Contact contact)
        {
            if (contact.ListPosseder.Count > 0)
            {
                GetConnexion();
                MySqlCommand comm = cnx.CreateCommand();
                comm.CommandText = "DELETE FROM posseder WHERE ID_contact=@ID_contact";
                comm.Parameters.AddWithValue("@ID_contact", contact.Id);

                comm.ExecuteNonQuery();
                CloseConnexion();
                contact.ListPosseder.Clear();
            }
        }

    }

}
