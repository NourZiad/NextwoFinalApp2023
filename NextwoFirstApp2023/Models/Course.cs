namespace NextwoFirstApp2023.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseTitle { get; set; }

        public string? CourseDescription { get; set; }

        public int Price { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }

        public int Duration { get; set; }
        public int Hours { get; set; }

        public string? Rate { get; set; }

    }
}
