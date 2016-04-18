using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemo160418_2.Model
{
    public class Frenemies
    {
        public int Id { get; set; }
        //public int Djur1Id { get; set; } // FK
        public Djur Djur1 { get; set; }
        //public int Djur2Id { get; set; } // FK
        public Djur Djur2 { get; set; }
        public string Relation { get; set; }
    }
}
