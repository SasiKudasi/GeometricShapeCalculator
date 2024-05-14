using GeometricShapeCalculatorTestTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LogIntoConsole : ILogger
    {
        public void Logers(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
