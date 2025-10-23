using SimulationsPretsBancaires.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationsPretsBancaires.Services
{
    internal static class ExporterFichierCSV
    {
        // Exporte l'échéancier en CSV (UTF-8) ; séparateur ';'
        public static void ExporterEcheancier(List<Echeance> echeancier, string chemin)
        {
            using var writer = new StreamWriter(chemin, false, new UTF8Encoding(true));
            writer.WriteLine("Numero;Date;Interets;Principal;ResteDu");

            foreach (var e in echeancier)
            {
                writer.WriteLine($"{e.NumeroEcheance};{e.DateEcheance:yyyy-MM-dd};{e.Interets:F2};{e.MontantPrincipal:F2};{e.ResteDu:F2}");
            }
        }
    }
}
