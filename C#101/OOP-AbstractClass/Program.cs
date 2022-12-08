using System;

namespace OOPAbstractClass {

    public class Program {

        static void Main(string[] args) 
        {
            NewFocus newFocus = new();
            Console.WriteLine(newFocus.WhichCompanyCar().ToString());
            Console.WriteLine(newFocus.HowManyWheels().ToString());
            Console.WriteLine(newFocus.WhatIsDefaultColor().ToString());

            NewCivic newCivic = new();
            Console.WriteLine(newCivic.WhichCompanyCar().ToString());
            Console.WriteLine(newCivic.HowManyWheels().ToString());
            Console.WriteLine(newCivic.WhatIsDefaultColor().ToString());
            
        }
    }
}
