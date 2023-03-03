using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    public string Quantity { get; set; }
    
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    } 

  }
}

