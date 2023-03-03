using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }
  [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}