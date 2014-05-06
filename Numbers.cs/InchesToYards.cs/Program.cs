using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToYards.cs
{
    class Program
    {
        public static void Convert(int a)
        {
            Console.WriteLine("{0} yards,{1} feet and {2} inches ", a / 36, ((a % 36) / 12), ((a % 36)) % 12);

        }
        static void Main(string[] args)
        {
            int inch = 67;
            Convert(inch);



        }
    }
}
