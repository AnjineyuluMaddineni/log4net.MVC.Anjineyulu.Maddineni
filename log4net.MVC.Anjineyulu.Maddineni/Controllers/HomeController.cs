using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace log4net.MVC.Anjineyulu.Maddineni.Controllers
{
    public class HomeController : Controller
    {
        ILog log = log4net.LogManager.GetLogger(typeof(HomeController));
        // GET: Home
        public ActionResult Index()
        {
            log.Info("Index View fired");
            try
            {
                object o2 = null;
                int i2 = (int)o2;   // Error
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            log.Info("Index View completed");
            return View();           
        }
    }
}