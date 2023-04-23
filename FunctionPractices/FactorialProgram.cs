using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class FactorialProgram
    {
        public static void PrintFactorial()
        {
            int n, i, fact = 1;
            Console.WriteLine("Enter a number :");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial of"+" "+n+" "+ "is:"+fact);
        }
    }
}
