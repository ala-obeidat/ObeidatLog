using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObeidatLog.Logger;

namespace ObeidatLog.WebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Caller.Instance.Debug("Web", "Alaa", @"Id: 10, Page: 15 ,Password:123, Image: data:image/png;base64,iVBO++Rw0KGgoAAAANSUhEUgAAB0IAAAQ4CAIAAeXiM/H/wAAAABJRU5ErkJggg==, Data:Welcome to home , Other Image is  data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAB0IAAAQ4CAIAAeXiM/H/wAAAABJRU5ErkJggg==");
            Caller.Instance.Info("Love", "I love you");
            Caller.Instance.LogException(new Exception("HOPE"), "Love");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}