namespace NexaWorks.Models.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public int ProductBuildId { get; set; }
        public ProductBuild? ProductBuild { get; set; }

        public DateOnly CreationDate { get; set; }
        public DateOnly ResolutionDate { get; set; }
        public bool IsResolved { get; set; }
        public required string IssueDescription { get; set; }
        public string? ResolutionDescription { get; set; }
    }
}
