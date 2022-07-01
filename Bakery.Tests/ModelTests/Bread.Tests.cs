using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadPrice_BreadPriceForTwo_int()
    {
      Bread newBread = new Bread(2);
      newBread.BreadPrice();
      Assert.AreEqual(10, newBread.BreadOrderTotal);
    }

    [TestMethod]
    public void BreadPrice_BreadPriceForThree_int()
    {
      Bread newBread = new Bread(3);
      newBread.BreadPrice();
      Assert.AreEqual(10, newBread.BreadOrderTotal);
    }

    [TestMethod]
    public void BreadPrice_BreadPriceForSeven_int()
    {
      Bread newBread = new Bread(7);
      newBread.BreadPrice();
      Assert.AreEqual(25, newBread.BreadOrderTotal);
    }

    [TestMethod]
    public void BreadPrice_BreadPriceForEleven_int()
    {
      Bread newBread = new Bread(11);
      newBread.BreadPrice();
      Assert.AreEqual(40, newBread.BreadOrderTotal);
    }
  
    [TestMethod]
    public void BreadPrice_BreadPriceForTwelve_int()
    {
      Bread newBread = new Bread(12);
      newBread.BreadPrice();
      Assert.AreEqual(40, newBread.BreadOrderTotal);
    }
  }
}