using EfDemo160418.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDemo160418
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen");
            using (SchoolContext context = new SchoolContext())
            {
                Student s = new Student()
                {
                    StudentName = "David",
                    RegisteredDate = new DateTime(2016, 4, 17)
                };
                context.Students.Add(s);
                context.SaveChanges();

                int numStudents = context.Students.Count();
                Console.WriteLine("Antal studenter: " + numStudents);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
