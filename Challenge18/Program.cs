using System;
using System.Linq;

namespace FindMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};

            FindMax(numbers); // Output: 330
            FindMin(numbers); // Output: -65
            FindAverage(numbers); // Output: 52.16

            
        }

        static int FindMax(int[] numbers)
        {

            int m = numbers.Max();
            Console.WriteLine(m);
            return 0;
        }

        static int FindMin(int[] numbers)
        {
            int m = numbers.Min();
            Console.WriteLine(m);
            return 0;
        }

        static int FindAverage(int[] numbers)
        {
            double m = numbers.Average();
            Console.WriteLine(m);
            return 0;
        }
    }
}
