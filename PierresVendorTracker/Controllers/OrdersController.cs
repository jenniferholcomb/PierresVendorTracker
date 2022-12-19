using System.Collections.Generic;
// using System;
using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;

namespace PierresOrders.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int orderId)
    {
      // Dictionary<string, object> model = new Dictionary<string, object>();
      // Vendor foundVendor = Vendor.Find(vendor.Id);
      // List<Order> vendorOrders = foundVendor.OrderItems;
      // model.Add("orders", vendorOrders);
      // model.Add("vendor", foundVendor);
      Order foundOrder = Order.Find(orderId);
      return View("Show", foundOrder);
    }
  }
}

// <h3>ORDER @Model["orders"].Id:</h3><br>

// <h5>@Model["orders"].Title</h5>
// <h5>@Model["orders"].Description</h5>
// <h5>@Model["orders"].Quantity</h5>
// <h5>@Model["orders"].Price</h5>
// <h5>@Model["orders"].Frequency</h5>
// <h5>@Model["orders"].Date</h5><br>