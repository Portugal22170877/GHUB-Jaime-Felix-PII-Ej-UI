using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01
{
    internal class Ej01
    {
        static void Main(string[] args)
        {
    Console.Write("Ingresa la temperatura en grados Celsius: ");
    double celsius = Convert.ToDouble(Console.ReadLine());

    double fahrenheit = CelsiusToFahrenheit(celsius);

    Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit} °F");
}

static double CelsiusToFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;

        }
    }
}
