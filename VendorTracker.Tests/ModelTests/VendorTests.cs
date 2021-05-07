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
      string description = "weekly bread order";
      Vendor newVendor = new Vendor("test", description);

      //Act
      string updatedDescription = "bi-weekly bread order";
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


  }
}