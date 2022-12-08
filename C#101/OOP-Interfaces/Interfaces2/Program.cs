using System;

namespace Interfaces2 {

    public class Program {

        static void Main(string[] args) 
        {
            Focus focus = new();
            Console.WriteLine(focus.WhichCompanyCar().ToString());
            Console.WriteLine(focus.HowManyWheels().ToString());
            Console.WriteLine(focus.WhatIsDefaultColor().ToString());

            Civic civic = new();
            Console.WriteLine(civic.WhichCompanyCar().ToString());
            Console.WriteLine(civic.HowManyWheels().ToString());
            Console.WriteLine(civic.WhatIsDefaultColor().ToString());

        }

    }
}
