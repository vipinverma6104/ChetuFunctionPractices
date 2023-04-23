using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class Assesment2
    {
        public static void DateFormat()
        {
            // Get the current system date
            DateTime currentDate = DateTime.Now;

            // Ask the user for the desired date format
            Console.Write("Enter the desired date format (e.g. yyyy-MM-dd): ");
            string dateFormat = Console.ReadLine();

            // Format the date according to the user's specification
            string formattedDate = currentDate.ToString(dateFormat);

            // Print the formatted date to the console
            Console.WriteLine("The current date is: {0}", formattedDate);
        }
    }
}
