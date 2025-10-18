using SimulationsPretsBancaires.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimulationsPretsBancaires.Models
{
    internal class Prets
    {
        public int Id { get; set; }
        public string Emprunteur { get; set; }
        public double Capital { get; set; }           // montant du prêt
        public double TauxAnnuel { get; set; }       // en pourcentage, ex: 4.5
        public int DureeMois { get; set; }           // durée en mois
        public DateTime DateDebut { get; set; } 
        
    }
}
