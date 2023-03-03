using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

  [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_ReturnsOrderDescription_Stirng()
    {
      string Description = "Order of Flour";
      Order newOrder = new Order(Description);
      string result = newOrder.Description;

      Assert.AreEqual(Description, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAnEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList,result);
    }

    [TestMethod]
    public void GetAll_ReturnAllOrders_OrderList()
    {
      string description01 = "Order of Flour From Old Factory";
      string description02 = "Order of Eggs from Scandanavia 2.0";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}