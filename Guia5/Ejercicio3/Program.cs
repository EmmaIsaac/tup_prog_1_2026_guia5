using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,acu;
            double prom;

            acu = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese numero:");
                n=Convert.ToInt32(Console.ReadLine());
                acu = acu + n;
            }
            prom = acu / 10.0;
            Console.WriteLine("El promedio es: " + prom);
            Console.ReadKey();
        }
    }
}
