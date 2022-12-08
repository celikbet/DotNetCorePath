using System;

namespace OOPInheritancePolymorphismSealedClass
{

    public class Plants: LivingThings
    {
        protected void PhotoSynthesis() {
            Console.WriteLine("Plants photosynthesize.");
        }

        public override void ReactionToStimuli()
        {
            //base.ReactionToStimuli();
            Console.WriteLine("Plants react to the Sun.");
        }
    }

    public class SeedPlants: Plants{
        public SeedPlants() {
            base.PhotoSynthesis();
            base.Nutrition();
            base.Respiratory();
            base.Excretion();
            base.ReactionToStimuli();
        }

        public void SeedProduce() {
            Console.WriteLine("Seed plants multiply by produced seeds");
        }

    }

    public class SeedlessPlantds: Plants{
        public SeedlessPlantds() {
            base.PhotoSynthesis();
            base.Nutrition();
            base.Respiratory();
            base.Excretion();
        }
        public void sporesProduce() {
            Console.WriteLine("Seedless plants reproduce using unicellular haploid spores.");
        }
    }
}