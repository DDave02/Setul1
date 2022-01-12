using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
            //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            n += m;
            m += n;
            n = m - n;
            m = m - 2 * n;
            Console.WriteLine($"n={n} m={m}");
        }
    }
}
