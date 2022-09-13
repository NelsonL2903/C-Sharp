using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("My name is Nelson");

      // Asks user their age
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine("You are " + input + " years old!");
     }
  }
}
 