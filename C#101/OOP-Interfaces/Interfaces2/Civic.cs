using System;

namespace Interfaces2 {

    public class Civic : IVehicle
    {

        public int HowManyWheels()
        {
            return 4;
        }

        public Color WhatIsDefaultColor()
        {
            return Color.Red;
        }

        public Make WhichCompanyCar()
        {
            return Make.Honda;
        }
    }
}