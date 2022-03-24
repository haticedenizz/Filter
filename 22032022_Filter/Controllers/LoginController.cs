using _22032022_Filter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22032022_Filter.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(Kullanici model)
        {
            DatabaseContext db = new DatabaseContext();

           Kullanici k=db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre);

            if(k==null)
            {
                ModelState.AddModelError("", "Hatalı kullanıcı adı yada şifre");
                return View(model);
            }
            else
            {
                Session["login"] = k;
                return RedirectToAction("Index", "Home");
            }
          
        }    
    
        public ActionResult Error()
        {
            if (TempData["hata"] == null)
                return RedirectToAction("Index", "Home");

            Exception model =(Exception)TempData["hata"];
            return View(model);
        }
    }
}