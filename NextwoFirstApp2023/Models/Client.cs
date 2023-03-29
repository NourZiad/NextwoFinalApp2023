namespace NextwoFirstApp2023.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public string? ClientName { get; set; }

        public string? ClientImg { get; set; }

        public string? ClientPosition { get; set; }

        public DateTime CreateDateTime { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

        public int UserId { get; set; }
    }
}
