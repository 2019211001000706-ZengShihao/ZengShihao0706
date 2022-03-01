using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZengShihao0706
{
    internal class DayPrinter
    {
        static void Main(string[] args)
        {
            //日期数组
            String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //打印日期
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
                //Console.ReadLine();
            }

        }
    }
}
