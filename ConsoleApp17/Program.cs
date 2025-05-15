using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        public static double Min(double a, double b)
        {
            return a < b ? a : b;
        }

        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        public delegate double CompareDelegate(double x, double y);

        static void Main()
        {
            CompareDelegate minDelegate = new CompareDelegate(Min); // сравнивание делеагата минимальное
                                                                    // и максимальное
            CompareDelegate maxDelegate = new CompareDelegate(Max);

            double num1 = 17;
            double num2 = 14.2;

            Console.WriteLine($"Минемальное: {minDelegate(num1, num2)}");
            Console.WriteLine($"Максимольное: {maxDelegate(num1, num2)}");
            Console.ReadKey();
        }
    }
}
