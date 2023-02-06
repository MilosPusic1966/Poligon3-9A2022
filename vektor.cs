using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligon3_9A2022
{
    class vektor
    {
        public tacka pocetak, kraj;
        public vektor(tacka a, tacka b) 
        {
            pocetak = a;
            kraj = b;
            //kraj = new tacka(b.x - a.x, b.y - a.y);
        }
        public vektor(tacka b) 
        {
            pocetak = new tacka(0, 0);
            kraj = b;
        }
        public double ugao_x() { return 0; }
        public double ugao(vektor a, vektor b) { return 0; }
        public int presek(vektor a, vektor b) {
            // 0 = nema preseka
            // 1 = tacka
            // 2 = vektor (duz)
            return 0; 
        }
        public static bool seku_se(vektor a, vektor b)
        {
            int na_a = util.SIS(b.pocetak, b.kraj, a);
            int na_b = util.SIS(a.pocetak, a.kraj, b);
            if (na_a * na_b != 0) return true;
            else return false;
        }
        public void stampa()
        {
            Console.WriteLine("vektor od: x={0}, y={1}", pocetak.x, pocetak.y);
            Console.WriteLine("vektor do: x={0}, y={1}", kraj.x, kraj.y);
        }
    }
}
