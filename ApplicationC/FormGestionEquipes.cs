using ApplicationC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApplicationC
{
    public partial class FormGestionEquipes : Form
    {
        private EtatGestion etat;
        private bool premier;
        public FormGestionEquipes(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RemplirListeEquipes()
        {
            cbListe.ValueMember = "idequipe";//permet de stocker l'identifiant
            cbListe.DisplayMember = "nomequipe";
            BSListeE.DataSource = ModeleEquipe.listeEquipes();
            cbListe.DataSource = BSListeE;
            cbListe.SelectedIndex = -1;
        }
        public void RemplirDGVMembres()
        {
            BSListeM.DataSource = ModeleMembre.listeMembres().Select(static x => new
            {
                x.Idmembre,
                x.Nom,
                x.Prenom
                //x.IdequipeNavigation.Nomequipe
            }).OrderBy(x => x.Idmembre);

            dgvMembres.DataSource = BSListeM;
            dgvMembres.Columns[0].HeaderText = "Identifiant Membre";
            dgvMembres.Columns[1].HeaderText = "Nom";
            dgvMembres.Columns[2].HeaderText = "Prénom";
            //dgvMembres.Columns[3].HeaderText = "Nom d'équipe";
        }

        private void FormGestionEquipes_Load(object sender, EventArgs e)
        {
            premier = true;
            RemplirDGVMembres();
            if (etat == EtatGestion.Create) // cas etat create
            {
                label1.Text = "Ajout d'une Equipe";
                BtnAction.Text = "AJOUTER";
                gbInfo.Visible = true;
                cbListe.Visible = false;
                dgvMembres.Visible = false;
                lblMembre.Visible = false;

                lblNomEquipe.Location = new Point(265, 61);
                tbNom.Location = new Point(265, 85);
                lblEmail.Location = new Point(265, 129);
                tbLogin.Location = new Point(265, 153);
                lblLienPrototype.Location = new Point(265, 199);
                tbLienPrototype.Location = new Point(265, 221);

            }
            else // cas etat update
            {
                label1.Text = "Modification d'une Equipe";
                BtnAction.Text = "MODIFIER";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                lblMembre.Visible = true;
                dgvMembres.Visible = true;
                RemplirListeEquipes();
                premier = false;
                
            }
        }

        private void Annuler()
        {
            tbNom.Clear();
            tbLienPrototype.Clear();
            tbLogin.Clear();
            tbNom.Focus();
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            string nomequipe, lienprototype, login;

            if (tbNom.Text == "" || tbLienPrototype.Text == "" || tbLogin.Text == "")
            {
                MessageBox.Show("Ajout impossible : il faut compléter tous les champs !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                nomequipe = tbNom.Text;
                lienprototype = tbLienPrototype.Text;
                login = tbLogin.Text;

                if (etat == EtatGestion.Create) // cas de l'ajout
                {
                    if (ModeleEquipe.AjoutEquipe(nomequipe, lienprototype, login))
                    {
                        MessageBox.Show("Equipe ajouté " + ModeleEquipe.RetourneDerniereEquipeSaisi());
                        Annuler();
                    }
                    else
                    {
                        MessageBox.Show("Erreur, l'équipe n'a pas été ajouté !");
                    }
                }
                if (etat == EtatGestion.Update) // cas de la mise à jour
                {
                    Equipe E = (Equipe)BSListeE.Current;
                    int idE = Convert.ToInt32(lblIdE.Text);
                    if (ModeleEquipe.ModificationEquipe(idE, nomequipe, lienprototype, login))
                    {
                        MessageBox.Show("Equipe modifié");
                        gbInfo.Visible = false;
                        cbListe.SelectedIndex = -1;
                        // Annuler();
                    }
                    else
                    {
                        MessageBox.Show("Erreur, l'équipe n'a pas été modifié !");
                    }
                }

            }
        }

        private void BSListeE_CurrentChanged(object sender, EventArgs e)
        {
            if (premier == true) { cbListe.SelectedIndex = -1; }
            // si une équipe est sélectionnée dans la liste des équipes
            if (cbListe.SelectedIndex != -1)
            {
                // récupération de l'équipe sélectionnée
                Equipe E = (Equipe)BSListeE.Current;

                // mise à jour des champs de l'équipe sélectionnée
                lblIdE.Text = E.Idequipe.ToString();
                tbNom.Text = E.Nomequipe;
                tbLienPrototype.Text = E.Lienprototype;
                tbLogin.Text = E.Login;


                gbInfo.Visible = true;
                dgvMembres.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        private void CbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            BSListeE_CurrentChanged(sender, e);
        }

        private void AjouterMembreDansEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idE = Convert.ToInt32(lblIdE.Text);
            System.Type type = BSListeM.Current.GetType();
            int idM = (int)type.GetProperty("Idmembre").GetValue(BSListeM.Current, null);

            Membre M = ModeleMembre.RecupererMembre(idM);
            if (ModeleMembre.ModificationEquipeDuMembre(idM, idE))
            {
                MessageBox.Show("Membre ajouté à l'équipe");
                //gbInfo.Visible = false;
                //cbListe.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Erreur, le membre n'a pas été ajouté à l'équipe !");
            }
        }
    }
}
