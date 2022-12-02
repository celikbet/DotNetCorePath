using System;

namespace methodsDatetimeMath {
    public class Program {

        static void Main(string[] args) 
        {
            // DateTime Library 
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // returns day with number
            Console.WriteLine(DateTime.Now.ToString("ddd")); // returns shorter name of day
            Console.WriteLine(DateTime.Now.ToString("dddd")); // returns full name of day

            Console.WriteLine(DateTime.Now.ToString("MM")); // returns month with number
            Console.WriteLine(DateTime.Now.ToString("MMM")); // returns shorter name of month
            Console.WriteLine(DateTime.Now.ToString("MMMM"));  // returns full name of month

            Console.WriteLine(DateTime.Now.ToString("yy")); // returns last two of year
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // return full year

            // *****************************************
            // Math Library

            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); // returns the largest closest number
            Console.WriteLine(Math.Round(22.3));   // returns the closest number 
            Console.WriteLine(Math.Floor(22.7));   // returns the smallest closest number

            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Max(2,6));

            Console.WriteLine(Math.Pow(3,4)); // exponential (3 to the 4)
            Console.WriteLine(Math.Sqrt(9));  // square root
            Console.WriteLine(Math.Log(9));   // logarithmic function on the base e
            Console.WriteLine(Math.Log10(10));   // logarithmic function on the base 10
            Console.WriteLine(Math.Exp(3));   // exponential function e

        }
    }
}
