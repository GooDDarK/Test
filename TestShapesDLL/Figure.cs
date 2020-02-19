using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapesDLL
{
    public abstract class Figure
    {
        public abstract string Area();
        public abstract string ShapeName();
        public void GetInfo()
        {
            Console.WriteLine($"Название фигуры:{ShapeName()}" +
                              $"Площадь фигуры:{Area()}");
            Console.ReadLine();
        }
    }
}
