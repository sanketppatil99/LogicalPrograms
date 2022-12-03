using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class TemperaturConversion
    {
        public static void temperaturConversion()
        {
            int F , C;
            Console.WriteLine("Enter 1.) To convert Temperatur Celsius to Fahrenheit : \n " +
                "Enter 2.) To convert Temperatur Fahrenheit to Celsius : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the value in Celsius =  ");
                    C = Convert.ToInt32(Console.ReadLine());
                    F = (C * 9 / 5) + 32;
                    Console.WriteLine("Temperature in Fahrenheit is {0} °F ", F);
                    break;
                case 2:
                    Console.WriteLine("Enter the value in Fahrenheit =  ");
                    F = Convert.ToInt32(Console.ReadLine());
                    C = (F - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius is {0} °C ", C);
                    break;
                    
            }
        }
    }
}
