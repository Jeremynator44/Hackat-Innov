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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApplicationC
{
    public partial class FormGestionMembres : Form
    {
        private EtatGestion etat;
        public FormGestionMembres(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RemplirListeMembres()
        {
            cbListe.ValueMember = "idmembre";//permet de stocker l'identifiant
            cbListe.DisplayMember = "nom";
            BSListeM.DataSource = ModeleMembre.listeMembres();
            cbListe.DataSource = BSListeM;
            cbListe.SelectedIndex = -1;
        }
        public void RemplirListeEquipes()
        {
            cbEquipe.ValueMember = "idequipe";//permet de stocker l'identifiant
            cbEquipe.DisplayMember = "nomequipe";
            BSListeE.DataSource = ModeleEquipe.listeEquipesInscrites();
            cbEquipe.DataSource = BSListeE;
            cbEquipe.SelectedIndex = -1;
        }

        private void FormGestionMembres_Load(object sender, EventArgs e)
        {
            RemplirListeEquipes();
            if (etat == EtatGestion.Create) // cas etat create
            {
                label1.Text = "Ajout d'un Membre";
                BtnAction.Text = "AJOUTER";
                gbInfo.Visible = true;
                cbListe.Visible = false;

            }
            else // cas etat update
            {
                label1.Text = "Modification d'un Membre";
                BtnAction.Text = "MODIFIER";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                RemplirListeMembres();
            }
        }

        private void Annuler()
        {
            tbNom.Clear();
            tbPrénom.Clear();
            tbEmail.Clear();
            tbPortfolio.Clear();
            tbTéléphone.Clear();
            dtDateNaissance.Value = DateTime.Today;
            cbEquipe.SelectedIndex = -1;
            tbNom.Focus();
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            int idEquipe = -1;
            string nom, prenom, email, telephone, lienportfolio;
            DateOnly datenaissanceDtonly;
            DateTime datenaissance;

            if (tbNom.Text == "" || tbPrénom.Text == "" || tbEmail.Text == "" || tbTéléphone.Text == "" || tbPortfolio.Text == "")
            {
                MessageBox.Show("Ajout impossible : il faut compléter tous les champs !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                // Calcul de l'âge
                int age = DateTime.Today.Year - dtDateNaissance.Value.Year;
                // Vérifier si l'âge est inférieur à 15 ans
                if (age < 15)
                {
                    MessageBox.Show("Ajout impossible : problème sur la date de naissance ! La personne doit avoir au moins 15 ans !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbTéléphone.Text.Length < 10)
                {
                    MessageBox.Show("Ajout impossible : problème sur le nombre de chiffre du numéro de téléphone !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nom = tbNom.Text;
                    prenom = tbPrénom.Text;
                    email = tbEmail.Text;
                    lienportfolio = tbPortfolio.Text;
                    telephone = tbTéléphone.Text;
                    datenaissance = dtDateNaissance.Value;
                    datenaissanceDtonly = DateOnly.FromDateTime(datenaissance);

                    if (cbEquipe.SelectedIndex != -1)
                    {
                        idEquipe = Convert.ToInt32(cbEquipe.SelectedValue.ToString());
                    }

                    if (etat == EtatGestion.Create) // cas de l'ajout
                    {
                        if (ModeleMembre.AjoutMembre(nom, prenom, email, telephone, lienportfolio, datenaissanceDtonly, idEquipe))
                        {
                            MessageBox.Show("Membre ajouté " + ModeleMembre.RetourneDernierMembreSaisi());
                            Annuler();
                        }
                    }
                    if (etat == EtatGestion.Update) // cas de la mise à jour
                    {
                        Membre M = (Membre)BSListeM.Current;
                        if (ModeleMembre.ModificationMembre(M.Idmembre, nom, prenom, email, telephone, lienportfolio, datenaissanceDtonly, idEquipe))
                        {
                            MessageBox.Show("Membre modifié");
                            gbInfo.Visible = false;
                            cbListe.SelectedIndex = -1;
                            // Annuler();
                        }
                    }
                }
            }
        }

        private void BSListeM_CurrentChanged(object sender, EventArgs e)
        {

            // si un membre est sélectionné dans la liste des membres
            if (cbListe.SelectedIndex != -1)
            {
                // récupération du membre sélectionné
                Membre M = (Membre)BSListeM.Current;

                // mise à jour des champs de l'hackathon sélectionné
                tbNom.Text = M.Nom;
                tbPrénom.Text = M.Prenom;
                tbEmail.Text = M.Email;
                tbTéléphone.Text = M.Telephone;
                tbPortfolio.Text = M.Lienportfolio;

                // Convertir DateOnly en chaîne
                string dateOnlyString = M.Datenaissance.ToString(); // Par exemple : "2024-11-20"

                // Convertir la chaîne en DateTime
                if (DateTime.TryParse(dateOnlyString, out DateTime dateTime))
                {
                    dtDateNaissance.Value = dateTime;
                }
                else
                {
                    MessageBox.Show("Impossible de convertir la date de naissance.");
                }


                if (M.Idequipe != null)
                {
                    cbEquipe.Text = M.IdequipeNavigation.Nomequipe;
                }
                gbInfo.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        private void CbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            BSListeM_CurrentChanged(sender, e);
        }
    }
}
