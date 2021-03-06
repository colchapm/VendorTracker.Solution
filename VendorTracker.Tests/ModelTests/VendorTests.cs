using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Red River Run Golf Club";
      Vendor newVendor = new Vendor(name, "test");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Vendor";
      Vendor newVendor = new Vendor("test", description);

      //Act
      string updatedDescription = "GoldVendor";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      //Arrange
      List<Vendor> newList = new List<Vendor> {};

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      Vendor newVendor1 = new Vendor("Red River Run Golf Club", "Vendor");
      Vendor newVendor2 = new Vendor("Reed College", "Vendor");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arange
      Vendor newVendor = new Vendor("Red River Run Golf Club", "Vendor");
      
      //Act 
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      Vendor newVendor1 = new Vendor("Red River Run Golf Club", "Vendor");
      Vendor newVendor2 = new Vendor("Reed College", "Vendor");

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string name = "Croissants";
      string description = "25 chocolate croissants";
      int price = 30;
      string date = "5/1/21";
      Order newOrder = new Order(name, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Blue Kangoroo Coffee Roasters";
      string vendorDescription = "Vendor";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);

    }
  }
}