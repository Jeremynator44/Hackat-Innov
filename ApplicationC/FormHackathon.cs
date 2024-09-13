using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationC.Entities;

namespace ApplicationC
{
    public partial class FormHackathon : Form
    {
        public FormHackathon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BSHackathon.DataSource = ModeleHackathon.listeHackathons().Select(static x => new
            {
                x.Idhackathon,
                x.Thematique,
                x.Lieu,
                x.Ville,
                x.Dateheuredebuth,
                x.Dateheurefinh,
                x.Nbplacemax,
                x.Datebutoir,
                x.Objectifs,
                x.IdorganisateurNavigation.Nom,
                x.IdorganisateurNavigation.Prenom
            }).OrderByDescending(x => x.Dateheuredebuth);


            dgvHackathon.DataSource = BSHackathon;
            dgvHackathon.Columns[0].HeaderText = "Identifiant";
            dgvHackathon.Columns[1].HeaderText = "Thématique";
            dgvHackathon.Columns[2].HeaderText = "Lieu";
            dgvHackathon.Columns[3].HeaderText = "Ville";
            dgvHackathon.Columns[4].HeaderText = "Date de début";
            dgvHackathon.Columns[5].HeaderText = "Date de fin";
            dgvHackathon.Columns[6].HeaderText = "Nombre de place Max";
            dgvHackathon.Columns[7].HeaderText = "Date Butoir Inscription";
            dgvHackathon.Columns[8].HeaderText = "Objectifs";
            dgvHackathon.Columns[9].HeaderText = "Nom Organisateur";
            dgvHackathon.Columns[10].HeaderText = "Prénom Organisateur";
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VoirLesÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = BSHackathon.Current.GetType();
            int idH = (int)type.GetProperty("Idhackathon").GetValue(BSHackathon.Current, null);
           
            List<Equipe> lesEquipes = ModeleHackathon.listeEquipesParHackathon(idH);
            if (lesEquipes.Count != 0)
            {
                BSEquipe.DataSource = (lesEquipes).Select(static x => new
                  {
                      x.Idequipe,
                      x.Nomequipe
                  });

                dgvEquipes.DataSource = BSEquipe;
                dgvEquipes.Visible = true;

            }
            else
            {
                dgvEquipes.Visible = false;
                MessageBox.Show("Pas d'équipe pour cet hackathon");
            }

        }

        private void DgvHackathon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEquipes.Visible = false;
        }

        private void DgvHackathon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEquipes.Visible = false;
        }

        private void DgvHackathon_Click(object sender, EventArgs e)
        {
            dgvEquipes.Visible = false;
        }

    
    }
}
