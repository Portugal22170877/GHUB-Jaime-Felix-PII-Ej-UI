using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    internal class Ej04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los coeficientes de la ecuación cuadrática (ax^2 + bx + c):");
            Console.Write("Coeficiente a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coeficiente b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coeficiente c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            //
            EcuacionCuadratica ecuacion = new EcuacionCuadratica(a, b, c);

            
            int discriminante = ecuacion.GetDiscriminante();

            
            if (discriminante > 0)
            {
                Console.WriteLine($"Las raíces de la ecuación son:");
                Console.WriteLine($"Raíz 1: {ecuacion.GetRaiz1()}");
                Console.WriteLine($"Raíz 2: {ecuacion.GetRaiz2()}");
            }
            else if (discriminante == 0)
            {
                Console.WriteLine($"La ecuación tiene una raíz doble:");
                Console.WriteLine($"Raíz: {ecuacion.GetRaiz1()}");
            }
            else
            {
                Console.WriteLine("La ecuación no tiene raíces reales.");
            }
        }
    }
}
