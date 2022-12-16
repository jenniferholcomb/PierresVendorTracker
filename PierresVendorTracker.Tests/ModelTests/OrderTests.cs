using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void OrderConstuctor_CreatesInstanceOfOrder_Order()
    {
      // Arrange
      Order newOrder = new Order("test order");

      // Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetItem_ReturnsItem_String()
    {
      // Arrange
      string item = "baguette";

      // Act
      Order newVendor = new Order(item);
      string result = newOrder.item;

      // Assert
      Assert.AreEqual(newVendor, result);

    }

    [TestMethod]
    public void SetItem_SetOrderItem_String()
    {
      // Arrange
      string item = "baguette";
     Order newOrder = new Order(item);

      // Act
      string updateItem = "croissant";
      newOrder.Item = updateItem;
      string result = newOrder.Item;

      // Assert
      Assert.AreEqual(updateItem, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      string order01 = "baguette";
      string order02 = "croissant";
      Order newOrder1 = new Order(order01);
      Order newOrder2 = new Order(order02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }


  }
}