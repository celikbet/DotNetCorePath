using System;

namespace classEnumeration {

    class Program {

        static void Main(string[] args) 
        {
            // Days Enumaration
            Console.WriteLine(Days.Sunday);
            Console.WriteLine(((int)Days.Saturday));

            // Weather Enumaration
            int temperature = 32;
            if(temperature <= (int)Weather.Normal) 
                Console.WriteLine("Wait for better weather to go outside");
            else if (temperature  >= (int)Weather.Sunny)
                Console.WriteLine("It is very warm to go outside");
            else if (temperature >= (int)Weather.Normal && temperature < (int)Weather.VerySunny)
                Console.WriteLine("Let's go outside!");


        }
    }

    enum Days 
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesdey,
        Thursday,
        Friday=23,
        Saturday
    }

    enum Weather
    {
        Cold = 5,
        Normal = 20,
        Sunny = 25,
        VerySunny = 30,
    }
}