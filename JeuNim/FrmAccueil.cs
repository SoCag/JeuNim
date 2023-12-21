﻿using JeuNim.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuNim
{
    public partial class FrmAccueil : Form
    {
        Joueur utilisateurConnecte;
        public FrmAccueil(Joueur pJoueurConnecte)
        {
            InitializeComponent();
            utilisateurConnecte = pJoueurConnecte;
        }


        private void btnCreer_Click(object sender, EventArgs e)
        {
            using (NesContext nesContext = new NesContext())
            {
                Partie partie = new Partie
                {
                    Numero = GenerateRandom(),
                    NbBaton = GenerateRandome(),
                    EstCommence = false,
                    EstTermine = false,
                    DatePartie = Date(),
                };
                nesContext.Parties.Add(partie);
                nesContext.SaveChanges();

                Participant participant = new Participant
                {
                    Aperdu = false,
                    ACommence = GenerateAleat(),
                    IdPartie = partie.IdPartie,
                    IdJoueur = utilisateurConnecte.IdJoueur,
                };
                // a faire - PAGE DU JEU
            };

        }
        static string GenerateRandom()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Générer une chaîne de 6 caractères aléatoires
            string randomString = new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomString;
        }

        static int GenerateRandome()
        {
            Random random = new Random();

            // Générer un nombre aléatoire entre 16 et 21 inclus
            int randomNumber = random.Next(16, 22); // Le second argument (22) est exclusif

            return randomNumber;
        }

        static DateTime Date()
        {
            DateTime today = DateTime.Now;

            return today;
        }

        static bool GenerateAleat()
        {
            Random random = new Random();
            bool isRandom = random.Next(0, 2) == 0; // Génère aléatoirement vrai ou faux (0 pour faux, 1 pour vrai)

            return isRandom;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            try
            {
                using (NesContext context = new NesContext())
                {
                    /// elle est vide
                    if (String.IsNullOrEmpty(txtNumero.Text))
                    {
                        Partie partie = context.Parties
                            .Where(p => p.EstCommence == false && p.EstPrive == false)
                            .OrderByDescending(p => p.DatePartie)
                            .Single();
                        
                        Participant participantDejaCree = context.Participants
                            .Where(p => p.IdPartie == partie.IdPartie)
                            .Single();

                        bool commence;
                        if (participantDejaCree.ACommence)
                        {
                            commence = false;
                        }
                        else
                        {
                            commence = true;
                        }
                        Participant participant = new Participant
                        {
                            Aperdu = false,
                            ACommence = commence,
                            IdPartie = partie.IdPartie,
                            IdJoueur = utilisateurConnecte.IdJoueur,
                        };
                    }
                    else
                    {
                        Partie partie = context.Parties
                            .Where(p => p.EstCommence == false && p.Numero == txtNumero.Text)
                            .Single();

                        Participant participantDejaCree = context.Participants
                            .Where(p => p.IdPartie == partie.IdPartie)
                            .Single();

                        bool commence;
                        if (participantDejaCree.ACommence)
                        {
                            commence = false;
                        }
                        else
                        {
                            commence = true;
                        }
                        Participant participant = new Participant
                        {
                            Aperdu = false,
                            ACommence = commence,
                            IdPartie = partie.IdPartie,
                            IdJoueur = utilisateurConnecte.IdJoueur,
                        };
                    }
                    {

                    };
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Numero de partie inexistant :\n" + ex.Message);
            }
        }
    }
}
