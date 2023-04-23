using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class EnterAnyNamePrnit
    {
        public static void PrintAbbreviatedFormat()
        {
            string name = "raj kumar verma";
            string[] Arr = name.Split(' ');
            string str1 = Arr[0].Substring(0, Arr[0].IndexOf("a")).ToUpper();
            string str2= Arr[1].Substring(0, Arr[1].IndexOf("u")).ToUpper();
            Console.WriteLine(str1 + "." + str2 + "." + " " + Arr[2].Replace('v','V'));
        }
    }
}
