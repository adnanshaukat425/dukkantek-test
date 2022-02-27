using IMS.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.ViewModels
{
    public class ProductVM
    {
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
        [ValidateStatus]
        public int StatusId { get; set; }

        [Required]
        [ValidateCatagory]
        public int CatagoryId { get; set; }

        public DateTime Created { get; set; }
        
        public DateTime Updated { get; set; }
    }
}
