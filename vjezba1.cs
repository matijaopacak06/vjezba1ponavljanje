using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanjeVjezba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 3;
            double c = 4;
            double d = 5;
            double x = (a+a+b*b+c*c)/(a*a)+(b*b)+(c*c)+(d*d);
            Console.WriteLine("rezultat je:" +x);
            Console.ReadKey();

        }
    }
}
