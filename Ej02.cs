using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    internal class Ej02
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese tres valores enteros:");
            int[] valores = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            OrdenarAscendentemente(valores);

           
            Console.WriteLine("Los valores ordenados ascendentemente son:");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }
        }

        static void OrdenarAscendentemente(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                       
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
