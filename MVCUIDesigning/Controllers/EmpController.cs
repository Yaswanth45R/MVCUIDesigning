using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;

namespace MVCUIDesigning.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet]
        public ViewResult AddEmp()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult AddEmp(Employee Emp)
        {
                return RedirectToAction("AddEmp2", Emp);
        }
        public ViewResult AddEmp2(Employee Emp)
        {
            return View("EmpDisplay2", Emp);
        }
        public ViewResult CookiesTest1(int? Id,string Name,double? Price)
        {
            HttpCookie Cookie = new HttpCookie("ProductCookie");
            Cookie["Id"] = Id.ToString();
            Cookie["Name"] = Name;
            Cookie["Price"] = Price.ToString();
            Cookie.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(Cookie);
            return View();
        }
        public ViewResult CookiesTest2() 
        {
            return View();
        }
    }
}