using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligon3_9A2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int izbor=1;
            while (izbor != 0)
            {
                Console.WriteLine("Unesite:");
                Console.WriteLine("1: Unos poligona");
                Console.WriteLine("2: Sacuvaj u fajl");
                Console.WriteLine("3: Ucitaj iz fajla");
                Console.WriteLine("4: Prikazi poligon");
                izbor = Convert.ToInt32(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        Console.WriteLine("Unesite broj temena:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        poligon novi = new poligon(n);
                        novi.unos();
                        break;
                }
            }
        }
    }
}
