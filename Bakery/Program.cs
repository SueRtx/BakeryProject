using System;
using Bakery;

public class Program
{
  public static void Main()
  {
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(@"
        Sunny Bakery
    -------- Menu --------
    |                    |
    |      *Bread*       |
    |     1 for $ 5      |
    | Buy 2 Get One FREE |
    |    (3 FOR $ 10)    |
    |                    |
    |      *Pastry*      |
    |     1 for $ 2      |
    |     3 for $ 5      |
    |     4 for $ 7      |
    |     6 FOR $ 10     |
    ----------------------");
    
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
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Bread :" + " " + breadOrder + " " + "for $" + newBread.BreadOrderTotal);
      Console.WriteLine("Pastry :" + " " + pastryOrder + " " + "for $" + newPastry.PastryOrderTotal);
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Total: $" + (newBread.BreadOrderTotal + newPastry.PastryOrderTotal));
    }
  }
}