using NexaWorks.Models.Entities;

namespace NexaWorks.Data
{
    public static class ProductInfosDataSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Trader en Herbe" },
                    new Product { Name = "Maître des Investissements" },
                    new Product { Name = "Planificateur d'Entraînement" },
                    new Product { Name = "Planificateur d'Anxiété Sociale" }
                );
            }
            context.SaveChanges();

            if (!context.ProductVersions.Any())
            {
                context.ProductVersions.AddRange(
                    // Trader en Herbe
                    new ProductVersion { VersionNumber = 1.0f, ProductId = 1 },
                    new ProductVersion { VersionNumber = 1.1f, ProductId = 1 },
                    new ProductVersion { VersionNumber = 1.2f, ProductId = 1 },
                    new ProductVersion { VersionNumber = 1.3f, ProductId = 1 },

                    // Maître des Investissements
                    new ProductVersion { VersionNumber = 1.0f, ProductId = 2 },
                    new ProductVersion { VersionNumber = 2.0f, ProductId = 2 },
                    new ProductVersion { VersionNumber = 2.1f, ProductId = 2 },

                    // Plannificateur d'Entraînement
                    new ProductVersion { VersionNumber = 1.0f, ProductId = 3 },
                    new ProductVersion { VersionNumber = 1.1f, ProductId = 3 },
                    new ProductVersion { VersionNumber = 2.0f, ProductId = 3 },

                    // Plannificateur d'Anxiété Sociale
                    new ProductVersion { VersionNumber = 1.0f, ProductId = 4 },
                    new ProductVersion { VersionNumber = 1.1f, ProductId = 4 }
                );
            }

            context.SaveChanges();

            if (!context.ProductOperatingSystems.Any())
            {
                context.ProductOperatingSystems.AddRange(
                    new ProductOperatingSystem { Name = "Linux" },
                    new ProductOperatingSystem { Name = "MacOS" },
                    new ProductOperatingSystem { Name = "Windows" },
                    new ProductOperatingSystem { Name = "Android" },
                    new ProductOperatingSystem { Name = "iOS" },
                    new ProductOperatingSystem { Name = "Windows Mobile" }
                );
            }

            context.SaveChanges();

        }
    }
}
