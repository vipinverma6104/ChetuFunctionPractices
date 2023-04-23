using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class ReverseofString
    {
        public static void StringReverse()
        {
            Console.WriteLine("Enter any string : ");
            string str= Console.ReadLine();
            char[] Arr= str.Trim().ToCharArray();
            // using inbuilt function
            Array.Reverse( Arr );
            char[] revStr = Arr;
            Console.WriteLine(revStr);
            //without using inbuilt function
            //string reverseString = "";
            //for(int i=Arr.Length-1; i>=0; i--)
            //{
            //    reverseString += Arr[i];
            //}
            //Console.WriteLine("Reversed string is: "+reverseString);
        }
    }
}
