using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osoba o1 = new Osoba("Jan","Kowalski");
            //o1.WypiszInfo();
            Student s1 = new Student("Anna","Nowak",2,2,12345);
            s1.WypiszInfo();

            Osoba student1 = new Student("Roman","Nowaczyk",1,2,34521);
            student1.WypiszInfo();

            Console.ReadKey();
        }
    }
}
