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
        public static List<Inscrire> listeInscription()
        {
            return Modele.MonModel.Inscrires.Include(a => a.IdequipeNavigation).Include(a => a.IdhackathonNavigation).ToList();
        }

    }
}
