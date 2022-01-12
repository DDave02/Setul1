using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Afisati in ordine inversa cifrele unui numar n.
            int n;
            n = int.Parse(Console.ReadLine());
            Console.Write( $"Cifrele lui {n} in ordine inversa sunt: ");
            while(n!=0)
            {
                Console.Write(n%10+" ");
                n /= 10;
            }
        }
    }
}
