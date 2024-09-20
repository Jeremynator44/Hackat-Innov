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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void QUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListeDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHackathon());
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

        private void FormMenu_Load(object sender, EventArgs e)
        {
        }

        private void GestionDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Create)); // Form de Gestion en ajout (create)
        }

        private void ModificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Update)); // Form de Gestion en modification (update)
        }

        private void menuStripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
