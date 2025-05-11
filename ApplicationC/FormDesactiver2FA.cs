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
                    ModeleAdministrateur.DoubleAuth(email, "désactiver");
                    MessageBox.Show("La double authentification a été désactivé avec succès !");
                    MessageBox.Show("Vous allez être déconnecter pour que la désactivation soit complète !");
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
