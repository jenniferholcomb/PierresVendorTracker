using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string VenName { get; set; }

    private static List<Vendor> _instances = new List<Vendor> {};
  

    public Vendor(string vendorName)
    {
      VenName = vendorName;
      _instances.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}