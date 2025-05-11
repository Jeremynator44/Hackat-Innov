using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtpNet;
using QRCoder;

namespace ApplicationC
{
    public partial class Form2FA : Form
    {
        private string email;
        private bool auth2fa;
        private Totp totp;

        public Form2FA(string email, bool auth2fa)
        {
            InitializeComponent();
            this.email = email;
            this.auth2fa = auth2fa;
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            lbl2Authentification.BackColor = Color.Transparent;
            txtCode.Text = "";
        }
        private bool VérifCode2fa()
        {
            string secret = ModeleAdministrateur.RecupererCodeSecret(email);
            byte[] decodedSecretKey = Base32.Base32Encoder.Decode(secret);

            totp = new Totp(decodedSecretKey);

            // Récupère le code entré par l'utilisateur
            string userCode = txtCode.Text.Trim();

            // La vérification se fait avec une tolérance de +/- 1 période de 30 secondes (RFC)
            bool isValid = totp.VerifyTotp(userCode, out long timeStepMatched, new VerificationWindow(previous: 1, future: 1));

            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn2Authentification_Click(object sender, EventArgs e)
        {
            if (VérifCode2fa())
            {
                MessageBox.Show("Connecté avec succès !");
                FormMenu formmenu = new FormMenu(email, true);
                formmenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Code Invalide. Veuillez réessayer.");
            }
        }
    }
}
