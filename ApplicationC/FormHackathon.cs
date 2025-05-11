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
using ApplicationC.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ApplicationC
{
    public partial class FormHackathon : Form
    {
        private int idHT;
        private int idHD;
        private int idHV;
        private bool premier;
        private string thematique;
        private string dateheuredebuth;
        private string ville;

        public FormHackathon()
        {
            InitializeComponent();
            idHT = cbTriHackathonThématique.SelectedIndex;
            idHD = cbTriHackathonThématique.SelectedIndex;
            idHV = cbTriHackathonThématique.SelectedIndex;
        }

        private void FormHackathon_Load(object sender, EventArgs e)
        {
            premier = true;
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
            //RemplirFiltreThematique();
            //RemplirFiltreDate();
            //RemplirFiltreVille();
            premier = false;


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


        //Filtre thematique
        public void RemplirFiltreThematique()
        {
            cbTriHackathonThématique.ValueMember = "idhackathon";//permet de stocker l'identifiant
            cbTriHackathonThématique.DisplayMember = "thematique";
            BSFiltreThematique.DataSource = ModeleHackathon.listeHackathons();
            cbTriHackathonThématique.DataSource = BSFiltreThematique;
            cbTriHackathonThématique.SelectedIndex = -1;
        }
        private void cbFiltreThematique_SelectedIndexChanged(object sender, EventArgs e)
        {
            idHT = cbTriHackathonThématique.SelectedIndex + 1;
            BSFiltreThematique_CurrentChanged(sender, e);
        }

        private void BSFiltreThematique_CurrentChanged(object sender, EventArgs e)
        {
            {
                if (premier == true) { cbTriHackathonThématique.SelectedIndex = -1; }
                // si un hackathon est sélectionné dans la liste des hackathons
                if (cbTriHackathonThématique.SelectedIndex != -1)
                {

                    BSHackathon.DataSource = ModeleHackathon.listeHackathons(thematique, dateheuredebuth, ville).Select(static x => new
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


                }
            }
        }


        //Filtre date
        public void RemplirFiltreDate()
        {
            cbTriHackathonDate.ValueMember = "idhackathon";//permet de stocker l'identifiant
            cbTriHackathonDate.DisplayMember = "dateheuredebuth";
            BSFiltreDate.DataSource = ModeleHackathon.listeHackathons();
            cbTriHackathonDate.DataSource = BSFiltreDate;
            cbTriHackathonDate.SelectedIndex = -1;
        }
        private void cbFiltreDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            idHD = cbTriHackathonDate.SelectedIndex + 1;
            BSFiltreDate_CurrentChanged(sender, e);
        }

        private void BSFiltreDate_CurrentChanged(object sender, EventArgs e)
        {
            {
                if (premier == true) { cbTriHackathonDate.SelectedIndex = -1; }
                // si un hackathon est sélectionné dans la liste des hackathons
                if (cbTriHackathonDate.SelectedIndex != -1)
                {
                    thematique = cbTriHackathonThématique.Text;
                    dateheuredebuth = cbTriHackathonDate.Text;
                    ville = cbTriHackathonThématique.Text;

                    BSHackathon.DataSource = ModeleHackathon.listeHackathons(thematique, dateheuredebuth, ville).Select(static x => new
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


                }
            }
        }


        //Filtre ville
        public void RemplirFiltreVille()
        {
            cbTriHackathonVille.ValueMember = "idhackathon";//permet de stocker l'identifiant
            cbTriHackathonVille.DisplayMember = "ville";
            BSFiltreVille.DataSource = ModeleHackathon.listeHackathons();
            cbTriHackathonVille.DataSource = BSFiltreVille;
            cbTriHackathonVille.SelectedIndex = -1;
        }
        private void cbTriHackathonVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            idHV = cbTriHackathonVille.SelectedIndex + 1;
            BSFiltreVille_CurrentChanged(sender, e);
        }

        private void BSFiltreVille_CurrentChanged(object sender, EventArgs e)
        {
            {
                if (premier == true) { cbTriHackathonVille.SelectedIndex = -1; }
                // si un hackathon est sélectionné dans la liste des hackathons
                if (cbTriHackathonVille.SelectedIndex != -1)
                {
                    thematique = cbTriHackathonThématique.Text;
                    dateheuredebuth = cbTriHackathonDate.Text;
                    ville = cbTriHackathonThématique.Text;    

                    BSHackathon.DataSource = ModeleHackathon.listeHackathons(thematique, dateheuredebuth, ville).Select(static x => new
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


                }
            }
        }

    }
}
