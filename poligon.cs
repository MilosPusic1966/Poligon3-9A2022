using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Poligon3_9A2022
{
    class poligon
    {
        public int broj_temena;
        public tacka[] teme;
        public poligon(int n){
            teme = new tacka[n];
            broj_temena = n;
        }
        public void unos() {
            for (int i = 0; i < broj_temena; i++)
            {
                Console.WriteLine("Za teme {0} x=", i);
                teme[i].x = Convert.ToDouble(Console.Read());
                Console.WriteLine("Za teme {0} y=", i);
                teme[i].y = Convert.ToDouble(Console.Read());
            }
        }
        public void ucitaj(){
            for (int i = 0; i < broj_temena; i++)
            {
                teme[i].x = Convert.ToDouble(Console.ReadLine());
                teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void snimi() {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(broj_temena);
            for (int i = 0; i < broj_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
        }
        public bool prost() { return true; }
        public bool konveksan() { return true; }
        public double povrsina() { return 0; }
        public void stampa() 
        {
            Console.WriteLine("Mnogougao ima {0} temena:", broj_temena);
            for (int i = 0; i < broj_temena; i++)
            {
                Console.WriteLine("Tacka {0}: x={1} y={2} ", i, teme[i].x, teme[i].y);
            }
        }

    }
}
