using Microsoft.EntityFrameworkCore;
using NexaWorks.Models.Entities;

namespace NexaWorks.Data
{
    public static class ProductInfosDataSeed
    {
        public static void Seed(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {
                context.Products.AddRange(new List<Product>
                {
                    new Product { Id = 1, Name = "Trader en Herbe"},
                    new Product { Id = 2, Name = "Maître des Investissements"},
                    new Product { Id = 3, Name = "Plannificateur d'Entraînement"},
                    new Product { Id = 4, Name = "Plannificateur d'Anxiété Sociale"},

                });
                context.SaveChanges();
            }

            if (!context.ProductVersions.Any())
            {
                context.ProductVersions.AddRange(new List<ProductVersion>
                {
                    // Trader en Herbe
                    new ProductVersion { Id = 1, VersionNumber = 1.0f, ProductId = 1},
                    new ProductVersion { Id = 2, VersionNumber = 1.1f, ProductId = 1},
                    new ProductVersion { Id = 3, VersionNumber = 1.2f, ProductId = 1},
                    new ProductVersion { Id = 4, VersionNumber = 1.3f, ProductId = 1},

                    // Maître des Investissements
                    new ProductVersion { Id = 5, VersionNumber = 1.0f, ProductId = 2},
                    new ProductVersion { Id = 6, VersionNumber = 2.0f, ProductId = 2},
                    new ProductVersion { Id = 7, VersionNumber = 2.1f, ProductId = 2},

                    // Plannificateur d'Entraînement
                    new ProductVersion { Id = 8, VersionNumber = 1.0f, ProductId = 3},
                    new ProductVersion { Id = 9, VersionNumber = 1.1f, ProductId = 3},
                    new ProductVersion { Id = 10, VersionNumber = 2.0f, ProductId = 3},

                    // Plannificateur d'Anxiété Sociale
                    new ProductVersion { Id = 11, VersionNumber = 1.0f, ProductId = 4},
                    new ProductVersion { Id = 12, VersionNumber = 1.1f, ProductId = 4},
                });
                context.SaveChanges();
            }

            if (!context.ProductOperatingSystems.Any())
            {
                context.ProductOperatingSystems.AddRange(new List<ProductOperatingSystem>
                {
                    new ProductOperatingSystem { Id = 1, Name = "Linux" },
                    new ProductOperatingSystem { Id = 2, Name = "MacOS" },
                    new ProductOperatingSystem { Id = 3, Name = "Windows" },
                    new ProductOperatingSystem { Id = 4, Name = "Android" },
                    new ProductOperatingSystem { Id = 5, Name = "iOS" },
                    new ProductOperatingSystem { Id = 6, Name = "Windows Mobile" },
                });
                context.SaveChanges();
            }
        }
    }
}
