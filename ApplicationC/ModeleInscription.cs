using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC
{
    public static class ModeleInscription
    {
        /// <summary>
        /// Retourne la liste des inscriptions en incluant les hackathons et les équipes
        /// </summary>
        /// <returns></returns>
        public static List<Inscrire> listeInscription(int idH)
        {
            return Modele.MonModel.Inscrires.Include(a => a.IdequipeNavigation).Where(a => a.Idhackathon == idH && a.Datedesinscription == null).ToList();
        }

        public static Inscrire RecupererInscription(int idE, int idH)
        {
            return Modele.MonModel.Inscrires.First(x => x.IdhackathonNavigation.Idhackathon == idH && x.IdequipeNavigation.Idequipe == idE);
        }
    }
}
