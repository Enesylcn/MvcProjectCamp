using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class IstatistikController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            ViewBag.Value = c.Categories.Count().ToString();
            ViewBag.Valu = c.Headings.Include("Yazılım").Where(x => x.CategoryID == 12).Count().ToString();
            ViewBag.Val = c.Writers.Where(x => x.WriterName.Contains("a")).Count().ToString();
            return View();
        }
    }
}