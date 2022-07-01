using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    public int PastryOrderTotal { get; set; }
    public Pastry  (int PastryOrder)
    {
      PastryOrder = PastryOrder;
      PastryOrderTotal = 0;
    }

    
  }
}