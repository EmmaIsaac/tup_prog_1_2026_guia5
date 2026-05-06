using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,cont;

            Console.WriteLine("Ingrese su numero:");
            n = Convert.ToInt32(Console.ReadLine());

            cont = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont=cont + 1;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine($"{n} es un numero primo");
            }
            else
            {
                Console.WriteLine($"{n} NO es un numero primo");
            }
            Console.ReadKey();
        }
    }
}
