using Log4netMVC.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Log4netMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(Server.MapPath("/log4net.config")));

        }
        /// <summary>
        ///  程序出错时通过lognet写日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Error(Object sender, EventArgs e)
        {
            Exception objExp = HttpContext.Current.Server.GetLastError();
            LogHelper.ErrorLog("\r\n客户机IP:" + Request.UserHostAddress + "\r\n错误地址:" + Request.Url
                + "\r\n异常信息:" + Server.GetLastError().Message, objExp);
        }
    }
}
