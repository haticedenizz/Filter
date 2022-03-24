using _22032022_Filter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22032022_Filter.Filter
{
    public class ResFilter : FilterAttribute, IResultFilter
    {
        DatabaseContext db = new DatabaseContext(); 
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            db.Loglar.Add(new LogTable()
            {
                KullaniciAdi = "deneme",
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                Tarih = DateTime.Now,
                Bilgi = "View Çalıştı"

            }) ; 
            db.SaveChanges();

        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            db.Loglar.Add(new LogTable()
            {
                KullaniciAdi = "deneme",
                ActionName = filterContext.RouteData.Values["action"].ToString(),
                ControllerName = filterContext.RouteData.Values["controller"].ToString(),
                Tarih = DateTime.Now,
                Bilgi = "View çalışıyor"

            });
            db.SaveChanges();

        }
    }
}