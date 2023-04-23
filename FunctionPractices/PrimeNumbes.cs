using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class PrimeNumbes
    {
        public static void FindPrimeNumbers()
        {
            // Prompt the user to enter two numbers
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Swap the numbers if necessary to ensure num1 is the smaller number
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            // Iterate through the numbers between num1 and num2, and check if each is prime
            Console.WriteLine("Prime numbers between {0} and {1}:", num1, num2);
            for (int i = num1; i <= num2; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
