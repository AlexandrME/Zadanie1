using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите первое число");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("среднее арифметическе =");
            Console.WriteLine("{0} ", 0.5 * (a + b));
            Console.WriteLine("среднее геометрическое =");
            Console.WriteLine("{0} ", Math.Sqrt(a * b));
            Console.ReadKey(false);
        }
    }
}
