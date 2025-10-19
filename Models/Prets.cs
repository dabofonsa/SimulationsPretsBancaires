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
        public string NomEmprunteur { get; set; }     // nom de l'emprunteur
        public double Montant { get; set; }          // montant du prêt en euros
        public double TauxAnnuel { get; set; }       // en pourcentage, ex: 7.5 pour 7,5%
        public int DureeMois { get; set; }           // durée en mois
        public DateTime DateDebut { get; set; }      // date de début du prêt
        public double Mensualite { get; set; }       // mensualité à payer

    }
}
