using JeuNim.Models;
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
        Partie partie;
        Participant participant1;
        Participant participant2;
        public FrmJeu(int pNumeroPartie)
        {
            InitializeComponent();
            setPartieByNumero(pNumeroPartie);
            labelNumeroPartie.Text = pNumeroPartie.ToString();
        }

        private void setPartieByNumero(int pNumeroPartie)
        {
            try
            {
                using (NesContext context = new NesContext())
                {
                    partie = context.Parties.Where(p => p.Numero == pNumeroPartie.ToString()).Single();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la récupération de la partie :\n" + ex.Message);
            }
        }

        private void timerRefreshDonnee_Tick(object sender, EventArgs e)
        {
            RafraichirDonnees();
        }

        private void RafraichirDonnees()
        {
            try
            {
                using(NesContext context = new NesContext())
                {
                    participant2 = context.Participants.Where(p => p.IdPartie == partie.IdPartie && p.IdParticipant != participant1.IdParticipant).Single();
                    labelNomAdversaire.Text = participant2.IdJoueurNavigation.Login;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur à la récupération de la partie :\n" + ex.Message);
            }
        }
    }
}
