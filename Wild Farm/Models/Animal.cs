using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wild_Farm.Interfaces;

namespace Wild_Farm.Models
{
    public abstract class Animal : IAnimal
    {
        double weight;
        string name;
        int foodEaten;
        private double weightIncrease;

        public Animal(string name, double weight,double weightIncrease)
        {
            Name = name;
            Weight = weight;
            WeightIncrease = weightIncrease;
        }

        public string Name 
        { 
            get => name;
            private set
            {
                if(string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }
        public double Weight
        { 
            get => weight;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight cannot be zero or negative");
                }
                weight = value;
            }
        }
        public int FoodEaten { get; private set; }
        public double WeightIncrease { get;private set; }
        public virtual IReadOnlyCollection<Type> PreferedFood { get; private set; }
     
        public virtual void Feed(IFood food)
        {
            if(!PreferedFood.Contains(food.GetType()))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            FoodEaten += food.Quantity;
            Weight += food.Quantity * WeightIncrease;
           
        }
      
        public abstract string ProduceSound();
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, ";
        }
        
    }
}
