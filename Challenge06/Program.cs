  
using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called Grade()
            // That method should accept an integer with some criteria
            // 1) If the input more than 90 the output will be "A"
            // 2) If the input within range 80 to 89 the output will be "B"
            // 3) If the input within range 70 to 79 the output will be "C"
            // 4) If the input within range 60 to 69 the output will be "D"
            // 5) If the input below 59 the output will be "E"

            Console.WriteLine("Nilai Angka : ");
            int input = Convert.ToInt32(Console.ReadLine());

            if(input >= 90)
            Console.WriteLine("A");

            else if(input >= 80 && input <= 89)
            Console.WriteLine("B");

            else if(input >= 70 && input <= 79)
            Console.WriteLine("C");

            else if(input >= 60 && input <= 69)
            Console.WriteLine("D");

            else
            Console.WriteLine("E");
               

        }
    }
}
