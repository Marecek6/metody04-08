using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metody04_08
{
    class CelaCisla
    {
        public static double mocnina(int a, int b)
        {
            double vysledek = 0, mocnina = 1;
            int i = 1;
            if (b > 0)
            {
                while (i <= b)
                {
                    mocnina *= a;
                    i++;
                }
                vysledek = mocnina;
            }
            else
            {
                while (i <= -b)
                {
                    mocnina *= a;
                    i++;
                }
                vysledek = 1 / mocnina;
            }
            return vysledek;
        }

        public static int faktorial(int a)
        {
            int i = 1, vysledek = 1;
            if (a >= 13) throw new ArgumentException("faktorial se nevejde do int");
            while (i <= a)
            {
                vysledek *= i;
                i++;
            }
            return vysledek;
        }

        public static int cifsouc(int a)
        {
            int soucet = 0, cifra = 0;
            while (a > 0)
            {
                cifra = a % 10;
                if (cifra % 2 != 0)
                {
                    soucet += cifra;
                }
                a /= 10;
            }
            return soucet;
        }
    }
}
