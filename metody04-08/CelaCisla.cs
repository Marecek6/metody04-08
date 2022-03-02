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
    }
}
