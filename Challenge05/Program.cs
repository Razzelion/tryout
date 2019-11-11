using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new method with ability to detect odd or even number.
            // Example:
            IsOdd(4); // false
            IsEven(8); // true
            IsOdd(18);
            IsOdd(13);
            IsEven(244);
            IsEven(10001);
            //int no1;
            

            //Console.Write("Masukkan angka : ");
            //no1 = Convert.ToInt32(Console.ReadLine());

            


            
        }

        private static double IsOdd(double value)
        {
            Console.Write($"IsOdd {value} ? ");
            if(value % 2 == 0)
            Console.Write("FALSE \n");
            else
            Console.Write("TRUE \n");
            return 0;
        }

        private static double IsEven(double value)
        {
            Console.Write($"IsEven {value} ? ");
            if(value % 2 == 0)
            Console.Write("TRUE \n");
            else
            Console.Write("FALSE \n");
            return 0;
        }
    }
}

