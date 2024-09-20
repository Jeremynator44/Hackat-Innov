using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            if (txtIdentifiant.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Aucun champ n'a été rempli ! ");
            }
            else
            {

                if (Controleur.ValidMail(txtIdentifiant.Text) && )
                {
                    FormMenu formmenu = new FormMenu();
                    formmenu.Show();
                }
                else
                {
                    MessageBox.Show("L'identifiant ou mot de passe est incorrect ! ");
                }
            }
        }
    }
}
