using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfDemo160418_2.Model;

namespace EfDemo160418_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoo");
            using (ZooContext zooContext = new ZooContext())
            {
                int numDjur = zooContext.Djur.Count();
                Console.WriteLine("Antal djur: " + numDjur);
                if (numDjur == 0)
                {
                    Djur apa = new Djur()
                    {
                        Namn = "apa",
                        AntalBen = 4
                    };
                    Djur tiger = new Djur()
                    {
                        Namn = "tiger",
                        AntalBen = 4
                    };
                    zooContext.Djur.Add(apa);
                    zooContext.Djur.Add(tiger);

                    zooContext.SaveChanges();
                    Console.WriteLine("Djur sparade till db");
                }
                int numRelations = zooContext.Frenemies.Count();
                Console.WriteLine("Antal relationer: " + numRelations);
                if (numRelations == 0)
                {
                    Djur apa = zooContext.Djur.Where(
                        d => d.Id == 1).First();
                    Djur tiger = zooContext.Djur.Where(
                        d => d.Id == 2).First();
                    Frenemies f = new Frenemies()
                    {
                        Relation = "fiender",
                        Djur1 = apa,
                        Djur2 = tiger
                    };
                    zooContext.Frenemies.Add(f);
                    zooContext.SaveChanges();
                    Console.WriteLine("Lade till relation");
                }
            }
            
            Console.WriteLine("Press key to exit");
            Console.ReadLine();
        }
    }
}
