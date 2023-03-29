namespace NextwoFirstApp2023.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string? BlogTitle { get; set;}
                     
        public string? BlogDescription { get; set;}
        public string? BlogImg { get; set;}

        public DateTime CreateDateTime { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

        public int UserId { get; set; }

    }
}
