using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Controllers
{
 public class OrdersController : Controller
 {

  [HttpGet("/vendors/{vendorID}/orders/new")]
  public ActionResult New(int vendorID)
  {
   Vendor vendor = Vendor.Find(vendorID);
   return View(vendor);
  }

  [HttpGet("/vendors/{vendorID}/orders/{orderID}")]
  public ActionResult Show(int vendorID, int orderID)
  {
   Order order = Order.Find(orderID);
   Vendor vendor = Vendor.Find(vendorID);
   Dictionary<string, object> model = new Dictionary<string, object>();
   model.Add("order", order);
   model.Add("vendor", vendor);
   return View(model);
  }

 }
}
