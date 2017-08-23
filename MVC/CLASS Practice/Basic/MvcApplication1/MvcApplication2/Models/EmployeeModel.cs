using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class EmployeeModel
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public int Salary { get; set; }

        
    }
    public class EmpCRUDOperations
    {
       public static List<EmployeeModel> emps = new List<EmployeeModel>();
          
        public static List<EmployeeModel> getEmployees()
        {
            emps.Add(new EmployeeModel { Empno = 1, Ename = "Scott", Salary = 3000 });
            emps.Add(new EmployeeModel { Empno = 2, Ename = "Mary", Salary = 3200 });
            emps.Add(new EmployeeModel { Empno = 3, Ename = "Jhon", Salary = 3600 });
            return emps;
        }

        public static  void AddEmp(EmployeeModel emp){
            emps.Add(emp);
        }

        public static void DeleteEmp(int id)
        {
            emps.Remove(emps.Find(e => e.Empno == id));
        }
        public static EmployeeModel getEmpbyId(int id)
        {
            return emps.Find(e => e.Empno == id);
        }


        public static void UpdateEmp(EmployeeModel emp)
        {
            emps.Remove(emps.Find(e => e.Empno == emp.Empno));
            emps.Add(emp);
        }
       
    }
}