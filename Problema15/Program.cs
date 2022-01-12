using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dau 3 numere. Sa se afiseze in ordine crescatoare.
            Console.WriteLine("Dati 3 numere pe randuri diferite: ");
            int a1, a2, a3,aux=1;
            a1 = int.Parse(Console.ReadLine());
            a2 = int.Parse(Console.ReadLine());
            a3 = int.Parse(Console.ReadLine());
            Console.Write(" Numerele in ordine crescatoare sunt: ");
            if(a1>=a2)
            {
                aux = a2;
                a2 = a1;
                a1 = aux;
            }
            if (a1 >= a3)
            {
                aux = a3;
                a3 = a1;
                a1 = aux;
            }
            if (a2>=a3)
            {
                aux = a3;
                a3 = a2;
                a2 = aux;
            }
            Console.Write($" {a1} {a2} {a3}");
            Console.WriteLine();
        }
    }
}
