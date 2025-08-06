using NexaWorks.Models.Entities;

namespace NexaWorks.Data
{
    public class ProductInfosDataSeed
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
                context.SaveChanges();
            }

            if (!context.ProductVersions.Any())
            {
                context.ProductVersions.AddRange(
                    new ProductVersion { VersionNumber = "1.0" },
                    new ProductVersion { VersionNumber = "1.1" },
                    new ProductVersion { VersionNumber = "1.2" },
                    new ProductVersion { VersionNumber = "1.3" },
                    new ProductVersion { VersionNumber = "2.0" },
                    new ProductVersion { VersionNumber = "2.1" }
                );
                context.SaveChanges();
            }

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
                context.SaveChanges();
            }

            if (!context.ProductBuilds.Any())
            {
                context.ProductBuilds.AddRange(
                    // Trader en Herbe
                    new ProductBuild { ProductId = 1, ProductVersionId = 1, OperatingSystemId = 1 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 1, OperatingSystemId = 3 },

                    new ProductBuild { ProductId = 1, ProductVersionId = 2, OperatingSystemId = 1 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 2, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 2, OperatingSystemId = 3 },

                    new ProductBuild { ProductId = 1, ProductVersionId = 3, OperatingSystemId = 1 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 3, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 3, OperatingSystemId = 3 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 3, OperatingSystemId = 4 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 3, OperatingSystemId = 5 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 3, OperatingSystemId = 6 },

                    new ProductBuild { ProductId = 1, ProductVersionId = 4, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 4, OperatingSystemId = 3 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 4, OperatingSystemId = 4 },
                    new ProductBuild { ProductId = 1, ProductVersionId = 4, OperatingSystemId = 5 },

                    // Maître des Investissements
                    new ProductBuild { ProductId = 2, ProductVersionId = 1, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 2, ProductVersionId = 1, OperatingSystemId = 5 },

                    new ProductBuild { ProductId = 2, ProductVersionId = 5, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 2, ProductVersionId = 5, OperatingSystemId = 4 },
                    new ProductBuild { ProductId = 2, ProductVersionId = 5, OperatingSystemId = 5 },

                    new ProductBuild { ProductId = 2, ProductVersionId = 6, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 2, ProductVersionId = 6, OperatingSystemId = 3 },
                    new ProductBuild { ProductId = 2, ProductVersionId = 6, OperatingSystemId = 4 },
                    new ProductBuild { ProductId = 2, ProductVersionId = 6, OperatingSystemId = 5 },

                    // Planificateur d’Entraînement
                    new ProductBuild { ProductId = 3, ProductVersionId = 1, OperatingSystemId = 1 },
                    new ProductBuild { ProductId = 3, ProductVersionId = 1, OperatingSystemId = 2 },

                    new ProductBuild { ProductId = 3, ProductVersionId = 2, OperatingSystemId = 1 },
                    new ProductBuild { ProductId = 3, ProductVersionId = 2, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 3, ProductVersionId = 2, OperatingSystemId = 3 },
                    new ProductBuild { ProductId = 3, ProductVersionId = 2, OperatingSystemId = 4 },
                    new ProductBuild { ProductId = 3, ProductVersionId = 2, OperatingSystemId = 5 },
                    new ProductBuild { ProductId = 3, ProductVersionId = 2, OperatingSystemId = 6 },

                    new ProductBuild { ProductId = 3, ProductVersionId = 5, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 3, ProductVersionId = 5, OperatingSystemId = 3 },
                    new ProductBuild { ProductId = 3, ProductVersionId = 5, OperatingSystemId = 4 },
                    new ProductBuild { ProductId = 3, ProductVersionId = 5, OperatingSystemId = 5 },

                    // Planificateur d'Anxiété Sociale
                    new ProductBuild { ProductId = 4, ProductVersionId = 1, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 4, ProductVersionId = 1, OperatingSystemId = 3 },
                    new ProductBuild { ProductId = 4, ProductVersionId = 1, OperatingSystemId = 4 },
                    new ProductBuild { ProductId = 4, ProductVersionId = 1, OperatingSystemId = 5 },

                    new ProductBuild { ProductId = 4, ProductVersionId = 2, OperatingSystemId = 2 },
                    new ProductBuild { ProductId = 4, ProductVersionId = 2, OperatingSystemId = 3 },
                    new ProductBuild { ProductId = 4, ProductVersionId = 2, OperatingSystemId = 4 },
                    new ProductBuild { ProductId = 4, ProductVersionId = 2, OperatingSystemId = 5 }
                );

                context.SaveChanges();
            }
        }
    }
}
