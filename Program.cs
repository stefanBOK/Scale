using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 8ma
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int x = 1; x < i + i; x++)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine();
        }
    }
}
