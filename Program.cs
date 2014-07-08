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
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} ", 0.5 * (a + b));
            Console.WriteLine("{0} ", Math.Sqrt(a * b));
            Console.ReadKey(false);
        }
    }
}
