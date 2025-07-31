//using Microsoft.EntityFrameworkCore;
//using NexaWorks.Models.Entities;

//namespace NexaWorks.Data
//{
//    public class TicketDataSeed
//    {
//        public static void Seed(IServiceProvider services)
//        {
//            using var scope = services.CreateScope();
//            var ctx = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

//            Applique les migrations
//            ctx.Database.Migrate();

//            Si les tickets existent déjà, on sort
//            if (ctx.Tickets.Any()) return;

//            Prépare la liste de tickets
//           var tickets = new List<Ticket>
//           {
//                new Ticket {
//                    ProductVersionId     = 1,
//                    OperatingSystemId    = 2,
//                    CreationDate         = new DateTime(2025,1,14),
//                    ResolutionDate       = new DateTime(2025,1,20),
//                    Status               = "Resolved",
//                    IssueDescription     = "Lors de l’ouverture de l'application, celle-ci se ferme immédiatement sans message.",
//                    ResolutionDetails    = "Conflit détecté avec la dernière version Android ; correctif publié v1.3.1."
//                },
//                 … tes 24 autres tickets …
//            };

//            ctx.Tickets.AddRange(tickets);
//            ctx.SaveChanges();
//        }
//    }
//}
