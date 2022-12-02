using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LogicalPrograms
{
    public static class PrimeNumber
    {

        public static void primeNumber()
        {
            int a = 0;
            Console.WriteLine("Enter the any Number  ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }

            }

            if (a == 2)
            {
                Console.WriteLine("{0} is prime number", n);
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }


        }
    }
}