using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    abstract class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public Osoba() { }

        public Osoba(string wyraz1, string nazwisko)
        {
            this.imie = wyraz1;
            this.nazwisko = nazwisko;
        }

        public abstract void WypiszInfo();
    }
}
