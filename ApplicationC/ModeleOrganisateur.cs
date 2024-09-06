using ApplicationC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC
{
    public static class ModeleOrganisateur
    {

        /// <summary>
        /// Retourne toute la liste des organisateurs
        /// </summary>
        /// <returns></returns>
        public static List<Organisateur> listeOrganisateurs()
        {
            return Modele.MonModel.Organisateurs.ToList();
        }

        /// <summary>
        /// Retourne vrai si l'ajout d'un organisateur a pu avoir lieu
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool AjoutOrganisateur(string nom, string prenom, string email)
        {
            Organisateur unOrga;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unOrga = new Organisateur();
                unOrga.Nom = nom;
                unOrga.Prenom = prenom;
                unOrga.Email = email;

                Modele.MonModel.Organisateurs.Add(unOrga);
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
