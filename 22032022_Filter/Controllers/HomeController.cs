using _22032022_Filter.Filter;
using _22032022_Filter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22032022_Filter.Controllers
{
    [ActFilter]
    public class HomeController : Controller
    {
        // GET: Home
        [ResFilter]
        public ActionResult Index()
        {
            return View();
        }
       
        [ExcFilter]
        public ActionResult Index2()
        {
            int sayi = 0;
            int deger = 100 /sayi;

            return View();
        }
      
        public ActionResult Index3(int? id)
        {
            return View();
        }
    }
}