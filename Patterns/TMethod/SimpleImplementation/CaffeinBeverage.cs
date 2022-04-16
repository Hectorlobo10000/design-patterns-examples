using System;

namespace Patterns.TMethod.SimpleImplementation
{
    public abstract class CaffeinBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void AddCondiments();
        protected abstract void Brew();

        private void PourInCup()
        {
            Console.WriteLine("pouring into cup");
        }

        private void BoilWater()
        {
            Console.WriteLine("boiling water");
        }
    }
}