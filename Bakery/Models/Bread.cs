using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    public int BreadOrder { get; set; }
    public int BreadOrderTotal { get; set; }
    public Bread  (int breadOrder)
    {
      BreadOrder = breadOrder;
      BreadOrderTotal = 0;
    }
  }
}