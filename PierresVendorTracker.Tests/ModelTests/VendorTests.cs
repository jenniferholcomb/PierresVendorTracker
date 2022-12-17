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
      Vendor newVendor = new Vendor("test vendor", "test vendor type");

      // Assert
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      // Arrange
      string venName = "Suzie's cafe";
      string venType = "restaurant";

      // Act
      Vendor newVendor = new Vendor(venName, venType);
      string result = newVendor.VenName;

      // Assert
      Assert.AreEqual(venName, result);

    }

    [TestMethod]
    public void SetName_SetVendorName_String()
    {
      // Arrange
      string venName = "Suzie's cafe";
            string venType = "restaurant";
      Vendor newVendor = new Vendor(venName, venType);

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
      string venType01 = "restaurant";
      string venType02 = "market";
      Vendor newVendor1 = new Vendor(vendor01, venType01);
      Vendor newVendor2 = new Vendor(vendor02, venType02);
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
      string title = "baguette";
      string description = "wheat";
      int quantity = 20;
      int price = 2;
      string frequency = "weekly";
      string date = "12/16/2022";
      Order newOrder = new Order(title, description, quantity, price, frequency, date);
      List<Order> newList = new List<Order> { newOrder };
      string vendor01 = "Suzie's cafe";
      string venType = "restaurant";
      Vendor newVendor = new Vendor(vendor01, venType);

      // Act
      newVendor.AddItem(newOrder);
      List<Order> result = newVendor.OrderItems;

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      // Arrange
      string venName = "Suzie's Cafe";
      string venType = "restaurant";
      Vendor newVendor = new Vendor(venName, venType);

      // Act
      int result = newVendor.Id;

      // Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsVendorFromId_Vendor()
    {
      // Arrange
      string venName = "Suzie's Cafe";
      string venType = "restaurant";
      Vendor newVendor = new Vendor(venName, venType);

      // Act
      Vendor result = Vendor.Find(1);

      // Assert
      Assert.AreEqual(newVendor, result);
    }

  }
}