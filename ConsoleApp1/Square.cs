using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeCalculatorTestTask
{
    public class Square : IFigure
    {
        // Площадь квадрата - сторона в квадрате
        public double Area(double x, double y)
        {
            return x * x; 
        }
        // Периметр квадрата - сторона умноженная на 4
        public double Perimeter(double x, double y)
        {
            return 4 * x; 
        }
    }
}
