using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapesDLL
{
    public class UnknownShape : Figure
    {
        double UnknownArea;
        public override string Area()
        {
            return UnknownArea.ToString();
        }
        public override string ShapeName()
        {
            return "Неизвестная фигура";
        }
    }
}
