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
        public string Relation { get; set; }

        // Djur1 och Djur2 är navigation properties
        // och man ska använda virtual för att garantera
        // att EF tar med dem på rätt sätt
        public virtual Djur Djur1 { get; set; }
        public virtual Djur Djur2 { get; set; }
    }
}
