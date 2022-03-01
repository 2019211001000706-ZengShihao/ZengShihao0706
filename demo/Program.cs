using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i=8>>5;
            int? j=i>0?i:null;
            var a = j??int.MinValue;
            Console.WriteLine(a);
        }
    }
}
