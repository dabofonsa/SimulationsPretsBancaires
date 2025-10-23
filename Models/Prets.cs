using SimulationsPretsBancaires.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimulationsPretsBancaires.Models
{
    //internal class Prets
    public class Prets
    {
        public int Id { get; set; }
        public string NomEmprunteur { get; set; }     // nom de l'emprunteur
        public double Montant { get; set; }          // montant du prêt en euros
        public double TauxAnnuel { get; set; }       // en pourcentage, ex: 7.5 pour 7,5%
        public int DureeMois { get; set; }           // durée en mois
        public DateTime DateDebut { get; set; }      // date de début du prêt
        public double Mensualite { get; set; }       // mensualité à payer

        public List<Echeance> GenererEcheancier()
        {
            var liste = new List<Echeance>();
            double capitalRestant = Montant;
            double mensualite = CalculateurPret.CalculerMensualite(Montant, TauxAnnuel, DureeMois);
            double tauxMensuel = TauxAnnuel / 12 / 100;

            for (int i = 1; i <= DureeMois; i++)
            {
                double interets = capitalRestant * tauxMensuel;
                double principal = mensualite - interets;
                capitalRestant -= principal;

                liste.Add(new Echeance
                {
                    NumeroEcheance = i,
                    DateEcheance = DateDebut.AddMonths(i),
                    Interets = Math.Round(interets, 2),
                    MontantPrincipal = Math.Round(principal, 2),
                    ResteDu = Math.Round(Math.Max(capitalRestant, 0), 2)
                });
            }

            return liste;
        }


    }
}
