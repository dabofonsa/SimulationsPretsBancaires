using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationsPretsBancaires.Models
{
    internal class Echeance
    {
        public int Id { get; set; }
        public int PretId { get; set; }
        public int Numero { get; set; }        // numéro de la mensualité
        public DateTime Date { get; set; }
        public double Interets { get; set; }
        public double MontantPrincipal { get; set; }
        public double ResteDu { get; set; }
    }
}
