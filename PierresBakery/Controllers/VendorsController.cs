using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Controllers
{
  public class VendorController : Controller
  {

   [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string description)
    {
      Vendor myVendor = new Vendor(description);
      return RedirectToAction("Index");
    }

  }
}
