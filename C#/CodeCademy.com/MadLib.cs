using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a madlib test program
      Author: Riffy_Divine
      */


      // Let the user know that the program is starting:
      Console.WriteLine("...Booting MadLib...");

      // Give the Mad Lib a title:
      string title = "This is the MadLib, begin.";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      Console.Write("Enter an adjective: ");
      string adjectiveOne = Console.ReadLine();
      Console.Write("Enter another adjective: ");
      string adjectiveTwo = Console.ReadLine();
      Console.Write("One more adjective: ");
      string adjectiveThree = Console.ReadLine();
      Console.Write("Enter a verb: ");
      string verbOne = Console.ReadLine();
      Console.Write("Enter a noun: ");
      string nounOne = Console.ReadLine();
      Console.Write("Enter one more noun: ");
      string nounTwo = Console.ReadLine();
      Console.WriteLine("Okay, half way there.");
      Console.Write("Enter an animal: ");
      string animalOne = Console.ReadLine();
      Console.Write("Enter a food: ");
      string foodOne = Console.ReadLine();
      Console.Write("Enter a fruit: ");
      string fruitOne = Console.ReadLine();
      Console.Write("Enter a superhero: ");
      string superheroOne = Console.ReadLine();
      Console.Write("Enter a country: ");
      string countryOne = Console.ReadLine();
      Console.Write("Enter a dessert: ");
      string dessertOne = Console.ReadLine();
      Console.Write("Enter a year: ");
      string yearOne = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animalOne}s were protesting to keep {foodOne} in stores. They began to {verbOne} to the rhythm of the {nounOne}, which made all the {fruitOne}s very {adjectiveThree}. Concerned, {name} texted {superheroOne}, who flew {name} to {countryOne} and dropped {name} in a puddle of frozen {dessertOne}. {name} woke up in the year {yearOne}, in a world where {nounTwo}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
