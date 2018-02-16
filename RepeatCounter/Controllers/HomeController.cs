using Microsoft.AspNetCore.Mvc;
using RepeatCounter.Models;

namespace RepeatCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      string fakeString = "";
      return View("Index", fakeString);
    }
  }
}
