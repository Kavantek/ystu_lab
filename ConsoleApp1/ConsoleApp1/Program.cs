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
            int x, y,s=0, f;
            string d,d2=" ";
            do
            {
                Console.WriteLine("Ready");
                x = Convert.ToInt32(Console.ReadLine());
                d = Console.ReadLine();
                y = Convert.ToInt32(Console.ReadLine());
                if (d == "+") { s = x + y; }
                if (d == "-") { s = x - y; }
                if (d == "*") { s = x * y; }
                if (d == "/") { s = x / y; }
                do
                {
                    d2 = Console.ReadLine();
                    if (d2 == "+")
                    {
                        x = s;
                        y = Convert.ToInt32(Console.ReadLine());
                        s = x + y;
                    }
                    if (d2 == "-")
                    {
                        x = s;
                        y = Convert.ToInt32(Console.ReadLine());
                        s = x - y;
                    }
                    if (d2 == "*")
                    {
                        x = s;
                        y = Convert.ToInt32(Console.ReadLine());
                        s = x * y;
                    }
                    if (d2 == "/")
                    {
                        x = s;
                        y = Convert.ToInt32(Console.ReadLine());
                        s = x / y;
                    }
                } while (d2 != "=");
                Console.WriteLine(s+"\n");
                Console.WriteLine("exit 1 \nagain 2 \n");
                f = Convert.ToInt32(Console.ReadLine());
            } while (f != 1);
        }
    }
}
