using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definición de coordenadas
            int x1 = 5, y1 = 2;
            int x2 = 75, y2 = 22;

            // Dibujar líneas horizontales (superior e inferior)
            for (int x = x1; x <= x2; x++)
            {
                Console.SetCursorPosition(x, y1);
                Console.Write("*");

                Console.SetCursorPosition(x, y2);
                Console.Write("*");
            }

            // Dibujar líneas verticales (izquierda y derecha)
            for (int y = y1; y <= y2; y++)
            {
                Console.SetCursorPosition(x1, y);
                Console.Write("*");

                Console.SetCursorPosition(x2, y);
                Console.Write("*");
            }

            // Mover el cursor fuera del marco para que no estorbe al finalizar
            Console.SetCursorPosition(0, y2 + 2);
            Console.WriteLine("Marco dibujado. Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
