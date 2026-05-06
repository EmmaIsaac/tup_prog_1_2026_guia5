using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod, cant;
            double precio, monto, total;

            string resp="";
            total = 0;
            while (resp != "n")
            {
                Console.WriteLine("Ingrese codigo del producto:");
                cod = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad:");
                cant = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese precio unitario del producto:");
                precio = Convert.ToDouble(Console.ReadLine());
                
                monto = precio * cant;
                Console.WriteLine($"Codigo:{cod} - Cantidad:{cant} - Precio U:${precio} - Monto:${monto}");
                
                total = total + monto;

                Console.WriteLine("¿Desea Continuar? S/N");
                resp = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Total a pagar: ${total}");
            Console.ReadKey();

        }
    }
}
