using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Poligon3_9A2022
{
    class Program
    {
        static void Main(string[] args)
        {
            poligon mnogougao=null;
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
                        mnogougao = new poligon(n);
                        mnogougao.unos();
                        break;
                    case 2:
                        mnogougao.snimi();
                        break;
                    case 3:
                        StreamReader ulaz = new StreamReader("poligon.txt");
                        int br = Convert.ToInt32(ulaz.ReadLine());
                        mnogougao = new poligon(br);
                        mnogougao.ucitaj();
                        break;
                    case 4:
                        if (mnogougao != null)
                        {
                            mnogougao.stampa();
                        }
                        break;
                }
            }
        }
    }
}
