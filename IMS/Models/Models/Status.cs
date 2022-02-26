using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
        public virtual Product Product { get; set; }
    }
}
