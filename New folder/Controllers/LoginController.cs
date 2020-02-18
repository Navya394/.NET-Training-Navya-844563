using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAVYAHANDSON.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index( string input1,int input2)
        {
            NAVYAEntities2 obj = new NAVYAEntities2();
            var userid = from i in obj.USERINFOes where (i.USERNAME == input1) && (i.PASSWD == input2) select i.USERID;
            var uid = userid.FirstOrDefault();
            if(uid!=0)
            {
                var data = from i in obj.USERDETAILS where (i.USERID == uid) select i;
                var name = data.FirstOrDefault();
                ViewBag.name = name.NAME;
                ViewBag.age = name.AGE;
                ViewBag.city = name.CITY;
                ViewBag.reportingto = name.REPORTINGTTO;
                return View();
   }
           else
            {
                return View("failed login");
            }
        }
    }
}