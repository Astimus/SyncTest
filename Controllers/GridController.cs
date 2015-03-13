using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4;
namespace MvcApplication4.Controllers
{
    public class GridController : Controller
    {
        //
        // GET: /Grid/
        public ActionResult GridFeatures()
        {
            var DataSource = new NorthwindDataContext().OrdersViews.ToList();
            ViewBag.datasource = DataSource;
            return View();
        }
    }
}
