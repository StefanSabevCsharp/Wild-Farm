using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wild_Farm.Food;

namespace Wild_Farm.Models
{
    public class Cat : Feline
    {
        const double weightIncrease = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, weightIncrease, livingRegion,breed)
        {
            Breed = breed;
        }
        public double WeightIncrease => weightIncrease;
        public string Breed { get;private set; }
        public override IReadOnlyCollection<Type> PreferedFood => new List<Type>() { typeof(Vegetable), typeof(Meat)};
        public override string ProduceSound()
        {
            return "Meow";
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
