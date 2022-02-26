using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SQL
{
    public class ApplicationSQLDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Catagory> Catagories { get; set; }

        public ApplicationSQLDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
