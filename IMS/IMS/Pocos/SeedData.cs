using Models.Models;
using System.Collections.Generic;

namespace IMS.Pocos
{
    public class SeedData
    {
        public bool Seed { get; set; }
        public List<Catagory> Catagories { get; set; }
        public List<Status> Statuses { get; set; }
        public List<Product> Products { get; set; }
    }
}
