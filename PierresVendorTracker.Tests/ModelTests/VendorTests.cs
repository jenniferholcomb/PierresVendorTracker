using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstuctor_CreatesInstanceOfVendor_Vendor()
    {
      // Arrange
      Vendor newVendor = new Vendor("test vendor");

      // Assert
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      // Arrange
      string venName = "Suzie's cafe";

      // Act
      Vendor newVendor = new Vendor(venName);
      string result = newVendor.VenName;

      // Assert
      Assert.AreEqual(venName, result);

    }

    [TestMethod]
    public void SetName_SetVendorName_String()
    {
      // Arrange
      string venName = "Suzie's cafe";
      Vendor newVendor = new Vendor(venName);

      // Act
      string newName = "Suzie's deli";
      newVendor.VenName = newName;
      string result = newVendor.VenName;

      // Assert
      Assert.AreEqual(newName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      // Arrange
      List<Vendor> newList = new List<Vendor> { };

      // Act
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      string vendor01 = "Suzie's Cafe";
      string vendor02 = "Bea's Bread Shop";
      Vendor newVendor1 = new Vendor(vendor01);
      Vendor newVendor2 = new Vendor(vendor02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddOrderItem_AssociatesOrderWithVendor_OrderItemList()
    {
      // Arrange
      string item = "baguette";
      Order newOrder = new Order(item);
      List<Order> newList = new List<Order> { newOrder };
      string vendor01 = "Suzie's cafe";
      Vendor newVendor = new Vendor(vendor01);

      // Act
      newVendor.AddItem(newOrder);
      List<Order> result = newVendor.OrderItems;

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}