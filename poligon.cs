﻿using System;
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
        public static poligon unos() {
            Console.WriteLine("Unesite broj temena");
            int n = Convert.ToInt32(Console.ReadLine());
            poligon novi = new poligon(n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Za teme {0} x=", i);
                double temp_x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Za teme {0} y=", i);
                double temp_y = Convert.ToDouble(Console.ReadLine());
                novi.teme[i] = new tacka(temp_x, temp_y);
                //Console.Write
            }
            return novi;
        }
        public static poligon ucitaj(){
            StreamReader ulaz = new StreamReader("poligon.txt");
            int n = Convert.ToInt32(ulaz.ReadLine());
            poligon novi = new poligon(n);
            for (int i = 0; i < n; i++)
            {
                double temp_x = Convert.ToDouble(ulaz.ReadLine());
                double temp_y = Convert.ToDouble(ulaz.ReadLine());
                novi.teme[i] = new tacka(temp_x, temp_y);
            }
            return novi;
        }
        public void snimi() {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(broj_temena);
            for (int i = 0; i < broj_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
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
