using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class MaxNumber
    {
        public static void FindMax()
        {
            Console.WriteLine("Enter first number: ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if(n1>n2 && n1>n3)
            {
                Console.WriteLine("Greatest number is n1: "+n1);
            }
            else if(n2>n1 && n2>n3)
            {
                Console.WriteLine("Greatest number is n2: " + n2);
            }
            else
            {
                Console.WriteLine("Greatest number is n3: "+n3);
            }
        }
    }
}
