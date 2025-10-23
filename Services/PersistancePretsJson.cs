using SimulationsPretsBancaires.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace SimulationsPretsBancaires.Services
{
    // Service de persistance des prêts au format JSON
    // Gère le stockage sur disque avec chargement et sauvegarde automatiques
    // Pattern Repository pour isoler l'accès aux données
    internal class PersistancePretsJson
    {
        private readonly string filePath;
        private List<Prets> cache;

        // Initialise le service de persistance et charge les données existantes
        // cheminFichier = Chemin du fichier JSON (par défaut : prets.json)
        public PersistancePretsJson(string cheminFichier = "prets.json")
        {
            filePath = cheminFichier;
            Charger();
        }

  
        // Charge les prêts depuis le fichier JSON
        // Crée un cache vide si le fichier n'existe pas ou est corrompu
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
                    // En cas d'erreur de lecture, initialiser un cache vide
                    cache = new List<Prets>();
                }
            }
            else
            {
                // Fichier inexistant : initialiser un cache vide
                cache = new List<Prets>();
            }
        }


        // Sauvegarde le cache dans le fichier JSON
        // Format indenté pour faciliter la lecture humaine
        private void Sauvegarder()
        {
            var json = JsonSerializer.Serialize(cache, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }


        // Récupère tous les prêts enregistrés
        // Retourne des copies pour éviter les modifications accidentelles du cache
        // Retourne la Liste de tous les prêts
        public List<Prets> RecupererTous() => cache.Select(c => CopierPret(c)).ToList();


        //Récupère un prêt spécifique par son identifiant "Id" et retourne Prêt trouvé ou null (rien) si inexistant
        public Prets RecupererParId(int id) => CopierPret(cache.FirstOrDefault(p => p.Id == id));

        // Ajoute un nouveau prêt à la base et Génère automatiquement un identifiant unique et incrémental
        //"pret" = Prêt à ajouter (l'Id sera assigné automatiquement)
        public void Ajouter(Prets pret)
        {
            // Génération d'un ID auto-incrémenté
            int prochainId = cache.Any() ? cache.Max(p => p.Id) + 1 : 1;
            pret.Id = prochainId;

            cache.Add(pret);
            Sauvegarder();
        }


        // Modifie un prêt existant dans la base en chargeant d'abord les données sans le formulaire 
        // apres modification il l'enregistre dans la base automatiquement
        public void Modifier(Prets pret)
        {
            // Recherche de l'index du prêt à modifier
            var idx = cache.FindIndex(p => p.Id == pret.Id);

            if (idx >= 0)
            {
                cache[idx] = pret;
                Sauvegarder();
            }
            else
            {
                // Si le prêt n'existe pas, lever une exception
                throw new Exception("Prêt introuvable.");
            }
        }


        // Supprime un prêt de la base
        public void Supprimer(int id)
        {
            cache.RemoveAll(p => p.Id == id);
            Sauvegarder();
        }


        // Crée une copie profonde d'un prêt
        // Évite les modifications accidentelles du cache via les références
        // p = Prêt source à copier
        // retourne une Nouvelle instance avec les mêmes valeurs, ou null si source null
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