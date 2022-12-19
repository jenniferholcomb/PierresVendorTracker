using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public string Frequency { get; set; }
    public string Date { get; set; }
    public int Id { get; }

    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, int quantity, int price, string frequency, string date)
    {
      Title = title;
      Description = description;
      Quantity = quantity;
      Price = price;
      Frequency = frequency;
      Date = date;
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

    public static Order Find(int orderId)
    {
      return _instances[orderId - 1];
    }
  }
}