using System;

namespace Interfaces2 {

    public class Program {

        static void Main(string[] args) 
        {
            Focus focus = new();
            Console.WriteLine(focus.WhichCompanyCar().ToString());
            Console.WriteLine(focus.HowManyWhell().ToString());
            Console.WriteLine(focus.WhatIsDefaultColor().ToString());

            Civic civic = new();
            Console.WriteLine(civic.WhichCompanyCar().ToString());
            Console.WriteLine(civic.HowManyWhell().ToString());
            Console.WriteLine(civic.WhatIsDefaultColor().ToString());

        }

    }
}
