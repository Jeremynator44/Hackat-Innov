using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC
{
    public static class ModeleEquipe
    {
        public static List<Inscrire> listeEquipesInscrites()
        {
            return Modele.MonModel.Inscrires.Include(p => p.IdequipeNavigation).Where(p => p.Datedesinscription == null).ToList();
        }

        public static List<Equipe> listeEquipes()
        {
            return Modele.MonModel.Equipes.ToList();
        }

        public static Equipe RecupererEquipe(int idE)
        {
            Equipe uneEquipe = new Equipe();
            try
            {
                uneEquipe = Modele.MonModel.Equipes.First(x => x.Idequipe == idE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneEquipe;
        }

        public static int RetourneDerniereEquipeSaisi()
        {
            return Modele.MonModel.Equipes.Max(x => x.Idequipe);
        }

        public static string RecupererHackathonDeEquipe(int idE, int idH)
        {
            Inscrire uneInscription = new Inscrire();
            string nomhackathon = "";
            try
            {
                uneInscription = ModeleInscription.RecupererInscription(idE, idH);
                nomhackathon = uneInscription.IdhackathonNavigation.Thematique;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return nomhackathon;
        }

        public static bool AjoutEquipe(string nomequipe, string lienprototype, string login)
        {
            Equipe uneEquipe;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                uneEquipe = new Equipe();
                uneEquipe.Nomequipe = nomequipe;
                uneEquipe.Login = login;
                uneEquipe.Lienprototype = lienprototype;

                Modele.MonModel.Equipes.Add(uneEquipe);
                Modele.MonModel.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ModificationEquipe(int idE, string nomequipe, string lienprototype, string login)
        {
            Equipe uneEquipe;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                uneEquipe = RecupererEquipe(idE);

                // mise à jour des champs de l'hackathon
                uneEquipe.Nomequipe = nomequipe;
                uneEquipe.Login = login;
                uneEquipe.Lienprototype = lienprototype;

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool SupprimerEquipe(int idE)
        {
            Equipe uneEquipe;
            bool vretour = true;
            try
            {
                // récupération du membre à modifier
                uneEquipe = RecupererEquipe(idE);

                // suppression du membre
                Modele.MonModel.Equipes.Remove(uneEquipe);

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool DesinscrireEquipe(int idE, int idH)
        {
            Inscrire uneInscription;
            bool vretour = true;
            try
            {
                // récupération de l'équipe
                uneInscription = ModeleInscription.RecupererInscription(idE, idH);

                // update de l'équipe
                uneInscription.Datedesinscription = DateOnly.FromDateTime(DateTime.Today);

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
