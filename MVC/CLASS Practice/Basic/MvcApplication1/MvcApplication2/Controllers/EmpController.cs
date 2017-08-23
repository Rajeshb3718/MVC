using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;


namespace MvcApplication2.Controllers
{
    public class EmpController : Controller
    {
        //
        // GET: /Emp/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addEmp()
        {
            EmployeeModel emp=new EmployeeModel();
            return View();
        }
        public ActionResult getEmployees()
        {
            var emps= EmpCRUDOperations.getEmployees();
            return View(emps);
        }

    }
}
