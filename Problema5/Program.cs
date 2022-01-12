using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
            Console.WriteLine("Dati un numar n si un numar k care sa fie mai mic sau egala cu numarul cifrelor lui n: ");
            int n = int.Parse(Console.ReadLine()), k = int.Parse(Console.ReadLine());
            int m = n;
            int z = 0;
            while(k!=z)
            {
                z++;
                if(k==z)
                    Console.WriteLine($"A {k}-a cifra a numarului {m} este: "+n%10);
                n /= 10;
            }
        }
    }
}
