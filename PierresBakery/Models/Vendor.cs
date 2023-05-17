using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Vendor
  {
    public string Description { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string description)
    {
      Description = description;
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
