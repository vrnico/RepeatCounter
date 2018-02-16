using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using RepeatCounter.Models;
using RepeatCounter.Controllers;

namespace RepeatCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnCorrectView_True()
    {
      //arrange
      HomeController controller = new HomeController();

      //
      IActionResult indexView = controller.Index();
      ViewResult result = indexView as ViewResult;

      //
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
  }  
}
