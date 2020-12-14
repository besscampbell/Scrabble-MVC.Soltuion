using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Controllers
{
    public class HomeController : Controller
    {
        // [Route("/")]
        public ActionResult ProjectSpec() { return View(); }     
    }
}