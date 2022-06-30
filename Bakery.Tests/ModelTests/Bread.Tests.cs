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
    public void BreadRegularPrice_ReturnBreadRegPrice_int()
    {
      Bread newBread = new Bread(2);
      newBread.BreadRegularPrice();
      Assert.AreEqual(10, newBread.BreadRegPrice);
    }

 
   
   

  }
}