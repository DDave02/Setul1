using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati toti divizorii numarului n. 
            int n;
            n = int.Parse(Console.ReadLine());
            Console.Write($"Divizorii lui {n} sunt: ");
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                    Console.Write($" {i}");
            }
            Console.WriteLine();
        }
    }
}
