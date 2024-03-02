using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    internal class EcuacionCuadratica
    {
        private int a, b, c;

        
        public EcuacionCuadratica(int coeficienteA, int coeficienteB, int coeficienteC)
        {
            a = coeficienteA;
            b = coeficienteB;
            c = coeficienteC;
        }

        
        public int CoeficienteA
        {
            get { return a; }
            set { a = value; }
        }

        public int CoeficienteB
        {
            get { return b; }
            set { b = value; }
        }

        public int CoeficienteC
        {
            get { return c; }
            set { c = value; }
        }

        
        public int GetDiscriminante()
        {
            return b * b - 4 * a * c;
        }

        
        public double GetRaiz1()
        {
            int discriminante = GetDiscriminante();
            if (discriminante < 0)
                return 0;
            else
                return (-b + Math.Sqrt(discriminante)) / (2 * a);
        }

        
        public double GetRaiz2()
        {
            int discriminante = GetDiscriminante();
            if (discriminante < 0)
                return 0;
            else
                return (-b - Math.Sqrt(discriminante)) / (2 * a);
        }
        }
}
