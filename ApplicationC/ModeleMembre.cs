using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC
{
    public static class ModeleMembre
    {
        public static List<Membre> listeMembres()
        {
            return Modele.MonModel.Membres.Include(a => a.IdequipeNavigation).ToList();
        }

        public static List<Membre> listeMembresParEquipe(int idE)
        {
            return Modele.MonModel.Membres.Include(a => a.IdequipeNavigation).Where(a => a.Idequipe == idE).ToList();
        }

        public static Membre RecupererMembre(int idM)
        {
            Membre unMembre = new Membre();
            try
            {
                unMembre = Modele.MonModel.Membres.First(x => x.Idmembre == idM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unMembre;
        }

        public static int RetourneDernierMembreSaisi()
        {
            return Modele.MonModel.Membres.Max(x => x.Idmembre);
        }

        public static bool AjoutMembre(string nom, string prenom, string email, string telephone, string lienportfolio, DateOnly datenaissance, int idEquipe)
        {
            Membre unMembre;
            bool vretour = true;
            try
            {
                unMembre = new Membre();
                unMembre.Nom = nom;
                unMembre.Prenom = prenom;
                unMembre.Email = email;
                unMembre.Telephone = telephone;
                unMembre.Datenaissance = datenaissance;
                unMembre.Lienportfolio = lienportfolio;
                if (idEquipe > 0) { unMembre.Idequipe = idEquipe; }

                Modele.MonModel.Membres.Add(unMembre);
                Modele.MonModel.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ModificationMembre(int idM, string nom, string prenom, string email, string telephone, string lienportfolio, DateOnly datenaissance, int idEquipe)
        {
            Membre unMembre;
            bool vretour = true;
            try
            {
                // récupération du membre à modifier
                unMembre = RecupererMembre(idM);

                // mise à jour du membre
                unMembre.Nom = nom;
                unMembre.Prenom = prenom;
                unMembre.Email = email;
                unMembre.Telephone = telephone;
                unMembre.Datenaissance = datenaissance;
                unMembre.Lienportfolio = lienportfolio;
                if (idEquipe > 0) { unMembre.Idequipe = idEquipe; }

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ModificationEquipeDuMembre(int idM, int idEquipe)
        {
            Membre unMembre;
            bool vretour = true;
            try
            {
                // récupération du membre à modifier
                unMembre = RecupererMembre(idM);

                // mise à jour des champs du membre
                unMembre.Idequipe = idEquipe;

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool SupprimerMembre(int idM)
        {
            Membre unMembre;
            bool vretour = true;
            try
            {
                // récupération du membre à modifier
                unMembre = RecupererMembre(idM);

                // suppression du membre
                Modele.MonModel.Membres.Remove(unMembre);

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        
    }
}