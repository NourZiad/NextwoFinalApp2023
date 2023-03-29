using System.ComponentModel.DataAnnotations;

namespace NextwoFirstApp2023.Models.CommonProp
{
    public class CommonProp
    {
        [Display(Name = "Diration Date")]
        public DateTime CreationDate { get; set; }
        [Display(Name ="Is Published")]

        public bool IsPublished { get; set; }
        [Display(Name="Is Deleted")]

        public bool IsDeleted { get; set; }
        [Display(Name="User")]

        public Guid UserId { get; set; }
    }
}
