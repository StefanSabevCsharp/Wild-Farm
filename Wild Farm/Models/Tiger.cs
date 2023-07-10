using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wild_Farm.Food;

namespace Wild_Farm.Models
{
    public class Tiger : Feline
    {
        const double increaseWeightPercentage = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, increaseWeightPercentage, livingRegion, breed)
        {

        }

        public double IncreaseWeightPercentage => increaseWeightPercentage;
        public override IReadOnlyCollection<Type> PreferedFood => new List<Type>() {typeof(Meat) };
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

    }
}
