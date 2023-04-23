using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractices
{
    internal class BillDiscountProgram
    {
        public static void DiscountAmount()
        {
            double good_amt;
            Console.WriteLine("Enter amount of goods: ");
            good_amt=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Amount after discount: ");
            if(good_amt >=30000)
            {
                good_amt = good_amt - (good_amt * 30 / 100);
                Console.WriteLine(good_amt);
            }
            else if(good_amt>=20000 && good_amt<30000)
            {
                good_amt = good_amt - (good_amt * 20 / 100);
                Console.WriteLine(good_amt);
            }
            else if(good_amt>=10000 && good_amt<20000)
            {
                good_amt = good_amt - (good_amt * 10 / 100);
                Console.WriteLine(good_amt);
            }
            else
            {
                Console.WriteLine("No discount");
            }
        }
    }
}
