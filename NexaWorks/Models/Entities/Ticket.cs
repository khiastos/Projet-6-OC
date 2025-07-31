namespace NexaWorks.Models.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public DateOnly CreationDate { get; set; }

        public DateOnly ResolutionDate { get; set; }

        public bool IsResolved { get; set; }
        public required string IssueDescription { get; set; }

        public string? ResolutionDescription { get; set; }
        public int ProductVersionId { get; set; }
        public required ProductVersion ProductVersion { get; set; }
        public int ProductOperatingSystemId { get; set; }
        public required ProductOperatingSystem ProductOperatingSystem { get; set; }
    }
}
