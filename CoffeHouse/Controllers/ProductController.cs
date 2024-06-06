using System.Web.Mvc;

namespace CoffeHouse.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index() //Shop
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}