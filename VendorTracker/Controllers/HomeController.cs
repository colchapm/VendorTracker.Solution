using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}