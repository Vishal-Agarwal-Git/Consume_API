using System.ComponentModel.DataAnnotations;

namespace Consume_API.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Must be atlest 4 character long.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Select One")]
        public string Gender { get; set; }
        [Display(Name = "Active")]
        public string IsActive { get; set; }
    }
}
