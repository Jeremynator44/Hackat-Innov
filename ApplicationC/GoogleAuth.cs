using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtpNet;
using QRCoder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApplicationC
{
    public enum EtatAuth
    {
        Activation,
        Activé,
        Désactivation
    }
    public partial class GoogleAuth : Form
    {
        private string secretKey2;
        private byte[] secretKey;
        private Totp totp;
        private string email;


        public GoogleAuth(string email)
        {
            InitializeComponent();
            this.email = email;
            secretKey = KeyGeneration.GenerateRandomKey(20);
            secretKey2 = Base32.Base32Encoder.Encode(secretKey);
        }

        private void GoogleAuth_Load(object sender, EventArgs e)
        {
            GenerateQrCode();
            txt_CodeRécup.Text = GenererCodeRécup();
        }

        private void GenerateQrCode()
        {
            totpPictureBox.Image = GenerateQrCodeImage(GenerateOtpUri(secretKey2));
        }

        private string GenerateOtpUri(string secretKey)
        {
            var issuer = "HackatInnov";
            var accountName = email;
            return $"otpauth://totp/{accountName}?secret={secretKey}&issuer={issuer}";
        }


        private Bitmap GenerateQrCodeImage(string data)
        {
            using (var qrGenerator = new QRCodeGenerator())
            using (var qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q))
            using (var qrCode = new QRCode(qrCodeData))
            {
                return qrCode.GetGraphic(20);
            }
        }

        private string GenererCodeRécup()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder code = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int index = random.Next(caracteres.Length);
                code.Append(caracteres[index]);
            }

            return code.ToString();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            // Initialise TOTP avec la clé secrète
            totp = new Totp(secretKey);


            // Récupère le code entré par l'utilisateur
            string userCode = txtCode.Text.Trim();
            //Trim() retire tout les espaces présent dans le code saisi

            // La vérification se fait avec une période de 30 secondes
            bool isValid = totp.VerifyTotp(userCode, out long timeStepMatched, new VerificationWindow(previous: 1, future: 1));

            // Vérifie si le code est valide
            if (isValid)
            {
                ModeleAdministrateur.AjoutCodeSecretEtRecup(secretKey2, txt_CodeRécup.Text, email);
                MessageBox.Show("Activation de la double authentification réussie !");
                MessageBox.Show("Vous allez être déconnecter pour que l'activation soit complète !");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Code Invalide. Veuillez réessayer.");
            }
        }
    }

}


