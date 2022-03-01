using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year:");
            //记录用户输入的年份s
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a Leap Year.");
                    }
                    else
                    {
                        Console.WriteLine(year + " is not a Leap Year.");
                    }
                }
                else
                {
                    Console.WriteLine(year + " is a Leap Year.");
                }
                Console.ReadLine();
            }
        }
    }
}
