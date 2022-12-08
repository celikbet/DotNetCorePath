using System;

namespace Interfaces2 {

    public class Focus : IVehicle
    {
        public int HowManyWhell()
        {
            return 4;
        }

        public Color WhatIsDefaultColor()
        {
            return Color.White;
        }

        public Make WhichCompanyCar()
        {
            return Make.Ford;
        }
    }
}
