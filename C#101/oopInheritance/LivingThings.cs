using System;

namespace oopInheritance
{

    public class LivingThings
    {
        protected void Nutrition() {
            Console.WriteLine("Living things feed");
        }

        protected void Respiratory() {
            Console.WriteLine("Living things breath");
        }

        protected void Excretion() {
            Console.WriteLine("Living things excretize");
        }
    }
}