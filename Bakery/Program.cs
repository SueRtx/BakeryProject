using System;
using Bakery;

public class Program
{
  public static void Main()
  {
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(@"
          SUNNY BAKERY
    <-------- Menu -------->
    |                      |
    |        *Bread*       |
    |       1 for $ 5      |
    |  Buy 2 Get One FREE  |
    |      (3 FOR $ 10)    |
    |                      |
    |       *Pastry*       |
    |      1 for $ 2       |
    |  Buy 3 Get $ 1 Off   |
    |     (3 for $ 5)      |
    |                      |
    <---------------------->");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to Sunny Bakery!");
    SkipMenu();
    static void SkipMenu()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("How many bread would you like to order?");
      int breadOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("How Many Pastries would you like to order?");
      int pastryOrder = int.Parse(Console.ReadLine());
      Bread newBread = new Bread (breadOrder);
      newBread.BreadPrice();
      Pastry newPastry = new Pastry (pastryOrder);
      newPastry.PastryPrice();
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine(" ");
      Console.WriteLine("<<< Your Order >>>");
      Console.WriteLine("Bread :" + " " + breadOrder + " " + "for $" + " " +  newBread.BreadOrderTotal);
      Console.WriteLine("Pastry:" + " " + pastryOrder + " " + "for $" + " " + newPastry.PastryOrderTotal);
      Console.WriteLine(" ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Do you want to change your order? (Yes/No)");
      string orderAnswer = Console.ReadLine().ToLower();
      if (orderAnswer == "yes")
      {
        SkipMenu();
      }
      else 
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Your Total is: $" + " " + (newBread.BreadOrderTotal + newPastry.PastryOrderTotal));
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Thank you!");
        Console.WriteLine("Have a Nice Day!");
      }
    }
  }
}