using EfDemo160418_2.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemo160418_2
{
    public class ZooContext:DbContext
    {
        public ZooContext() : base() { }

        public DbSet<Djur> Djur { get; set; }
        public DbSet<Frenemies> Frenemies { get; set; }

    }
}
