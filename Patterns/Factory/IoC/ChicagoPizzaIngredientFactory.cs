namespace Patterns.Factory.IoC
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new Marinara();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = {new Garlic(), new Onion(), new Mushroom()};
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicesPepperoni();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }
    }
}