using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Pastry
  {
    public int PastryOrder {get; set;}
    public int PastryOrderTotal {get; set;}
    public Pastry  (int pastryOrder)
    {
      PastryOrder = pastryOrder;
      PastryOrderTotal = 0;
    }

    public int PastryPrice()
    {
    for (int i = 1; i <= PastryOrder; i++)
    {
      if ((i % 3) == 0) 
      {
        PastryOrderTotal += 1;
      }
      else
      {
        PastryOrderTotal += 2; 
      }
    }
    return PastryOrderTotal;
    }
  }
}