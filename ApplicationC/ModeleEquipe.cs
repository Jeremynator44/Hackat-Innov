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
        public static List<Equipe> listeEquipes()
        {
            return Modele.MonModel.Equipes.ToList();
        }

        public static bool EquipeInscrite()
        {
            return true;
        }
    }
}
