using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 1va
{
    class Program
    {
        static void Main(string[] args)
        {
        while (true)
        {
            int a;
            double p;
            a = Convert.ToInt32(Console.ReadLine());
            p = (a + 1) / 2;
            Console.WriteLine(Math.Round(p));
        }
        }
    }
}
