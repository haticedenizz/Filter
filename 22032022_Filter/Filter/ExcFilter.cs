using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _22032022_Filter.Filter
{
    public class ExcFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            filterContext.Controller.TempData["hata"] = filterContext.Exception;
            filterContext.Result = new RedirectResult("/Login/Error");
           
        }
    }
}