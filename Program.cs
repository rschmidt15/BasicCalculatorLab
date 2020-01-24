using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("so you want to know the weather?");
            
            Console.WriteLine("please enter temperature in degrees fahrenheit ");

            // int.Parse will take a string data type and convert it to an int data type
            int Temperature = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter relative humidty wright (90%) as 90");
            int humidty = int.Parse(Console.ReadLine());
            double solve3 = ((0.36) * (100 - humidty));
                     // double solve1 = ((100 - humidty));
                     // decimal solve2 = 9/25;
                     // Console.WriteLine("solve1= "+solve1+"and solve2= " + solve2 + "and solve3= " +solve3);
          

            double DP = (Temperature- solve3);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine(" ");
            Console.WriteLine("your dew point for the day is an amazing " + DP + " degrees fahrenheit*");
            Console.WriteLine(" ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");

            Console.WriteLine("if you would like your windchill for the day please enter windspeed");
          

            int windspeed = int.Parse(Console.ReadLine()); 
            double cookie = Math.Pow(windspeed, 0.16);
           
          
            double windtemp = (35.74 + (0.6215*Temperature) -(35.75*cookie)+(0.3965 * Temperature * cookie));
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("your windchill for the day is an amazing " + windtemp + " degrees fahrenheit");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("**************************************************************************");
        }
    }
}
