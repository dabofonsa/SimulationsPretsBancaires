using SimulationsPretsBancaires.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationsPretsBancaires.Services
{
    internal static class CalculateurPret
    {
        // Calcul de la mensualité M = P * (i / (1 - (1 + i)^-n)) avec i = tauxAnnuel/12
        public static double CalculerMensualite(double montant, double tauxAnnuel, int dureeMois)
        {
            if (dureeMois <= 0) return 0;
            if (tauxAnnuel <= 0) return Math.Round(montant / dureeMois, 2);

            double i = (tauxAnnuel / 100.0) / 12.0;
            double mensualite = montant * (i / (1 - Math.Pow(1 + i, - dureeMois)));
            return Math.Round(mensualite, 2);
        }
    }
}
