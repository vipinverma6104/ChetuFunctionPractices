using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class DuplicateWordString
    {
        public static void WordDuplicate()
        {
            string str= "C# is an object oriented programming language C# is very simple language because it has object oriented programming concepts";
            int count;
            str= str.ToLower();
            string[] words=str.Split(' ');
            Console.WriteLine("Duplicate words in a given string: ");
            for(int i=0;i<words.Length;i++)
            {
                count = 1;
                for(int j=i+1;j<words.Length;j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        count++;
                        words[j] = "0";
                    }
                }
                if(count>1 && words[i]!="0")
                    Console.WriteLine(words[i]);
            }
        }
    }
}
