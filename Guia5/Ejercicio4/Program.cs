using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,dividendo;

            Console.WriteLine("Ingrese primer numero:");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 < n2)
            {
                for (int i = n1; i < n2; i++)
                {
                    dividendo = i + 1;
                    if (dividendo % 2 == 0)
                    {
                        Console.WriteLine($"{dividendo} es divisible por 2");
                    }
                    if (dividendo % 3 == 0)
                    {
                        Console.WriteLine($"{dividendo} es divisible por 3");
                    }
                }
            }
            else if (n2 < n1)
            {
                for (int i = n2; i < n1; i++)
                {
                    dividendo = i + 1;
                    if (dividendo % 2 == 0)
                    {
                        Console.WriteLine($"{dividendo} es divisible por 2");
                    }
                    if (dividendo % 3 == 0)
                    {
                        Console.WriteLine($"{dividendo} es divisible por 3");
                    }
                }
            }
            else {
                Console.WriteLine("Los numeros ingresados son iguales");
            }            
            Console.ReadKey();
        }
    }
}
