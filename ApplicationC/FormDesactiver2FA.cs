namespace ApplicationC
{
    public partial class FormDesactiver2FA : Form
    {
        private string email;
        private bool auth2fa;

        public FormDesactiver2FA(string email, bool auth2fa)
        {
            InitializeComponent();
            this.email = email;
            this.auth2fa = auth2fa;
        }

        private void FormDesactiver2FA_Load(object sender, EventArgs e)
        {

        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (txtCodeRecup.Text == "")
            {
                MessageBox.Show("Le champ n'est pas rempli ! ");
            }
            else
            {
                if (txtCodeRecup.Text == ModeleAdministrateur.RecupererCodeRecup(email))
                {
                    ModeleAdministrateur.DoubleAuth(email, "d�sactiver");
                    MessageBox.Show("La double authentification a �t� d�sactiv� avec succ�s !");
                    MessageBox.Show("Vous allez �tre d�connecter pour que la d�sactivation soit compl�te !");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Le code saisi est incorect !");
                }

            }
        }
    }
}
