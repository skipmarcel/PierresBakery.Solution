using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class HomeController : Controller
  {

[HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

  }
}
