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
        public FormEquipes()
        {
            InitializeComponent();
        }

        private void FormMembres_Load(object sender, EventArgs e)
        {
            foreach (ModeleEquipe.listeEquipes() E as test)
            {
                if (ModeleEquipe.EquipeInscrite())
                {

                }
            }
            bsEquipe.DataSource = ModeleEquipe.listeEquipes().Select(static x => new
            {
                x.Idequipe,
                x.Nomequipe,
                x.Lienprototype,
                x.Login,
                x.EstInscrite
            }).OrderBy(x => x.Idequipe);


            dgvEquipe.DataSource = bsEquipe;
            dgvEquipe.Columns[0].HeaderText = "Identifiant Equipe";
            dgvEquipe.Columns[1].HeaderText = "Nom Equipe";
            dgvEquipe.Columns[2].HeaderText = "Lien Portfolio";
            dgvEquipe.Columns[3].HeaderText = "Email";
            dgvEquipe.Columns[4].HeaderText = "Est Inscrite";
        }
    }
}