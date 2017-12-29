using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2.ViewModel;

namespace Assignment2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult show()
        {

            EmpDept list = new EmpDept()
            {
                Id = 101,
                EmployeeName = "Vinay",
                DeptId = 1,
                DepartmentName = "FS"
            };
            return View(list);
        }
    }
}