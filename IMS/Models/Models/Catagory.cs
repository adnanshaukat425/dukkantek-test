using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public virtual Product Product { get; set; }
    }
}
