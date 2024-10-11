using ApplicationC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ApplicationC
{
    public partial class FormArchivageHackathon : Form
    {
        public FormArchivageHackathon()
        {
            InitializeComponent();
        }

        private void FormArchivageHackathon_Load(object sender, EventArgs e)
        {
            bsArchivageHackathon.DataSource = ModeleHackathon.listeHackathons().Select(x => new
            {
                x.Idhackathon,
                x.Thematique,
                x.Ville,
                x.Lieu,
                x.Conditions,
                x.Objectifs,
                x.Datebutoir,
                x.Dateheuredebuth,
                x.Dateheurefinh,
                x.Nbplacemax,
                x.IdorganisateurNavigation.Prenom,
                x.IdorganisateurNavigation.Nom
            });
            dgvArchivageListeHackatons.DataSource = bsArchivageHackathon;

            dgvArchivageListeHackatons.Columns[0].HeaderText = "Identifiant";
            dgvArchivageListeHackatons.Columns[6].HeaderText = "Date Butoir";
            dgvArchivageListeHackatons.Columns[7].HeaderText = "Date de début";
            dgvArchivageListeHackatons.Columns[8].HeaderText = "Date de fin";
            dgvArchivageListeHackatons.Columns[9].HeaderText = "Nombre de place Max";
            dgvArchivageListeHackatons.Columns[10].HeaderText = "Prénom Organisateur";
            dgvArchivageListeHackatons.Columns[11].HeaderText = "Nom Organisateur";

        }

        private void Actualisation()
        {
            bsArchivageHackathon.DataSource = ModeleHackathon.listeHackathons().Select(x => new
            {
                x.Idhackathon,
                x.Thematique,
                x.Ville,
                x.Lieu,
                x.Conditions,
                x.Objectifs,
                x.Datebutoir,
                x.Dateheuredebuth,
                x.Dateheurefinh,
                x.Nbplacemax,
                x.IdorganisateurNavigation.Prenom,
                x.IdorganisateurNavigation.Nom
            });
            dgvArchivageListeHackatons.DataSource = bsArchivageHackathon;

            dgvArchivageListeHackatons.Columns[0].HeaderText = "Identifiant";
            dgvArchivageListeHackatons.Columns[6].HeaderText = "Date Butoir";
            dgvArchivageListeHackatons.Columns[7].HeaderText = "Date de début";
            dgvArchivageListeHackatons.Columns[8].HeaderText = "Date de fin";
            dgvArchivageListeHackatons.Columns[9].HeaderText = "Nombre de place Max";
            dgvArchivageListeHackatons.Columns[10].HeaderText = "Prénom Organisateur";
            dgvArchivageListeHackatons.Columns[11].HeaderText = "Nom Organisateur";
        }

        private void btnArchiver_Click(object sender, EventArgs e)
        {
            bool reponse = false;
            System.Type type = bsArchivageHackathon.Current.GetType();
            int idHackathon = (int)type.GetProperty("Idhackathon").GetValue(bsArchivageHackathon.Current, null);
            string Thematique = (string)type.GetProperty("Thematique").GetValue(bsArchivageHackathon.Current, null);
            if (MessageBox.Show("Etes vous sur de vouloir archiver le hackathon : " + Thematique, "Archivage", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                reponse = ModeleHackathon.ArchivageHackathon(idHackathon);
                if (reponse)
                {
                    MessageBox.Show("La commande à bien été archivée !");
                    Actualisation();
                }
                else
                {
                    MessageBox.Show("La commande n'a pas pu être archivée !");
                }
            }
            

        }
    }
}
