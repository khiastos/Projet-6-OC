using NexaWorks.Models.Entities;

namespace NexaWorks.Data
{
    public class TicketDataSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            var productVersionMap = context.ProductVersions
                .ToDictionary(version => (version.ProductId, version.VersionNumber), version => version);

            var operatingSystemMap = context.ProductOperatingSystems
                .ToDictionary(os => os.Name, os => os);

            if (!context.Tickets.Any())
            {
                context.Tickets.AddRange(
                    new Ticket
                    {
                        CreationDate = DateOnly.Parse("2025-01-14"),
                        ResolutionDate = DateOnly.Parse("2025-01-20"),
                        IsResolved = true,
                        IssueDescription = "Lors de l’ouverture de l'application, celle-ci se ferme immédiatement sans afficher de message d'erreur.",
                        ResolutionDescription = "Identification d’un conflit avec la dernière mise à jour Android. Correction du bug par une mise à jour corrective (v1.3.1) de l’application.",
                        OperatingSystemName = operatingSystemMap["Android"].Name,
                        VersionNumber = productVersionMap[(1, 1.3f)].VersionNumber.ToString()
                    }

                );
            }
            context.SaveChanges();
        }
    }
}
