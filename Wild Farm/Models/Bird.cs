using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wild_Farm.Models
{
    public abstract class Bird : Animal
    {
        double weightIncrease;

        public Bird(string name, double weight, double wingSize,double weightIncrease)
            : base(name, weight, weightIncrease)
        {
            WingSize = wingSize;
            

        }
        public double WeightIncrease => weightIncrease;
        public double WingSize { get; private set; }


    }
}
