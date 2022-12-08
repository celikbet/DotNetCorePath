using System;

namespace OOPInheritancePolymorphismSealedClass
{

    class Program
    {
        static void Main(string[] args) 
        {
            //                            Living Things 
            //                                  |
            //              Plants                             Animals
            //         |                |                  |             |
            //     Seed Plants    Seedlees Plants       Reptiles        Birds


            SeedPlants seedPlants = new SeedPlants();
            seedPlants.SeedProduce();

            Console.WriteLine("***************");

            Birds seagull = new Birds();
            seagull.fly();

        }
    }
}