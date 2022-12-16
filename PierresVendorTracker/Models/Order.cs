using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Item { get; set; }

    private static List<Order> _instances = new List<Order> {};
  

    public Order(string itemOrdered)
    {
      Item = itemOrdered;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}