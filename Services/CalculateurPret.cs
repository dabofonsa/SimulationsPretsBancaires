using SimulationsPretsBancaires.Models;
using System;
using System.Collections.Generic;

namespace SimulationsPretsBancaires.Services
{
    
    // Service de calcul pour les prêts bancaires
    // Implémente les formules financières standards d'amortissement
    internal static class CalculateurPret
    {
        
        // Calcule la mensualité d'un prêt selon la formule d'amortissement constant
        // Formule : M = P × (i / (1 - (1 + i)^(-n)))
        // montant = Capital emprunté en euros
        // tauxAnnuel = Taux d'intérêt annuel en pourcentage
        // dureeMois = Durée du prêt en mois
        // Mensualité arrondie à 2 décimales
        public static double CalculerMensualite(double montant, double tauxAnnuel, int dureeMois)
        {
            // Cas limite : durée nulle
            if (dureeMois <= 0) return 0;

            // Cas spécial : taux zéro (division simple du capital)
            if (tauxAnnuel <= 0) return Math.Round(montant / dureeMois, 2);

            // Conversion du taux annuel en taux mensuel
            double tauxMensuel = (tauxAnnuel / 100.0) / 12.0;

            // Application de la formule standard d'amortissement
            double mensualite = montant * (tauxMensuel / (1 - Math.Pow(1 + tauxMensuel, -dureeMois)));

            return Math.Round(mensualite, 2);
        }

       
        // Génère l'échéancier complet d'un prêt avec détail mensuel
        // Chaque échéance contient : numéro, date, intérêts, principal, solde restant
        public static List<Echeance> GenererEcheancier(Prets pret)
        {
            var echeancier = new List<Echeance>();
            double soldeRestant = pret.Montant;

            // Calcul du taux mensuel à partir du taux annuel
            double tauxMensuel = (pret.TauxAnnuel / 100.0) / 12.0;
            double mensualite = CalculerMensualite(pret.Montant, pret.TauxAnnuel, pret.DureeMois);

            // Génération de chaque échéance mensuelle
            for (int numeroMois = 1; numeroMois <= pret.DureeMois; numeroMois++)
            {
                // Calcul de la part d'intérêts du mois
                double interetsMois = Math.Round(soldeRestant * tauxMensuel, 2);

                // Calcul de la part de capital remboursé
                double capitalRembourse = Math.Round(mensualite - interetsMois, 2);

                // Ajustement de la dernière échéance pour garantir un solde final à zéro
                if (numeroMois == pret.DureeMois)
                {
                    capitalRembourse = Math.Round(soldeRestant, 2);
                    mensualite = Math.Round(interetsMois + capitalRembourse, 2);
                }

                // Mise à jour du solde restant dû
                soldeRestant = Math.Round(soldeRestant - capitalRembourse, 2);
                if (soldeRestant < 0) 
                    soldeRestant = 0; // pas de solde négatif

                // Création de l'échéance
                echeancier.Add(new Echeance
                {
                    NumeroEcheance = numeroMois,
                    DateEcheance = pret.DateDebut.AddMonths(numeroMois),
                    Interets = interetsMois,
                    MontantPrincipal = capitalRembourse,
                    ResteDu = soldeRestant
                });
            }

            return echeancier;
        }
    }
}