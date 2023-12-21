using JeuNim.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuNim
{
    public partial class FrmJeu : Form
    {
        Partie partieEnCours;
        Joueur joueurConnecte;
        Participant participantConnecte;
        Participant participantAdversaire;
        List<Coup> listCoups;
        public FrmJeu(Joueur pJoueurConncte, Participant pParticipantConnecte, Partie pPartie)
        {
            InitializeComponent();
            partieEnCours = pPartie;
            participantConnecte = pParticipantConnecte;
            joueurConnecte = pJoueurConncte;
            labelNumeroPartie.Text = partieEnCours.Numero.ToString();
            labelNombreBaton.Text = partieEnCours.NbBaton.ToString();
            RafraichirDonnees();
            timerRefreshDonnee.Start();
        }

        private void timerRefreshDonnee_Tick(object sender, EventArgs e)
        {
            RafraichirDonnees();
        }

        private void RafraichirDonnees()
        {
            try
            {
                using (NesContext context = new NesContext())
                {
                    // On récupère l'adversaire
                    List<Participant> listParticipantAdversaire = context.Participants.Where(p => p.IdPartie == partieEnCours.IdPartie && p.IdParticipant != participantConnecte.IdParticipant).ToList();

                    if (listParticipantAdversaire.Count != 0)
                    {
                        // Je récupère le participant adversaire
                        participantAdversaire = context.Participants.Where(p => p.IdPartie == partieEnCours.IdPartie && p.IdParticipant != participantConnecte.IdParticipant).Single();
                        Joueur joueurAdversaire = context.Joueurs.Where(j => j.IdJoueur == participantAdversaire.IdJoueur).Single();
                        // On empêche le participant connecté de quitter
                        buttonQuitter.Enabled = false;

                        // La partie commence : On déclare la partie comme "Commencée" !
                        partieEnCours.EstCommence = true;
                        context.SaveChanges();

                        // On renseigne l'adversaire
                        labelNomAdversaire.Text = joueurAdversaire.Login;

                        // On récupère la liste des coups
                        listCoups = context.Coups.
                            Where(c => c.IdParticipant == participantConnecte.IdParticipant || c.IdParticipant == participantAdversaire.IdParticipant).
                            OrderBy(c => c.Ordre).ToList();

                        int nbBatonsEnleves = listCoups.Sum(c => c.NbBaton);
                        // On calcul le nombre de batons restants
                        int nbBatonsRestant = partieEnCours.NbBaton - nbBatonsEnleves;
                        // On met à jour le nombre de bâtons
                        labelNombreBaton.Text = nbBatonsRestant.ToString();

                        // S'il ne reste qu'un bâton, le joueur qui a joué le dernier coup a gagné
                        if (nbBatonsRestant == 1)
                        {
                            partieEnCours.EstTermine = true;
                            context.SaveChanges();

                            // On regarde si le dernier coup a été réalisé par le joueur connecté
                            if (participantConnecte.IdParticipant != listCoups.Last().IdParticipant)
                            {
                                // Alors je lui indique qu'il a gagné, et je ferme la partie quand il appuye sur OK
                                DialogResult resultat = MessageBox.Show("Vous avez gagné !!!", "Bien joué !", MessageBoxButtons.OK);

                                if (resultat == DialogResult.Yes)
                                {
                                    // Je le renvoie sur la page d'accueil
                                    FrmAccueil frmAccueil = new FrmAccueil(joueurConnecte);
                                    frmAccueil.Show();
                                    Close();
                                }
                            }
                            // Sinon il  a perdu
                            else
                            {
                                // J'indique qu'il a perdu sur le participant
                                participantConnecte.Aperdu = true;
                                context.SaveChanges();

                                DialogResult resultat = MessageBox.Show("Vous avez perdu.", "Dommage...", MessageBoxButtons.OK);

                                if (resultat == DialogResult.Yes)
                                {
                                    // Je le renvoie sur la page d'accueil
                                    FrmAccueil frmAccueil = new FrmAccueil(joueurConnecte);
                                    frmAccueil.Show();
                                    Close();
                                }
                            }
                        }
                        // Sinon la partie continue
                        else
                        {
                            // Si l'adversaire a perdu alors qu'il y a encore des batons c'est qu'il a abandonné, donc l'utilisateur connecté a gagné
                            if (participantAdversaire.Aperdu)
                            {
                                // Alors je lui indique qu'il a gagné, et je ferme la partie quand il appuye sur OK
                                DialogResult resultat = MessageBox.Show("Votre adversaire a abandonné...", "Trop fort ! ;)", MessageBoxButtons.OK);

                                if (resultat == DialogResult.Yes)
                                {
                                    // Je le renvoie sur la page d'accueil
                                    FrmAccueil frmAccueil = new FrmAccueil(joueurConnecte);
                                    frmAccueil.Show();
                                    Close();
                                }
                            }
                            // Sinon on continue
                            else
                            {
                                // Si la liste des coups est vide, alors la partie commence
                                if (listCoups.Count == 0)
                                {
                                    // Si le joueur qui commence est celui connecté actuellement, on lui débloque les boutons
                                    if (participantConnecte.ACommence)
                                    {
                                        numericBatonARetirer.Enabled = true;
                                        buttonEnleverBaton.Enabled = true;
                                    }
                                }
                                else
                                {
                                    // Je regarde si l'utilisateur connecté n'a pas exécuté le dernier coup
                                    if (participantConnecte.IdParticipant != listCoups.Last().IdParticipant)
                                    {
                                        // Alors je lui débloque les boutons
                                        numericBatonARetirer.Enabled = true;
                                        buttonEnleverBaton.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la récupération de la partie :\n" + ex.Message);
            }
        }

        private void buttonEnleverBaton_Click(object sender, EventArgs e)
        {
            // Le joueur connecté à joué, je lui ajoute un coup
            try
            {
                using (NesContext context = new NesContext())
                {
                    // On récupère la liste des coups
                    listCoups = context.Coups.
                        Where(c => c.IdParticipant == participantConnecte.IdParticipant || c.IdParticipant == participantAdversaire.IdParticipant).
                        OrderBy(c => c.Ordre).ToList();

                    int ordre;
                    if(listCoups.Count == 0)
                    {
                        ordre = 1;
                    }
                    else
                    {
                        ordre = listCoups.Last().Ordre + 1;
                    }

                    Coup coupJoue = new Coup
                    {
                        NbBaton = (int)numericBatonARetirer.Value,
                        Ordre = ordre
                    };
                    context.Coups.Add(coupJoue);
                    context.SaveChanges();

                    // Et je rebloque ses boutons
                    numericBatonARetirer.Enabled = false;
                    buttonEnleverBaton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à l'exécution :\n" + ex.Message);
            }
        }

        private void buttonAbandonner_Click(object sender, EventArgs e)
        {
            // Le joueur abandonne
            try
            {
                DialogResult resultat = MessageBox.Show("Êtes-vous sûr de vouloir abandonner ?\nVous perdrez la partie...", "Abandonner ?", MessageBoxButtons.YesNo);

                if (resultat == DialogResult.Yes)
                {
                    using (NesContext context = new NesContext())
                    {
                        participantConnecte.Aperdu = true;
                        partieEnCours.EstTermine = true;
                        context.SaveChanges();
                    }

                    // Je le renvoie sur la page d'accueil
                    FrmAccueil frmAccueil = new FrmAccueil(joueurConnecte);
                    frmAccueil.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à l'exécution :\n" + ex.Message);
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            // Si l'utilisateur ferme la fenêtre via ce bouton, la partie n'a pas commencée
            // Alors cela supprime la partie et le participant
            try
            {
                using (NesContext context = new NesContext())
                {
                    participantConnecte.Aperdu = true;
                    partieEnCours.EstTermine = true;
                    context.SaveChanges();
                }

                // Je le renvoie sur la page d'accueil
                FrmAccueil frmAccueil = new FrmAccueil(joueurConnecte);
                frmAccueil.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la fermeture :\n" + ex.Message);
            }
        }
    }
}
