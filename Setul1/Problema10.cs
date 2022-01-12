using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul1
{
    class Problema10
    {
        static void Main(string[] args)
        {
            //Test de primalitate: determinati daca un numar n este prim
            int n;
            n = int.Parse(Console.ReadLine());
            bool prim = true;
            if (n <= 1)
                prim = false;

            for(int d=2; d*d<=n; d++)
            {
                if (n % d == 0)
                    prim = false;
            }
            if(prim)
            {
                Console.WriteLine($"Numarul {n} este prim.");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este prim.");
            }
        }
    }
}
