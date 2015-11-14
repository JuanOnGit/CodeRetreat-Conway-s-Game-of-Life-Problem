using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CodeRetreat_Conway_s_Game_of_Life_Problem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
