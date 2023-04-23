using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class CharacterHandlingFunctions
    {
        public static void CharHandlining()
        {
            char a = 'm';
            Console.WriteLine(Char.ToUpper(a));
            Console.WriteLine(Char.ToLower(a));
            Console.WriteLine(Char.IsWhiteSpace(a));
            Console.WriteLine(Char.IsDigit(a));
            Console.WriteLine(Char.IsPunctuation(a));
            int b= 0X00;
            char c=Convert.ToChar(b);
            Console.WriteLine(Char.IsControl(c));
        }
    }
}
