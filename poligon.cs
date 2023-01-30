using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligon3_9A2022
{
    class poligon
    {
        int broj_temena;
        tacka[] teme;
        public poligon(int n){
            teme = new tacka[n];
        }
        public void ucitaj(){        }
        public void snimi() { }
        public bool prost() { return true; }
        public bool konveksan() { return true; }
        public double povrsina() { return 0; }
    }
}
