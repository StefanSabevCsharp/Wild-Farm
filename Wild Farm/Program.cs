using System.Security.Cryptography.X509Certificates;
using Wild_Farm.Factories;
using Wild_Farm.Food;
using Wild_Farm.Interfaces;
using Wild_Farm.Models;


string command;
List<IAnimal> animals = new List<IAnimal>();
while((command = Console.ReadLine()) != "End")
{
    string[] animalInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string[] foodInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
	try
	{
        IAnimal animal = AnimalFactoryCreator.CreateAnimal(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo.Skip(3).ToArray());
        IFood food = FoodFactoryCreator.FoodCreator(foodInfo);
        animals.Add(animal);
        Console.WriteLine(animal.ProduceSound());
        animal.Feed(food);
    }
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
    }
   
}
foreach (var animal in animals)
{
    Console.WriteLine(animal);
}
