using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
           {
               new Student("Linus", "Örnborg", "A"),
               new Student("Abbe", "Svensson", "F"),
               new Student("Kalle", "Andersson", "C"),
               new Student("Mohammed", "Abdulla", "B"),
               new Student("Dålig", "SomFan", "F"),
               new Student("Skön", "Kille", "D"),
               new Student("Karin", "Bermudasson", "A"),
           };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Linus", "Örnborg", 18000, 6),
                new Worker("Kalle", "Bertilsson", 8000, 8),
                new Worker("Sara", "Kallekalasson", 5000, 9),
                new Worker("Rare","Tyres", 10000, 8),
                new Worker("Humpa", "Lumpa", 12000, 8),
                new Worker("Dega", "Klet", 1000, 8)
            };

            students = students.OrderBy(student => student.Grade).ToList();
            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();
            students.ForEach(Console.WriteLine);
            workers.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
