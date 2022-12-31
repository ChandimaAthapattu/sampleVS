using System;
namespace FoodTruck
{
    public class FoodTruck : Truck
    {
        private Cook cook;

        public FoodTruck(Cook cook)
        {
            this.cook = cook;
        }

        public void setCook(Cook cook)
        {
            this.cook = cook;
        }

        public void cook_food(String food)
        {
            this.cook.cook(food);
        }
    }
}