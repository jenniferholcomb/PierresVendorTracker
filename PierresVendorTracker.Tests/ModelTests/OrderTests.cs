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
      Order.ClearAll();
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
      Order newOrder = new Order(item);
      string result = newOrder.Item;

      // Assert
      Assert.AreEqual(item, result);

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
      List<Order> newOrderList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newOrderList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string item01 = "baguette";
      string item02 = "croissant";
      Order newOrder1 = new Order(item01);
      Order newOrder2 = new Order(item02);
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newOrderList, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      // Arrange
      string item = "baguette";
      Order newOrder = new Order(item);

      // Act
      int result = newOrder.Id;

      // Assert
      Assert.AreEqual(1, result);
    }
  }
}