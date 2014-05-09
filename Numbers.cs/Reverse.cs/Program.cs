using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse.cs
{
    class Program
    {

        public static int Square(int a)
        {

            
            Console.WriteLine("{0} * {1} = {2}", a, a, a * a);

            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            

        }
    }
}
