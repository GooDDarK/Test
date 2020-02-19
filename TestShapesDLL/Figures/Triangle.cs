using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapesDLL
{
    public class Triangle : Figure
    {
        double A, B, C;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override string Area()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)).ToString();
        }
        public override string ShapeName()
        {
            return "треугольник";
        }
        public string RightTriangle() //проверка на прямоугольность
        {
            bool x = (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                    || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
                    || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));
            if (x == true)
            {
                return "Прямоугольность: прямоугольный";
            }
            else
            {
                return "Прямоугольность: не прямоугольный";
            }
        }
    }
}
