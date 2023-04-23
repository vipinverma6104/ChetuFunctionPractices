using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class DateTimeFunctions
    {
        public static void DateTimePractices()
        {
            var today=DateTime.Now;
            Console.WriteLine(today);
            Console.WriteLine(today.ToShortDateString());
            Console.WriteLine(today.ToShortTimeString());
            Console.WriteLine(today.ToLongDateString());
            Console.WriteLine(today.ToLongTimeString());
            Console.WriteLine(today.Year);
            Console.WriteLine(today.Month);
            Console.WriteLine(today.Day);
            Console.WriteLine(today.Date);
            Console.WriteLine(today.DayOfWeek);
            Console.WriteLine(today.Minute);
            Console.WriteLine(today.Second);
            Console.WriteLine(today.DayOfYear);
            Console.WriteLine(today.Hour);
            Console.WriteLine(today.Millisecond);
            Console.WriteLine(today.TimeOfDay);
            var Today = DateTime.UtcNow;
            Console.WriteLine(Today);
            var ToDay = DateTime.Parse("2021-03-05"); //yyyy-mm-dd
            Console.WriteLine(ToDay.AddMonths(9));
            Console.WriteLine(ToDay.AddMonths(-50));
            Console.WriteLine(ToDay.AddYears(-50));
            Console.WriteLine(ToDay.AddDays(-50));
            Console.WriteLine(ToDay.AddHours(-50));
            var x=DateTime.TryParse("1998-06-08 08:45:45",out var y);
            Console.WriteLine(y);
            Console.WriteLine(x);

            var p = DateTime.TryParseExact("1998-06-08 08:45:45", "yyyy-MM-dd hh:mm:ss",CultureInfo.InvariantCulture,DateTimeStyles.None,out var q);
            Console.WriteLine(q);
            Console.WriteLine(p);

            //Random Class
            Random rd= new Random();
            int otp = rd.Next(1111, 9999);
            string otp1 = rd.Next(1111, 9999).ToString();
            Console.WriteLine(otp);
            Console.WriteLine(otp1);
        }
    }
}
