using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeCalculatorTestTask
{
    public class Calculator
    {
        private readonly ILogger _logger;
        public Calculator(ILogger logger)
        {
            _logger = logger;
        }
        public double Perimetr(IFigure figure, double x, double y)
        {
            _logger.Logers("Начало расчёта ....");
            double result = 0;
            if (x >= 0 && y >= 0)
            {
                result = figure.Perimeter(x, y);
                _logger.Logers($"Расчет выполнен успешно, периметр фигуры равен {result}");
            }
            else
            {
                _logger.Logers("Вы ввели неверные параметры");
            }
            _logger.Logers("Конец расчёта.");

            return result;
        }
        public double Area(IFigure figure, double x, double y)
        {
            _logger.Logers("Начало расчёта ....");
            double result = 0;
            if (x >= 0 && y >= 0)
            {
                result = figure.Area(x, y);
                _logger.Logers($"Расчет выполнен успешно, площадь фигуры равна {result}");
            }
            else
            {
                _logger.Logers("Вы ввели неверные параметры");
            }
            _logger.Logers("Конец расчёта.");
            return result;
        }
    }
}
