using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Item { get; set; }
    public int Id { get; }

    private static List<Order> _instances = new List<Order> {};

    public Order(string itemOrdered)
    {
      Item = itemOrdered;
      _instances.Add(this);
      Id = _instances.Count;
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