using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeCalculatorTestTask
{
    public class Rectangle : IFigure
    {
        //Площадь прямоугольника
        // в аргументы предеавать длину и ширину
        public double Area(double x, double y)
        {
            return x * y;
        }
        //Периметр прямоугольника
        // в аргументы предеавать длину и ширину
        public double Perimeter(double x, double y)
        {
           return 2 *(x+y);
        }
    }
}
