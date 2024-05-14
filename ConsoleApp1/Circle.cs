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
        //в параметры передавать число pi(х) и радиус(r)
        public double Area(double x, double y)
        {
            double result;
            if (x == Math.PI)
                result = x * Math.Pow(y, 2);
            else
                result = 0;
            return result;
        }
        // Длина окружности для круга
        //в параметры передавать число pi(х) и радиус(r)
        public double Perimeter(double x, double y)
        {
            double result;
            if (x == Math.PI)
                result = 2 * x * y;
            else
                result = 0;
            return result;
        }
    }
}
