using JeuNim.Models;

namespace JeuNim
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            string motDePasse = TxtMDP.Text;

            try
            {
                using (NesContext db = new NesContext())
                {
                    // Recherche l'utilisateur par adresse e-mail
                    Joueur utilisateur = db.Joueurs.FirstOrDefault(j => j.AdresseEmail == email);

                    if (utilisateur != null)
                    {
                        // V�rifie le mot de passe hach�
                        if (BCrypt.Net.BCrypt.Verify(motDePasse, utilisateur.MotDePasse))
                        {
                            // L'utilisateur est connect� avec succ�s
                            MessageBox.Show("Connexion r�ussie !");
                            // Effectuez ici les actions n�cessaires apr�s la connexion.
                        }
                        else
                        {
                            MessageBox.Show("Mot de passe incorrect.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Adresse e-mail non trouv�e.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cacher le formulaire principal (de connexion)
            this.Hide();

            // Afficher le formulaire d'inscription
            FrmInscription formInscription = new FrmInscription();
            formInscription.ShowDialog(); // Utilisez ShowDialog pour bloquer l'acc�s au formulaire principal jusqu'� ce que le formulaire d'inscription soit ferm�
        }

        private void TxtMDP_TextChanged(object sender, EventArgs e)
        {
            TxtMDP.PasswordChar = '*';
        }

        private void cacherMDP(object sender, EventArgs e)
        {
            // Masque � nouveau le texte lorsque la souris quitte l'ic�ne
            TxtMDP.PasswordChar = '*';
        }

        private void visualiserMDP(object sender, EventArgs e)
        {

            // Afficher le texte brut (non masqu�) lorsque la souris survole l'ic�ne
            TxtMDP.PasswordChar = '\0';
        }
    }
}
