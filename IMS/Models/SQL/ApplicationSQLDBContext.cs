using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SQL
{
    internal class ApplicationSQLDBContext : DbContext
    {
        public ApplicationSQLDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
