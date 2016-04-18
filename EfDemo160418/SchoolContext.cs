using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfDemo160418.Model;

namespace EfDemo160418
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        { }

        public DbSet<Student> Students { get; set; }
    }
}
