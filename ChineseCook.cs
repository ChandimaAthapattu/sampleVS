using System;
namespace FoodTruck
{
	public class ChineseCook : Cook
	{

        public override void cook(string food)
        {
            Console.WriteLine("Cooking " + food + " in chinese");
        }
    }
}

