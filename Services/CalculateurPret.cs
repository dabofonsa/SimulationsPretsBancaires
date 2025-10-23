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


        // Génère l'échéancier détaillé
        public static List<Echeance> GenererEcheancier(Prets pret)
        {
            var echeancier = new List<Echeance>();
            double solde = pret.Montant;
            double monthlyRate = (pret.TauxAnnuel / 100.0) / 12.0;
            double mensualite = CalculerMensualite(pret.Montant, pret.TauxAnnuel, pret.DureeMois);

            for (int n = 1; n <= pret.DureeMois; n++)
            {
                double interet = Math.Round(solde * monthlyRate, 2);
                double principalPart = Math.Round(mensualite - interet, 2);

                // Ajustement à la dernière échéance pour éviter centimes négatifs
                if (n == pret.DureeMois)
                {
                    principalPart = Math.Round(solde, 2);
                    mensualite = Math.Round(interet + principalPart, 2);
                }

                solde = Math.Round(solde - principalPart, 2);
                if (solde < 0) solde = 0;

                echeancier.Add(new Echeance
                {
                    NumeroEcheance = n,
                    DateEcheance = pret.DateDebut.AddMonths(n),
                    Interets = interet,
                    MontantPrincipal = principalPart,
                    ResteDu = solde
                });
            }

            return echeancier;
        }
    }
}
