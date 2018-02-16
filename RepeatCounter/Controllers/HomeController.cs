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
    [HttpPost("/result")]
    public ActionResult Result()
    {
      string inputString = Request.Form["input-string"];
      string findString = Request.Form["find-string"];


      return View("Index");

    }
  }
}
