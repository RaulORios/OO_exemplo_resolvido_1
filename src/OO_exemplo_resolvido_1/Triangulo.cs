using System;

namespace OO_exemplo_resolvido_1
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            //double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //return raiz;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}
