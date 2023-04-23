using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class EmailPrint
    {
        public static string Repeat(int time)
        {
            string star=string.Empty;
            for(int i=1; i<=time; i++)
            {
                star += "*";
            }
            return star;
        }
        public static void FormatEmail()
        {
            string email = "rakesh.verma@gmail.com";
            string username=email.Substring(0,email.IndexOf("@"));
            string femail=username.Substring(0,3)+Repeat(username.Length-3) +email.Substring(email.IndexOf("@"));
            Console.WriteLine("Email address in required format is: "+femail);
        }
    }
}
