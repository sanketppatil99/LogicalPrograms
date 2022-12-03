using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public static void monthlyPayment()
        {
            Console.WriteLine("Enter principal loan amount P = ");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("R percent interest compounded monthly = ");
            int R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year you want Monthly Payment Y = ");
            int Y = Convert.ToInt32(Console.ReadLine());

            int n = 12 * Y;
            int r = R / (12 * 100);
            int Payment = ( P * r )/ 1 -(1 + r)^(-n);
            Console.WriteLine("Monthly Payment is = {0}", Payment);
        }
    }
}
