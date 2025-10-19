using SimulationsPretsBancaires.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SimulationsPretsBancaires.Services
{
    internal class PersistancePretsJson
    {
        private readonly string filePath;
        private List<Prets> cache;

        public PersistancePretsJson(string cheminFichier = "prets.json")
        {
            filePath = cheminFichier;
            Charger();
        }

        private void Charger()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    var texte = File.ReadAllText(filePath);
                    cache = JsonSerializer.Deserialize<List<Prets>>(texte) ?? new List<Prets>();
                }
                catch
                {
                    cache = new List<Prets>();
                }
            }
            else
            {
                cache = new List<Prets>();
            }
        }

        private void Sauvegarder()
        {
            var json = JsonSerializer.Serialize(cache, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public List<Prets> RecupererTous() => cache.Select(c => CopierPret(c)).ToList();

        public Prets RecupererParId(int id) => CopierPret(cache.FirstOrDefault(p => p.Id == id));

        public void Ajouter(Prets pret)
        {
            int prochainId = cache.Any() ? cache.Max(p => p.Id) + 1 : 1;
            pret.Id = prochainId;
            cache.Add(pret);
            Sauvegarder();
        }

        public void Modifier(Prets pret)
        {
            var idx = cache.FindIndex(p => p.Id == pret.Id);
            if (idx >= 0)
            {
                cache[idx] = pret;
                Sauvegarder();
            }
            else throw new Exception("Prêt introuvable.");
        }

        public void Supprimer(int id)
        {
            cache.RemoveAll(p => p.Id == id);
            Sauvegarder();
        }

        private Prets CopierPret(Prets p) =>
            p == null ? null : new Prets
            {
                Id = p.Id,
                NomEmprunteur = p.NomEmprunteur,
                Montant = p.Montant,
                TauxAnnuel = p.TauxAnnuel,
                DureeMois = p.DureeMois,
                DateDebut = p.DateDebut
            };
    }
}
