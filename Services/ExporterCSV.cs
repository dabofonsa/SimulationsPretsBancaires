using SimulationsPretsBancaires.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimulationsPretsBancaires.Services
{
    // Service d'export de données au format CSV et Gère l'encodage UTF-8 
    internal static class ExporterFichierCSV
    {

        // Exporte l'échéancier d'un prêt vers un fichier CSV
        // Format : colonnes séparées par point-virgule, décimales avec 2 chiffres
        // Encodage : UTF-8 avec BOM pour une ouverture correcte dans Excel
        // echeancier = Liste des échéances à exporter
        // chemin = Chemin complet du fichier de destination
        public static void ExporterEcheancier(List<Echeance> echeancier, string chemin)
        {
            // Création du fichier avec encodage UTF-8
            using var writer = new StreamWriter(chemin, false, new UTF8Encoding(true));

            // Écriture de l'en-tête avec séparateur point-virgule
            writer.WriteLine("Numero;Date;Interets;Principal;ResteDu");

            // Écriit chaque échéance ligne par ligne
            foreach (var e in echeancier)
            {
                // Format : nombre entier, date ISO, montants avec 2 décimales
                writer.WriteLine(
                    $"{e.NumeroEcheance};" +
                    $"{e.DateEcheance:yyyy-MM-dd};" +
                    $"{e.Interets:F2};" +
                    $"{e.MontantPrincipal:F2};" +
                    $"{e.ResteDu:F2}"
                );
            }
            // Le fichier est automatiquement fermé par le using
        }
    }
}