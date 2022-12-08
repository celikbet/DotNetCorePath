using System;

namespace OOPAbstractClass {

    public class NewCorolla : Vehicle
    {
        public override Make WhichCompanyCar()
        {
            return Make.Toyota;
        }
    }
}