using NexaWorks.Models.Entities;

namespace NexaWorks.Data
{
    public class TicketDataSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            var buildMap = context.ProductBuilds.ToDictionary(
                build => (build.ProductId, build.ProductVersionId, build.OperatingSystemId),
                build => build.Id);

            if (!context.Tickets.Any())
            {
                context.Tickets.AddRange(
                    new Ticket
                    {
                        ProductBuildId = buildMap[(1, 4, 4)],
                        CreationDate = DateOnly.Parse("2025-01-14"),
                        ResolutionDate = DateOnly.Parse("2025-01-20"),
                        IsResolved = true,
                        IssueDescription = "Lors de l’ouverture de l'application, celle-ci se ferme immédiatement sans afficher de message d'erreur.",
                        ResolutionDescription = "Identification d’un conflit avec la dernière mise à jour Android. Correction du bug par une mise à jour corrective (v1.3.1) de l’application."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(2, 5, 2)],
                        CreationDate = DateOnly.Parse("2025-01-28"),
                        IsResolved = false,
                        IssueDescription = "Le logiciel présente des ralentissements importants lors de l'affichage des graphiques financiers avancés."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(3, 2, 5)],
                        CreationDate = DateOnly.Parse("2025-02-05"),
                        ResolutionDate = DateOnly.Parse("2025-02-08"),
                        IsResolved = true,
                        IssueDescription = "L’utilisateur reçoit des notifications d'entraînement en double.",
                        ResolutionDescription = "Correction du gestionnaire de notifications qui lançait deux fois la tâche. Mise à jour déployée via l'App Store."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(4, 2, 2)],
                        CreationDate = DateOnly.Parse("2025-07-15"),
                        IsResolved = false,
                        IssueDescription = "Impossibilité de sauvegarder les sessions enregistrées localement."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(1, 3, 6)],
                        CreationDate = DateOnly.Parse("2025-02-22"),
                        ResolutionDate = DateOnly.Parse("2025-02-28"),
                        IsResolved = true,
                        IssueDescription = "Erreur d'affichage des valeurs boursières après une longue session d’utilisation.",
                        ResolutionDescription = "Correction d'une fuite de mémoire entraînant un dépassement des ressources graphiques disponibles."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(2, 6, 5)],
                        CreationDate = DateOnly.Parse("2025-03-05"),
                        IsResolved = false,
                        IssueDescription = "Impossible de restaurer les achats intégrés après réinstallation de l’application."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(3, 5, 4)],
                        CreationDate = DateOnly.Parse("2025-03-12"),
                        ResolutionDate = DateOnly.Parse("2025-03-17"),
                        IsResolved = true,
                        IssueDescription = "L’application affiche un écran noir lors du passage en mode sombre.",
                        ResolutionDescription = "Correction du thème sombre mal paramétré et mise à jour publiée sur le Play Store."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(1, 2, 1)],
                        CreationDate = DateOnly.Parse("2025-03-25"),
                        IsResolved = false,
                        IssueDescription = "Plantage systématique lors du téléchargement des historiques des transactions."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(4, 1, 3)],
                        CreationDate = DateOnly.Parse("2025-04-10"),
                        ResolutionDate = DateOnly.Parse("2025-04-14"),
                        IsResolved = true,
                        IssueDescription = "L’application perd les paramètres utilisateur après chaque redémarrage.",
                        ResolutionDescription = "Correction du mécanisme de sauvegarde des préférences utilisateur en base locale."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(1, 1, 3)],
                        CreationDate = DateOnly.Parse("2025-04-19"),
                        IsResolved = false,
                        IssueDescription = "Les transactions affichées ne correspondent pas à celles effectuées."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(3, 1, 2)],
                        CreationDate = DateOnly.Parse("2025-04-25"),
                        ResolutionDate = DateOnly.Parse("2025-04-30"),
                        IsResolved = true,
                        IssueDescription = "Le son des rappels d’entraînement ne fonctionne pas.",
                        ResolutionDescription = "Correction du bug lié à la gestion audio spécifique à MacOS."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(2, 1, 2)],
                        CreationDate = DateOnly.Parse("2025-05-03"),
                        IsResolved = false,
                        IssueDescription = "Échec à la connexion au serveur principal sans message clair."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(4, 2, 4)],
                        CreationDate = DateOnly.Parse("2025-05-10"),
                        ResolutionDate = DateOnly.Parse("2025-05-15"),
                        IsResolved = true,
                        IssueDescription = "L’application se fige à l'écran d'accueil après une utilisation prolongée.",
                        ResolutionDescription = "Optimisation du chargement des ressources au démarrage."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(1, 3, 4)],
                        CreationDate = DateOnly.Parse("2025-05-18"),
                        IsResolved = false,
                        IssueDescription = "Affichage incorrect du solde du portefeuille utilisateur après certaines transactions."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(2, 6, 4)],
                        CreationDate = DateOnly.Parse("2025-05-24"),
                        IsResolved = false,
                        IssueDescription = "L'application se ferme inopinément lors de la génération de rapports financiers complexes."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(3, 1, 1)],
                        CreationDate = DateOnly.Parse("2025-06-02"),
                        IsResolved = false,
                        IssueDescription = "Impossible de synchroniser les entraînements avec le cloud depuis la dernière mise à jour."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(4, 1, 2)],
                        CreationDate = DateOnly.Parse("2025-06-12"),
                        ResolutionDate = DateOnly.Parse("2025-06-18"),
                        IsResolved = true,
                        IssueDescription = "Crash de l'application lors de l'utilisation du module de méditation guidée.",
                        ResolutionDescription = "Correction d'un bug lié à la gestion audio."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(2, 5, 4)],
                        CreationDate = DateOnly.Parse("2025-06-20"),
                        ResolutionDate = DateOnly.Parse("2025-06-25"),
                        IsResolved = true,
                        IssueDescription = "Erreur lors de la génération des relevés de portefeuille en format PDF.",
                        ResolutionDescription = "Ajustement du module de génération PDF."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(1, 4, 3)],
                        CreationDate = DateOnly.Parse("2025-06-30"),
                        IsResolved = false,
                        IssueDescription = "Déconnexions fréquentes lors de sessions de trading en direct."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(3, 2, 4)],
                        CreationDate = DateOnly.Parse("2025-07-05"),
                        ResolutionDate = DateOnly.Parse("2025-07-09"),
                        IsResolved = true,
                        IssueDescription = "Le compteur de calories brûlées ne s'affiche pas correctement après une mise à jour du système Android.",
                        ResolutionDescription = "Correction de la compatibilité avec la dernière version Android."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(4, 2, 3)],
                        CreationDate = DateOnly.Parse("2025-07-11"),
                        IsResolved = false,
                        IssueDescription = "Le calendrier intégré n'affiche plus correctement les événements planifiés."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(1, 1, 1)],
                        CreationDate = DateOnly.Parse("2025-07-17"),
                        ResolutionDate = DateOnly.Parse("2025-07-22"),
                        IsResolved = true,
                        IssueDescription = "L’application n’enregistre pas correctement les préférences utilisateur.",
                        ResolutionDescription = "Réécriture du gestionnaire de préférences utilisateur."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(2, 1, 2)],
                        CreationDate = DateOnly.Parse("2025-07-25"),
                        IsResolved = false,
                        IssueDescription = "Difficulté à importer des fichiers Excel dans l'application."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(3, 5, 3)],
                        CreationDate = DateOnly.Parse("2025-07-29"),
                        ResolutionDate = DateOnly.Parse("2025-08-03"),
                        IsResolved = true,
                        IssueDescription = "Bug entraînant une erreur de calcul de distance parcourue.",
                        ResolutionDescription = "Mise à jour du module de calcul des distances."
                    },
                    new Ticket
                    {
                        ProductBuildId = buildMap[(1, 3, 5)],
                        CreationDate = DateOnly.Parse("2025-08-04"),
                        IsResolved = false,
                        IssueDescription = "Problème de lenteur sur iOS après utilisation prolongée."
                    }
                );
            }
            context.SaveChanges();
        }
    }
}
