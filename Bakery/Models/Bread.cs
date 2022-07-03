using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    public int BreadOrder {get; set;}
    public int BreadOrderTotal {get; set;}
    public Bread  (int breadOrder)
    {
      BreadOrder = breadOrder;
      BreadOrderTotal = 0;
    }

    public int BreadPrice()
    {
    for (int i = 1; i <= BreadOrder; i++)
    {
      if ((i % 3) == 0) 
      {
        BreadOrderTotal += 0;
      }
      else
      {
        BreadOrderTotal += 5; 
      }
    }
    return BreadOrderTotal;
    }
  }
}