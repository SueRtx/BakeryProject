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
    for (int i = 0; i < BreadOrder; i++)
    {
      BreadRegPrice += 5;
    }
    return BreadRegPrice;
    }







  }
}