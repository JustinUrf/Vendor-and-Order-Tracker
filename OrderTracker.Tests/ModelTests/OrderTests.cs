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
      Order newOrder = new Order("Test", "placeholder", "placeholder", "placeholder");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_ReturnsOrderDescription_Stirng()
    {
      string Title = "Order of Flour";
      Order newOrder = new Order(Title, "placeholder", "placeholder", "placeholder");
      string result = newOrder.Title;

      Assert.AreEqual(Title, result);
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
      Order newOrder1 = new Order(description01, "placeholder", "placeholder", "placeholder");
      Order newOrder2 = new Order(description02, "placeholder", "placeholder", "placeholder");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersAreHaveAnID_IDValue()
    {
      string description = "This is useless, I want an ID!";
      Order newOrder = new Order(description, "placeholder", "placeholder", "placeholder");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    
    [TestMethod]
    public void Find_ReturnsCorrectOrderId_Order()
    {
      string description01 = "This is the first order!";
      string description02 = "This is the second order!";
      Order newOrder1 = new Order(description01, "placeholder", "placeholder", "placeholder");
      Order newOrder2 = new Order(description02, "placeholder", "placeholder", "placeholder");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void OrderConstructor_ReturnsAllPropertiesOfOrder_CompleteOrder()
    {
      string Title = "Order of Flour";
      string Description = "Running out of Excess Flour, 20lbs";
      string Price = "500$";
      string Date = "10/15/20";
      Order newOrder = new Order(Title, Description, Price, Date);
      string titleResult = newOrder.Title;
      string descriptionResult = newOrder.Description;
      string priceResult = newOrder.Price;
      string dateResult = newOrder.Date;
                        
      Assert.AreEqual(Title, titleResult);
      Assert.AreEqual(Description, descriptionResult);
      Assert.AreEqual(Price, priceResult);
      Assert.AreEqual(Date, dateResult);
      
    }

  }
}