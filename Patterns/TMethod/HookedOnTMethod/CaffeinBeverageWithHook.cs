using System;

namespace Patterns.TMethod.HookedOnTMethod
{
    public abstract class CaffeinBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();

            if (CustomerWantsCondiments())
            {
                AddCondiments();                
            }
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
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