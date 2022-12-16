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
      return RedirectToAction("Index");
    }

    // [HttpGet]
    // public ActionResult Show(int vendorId)
    // {
    //   Vendor currentVendor = Vendor.Find(vendorId);
    //   return View(currentVendor);
    // }
  }
}
