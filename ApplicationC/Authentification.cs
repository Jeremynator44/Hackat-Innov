using ApplicationC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace ApplicationC
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            lblAuthentification.BackColor = Color.Transparent;
            txtIdentifiant.Text = "";
            txtPassword.Text = "";
        }

        private void btnVoirMasquer_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            
        }

        private void btnAuthentification_Click(object sender, EventArgs e)
        {
            if (txtIdentifiant.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Aucun champ n'a été rempli ! ");
            }
            else
            {
                if (txtIdentifiant.Text == "")
                {
                    MessageBox.Show("Le champ email n'a pas été rempli ! ");
                }
                else
                {
                    if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Le champ mot de passe n'a pas été rempli ! ");
                    }
                    else
                    {
                        if (ModeleAdministrateur.VerifAdministrateur(txtPassword.Text, txtIdentifiant.Text))
                        {
                            if (ModeleAdministrateur.DoubleAuth(txtIdentifiant.Text, "vérifier")){
                                Form2FA form2fa = new Form2FA(txtIdentifiant.Text, true);
                                form2fa.Show();
                                this.Hide();
                            }
                            else
                            {
                                FormMenu formmenu = new FormMenu(txtIdentifiant.Text, false);
                                formmenu.Show();
                                this.Hide();
                            }
                            
                        }
                    }
                }

            }
        }

        
    }
}
