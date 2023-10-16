using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Leap_Year
{
    internal class Program
    {
        static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }


        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" Check Leap year");
            // check if a year leap year
            int year = 2816;
            int year2 = 2018;

            bool IsLeapYear = IfYearIsLeap(year);
            bool isLeapYear2 = IfYearIsLeap(year2);
            Console.WriteLine($"IsleapYear ({year}) -> {IsLeapYear}");
            Console.WriteLine($"IsleapYear ({year}) -> {isLeapYear2}");
            Console.ReadLine();
        }
    }
}
