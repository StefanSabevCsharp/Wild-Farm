using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wild_Farm.Models
{
    public abstract class Mammal : Animal
    {
        double weightIncrease;
        private string name;
        private double weight;

        public Mammal(string name, double weight, double weightIncrease, string livingRegion)
            : base(name, weight, weightIncrease)
        {
            LivingRegion = livingRegion;
        }

        public double WeightIncrease => weightIncrease;
        public string LivingRegion { get;private set; }
       
    }
}
