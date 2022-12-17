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
      string title = "baguette";
      string description = "wheat";
      int quantity = 20;
      int price = 2;
      string frequency = "weekly";
      string date = "12/16/2022";
      Order newOrder = new Order(title, description, quantity, price, frequency, date);

      // Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      // Arrange
      string title = "baguette";
      string description = "wheat";
      int quantity = 20;
      int price = 2;
      string frequency = "weekly";
      string date = "12/16/2022";

      // Act
      Order newOrder = new Order(title, description, quantity, price, frequency, date);
      string result = newOrder.Title;

      // Assert
      Assert.AreEqual(title, result);

    }

    [TestMethod]
    public void SetTitle_SetOrderTitle_String()
    {
      // Arrange
      string title = "baguette";
      string description = "wheat";
      int quantity = 20;
      int price = 2;
      string frequency = "weekly";
      string date = "12/16/2022";
      Order newOrder = new Order(title, description, quantity, price, frequency, date);

      // Act
      string updateTitle = "croissant";
      newOrder.Title = updateTitle;
      string result = newOrder.Title;

      // Assert
      Assert.AreEqual(updateTitle, result);
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
      string title = "baguette";
      string description = "wheat";
      int quantity = 20;
      int price = 2;
      string frequency = "weekly";
      string date = "12/16/2022";
      string title2 = "croissant";
      string description2 = "chocolate chip";
      int quantity2 = 12;
      int price2 = 3;
      string frequency2 = "weekly";
      string date2 = "12/16/2022";
      Order newOrder1 = new Order(title, description, quantity, price, frequency, date);
      Order newOrder2 = new Order(title2, description2, quantity2, price2, frequency2, date2);
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
      string title = "baguette";
      string description = "wheat";
      int quantity = 20;
      int price = 2;
      string frequency = "weekly";
      string date = "12/16/2022";
      Order newOrder = new Order(title, description, quantity, price, frequency, date);

      // Act
      int result = newOrder.Id;

      // Assert
      Assert.AreEqual(1, result);
    }
  }
}