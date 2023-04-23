using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class Assesment1
    {
        public static void FindDateFormat()
        {
            var Current_Date =DateTime.Now;
            string[] formats = { "dd/MM/yyyy", "yyyy/MM/dd", "dd/yyyy/MM", "MM/dd/yyyy", "dd MMMM yyyy","dd MM yyyy", "yyyy MM dd", "dd yyyy MM", "MM dd yyyy", "dd-MM-yyyy", "yyyy-MM-dd", "dd-yyyy-MM", "MM-dd-yyyy"};
            Console.WriteLine("Enter date in any format: ");
            var user_input = Console.ReadLine();
           
            var required_format = DateTime.TryParseExact(user_input, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var desired_output_format);
            Console.WriteLine(desired_output_format);
            Console.WriteLine(required_format);
        }
    }
}
