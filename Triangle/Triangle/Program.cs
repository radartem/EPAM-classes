using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Triangle
    {
        private Triangle() { }

        public static bool CheckTriangleInequality(double a,double b,double c) //a,b,c - triangle sides
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && c + b > a && c + a > b;
        }
    }
}
