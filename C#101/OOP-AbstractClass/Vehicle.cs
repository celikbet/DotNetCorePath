using System;

namespace OOPAbstractClass {

    public abstract class Vehicle {
        public int HowManyWheels() {
            return 4;
        }

        public virtual Color WhatIsDefaultColor() {
            return Color.White;
        }

        public abstract Make WhichCompanyCar();
    }
}

