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
                Console.WriteLine("Programm ready! Write symbols one by one with press enter beetwen");
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
                Console.WriteLine("Exit 1 \nAgain 2 \n");
                f = Convert.ToInt32(Console.ReadLine());
            } while (f != 1);
        }
    }
}
