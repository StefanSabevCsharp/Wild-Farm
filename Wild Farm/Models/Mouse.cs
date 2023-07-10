using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wild_Farm.Food;

namespace Wild_Farm.Models
{
    public class Mouse : Mammal
    {
        const double weightIncrease = 0.10;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, weightIncrease, livingRegion)
        {
        }
        public double WeightIncrease => weightIncrease;
        public override IReadOnlyCollection<Type> PreferedFood => new List<Type>() { typeof(Vegetable), typeof(Fruit) };
        public override string ProduceSound()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
