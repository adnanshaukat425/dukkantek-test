using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Barcode { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Weight { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public int CatagoryId { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated { get; set; }

        [ForeignKey("StatusId")]
        public virtual IList<Status> Statuses { get; set; }

        [ForeignKey("CatagoryId")]
        public virtual IList<Catagory> Catagories { get; set; }
    }
}
