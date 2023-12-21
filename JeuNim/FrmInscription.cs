using JeuNim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JeuNim
{
    public partial class FrmInscription : Form
    {

        public FrmInscription()
        {
            InitializeComponent();
        }

        private void BtnInscription_Click(object sender, EventArgs e)
        {


            // Variables
            string nom = TxtNomInscription.Text;
            string prenom = TxtPrenomInscription.Text;
            string motDePasse = TxtMDPInscription.Text;
            string confirmationMDP = TxtConfirmationMDP.Text;
            string email = TxtMailInscription.Text;
            string pseudo = TxtPseudo.Text;

            // Contrôle des informations saisies par l'utilisateur
            if (!SaisieValideChaine(nom) || !SaisieValideChaine(prenom) || !SaisieValideChaine(pseudo) || !SaisieValideChaine(motDePasse) || !SaisieValideChaine(confirmationMDP) || !SaisieValideChaine(email))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (!motDePasse.Equals(confirmationMDP))
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Adresse email invalide.");
                return;
            }


            // Hachage du mot de passe avant de le stocker dans la base de données
            string motDePasseHache = BCrypt.Net.BCrypt.HashPassword(motDePasse);

            // Enregistrement de l'utilisateur

            try
            {
                using (NesContext db = new NesContext())
                {
                    // Vérification si l'adresse email existe déjà (en ignorant la casse)
                    if (db.Joueurs.Any(j => j.AdresseEmail.ToLower() == email.ToLower()))
                    {
                        MessageBox.Show("L'adresse email existe déjà.");
                        return;
                    }

                    // Vérification si le login existe déjà (en ignorant la casse)
                    if (db.Joueurs.Any(j => j.Login.ToLower() == pseudo.ToLower()))
                    {
                        MessageBox.Show("Ce pseudo est déjà utilisé.");
                        return;
                    }

                    // Créer un nouvel utilisateur
                    Joueur NouveauJoueur = new Joueur
                    {
                        Nom = nom,
                        Prenom = prenom,
                        MotDePasse = motDePasseHache,
                        Login = pseudo,
                        AdresseEmail = email,
                    };

                    // Ajouter l'utilisateur à la base de données
                    db.Joueurs.Add(NouveauJoueur);

                    // Enregistrer les modifications dans la base de données
                    db.SaveChanges();

                    MessageBox.Show("Inscription réussie !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }


        }


        private bool SaisieValideChaine(string valeurSasie)
        {
            if (string.IsNullOrWhiteSpace(valeurSasie))
            {
                return false;
            }

            else return true;

        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Utilisation de l'expression régulière pour la validation de l'email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            //affiche la page de connexion
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();

            //ferme la pge d'inscription
            Close();

        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {

        }

        private void TxtMDPInscription_TextChanged(object sender, EventArgs e)
        {
            TxtMDPInscription.PasswordChar = '*';


        }

        private void TxtConfirmationMDP_TextChanged(object sender, EventArgs e)
        {
            TxtConfirmationMDP.PasswordChar = '*';
        }


        private void voirMDP(object sender, EventArgs e)
        {
            // Affiche le texte brut (non masqué) lorsque la souris survole l'icône
            TxtMDPInscription.PasswordChar = '\0';
        }

        private void cacherMDP(object sender, EventArgs e)
        {
            // Masque à nouveau le texte lorsque la souris quitte l'icône
            TxtMDPInscription.PasswordChar = '*';

        }



        private void voirConfirmationMDP(object sender, EventArgs e)
        {
            // Afficher le texte brut (non masqué) lorsque la souris survole l'icône
            TxtConfirmationMDP.PasswordChar = '\0';
        }

        private void cacherConfirmationMDP(object sender, EventArgs e)
        {
            // Masquer à nouveau le texte lorsque la souris quitte l'icône
            TxtConfirmationMDP.PasswordChar = '*';
        }

   
    }
}
