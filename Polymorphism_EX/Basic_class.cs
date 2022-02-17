using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_EX
{
    class Basic_class
    {
        public static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Sum(int x, int y,int z)
        {
            Console.WriteLine(x + y +z);
        }
        public static void Sum(int x)
        {
            Console.WriteLine(x++);
        }
        public static void Sum(int x, double y)
        {
            Console.WriteLine(x + y);
        }
    }
}
