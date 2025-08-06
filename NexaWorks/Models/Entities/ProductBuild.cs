namespace NexaWorks.Models.Entities
{
    public class ProductBuild
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int ProductVersionId { get; set; }
        public ProductVersion? VersionNumber { get; set; }

        public int OperatingSystemId { get; set; }
        public ProductOperatingSystem? OperatingSystem { get; set; }
    }
}
