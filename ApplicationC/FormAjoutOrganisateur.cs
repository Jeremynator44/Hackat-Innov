using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Diagnostics.CodeAnalysis;


namespace ApplicationC
{
    public partial class FormAjoutOrganisateur : Form
    {

        public FormAjoutOrganisateur()
        {
            InitializeComponent();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Ajout d'un organisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if (tbNom.Text != "" && tbPrenom.Text != "" && tbemail.Text != "")
            {
                if (!Controleur.ValidMail(tbemail.Text))
                {
                    MessageBox.Show("Erreur dans le format de l'adresse mail", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ModeleOrganisateur.AjoutOrganisateur(tbNom.Text, tbPrenom.Text, tbemail.Text))
                    {
                        MessageBox.Show("Organisateur ajouté, un email lui a été envoyé pour valider son inscription.");
                        Controleur.CreationEmail(tbemail.Text, tbNom.Text, tbPrenom.Text);
                        (System.Windows.Forms.Application.OpenForms["FormGestionHackathon"] as FormGestionHackathon).RemplirListeOrganisateurs();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans l'ajout d'un organisateur", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ajout impossible : Il faut saisir tous les champs", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// validation du format du Nom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != 'é' && e.KeyChar != 'è' && e.KeyChar != 'ê' && e.KeyChar != 'à' && e.KeyChar != 'ç' && e.KeyChar != 'ù' && e.KeyChar != '-'
                && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Space))
            {
                MessageBox.Show("Erreur dans le format de saisie du nom", "Erreur", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        /// <summary>
        /// validation du format du prénom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != 'é' && e.KeyChar != 'è' && e.KeyChar != 'ê' && e.KeyChar != 'à' && e.KeyChar != 'ç' && e.KeyChar != 'ù' && e.KeyChar != '-'
                && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Space))
            {
                MessageBox.Show("Erreur dans le format de saisie du prénom", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }
    }
}
