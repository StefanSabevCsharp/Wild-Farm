using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wild_Farm.Food;
using Wild_Farm.Interfaces;

namespace Wild_Farm.Models
{
    public class Hen : Bird
    {
        const double weightIncrease = 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize, weightIncrease)
        {
        }
     
        public override IReadOnlyCollection<Type> PreferedFood => new List<Type>() { typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds) };
        //public double WeightIncrease => weightIncrease;

        public override string ProduceSound()
        {
           return "Cluck";
        }
        public override string ToString()
        {
            return $"{base.ToString()}{WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
