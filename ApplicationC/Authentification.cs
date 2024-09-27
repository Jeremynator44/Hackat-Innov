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
                            FormMenu formmenu = new FormMenu();
                            formmenu.Show();
                            this.Hide();
                        }
                    }
                }
             
            }
        }
    }
}
