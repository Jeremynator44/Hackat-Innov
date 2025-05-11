using ApplicationC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Net;

namespace ApplicationC
{
    public static class Email
    {
        /// <summary>
        /// Envoie une notification par email via MailHog ou tout autre serveur SMTP.
        /// </summary>
        /// <param name="destinataire">L'email du destinataire</param>
        /// <param name="sujet">Le sujet de l'email</param>
        /// <param name="corps">Le contenu de l'email en HTML</param>
        public static void EnvoyerEmailNotification(string destinataire, string sujet, string corps)
        {
            // Informations du serveur SMTP (MailHog ou autre)
            string smtpServer = "mail.dombtsig.local";  // L'URL de votre serveur SMTP
            int smtpPort = 1025;  // Port SMTP par défaut de MailHog
            string fromEmail = "hello@hackatinnov.com";  // Adresse d'expédition

            try
            {
                // Créer un message email
                MailMessage mail = new MailMessage(fromEmail, destinataire, sujet, corps)
                {
                    IsBodyHtml = true,  // Configurer l'email pour utiliser du contenu HTML
                    BodyEncoding = Encoding.UTF8 // Encodage en UTF-8
                };

                // Ajouter l'en-tête "Content-Transfer-Encoding" pour l'encodage quoted-printable
                mail.Headers.Add("Content-Transfer-Encoding", "quoted-printable");

                // Créer un client SMTP
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
                {
                    DeliveryMethod = SmtpDeliveryMethod.Network, // Méthode de livraison du réseau
                    UseDefaultCredentials = false, // Désactiver les identifiants par défaut
                    Credentials = new NetworkCredential(fromEmail, "votreMotDePasseSiNécessaire") // Authentification si nécessaire
                };

                // Envoyer l'email
                smtpClient.Send(mail);

                Console.WriteLine($"Email envoyé à : {destinataire}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'envoi de l'email : " + ex.Message);
            }
        }
    }

    




}
