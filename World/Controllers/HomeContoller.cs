using World.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace World.Controllers
{
    public class HomeController : Controller
    {
        private readonly TreeContext _context;

        public HomeController(TreeContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}