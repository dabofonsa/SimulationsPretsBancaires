using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationsPretsBancaires.Models
{
    //internal class Echeance
    public class Echeance
    {
    
        public int NumeroEcheance { get; set; }                       // numéro de la mensualité
        public DateTime DateEcheance { get; set; }                    // date de la mensualité
        public double Interets { get; set; }                  // part des intérêts payés
        public double MontantPrincipal { get; set; }          // part du capital remboursée
        public double ResteDu { get; set; }                   // capital restant dû après paiement
    }
}
