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
    
    [TestMethod]
    public void GetVendorName_ReturnVendorNameAndDescription_String()
    {
      string vendorName = "Bob The Builder";
      string Description = "He sells me the good good build build";
      Vendor newVendor = new Vendor(vendorName, Description);
      string vendorNameResult = newVendor.Name;
      string descriptionResult = newVendor.Description;
      Assert.AreEqual(vendorName, vendorNameResult);
      Assert.AreEqual(Description, descriptionResult);
    }

    [TestMethod]
    public void GetVendorId_ReturnsVendorId_Int()
    {
      string vendorName = "Totally not an AI";
      string Description = "Real person that I buy real product from";
      Vendor newVendor = new Vendor(vendorName, Description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}