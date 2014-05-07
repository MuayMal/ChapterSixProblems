using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram.cs
{
    class Program
    {
        public static void ConsoleWriteLineDupe (string msg, params object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                msg = msg.Replace("{" + i + "}", parameters[i].ToString());
            }

            Console.WriteLine(msg);
        }


        public static void Monogram(char a, char b, char c, char d, char e, char f)
        {

           Console.WriteLine("** {0}.{1}.{2}. **",a,b,c);

           Console.WriteLine("** {0}.{1}.{2}. **", d, e, f); 
        }

        static void Main(string[] args)
        {
            char f1 = 'M', m1 = 'Q', l1 = 'T', f2 = 'T', m2 = 'L', l2 = 'M';

            
            Monogram(f1,m1,l1,f2,m2,l2);

        }
    }
}
