using System;
using System.Linq;

namespace DaysToNextBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            //var today = DateTime.Today;
            // Count the days of your next Ultah
              DateTime Ultah = new DateTime(1988, 05, 23);
              DateTime now = DateTime.Today;
              int months = 0;
              int days = 0;

              DateTime nextUltah = Ultah.AddYears(now.Year - Ultah.Year);
              if (nextUltah < now)
              {
                  nextUltah = nextUltah.AddYears(1);
              }

              while (now.AddMonths(months + 1) <= nextUltah)
              {
                  months++;
              }
              days = nextUltah.Subtract(now.AddMonths(months)).Days;

              Console.WriteLine("{0} month(s) and {1} day(s) remaining to my next birthday.", months, days);
            
        }
    }
}
