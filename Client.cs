//Applying bridge pattern

using System;
namespace FoodTruck
{
	public class Client
	{

        public static void Main(String []args)
        {
            Cook c1 = new ChineseCook();
            Cook c2 = new IndianCook();
            Truck t1 = new FoodTruck(c1);
            FoodTruck ft1 = (FoodTruck)t1;
            ft1.cook_food("Rice");
            ft1.setCook(c2);
            ft1.cook_food("Chicken");
            ft1.move();
        }
	}
}


    