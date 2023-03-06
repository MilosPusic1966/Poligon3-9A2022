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
        public poligon(int n) {
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
        public static poligon ucitaj() {
            StreamReader ulaz = new StreamReader("poligon.txt");
            int n = Convert.ToInt32(ulaz.ReadLine());
            poligon novi = new poligon(n);
            for (int i = 0; i < n; i++)
            {
                double temp_x = Convert.ToDouble(ulaz.ReadLine());
                double temp_y = Convert.ToDouble(ulaz.ReadLine());
                novi.teme[i] = new tacka(temp_x, temp_y);
            }
            ulaz.Close();
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
        public bool prost()
        {
            // ponovljeno teme
            for (int i = 0; i < broj_temena - 1; i++)
            {
                for (int j = i + 1; j < broj_temena; j++)
                {
                    if (tacka.jednako(teme[i], teme[j])) return false;
                }
            }
            // return true;
            // presek nesusednih stranica
            for (int i = 0; i < broj_temena - 2; i++)
            {
                vektor prvi = new vektor(teme[i], teme[i + 1]);
                for (int j = i + 2; j < broj_temena; j++)
                {
                    if (i == 0 && j == broj_temena - 1) continue;
                    // prvi.stampa();
                    vektor drugi = new vektor(teme[j], teme[(j + 1) % broj_temena]);
                    // drugi.stampa();
                    if (vektor.seku_se(prvi, drugi) == true) return false;
                }
            }
            return true;
        }
        public bool konveksan() {
            if (prost() == false)
            {
                Console.WriteLine("Nije prost, ne moze biti konveksan");
                return false;
            }
            int brojac = 0;
            int treba = broj_temena;
            for (int i = 0; i < broj_temena; i++)
            {
                vektor prvi = new vektor(teme[i], teme[(i + 1) % broj_temena]);
                vektor drugi = new vektor(teme[(i + 1) % broj_temena], teme[(i + 2) % broj_temena]);
                double ugao = util.vekt_p(prvi, drugi);
                if (ugao > 0) brojac++;
                if (ugao == 0) treba--;
            }
            if ((brojac == treba) || (brojac == 0)) return true;
            else return false;
        }
        public double povrsina() {
            if (prost()== false)
            {
                Console.WriteLine("Nije prost, ne znamo povrsinu!");
                return -1;
            }
            double povrs = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                povrs += teme[i].x * teme[(i + 1) % broj_temena].y;
                povrs -= teme[i].y * teme[(i + 1) % broj_temena].x;
            }
            return Math.Abs(povrs/2); 
        }
        public bool TuP()
        {
            if (prost() == false)
            {
                Console.WriteLine("Nije prost");
                return false;
            }
            Console.Write("Za tacku x=");
            double temp_x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Za tacku y=");
            double temp_y = Convert.ToDouble(Console.ReadLine());
            double max = teme[0].x;
            for (int i = 1; i < broj_temena; i++)
            {
                if (max < teme[i].x) max = teme[i].x;
            }
            tacka leva = new tacka(temp_x, temp_y);
            tacka desna = new tacka(max+1, temp_y);
            vektor poluprava = new vektor(leva, desna);
            int presek = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                vektor stranica = new vektor(teme[i], teme[(i + 1) % broj_temena]);
                stranica.stampa();
                if (util.specijalna_sadrzi_tacku(poluprava,  teme[(i + 1) % broj_temena]))
                {
                    if (util.SIS(teme[i], teme[(i + 2) % broj_temena], poluprava) == 1) presek++;
                }
                if (vektor.seku_se(poluprava, stranica)) presek++;
                Console.WriteLine("presek={0}", presek);
            }
            
            if ((presek % 2) == 0) return false;
            return true;
        }
        public void stampa() 
        {
            Console.WriteLine("Mnogougao ima {0} temena:", broj_temena);
            for (int i = 0; i < broj_temena; i++)
            {
                Console.WriteLine("Tacka {0}: x={1} y={2} ", i, teme[i].x, teme[i].y);
            }
        }
        public poligon hull()
        {
            double min_x, min_y;
            min_x = teme[0].x;
            min_y = teme[0].y;
            int indeks = 0;
            for (int i = 1; i < broj_temena; i++)
            {
                if (teme[i].x < min_x)
                {
                    min_x = teme[i].x;
                    min_y = teme[i].y;
                    indeks = i;
                }
                else
                {
                    if (min_x == teme[i].x)
                    {
                        if (teme[i].y < min_y)
                        {
                            min_y = teme[i].y;
                            indeks = i;
                        }
                    }
                }
            }
            Console.WriteLine("pobedio={0}", indeks);
            List<tacka> hull = new List<tacka>();
            hull.Add(teme[indeks]);
            tacka X = new tacka(teme[indeks].x + 2, teme[indeks].y);
            //vektor PX = new vektor(teme[indeks], X);
            double min_ugao = 180;
            int indeks2 = 0;
            for (int i = 1; i < broj_temena; i++)
            {
                double temp_x = teme[(indeks + i) % broj_temena].x - teme[indeks].x;
                double temp_y = teme[(indeks + i) % broj_temena].y - teme[indeks].y;
                double temp_ugao = Math.Atan2(temp_y, temp_x);
                if (temp_ugao < min_ugao)
                {
                    min_ugao = temp_ugao;
                    indeks2 = (indeks + i) % broj_temena;
                }
            }
            hull.Add(teme[indeks2]);
            while (indeks2 != indeks)
            {
                min_ugao = 180;
                int indeks3 = 0;
                for (int brojac = indeks2+1; brojac % broj_temena <= indeks; brojac++)
                {
                    tacka poc = teme[indeks2];
                    tacka kraj = teme[brojac % broj_temena];
                    double temp_x = kraj.x - poc.x;
                    double temp_y = kraj.y - poc.y;
                    double temp_ugao = Math.Atan2(temp_y, temp_x);
                    if (temp_ugao < min_ugao)
                    {
                        min_ugao = temp_ugao;
                        indeks3 = brojac;
                    }
                }
                hull.Add(teme[indeks3]);
                indeks2 = indeks3;
            }
            // KOMENTARI I SUGESTIJE SU DOMACI!!!
            return null;
        }
        public void proba()
        {
            // Console.WriteLine(prost());
            /*tacka a = new tacka(2, 1);
            tacka b = new tacka(4, 4);
            tacka c = new tacka(4, 1);
            tacka d = new tacka(3, 4);
            vektor prvi = new vektor(a, b);
            prvi.stampa();
            vektor drugi = new vektor(c, d);
            drugi.stampa();
            */
            double ugao = Math.Atan2(1, -1)*180/Math.PI;
            Console.WriteLine("Ugao={0}", ugao);
        }
    }
}
