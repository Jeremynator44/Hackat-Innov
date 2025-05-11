using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
                MessageBox.Show(ex.Message);
            }
            return admin;
        }
        public static bool DoubleAuth(string email, string etat)
        {
            Administrateur admin = new Administrateur();
            bool vretour = true;
            try
            {
                admin = RecupererAdmin(email);
                if (etat == "vérifier")
                {
                    if (!admin.Enable2fa)
                    {
                        vretour = false;
                    }
                }
                else if (etat == "désactiver")
                {
                    admin.Enable2fa = false;
                }

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                vretour = false;
            }
            return vretour;
        }

        public static string RecupererCodeSecret(string email)
        {
            Administrateur admin = new Administrateur();
            string secretKey = "";
            try
            {
                admin = RecupererAdmin(email);
                secretKey = admin.Google2faSecret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return secretKey;
        }

        public static string RecupererCodeRecup(string email)
        {
            Administrateur admin = new Administrateur();
            string code = "";
            try
            {
                admin = RecupererAdmin(email);
                code = admin.Recuperation2fa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return code;
        }

        public static bool AjoutCodeSecretEtRecup(string secretKey, string code, string email)
        {
            Administrateur unadministrateur;
            bool vretour = true;
            try
            {
                // récupération 
                unadministrateur = RecupererAdmin(email);

                // mise à jour des champs
                unadministrateur.Recuperation2fa = code;
                unadministrateur.Codedesactivation2fa = code;
                unadministrateur.Google2faSecret = secretKey;
                unadministrateur.Enable2fa = true;

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
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
