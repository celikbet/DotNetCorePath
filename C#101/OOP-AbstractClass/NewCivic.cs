using System;

namespace OOPAbstractClass {

    public class NewCivic : Vehicle
    {
        public override Make WhichCompanyCar()
        {
            return Make.Honda;
        }

        public override Color WhatIsDefaultColor()
        {
            return Color.Grey;
        }
    }
}