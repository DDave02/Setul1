using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
            int n, p;
            n = int.Parse(Console.ReadLine());
            Console.Write($"Descompunerea in factori primi al numarului {n} este: ");
            for(int d=2;d*d<=n;d++)
            {
                p = 0;
                if(prim(d))
                    while(n%d==0)
                    {
                        p++;
                        n /= d;
                    }
                if(p!=0)
                if(n!=1)
                    Console.Write($" {d}^{p} x");
                else
                    Console.Write($" {d}^{p}.");
            }
            Console.WriteLine(" ");
        }

        private static bool prim(int d)
        {
            for (int i = 2; i * i <= d; i++)
                if (d % i == 0)
                    return false;
            return true;
        }
    }
}
