using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class MarksheetProgram
    {
        public static void CalculateMark()
        {
            Console.WriteLine("Enter Physics Marks: ");
            double phy=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Mathematics Marks: ");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Chemistry Marks: ");
            double che = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter English Marks: ");
            double eng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Hindi Marks: ");
            double hin = Convert.ToDouble(Console.ReadLine());

            double total_marks = phy + math + che + eng + hin;
            double percent = (total_marks / 5);
            string grade = "";
            if(percent>=80 && percent<100)
            {
                grade = "A++";
            }
            else if(percent>=75 && percent<=79)
            {
                grade = "A+";
            }
            else if(percent>=60 && percent<=74)
            {
                grade = "A";
            }
            else if(percent>=50 && percent<=59)
            {
                grade = "B";
            }
            else if(percent>=40 && percent<=49)
            {
                grade = "C";
            }
            else if(percent>=33 && percent<=39)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("Students Marks Details as: ");
            Console.WriteLine("Total marks: {0}\n Percentage: {1}\n Grade is: {2}",total_marks,percent,grade);
        }
    }
}
