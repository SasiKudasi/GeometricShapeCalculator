using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeCalculatorTestTask
{
    public class Circle : IFigure
    {
        // Площадь круга        
        public double Area(double x, double y)
        {
            double result;
            result = Math.PI * Math.Pow(x, 2);
            return result;
        }
        // Длина окружности для круга        
        public double Perimeter(double x, double y)
        {
            double result;
            result = 2 * Math.PI * x;
            return result;
        }
    }
}
