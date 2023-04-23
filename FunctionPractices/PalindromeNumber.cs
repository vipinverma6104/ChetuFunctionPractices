using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class PalindromeNumber
    {
        public static void CheckPalindrome()
        {
            int n, sum = 0, rem, temp;
            Console.WriteLine("Enter a number: ");
            n=int.Parse(Console.ReadLine());
            temp = n;
            while(n> 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Entered number is Palindrome!!");
            }
            else
            {
                Console.WriteLine("Number not a Palindrome !!");
            }
        }
    }
}
