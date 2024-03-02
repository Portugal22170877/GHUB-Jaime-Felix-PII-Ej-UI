using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    internal class Ej03
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del vector: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[N];

            
            Console.WriteLine("Ingrese los elementos del vector:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

           
            int negativos = 0, ceros = 0, positivos = 0;

            
            foreach (int num in vector)
            {
                if (num < 0)
                    negativos++;
                else if (num == 0)
                    ceros++;
                else
                    positivos++;
            }

            Console.WriteLine($"Cantidad de números negativos: {negativos}");
            Console.WriteLine($"Cantidad de ceros: {ceros}");
            Console.WriteLine($"Cantidad de números positivos: {positivos}");
        
    }
    }
}
