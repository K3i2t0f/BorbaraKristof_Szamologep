using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            indit();
        }

        static void indit()
        {
        }

        static int Osszeadas(int szam1, int szam2)
        {
            return szam1 + szam2;
        }

        static int Kivonas(int szam1, int szam2)
        {
            return szam1 - szam2;
        }

        static int Osztas(int szam1, int szam2)
        {
            return szam1 / szam2;
        }

        static int Szorzas(int szam1, int szam2)
        {
            return szam1 * szam2;
        }

        static int Szazalek(int szam1, int szam2)
        {
            return szam1 * szam2 / 100;
        }

    }
}
