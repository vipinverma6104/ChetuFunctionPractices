using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class OccuranceSpecificWord
    {
        public static void SpecificWordOccurance()
        {
            string str= "C# is an object oriented programming language C# is very simple language because it has object oriented programming concepts";
            Console.WriteLine("Enter any word: ");
            string str2=Console.ReadLine();
            int count = 0;
            foreach(var s in str.Split(' '))
            {
                if(s.ToLower() == str2.ToLower())
                {
                    count ++;
                }
            }
            Console.WriteLine(str2 +"found:"+ count + "time");
        }
    }
}
