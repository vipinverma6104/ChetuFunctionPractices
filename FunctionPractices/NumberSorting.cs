using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class NumberSorting
    {
        public static void SortNumber()
        {
            // Prompt the user to enter three numbers
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Sort the numbers using a simple bubble sort algorithm
            int[] nums = { num1, num2, num3 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            // Print the sorted numbers to the console
            Console.WriteLine("The numbers in sorted order are:");
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
