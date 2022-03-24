using _22032022_Filter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22032022_Filter.Filter
{
    public class ActFilter : FilterAttribute, IActionFilter
    {
        DatabaseContext db = new DatabaseContext();
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            db.Loglar.Add(new LogTable()
            {
                 KullaniciAdi = "deneme",
                 ActionName=filterContext.ActionDescriptor.ActionName,
                 ControllerName=filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                 Tarih=DateTime.Now,
                 Bilgi="Action bitti"

            }) ;
            db.SaveChanges();
            //log tablosuna veri at
        }
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            db.Loglar.Add(new LogTable()
            {
                KullaniciAdi = "deneme",
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Tarih = DateTime.Now,
                Bilgi = "Action çalışıyor"

            });
            db.SaveChanges();
        }
    }
}