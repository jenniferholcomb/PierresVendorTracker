using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
// using System.Collections.Generic;
// using System;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests 
  {

    [Test Method]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      // Arrange
      Vendor newVendor = new Vendor("test vendor");
      // Act
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
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Item> newList = new List<Item> { };

      // Act
      List<Item> result = Item.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      string vendor01 = "Suzie's Cafe";
      string vendor02 = "Bea's Bread Shop";
      Item newVendor1 = new Item(vendor01);
      Item newVendor2 = new Item(vendor02);
      List<Item> newList = new List<Item> { newVendor1, newVendor2 };

      //Act
      List<Item> result = Item.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void GetName_ReturnsName_String()
    // {
    //   // Act

    //   // Arrange

    //   // Assert
      
    // }
  }
}