using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wild_Farm.Food;

namespace Wild_Farm.Models
{
    public class Dog : Mammal
    {
        const double weightIncrease = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, weightIncrease, livingRegion)
        {
        }
        //public double WeightIncrease => weightIncrease;
        public override IReadOnlyCollection<Type> PreferedFood => new List<Type>() {typeof(Meat) };
        public override string ProduceSound()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
