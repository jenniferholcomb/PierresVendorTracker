using System.Collections.Generic;
// using System;
using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, bool vendorType1 = false, bool vendorType2 = false, bool vendorType3 = false)
    {
      string vendorType = "";
      if (vendorType1)
      {
        vendorType = "restaurant";
      }
      if (vendorType2)
      {
        vendorType = "market";
      }
      if (vendorType3)
      {
        vendorType = "wholesale distributor";
      }
      Vendor newVendor = new Vendor(vendorName, vendorType);
      return RedirectToAction("Index", "/");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      List<Order> vendorOrders = foundVendor.OrderItems;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

    [HttpPost("/vendors/{vendorId}")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderQuantity, int orderPrice, string orderFrequency, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderQuantity, orderPrice, orderFrequency, orderDate);
      foundVendor.AddItem(newOrder);
      List<Order> vendorOrders = foundVendor.OrderItems;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    } 
  } 
}

