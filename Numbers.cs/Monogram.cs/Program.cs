using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram.cs
{
    class Program
    {
       

        public static void Monogram(char a, char b, char c)
        {

           Console.WriteLine("** {0}.{1}.{2}. **",a,b,c);

        }

        static void Main(string[] args)
        {
            char f1 = 'M', m1 = 'Q', l1 = 'T', f2 = 'T', m2 = 'L', l2 = 'M';

            
            Monogram(f1,m1,l1);
            Monogram(f2, m2, l2);
        }
    }
}
