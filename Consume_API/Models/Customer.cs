using System.ComponentModel.DataAnnotations;

namespace Consume_API.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string IsActive { get; set; }
    }
}
