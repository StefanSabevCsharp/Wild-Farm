using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wild_Farm.Food;

namespace Wild_Farm.Models
{
    public class Owl : Bird
    {
        const double weightIncrease = 0.25;

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize, weightIncrease)
        {
        }
        public override IReadOnlyCollection<Type> PreferedFood => new List<Type>() {typeof(Meat)};
        public override string ProduceSound()
        {
           return "Hoot Hoot";
        }
        public override string ToString()
        {
            return $"{base.ToString()}{WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
