using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationC
{
    public static class Modele
    {
        private static Ap3BjcodeContext monModel;

        public static Ap3BjcodeContext MonModel { get => monModel; set => monModel = value; }

        public static void init()
        {
            monModel = new Ap3BjcodeContext();
        }

    }
    
}
