using System;

namespace Patterns.TMethod.HookedOnTMethod
{
    public class CoffeeWithHook : CaffeinBeverageWithHook
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("adding sugar and milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("dripping coffee through filter");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }

            return false;
        }

        public string GetUserInput()
        {
            string answer = null;
            
            Console.WriteLine("would you like milk and sugar with your coffee (y/n)?");
            
            var input = Console.ReadLine();

            try
            {
                answer = input;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            if (answer == null) return "no";

            return answer;
        }
    }
}