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
                Console.WriteLine("5: Prost");
                Console.WriteLine("6: Konveksan");
                Console.WriteLine("7: Povrsina");
                Console.WriteLine("8: Tacka u poligonu");
                Console.WriteLine("9: Proba");
                Console.WriteLine("10: Hull");
                Console.WriteLine("0: Kraj");
                izbor = Convert.ToInt32(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        mnogougao = poligon.unos();
                        break;
                    case 2:
                        mnogougao.snimi();
                        break;
                    case 3:
                        mnogougao = poligon.ucitaj();
                        break;
                    case 4:
                        if (mnogougao != null)
                        {
                            mnogougao.stampa();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Prost={0}", mnogougao.prost());
                        break;
                    case 6:
                        Console.WriteLine("Konveksan={0}", mnogougao.konveksan());
                        mnogougao.konveksan();
                        break;
                    case 7:
                        Console.WriteLine("Povrsina={0}", mnogougao.povrsina());
                        mnogougao.povrsina();
                        break;
                    case 8:
                        Console.WriteLine("Unutrasnjost={0}", mnogougao.TuP());
                        break;
                    case 9:
                        mnogougao.proba();
                        break;
                    case 10:
                        mnogougao = mnogougao.hull();
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
}
