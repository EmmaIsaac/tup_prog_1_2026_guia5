using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            long acumulador = 0;
            Console.WriteLine("Ingrese el numero hasta donde desea contar");
            numero=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++) {
                acumulador = acumulador + i;
                Console.WriteLine($"La suma de los números del 1 al {numero} es: {acumulador}");
            }
            Console.ReadKey();
        }
    }
}
