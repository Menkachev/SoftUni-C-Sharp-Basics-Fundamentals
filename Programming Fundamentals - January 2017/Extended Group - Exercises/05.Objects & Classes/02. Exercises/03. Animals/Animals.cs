namespace _03.Animals
{
    using System;
    using System.Collections.Generic;

    public class Animals
    {
        public static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            // 3 collections, to store the different animals inside them:
            Dictionary<string, Dog> dogs = new Dictionary<string, Dog>();
            Dictionary<string, Cat> cats = new Dictionary<string, Cat>();
            Dictionary<string, Snake> snakes = new Dictionary<string, Snake>();

            while (inputLine != "I'm your Huckleberry")
            {
                var inputParams = inputLine
                    .Split(' ');

                if (inputParams.Length > 2) // Because of the "talk {name}" command.
                {
                    //{class} {name} {age} {parameter}
                    string animalClass = inputParams[0];
                    string name = inputParams[1];
                    int age = int.Parse(inputParams[2]);
                    int parameter = int.Parse(inputParams[3]);

                    switch (animalClass)
                    {
                        case "Dog":
                            Dog newDog = new Dog();

                            newDog.Name = name;
                            newDog.Age = age;
                            newDog.NumberOfLegs = parameter;

                            dogs.Add(newDog.Name, newDog);
                            break;
                        case "Cat":
                            Cat newCat = new Cat();

                            newCat.Name = name;
                            newCat.Age = age;
                            newCat.IntelligenceQuotient = parameter;

                            cats.Add(newCat.Name, newCat);
                            break;
                        case "Snake":
                            Snake newSnake = new Snake();

                            newSnake.Name = name;
                            newSnake.Age = age;
                            newSnake.CrueltyCoefficient = parameter;

                            snakes.Add(newSnake.Name, newSnake);
                            break;
                    }
                }
                else
                {
                    string animalName = inputParams[1];

                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }
                    else if (cats.ContainsKey(animalName))
                    {
                        cats[animalName].ProduceSound();
                    }
                    else if (snakes.ContainsKey(animalName))
                    {
                        snakes[animalName].ProduceSound();
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}