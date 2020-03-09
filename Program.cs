using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappmaksym
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Math.Pow(x - y, 2);

            Console.WriteLine($"Z = {z}");


        }
    }
}