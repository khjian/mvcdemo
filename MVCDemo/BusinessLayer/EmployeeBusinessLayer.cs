using MVCDemo.Models;
using System.Collections.Generic;
using MVCDemo.DataAccessLayer;
using System.Linq;

namespace MVCDemo.BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }
    }
}