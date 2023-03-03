using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_VendorObj()
    {
      Vendor newVendor = new Vendor("test vendor", "Sells General Goods");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  }
}