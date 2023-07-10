using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wild_Farm.Models
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, double weightIncrease, string livingRegion, string breed)
            : base(name, weight, weightIncrease, livingRegion)
        {
            Breed = breed;
        }
        public string Breed { get;private set; }
    }
}

