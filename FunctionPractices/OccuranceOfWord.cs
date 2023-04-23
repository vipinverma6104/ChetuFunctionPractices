using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class OccuranceOfWord
    {
        public static int countItem(string[] ArrStr,string word)
        {
            int count = 0;
            foreach (var i in ArrStr) 
            {
                if(i== word) 
                  count++;
            }
            return count;
        }
        public static void FindOccuranceEvery()
        {
            string str = "C# is an object oriented programming language C# is very simple language because it has object oriented programming concepts";
            //Console.WriteLine("Enter word : ");
            //string word = Console.ReadLine();
            //string word = "it";
            var Arr= str.Split(' ');
            string[] temp= new string[Arr.Length];
            int index = 0;
            for(int i=0; i<Arr.Length;i++)
            {
                if (countItem(temp, Arr[i])==0) 
                {
                    Console.WriteLine($"{Arr[i]} found {countItem(Arr, Arr[i])}");
                    temp[index] = Arr[i];
                    index++;
                }
                
            }
        }
    }
}
