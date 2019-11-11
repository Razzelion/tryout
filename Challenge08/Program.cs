using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {int isLeapYear;
           Console.Write("masukkan tahun : ");
           isLeapYear= Convert.ToInt32(Console.ReadLine());
 
        if ((isLeapYear % 400) == 0)
        Console.WriteLine("TRUE", isLeapYear);
        else if ((isLeapYear % 100) == 0)
        Console.WriteLine("FALSE", isLeapYear);
        else if ((isLeapYear % 4) == 0)
        Console.WriteLine("TRUE\n", isLeapYear);
        else
        Console.WriteLine("FALSE.\n", isLeapYear);
}
        }
    }
}
