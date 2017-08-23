using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class Emp1Controller : Controller
    {
        //
        // GET: /Emp1/

        public ActionResult Index()
        {
            var emps = EmpCRUDOperations.getEmployees();
            return View(emps);
        }

        //
        // GET: /Emp1/Details/5

        public ActionResult Details(int id)
        {
            var emp = EmpCRUDOperations.emps.Find(a=>a.Empno==id);
            return View(emp);
        }

        //
        // GET: /Emp1/Create

        public ActionResult Create()
        {
            EmployeeModel emp = new EmployeeModel();
            return View(emp);
        }

        //
        // POST: /Emp1/Create

        [HttpPost]
        public ActionResult Create(EmployeeModel Emp)
        {
            try
            {
                EmpCRUDOperations.AddEmp(Emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Emp1/Edit/5

        public ActionResult Edit(int id)
        {
            var emp = EmpCRUDOperations.getEmpbyId(id);
            return View(emp);
        }

        //
        // POST: /Emp1/Edit/5

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            try
            {

                EmpCRUDOperations.UpdateEmp(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Emp1/Delete/5

        public ActionResult Delete(int id)
        {
            var emp = EmpCRUDOperations.getEmpbyId(id);
            return View(emp);
        }

        //
        // POST: /Emp1/Delete/5

        [HttpPost]
        public ActionResult Delete(int id,EmployeeModel emp)
        {
            try
            {
                EmpCRUDOperations.DeleteEmp(id);
               return RedirectToAction("Index");
               // return View(emp);
               // return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
