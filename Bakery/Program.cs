using System;
//using Bakery;

public class Program
{
  public static void Main()
  {
    Console.WriteLine(@"
    Sunny Bakery

    ------ Menu ------

    Bread
    1 for $ 5
    Buy 2 Get One FREE

    Pastry
    1 for $ 2
    3 for $ 5
    4 for $ 7
    -------------------");

    SkipMenu();
    static void SkipMenu()
    {
      Console.WriteLine("How Many Bread?");
     // int breadOrder = int.Parse(Console.ReadLine());
      Console.WriteLine("How Many Pastries?");
     // int pastryOrder = int.Parse(Console.ReadLine());
      //Bread newBread = new Bread (breadOrder);
      //newBread.BreadPrice();
      //Pastry newPastry = new Pastry (pastryOrder);
      //newPastry.PastryPrice();
      Console.WriteLine("Total:");
     
    }
  }
}