using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class CouponNo
    {
        public static void CheckCouponNumber()
        {
            string chars = "0123456789";
            Random random = new Random();
            string result = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            Console.WriteLine("Random coupon is: {0}", result);
        }
    }
}
