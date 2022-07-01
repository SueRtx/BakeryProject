using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryPrice_PastryPriceForTwo_int()
    {
      Pastry newPastry = new Pastry(2);
      newPastry.PastryPrice();
      Assert.AreEqual(4, newPastry.PastryOrderTotal);
    }

    [TestMethod]
    public void PastryPrice_PastryPriceForThree_int()
    {
      Pastry newPastry = new Pastry(3);
      newPastry.PastryPrice();
      Assert.AreEqual(5, newPastry.PastryOrderTotal);
    }

    [TestMethod]
    public void PastryPrice_PastryPriceForFour_int()
    {
      Pastry newPastry = new Pastry(4);
      newPastry.PastryPrice();
      Assert.AreEqual(7, newPastry.PastryOrderTotal);
    }






  }
}