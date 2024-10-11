using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC
{
    public static class ModeleMembre
    {
        /// <summary>
        /// Retourne la liste des hackathons en incluant l'organisateur
        /// </summary>
        /// <returns></returns>
        public static List<Membre> listeMembres()
        {
            return Modele.MonModel.Membres.Include(a => a.IdequipeNavigation).ToList();
        }
    }
}