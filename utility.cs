using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligon3_9A2022
{
    class util
    {
        public double skal_p(vektor a, vektor b) { return 0; }
        public static double vekt_p(vektor a, vektor b) 
        {            
            double det = (a.kraj.x-a.pocetak.x) * (b.kraj.y-b.pocetak.y) - (a.kraj.y-a.pocetak.y) * (b.kraj.x-b.pocetak.y);
            return det; 
        }
        public double rastojanje(tacka a, vektor b) { return 0; }
        public static int SIS(tacka a, tacka b, tacka c, tacka d)
        {
            vektor cd = new vektor(c, d);
            return SIS(a, b, cd);
        }
        public static int SIS(tacka ta, tacka tb, vektor vc) 
        {
            vektor va = new vektor(ta);
            vektor vb = new vektor(tb);
            double cxa = vekt_p(vc, va);
            double cxb = vekt_p(vc, vb);
            if (cxa * cxb > 0) return 0;
            else if (cxa * cxb < 0) return 1;
            else return -1;
        }
    }
}
