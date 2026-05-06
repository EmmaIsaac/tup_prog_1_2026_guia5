using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nCanciones, min, seg, duracionEnSeg, duracionEnSegMax, minFinales, segTotales, segResto;
            string cancion, cancionMayor;

            Console.WriteLine("Ingrese la cantidad de canciones de la lista:");
            nCanciones = Convert.ToInt32(Console.ReadLine());

            duracionEnSegMax = 0;
            segTotales = 0;
            cancionMayor = "";
            for (int i = 0; i < nCanciones; i++)
            {
                Console.WriteLine("Ingrese el nombre de la cancion:");
                cancion= Console.ReadLine();
                Console.WriteLine("Ingrese cantidad de minutos de la cancion:");
                min= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de segundos de la cancion:");
                seg = Convert.ToInt32(Console.ReadLine());

                duracionEnSeg = (min * 60) + seg;

                if (duracionEnSeg > duracionEnSegMax)
                {
                    cancionMayor = cancion;
                    duracionEnSegMax=duracionEnSeg;
                }

                segTotales = segTotales + duracionEnSeg;
            }

            minFinales = segTotales / 60;
            segResto = segTotales % 60;

            Console.WriteLine($"El tiempo total de la lista es de {minFinales} min., {segResto}seg.");
            Console.WriteLine($"La cancion con mayor duracion es: {cancionMayor}");
            Console.ReadKey();
        }
    }
}
