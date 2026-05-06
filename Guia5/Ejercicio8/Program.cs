using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantN, cantAp, cantRe, cantMB, cantIns;
            double nota, acu, prom, porMB, porIns;

            Console.WriteLine("Ingrese nota entre 0 y 10:");
            nota = Convert.ToDouble(Console.ReadLine());

            cantN = 0;
            cantMB = 0;
            cantIns = 0;
            cantRe = 0;
            acu = 0;
            while (nota >= 0 && nota <=10)
            {
                cantN = cantN + 1;
                acu = acu + nota;

                if (nota < 6)
                {
                    cantRe = cantRe + 1;
                }

                if (nota >= 8)
                {
                    cantMB=cantMB + 1;
                }
                if (nota <= 3)
                {
                    cantIns=cantIns + 1;
                }

                Console.WriteLine("Ingrese nota entre 0 y 10 (o -1 para Salir ):");
                nota = Convert.ToDouble(Console.ReadLine());
            }
            cantAp = cantN - cantRe;
            prom = acu / cantN;
            porMB = (cantMB*100.0)/cantN;
            porIns = (cantIns*100.0)/cantN;

            Console.WriteLine($"Cantidad de notas ingresadas: {cantN}");
            Console.WriteLine($"Promedio: {prom.ToString("0.00")}");
            Console.WriteLine($"Cantidad de Aprobados: {cantAp}");
            Console.WriteLine($"Cantidad de no Aprobados: {cantRe}");
            Console.WriteLine($"Porcentaje de alumnos con nota Muy Bueno: {porMB.ToString("0.00")}%");
            Console.WriteLine($"Porcentaje de alumnos con nota Insuficiente: {porIns.ToString("0.00")}%");
            Console.ReadKey();
        }
    }
}
