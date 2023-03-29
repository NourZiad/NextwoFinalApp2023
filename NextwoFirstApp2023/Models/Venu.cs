namespace NextwoFirstApp2023.Models
{
    public class Venu
    {
        public int VenuId { get; set; }

        public string? VenuTitle { get; set;}

        public DateTime CreateDateTime { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

        public int UserId { get; set; }
    }
}
