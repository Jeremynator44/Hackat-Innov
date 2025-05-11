using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationC
{
    public partial class FormMenu : Form
    {
        private string email;
        private bool auth2fa;
        public FormMenu(string email, bool auth2fa)
        {
            InitializeComponent();
            this.email = email;
            this.auth2fa = auth2fa;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (auth2fa == true)
            {
                activerToolStripMenuItem.Text = "Changer";
            }
            else
            {
                ListeDésactivationToolStripMenuItem.Visible = false;
            }
        }

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formEnfant);
            panelPrincipal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        //MENU

        private void menuStripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void activerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new GoogleAuth(email)); // Form 2FA
        }

        private void désactiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDesactiver2FA(email, auth2fa)); // Form Désactivation 2FA
        }

        private void SeDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void QUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //HACKATHONS

        private void ListeDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHackathon());   // Form de Liste des Hackathons
        }

        private void AjouterHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Create)); // Form de Gestion en ajout (create)
        }

        private void ModifierHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Update)); // Form de Gestion en modification (update)
        }

        private void ArchiverHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormArchivageHackathon()); // Form de Gestion en suppression
        }


        //MEMBRES

        private void ListeDesMembresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMembres());   // Form de Liste des Membres
        }
        private void AjouterMembresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembres(EtatGestion.Create)); // Form de Gestion en ajout (create)
        }

        private void ModifierMembresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembres(EtatGestion.Update)); // Form de Gestion en modification (update)
        }


        //EQUIPES

        private void ListeDesEquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEquipes()); // Form de Liste des Equipes
        }

        private void AjouterEquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipes(EtatGestion.Create)); // Form de Gestion en ajout (create)
        }

        private void ModifierEquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipes(EtatGestion.Update)); // Form de Gestion en modification (update)
        }
    }
}
