﻿using System;
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
            Console.WriteLine("Kérem adja meg az első számot:");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a második számot:");
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem válasszon műveletet: +, -, *, /, %");
            string muvelet = Console.ReadLine();
            if (muvelet == "+")
            {
                System.Console.WriteLine("Az összeg: " + Osszeadas(szam1, szam2));
            }
            else if (muvelet == "-")
            {
                System.Console.WriteLine("A különbség: " + Kivonas(szam1, szam2));
            }
            else if (muvelet == "*")
            {
                System.Console.WriteLine("A szorzat: " + Szorzas(szam1, szam2));
            }
            else if (muvelet == "/")
            {
                System.Console.WriteLine("Az osztás: " + Osztas(szam1, szam2));
            }
            else if (muvelet == "%")
            {
                System.Console.WriteLine("A százalék: " + Szazalek(szam1, szam2));
            }
            else
            {
                System.Console.WriteLine("Nem megfelelő művelet!");
            }
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
