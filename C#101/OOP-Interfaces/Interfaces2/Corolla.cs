using System;

namespace Interfaces2 {

    public class Corolla : IVehicle
    {
        public int HowManyWhell()
        {
            return 4;
        }

        public Color WhatIsDefaultColor()
        {
            return Color.Grey;
        }

        public Make WhichCompanyCar()
        {
            return Make.Toyota;
        }
    }
}