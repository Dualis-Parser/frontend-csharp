using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using dualis_frontend.Models;


namespace dualis_frontend.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            Session["username"] = "gahr.leonhard@dh-karlsruhe.de";
            Session["password"] = "n7%\\YT^IoAE0";

            if (Session["username"] != null && Session["password"] != null)
            {
                return RedirectToAction("Grades", "Home");
            }

            return View();
        }

        public async Task<ActionResult> Grades()
        {
            ViewBag.Data =
                (await JsonResponse.parseDataForUser((string) Session["username"], (string) Session["password"])).data;

            return View();
        }

        public ActionResult Imprint()
        {
            return View();
        }
    }
}