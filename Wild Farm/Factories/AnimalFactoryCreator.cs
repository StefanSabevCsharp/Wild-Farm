using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wild_Farm.Interfaces;
using Wild_Farm.Models;

namespace Wild_Farm.Factories
{
    public class AnimalFactoryCreator
    {
        public static IAnimal CreateAnimal(string type, string name, double weight, params string[] args)
        {
            switch (type)
            {
                  case "Cat":
                    return new Cat(name, weight, args[0], args[1]);
                case "Tiger":
                    return new Tiger(name, weight, args[0], args[1]);
                case "Owl":
                    return new Owl(name, weight, double.Parse(args[0]));
                case "Hen":
                    return new Hen(name, weight, double.Parse(args[0]));
                case "Mouse":
                    return new Mouse(name, weight, args[0]);
                case "Dog":
                    return new Dog(name, weight, args[0]);
                default:
                    throw new ArgumentException("Invalid animal type!");
            }
        }
    }
}
