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
    public partial class FormMembres : Form
    {
        public FormMembres()
        {
            InitializeComponent();
        }

        private void FormMembres_Load(object sender, EventArgs e)
        {
            bsMembre.DataSource = ModeleMembre.listeMembres().Select(static x => new
            {
                x.Idmembre,
                x.Nom,
                x.Prenom,
                x.Email,
                x.Telephone,
                x.Datenaissance,
                x.Lienportfolio,
                x.IdequipeNavigation.Nomequipe
            }).OrderBy(x => x.Idmembre);


            dgvMembre.DataSource = bsMembre;
            dgvMembre.Columns[0].HeaderText = "Identifiant Membre";
            dgvMembre.Columns[1].HeaderText = "Nom";
            dgvMembre.Columns[2].HeaderText = "Prénom";
            dgvMembre.Columns[3].HeaderText = "Email";
            dgvMembre.Columns[4].HeaderText = "Téléphone";
            dgvMembre.Columns[5].HeaderText = "Date de Naissance";
            dgvMembre.Columns[6].HeaderText = "Lien Portfolio";
            dgvMembre.Columns[7].HeaderText = "Equipe";
        }

        private void SupprimerMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bsMembre.Current.GetType();
            int idM = (int)type.GetProperty("Idmembre").GetValue(bsMembre.Current, null);

            Membre M = ModeleMembre.RecupererMembre(idM);
            DialogResult result = MessageBox.Show("Êtes-vous certain de vouloir supprimer le membre : " + M.Nom + " " + M.Prenom + " appartenant à l'équipe " + M.IdequipeNavigation.Nomequipe,"ERREUR",MessageBoxButtons.YesNo,MessageBoxIcon.Error);

            if (result == DialogResult.Yes) 
            {
                if (ModeleMembre.SupprimerMembre(idM))
                {
                    MessageBox.Show("Le membre a bien été supprimé !");
                    bsMembre.DataSource = ModeleMembre.listeMembres().Select(static x => new
                    {
                        x.Idmembre,
                        x.Nom,
                        x.Prenom,
                        x.Email,
                        x.Telephone,
                        x.Datenaissance,
                        x.Lienportfolio,
                        x.IdequipeNavigation.Nomequipe
                    }).OrderBy(x => x.Idmembre);
                }
                else
                {
                    MessageBox.Show("Le membre n'a pas été supprimé !");
                }

            }

        }
    }
}
