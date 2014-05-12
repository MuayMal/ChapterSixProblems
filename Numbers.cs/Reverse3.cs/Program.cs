using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse3.cs
{
    class Program
    {

        public static void Reverse (ref int x, ref int y, ref int z)
        {
            int temp = x;
            x = z;
            z = temp;

            
        }

        static void Main(string[] args)
        {
            int x = 1, y = 2, z = 3;
            Reverse( ref x, ref y, ref z);

            Console.Write(x);
            Console.Write(y);
            Console.Write(z);
        }
    }
}
