using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log4netMVC.Controllers
{
    public class HomeController : Controller
    {
        //private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // GET: Home
        public ActionResult Index()
        {
       
            try
            {
                int u = 0;
                var g = 1 / u;

            }
            catch (Exception e) {
                LogHelper.ErrorLog(e);
            }
            return View();
        }
    }
}