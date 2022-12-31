using System;
namespace FoodTruck
{
	public class IndianCook : Cook
    { 

        public override void cook(string food)
        {
            Console.WriteLine("Cooking " + food + " in indian");
        }
    }
}

