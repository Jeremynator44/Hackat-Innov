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

namespace ApplicationC
{
    public partial class FormEquipes : Form
    {
        private int idH;
        private bool premier;
        public FormEquipes()
        {
            InitializeComponent();
            idH = cbTriHackathon.SelectedIndex + 1;
        }

        private void FormEquipes_Load(object sender, EventArgs e)
        {
            premier = true;
            bsEquipe.DataSource = ModeleEquipe.listeEquipesInscrites().Select(static x => new
            {
                x.Idequipe,
                x.IdequipeNavigation.Nomequipe,
                x.IdequipeNavigation.Lienprototype,
                x.IdequipeNavigation.Login

            }).GroupBy(x => x.Idequipe)
            .Select(g => g.First());

            dgvEquipe.DataSource = bsEquipe;
            dgvEquipe.Columns[0].HeaderText = "Identifiant Equipe";
            dgvEquipe.Columns[1].HeaderText = "Nom Equipe";
            dgvEquipe.Columns[2].HeaderText = "Lien Portfolio";
            RemplirTriHackathons();
            premier = false;
        }

        public void RemplirTriHackathons()
        {
            cbTriHackathon.ValueMember = "idhackathon";//permet de stocker l'identifiant
            cbTriHackathon.DisplayMember = "thematique";
            BSListeH.DataSource = ModeleHackathon.listeHackathons();
            cbTriHackathon.DataSource = BSListeH;
            cbTriHackathon.SelectedIndex = -1;
        }

        private void VoirLesMembresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bsEquipe.Current.GetType();
            int idE = (int)type.GetProperty("Idequipe").GetValue(bsEquipe.Current, null);

            List<Membre> lesmembresparequipe = ModeleMembre.listeMembresParEquipe(idE);
            if (lesmembresparequipe.Count != 0)
            {
                bsMembre.DataSource = (lesmembresparequipe).Select(static x => new
                {
                    x.Idmembre,
                    x.Prenom,
                    x.Nom
                });

                dgvMembres.DataSource = bsMembre;
                dgvMembres.Visible = true;

            }
            else
            {
                dgvMembres.Visible = false;
                MessageBox.Show("Pas de membres pour cette équipe !");
            }

        }
        private void SupprimerEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bsEquipe.Current.GetType();
            int idE = (int)type.GetProperty("Idequipe").GetValue(bsEquipe.Current, null);

            Equipe E = ModeleEquipe.RecupererEquipe(idE);
            DialogResult result = MessageBox.Show("Êtes-vous certain de vouloir supprimer l'équipe : " + E.Nomequipe + " avec le lien prototype \'" + E.Lienprototype + "\' et ayant l'email \'" + E.Login + "\' !", "ERREUR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                if (ModeleEquipe.SupprimerEquipe(idE))
                {
                    MessageBox.Show("L'équipe a bien été supprimée !");
                    bsEquipe.DataSource = ModeleEquipe.listeEquipesInscrites().Select(static x => new
                    {
                        x.Idequipe,
                        x.IdequipeNavigation.Nomequipe,
                        x.IdequipeNavigation.Lienprototype,
                        x.IdequipeNavigation.Login

                    }).OrderBy(x => x.Idequipe);
                    cbTriHackathon.SelectedIndex = idH - 1;
                }
                else
                {
                    MessageBox.Show("L'équipe n'a pas été supprimée !");
                }
            }

        }

        private void DésinscrireEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbTriHackathon.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un hackathon pour désinscrire l'équipe associé à l'ahackathon !");
                return;
            }

            string nomHackathon = "";
            System.Type type = bsEquipe.Current.GetType();
            int idE = (int)type.GetProperty("Idequipe").GetValue(bsEquipe.Current, null);

            Equipe E = ModeleEquipe.RecupererEquipe(idE);
            nomHackathon = ModeleEquipe.RecupererHackathonDeEquipe(idE, idH);

            DialogResult result = MessageBox.Show("Êtes-vous certain de vouloir désinscrire l'équipe : " + E.Nomequipe + " avec le lien prototype \'" + E.Lienprototype + "\' et ayant l'email \'" + E.Login + "\' inscrit au hackathon \'" + nomHackathon + "\' !", "ERREUR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                if (ModeleEquipe.DesinscrireEquipe(idE, idH))
                {
                    MessageBox.Show("L'équipe a bien été désinscrite !");

                    // Envoyer des notifications aux membres de l'équipe
                    List<Membre> membres = ModeleMembre.listeMembresParEquipe(idE);
                    foreach (var membre in membres)
                    {
                        try
                        {
                            string corps = $"Bonjour {membre.Nom},<br><br>L'équipe '{E.Nomequipe}' a été désinscrite du hackathon '{nomHackathon}'.<br><br>Cordialement,<br>L'équipe Hackat'Innov.";
                            Email.EnvoyerEmailNotification(membre.Email, "Notification de désinscription", corps);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Échec de l'envoi de l'email à : " + membre.Email + "\n" + ex.Message);
                        }
                    }

                    // Rafraîchir la liste des équipes
                    FormEquipes_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("L'équipe n'a pas été désinscrite !");
                }
            }
        }





        private void DgvEquipe_Click(object sender, EventArgs e)
        {
            dgvMembres.Visible = false;
        }

        private void DgvEquipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMembres.Visible = false;
        }

        private void DgvEquipe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvMembres.Visible = false;
        }

        private void cbTriHackathon_SelectedIndexChanged(object sender, EventArgs e)
        {
            idH = cbTriHackathon.SelectedIndex + 1;
            BSListeH_CurrentChanged(sender, e);
        }

        private void BSListeH_CurrentChanged(object sender, EventArgs e)
        {
            {
                if (premier == true) {cbTriHackathon.SelectedIndex = -1;}
                // si un hackathon est sélectionné dans la liste des hackathons
                if (cbTriHackathon.SelectedIndex != -1)
                {
                    bsEquipe.DataSource = ModeleInscription.listeInscription(idH).Select(static x => new
                    {
                        x.Idequipe,
                        x.IdequipeNavigation.Nomequipe,
                        x.IdequipeNavigation.Lienprototype,
                        x.IdequipeNavigation.Login

                    }).OrderBy(x => x.Idequipe);

                    dgvEquipe.DataSource = bsEquipe;
                    

                }
            }
        }
    }
}