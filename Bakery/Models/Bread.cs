using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    public int BreadOrder { get; set; }
    public int BreadRegPrice { get; set; }
    public int BreadOrderTotal { get; set; }
    public Bread  (int breadOrder)
    {
      BreadOrder = breadOrder;
      BreadRegPrice = 0;
      BreadOrderTotal = 0;
    }

    public int BreadRegularPrice()
    {
    for (int i = 1; i <= BreadOrder; i++)
    {
      if ((i % 3) == 0) 
      {
      
        BreadRegPrice -= 0;
      }
      else
      {
        BreadRegPrice += 5; 
      }
      
    }
    return BreadRegPrice;
    }







  }
}