using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligon3_9A2022
{
    class tacka
    {
        public double x, y;
        public tacka(double _x, double _y) 
        {
            x = _x;
            y = _y;
        }
        public double r() { return 0; }
        public double alpha() { return 0; }
        public static bool jednako(tacka a, tacka b)
        {
            if ((a.x == b.x) && (a.y == b.y) ) return true;
            else return false;
        }
    }
}
