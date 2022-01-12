using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
            Console.WriteLine("Dati numerele a, b si n in aceasta ordine: ");
            int a, b, n,k=0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=b;i++)
            {
                if (i % n == 0)
                    k++;
            }
            if(k!=0)
                Console.WriteLine($"In intervalul [{a},{b}] sunt {k} numere care sunt divizibile cu {n}.");
            else
                Console.WriteLine($"In intervalul [{a},{b}] nu sunt numere divizivle cu {n}.");
        }
    }
}
