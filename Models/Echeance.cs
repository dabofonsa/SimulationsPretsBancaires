using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationsPretsBancaires.Models
{
    internal class Echeance
    {
        public int Id { get; set; }                           // identifiant de l'échéance
        public int PretId { get; set; }                       // identifiant du prêt associé
        public int Numero { get; set; }                       // numéro de la mensualité
        public DateTime Date { get; set; }                    // date de la mensualité
        public double Interets { get; set; }                  // part des intérêts payés
        public double MontantPrincipal { get; set; }          // part du capital remboursée
        public double ResteDu { get; set; }                   // capital restant dû après paiement
    }
}
