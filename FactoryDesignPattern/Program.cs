// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern;

Console.WriteLine("Hello, World!");

var NewDish = DishFactory.CreateAppitezerDish("ChieckenSalat");
NewDish.Serve();
