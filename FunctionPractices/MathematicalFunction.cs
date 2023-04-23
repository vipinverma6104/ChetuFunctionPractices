using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class MathematicalFunction
    {
        public static void CheckMathematical()
        {
            Console.WriteLine(Math.Sqrt(5.56));
            Console.WriteLine(Math.Sqrt(6));
            Console.WriteLine(Math.Ceiling(6.4)); //above
            Console.WriteLine(Math.Floor(6.4)); //below
            Console.WriteLine(Math.Round(6.4)); //nearest
            Console.WriteLine(Math.Round(6.5));
            Console.WriteLine(Math.Round(6.6));
            Console.WriteLine(Math.Pow(5,3));
            Console.WriteLine(Math.Pow(6.4,4));
            int a, b;
            b = Math.DivRem(20, 6, out a);
            Console.WriteLine(a); //Remainder Output 2
            Console.WriteLine(b); //Dividend Output 3
        }
    }
}
