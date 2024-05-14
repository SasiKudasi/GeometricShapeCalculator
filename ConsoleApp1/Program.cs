using GeometricShapeCalculatorTestTask;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logs = new LogIntoConsole();
            var circle = new Circle();
            var square = new Square();
            var rect = new GeometricShapeCalculatorTestTask.Rectangle();
            var calc = new Calculator(logs);
            calc.Area(circle, Math.PI, 3);
            calc.Area(square, 3, 3);
            calc.Area(rect, 3, 3);
            calc.Perimetr(square, 3, 3);
            calc.Perimetr(rect, 3, 3);
            calc.Perimetr(circle, Math.PI, 3);
        }
    }
}