using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, f;
            string d;
            do
            {
                Console.WriteLine("Ready");
                x = Convert.ToInt32(Console.ReadLine());
                d = Console.ReadLine();
                y = Convert.ToInt32(Console.ReadLine());
                if (d == "+") { Console.WriteLine(x + y); }
                if (d == "-") { Console.WriteLine(x - y); }
                if (d == "*") { Console.WriteLine(x * y); }
                if (d == "/") { Console.WriteLine(x / y); }
                Console.WriteLine("exit 1 \nagain 2 \n");
                f = Convert.ToInt32(Console.ReadLine());
            } while (f != 1);
        }
    }
}
