using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBGemi.Models
{
    public class DBGemiContext : DbContext
    {
        public DbSet<Ship> Ships { get; set; }

    }
}
