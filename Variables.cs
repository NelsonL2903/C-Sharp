using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create Variables
      string name = "Shadow";
      string breed = "Golden Retriever";
      int age = 5;
      double weight = 65.22;
      bool spayed = true;

      // Print variables to the console
      Console.WriteLine("Name: " + name);
      Console.WriteLine("Breed: " + breed);
      Console.WriteLine("Age: " + age);
      Console.WriteLine("Weight: " + weight);
      Console.WriteLine("Spayed: " + spayed);

      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");
      string faveNumber = Console.ReadLine();

      // Turn that answer into an int
      int faveInt = Convert.ToInt32(faveNumber);
      Console.WriteLine("Your favourite number is " + faveInt);

    }
  }
}
