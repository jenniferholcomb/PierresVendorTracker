using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string VenName { get; set; }
    public List<Order> OrderItems { get; set; }

    private static List<Vendor> _instances = new List<Vendor> {};
  

    public Vendor(string vendorName)
    {
      VenName = vendorName;
      _instances.Add(this);
      OrderItems = new List<Order> {};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void AddItem(Order orderItems)
    {
      OrderItems.Add(orderItems);
    }
  }
}