using System;

namespace oopInheritance
{

    public class Animals: LivingThings
    {
        protected void Adaptation() {
            Console.WriteLine("Animals adapt.");
        }
    }

    public class Reptiles : Animals{

        public Reptiles() {
            base.Adaptation();
            base.Nutrition();
            base.Respiratory();
            base.Excretion();
        }
        public void crawling() {
            Console.WriteLine("Reptiles moves with their downward angled legs, so called crawling.");
        }

    }

    public class Birds : Animals{

        public Birds() {
            base.Adaptation();
            base.Nutrition();
            base.Respiratory();
            base.Excretion();
        }
        public void fly() {
            Console.WriteLine("Birds fly.");
        }
    }
}