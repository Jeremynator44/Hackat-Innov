using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace ApplicationC
{
    public static class ModeleAdministrateur
    {

        /// <summary>
        /// Retourne toute la liste des organisateurs
        /// </summary>
        /// <returns></returns>
        public static List<Administrateur> listeAdministrateurs()
        {
            return Modele.MonModel.Administrateurs.ToList();
        }

        public static Administrateur RecupererAdmin (string email)
        {
            Administrateur admin = new Administrateur();
            try
            {
                admin = Modele.MonModel.Administrateurs.First(s => s.Email == email);
            }
            catch (Exception ex)
            {

            }
            return admin;
        }

        public static bool VerifAdministrateur(string password, string email)
        {
            bool verif = false;

            Administrateur admin = new Administrateur();
            admin = RecupererAdmin(email);

            try
            {
                if (admin.Idadministrateur != 0)
                {
                    if (BC.Verify(password, admin.Motpasse)) 
                    { 
                        verif = true;
                    }
                    else
                    {
                        MessageBox.Show("L'email ou le mot de passe est incorrect ! ");
                    }
                }
                else
                {
                    MessageBox.Show("L'email ou le mot de passe est incorrect ! ");
                }
            }
            catch (Exception ex)
            {
                verif = false;
            }

            return verif;
        }
    }
}
