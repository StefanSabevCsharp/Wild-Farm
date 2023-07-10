using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wild_Farm.Food;
using Wild_Farm.Interfaces;

namespace Wild_Farm.Factories
{
    public class FoodFactoryCreator
    {
        public static IFood FoodCreator(string[] foodInfo)
        {
            string foodType = foodInfo[0];
            int foodQuantity = int.Parse(foodInfo[1]);

            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(foodQuantity);
                case "Seeds":
                    return new Seeds(foodQuantity);
                case "Meat":
                    return new Meat(foodQuantity);
                case "Fruit":
                    return new Fruit(foodQuantity);
                default:
                    throw new ArgumentException("Invalid food type!");
            }
        }
    }
}
