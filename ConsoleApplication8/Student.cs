using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Student:Osoba
    {
        private int rokStudiow;
        private int numerGrupy;
        private int numerAlbumu;

        public Student() { }

        public Student(string imie, string nazwisko, int rok, int numerG, int numerA)
            :base(imie,nazwisko)
        {
            this.rokStudiow = rok;
            this.numerGrupy = numerG;
            this.numerAlbumu = numerA;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Imię i nazwisko: {0} {1}", imie, nazwisko);
            Console.WriteLine("Rok studiów: {0}", rokStudiow);
            Console.WriteLine("Numer grupy: {0}", numerGrupy);
            Console.WriteLine("Numer albumu: {0}", numerAlbumu);
        }
    }
}
