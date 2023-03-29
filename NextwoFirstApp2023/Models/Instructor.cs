namespace NextwoFirstApp2023.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }

        public string? InstructorName { get; set;}

        public string? InstructorImg { get; set;}

        public string? Position { get; set; }
        public string? Social { get; set; }

        public DateTime CreateDateTime { get; set; }

        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }

        public int UserId { get; set; }


    }
}
