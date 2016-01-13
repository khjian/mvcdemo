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

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }

        //public bool IsValidUser(UserDetails u)
        //{
        //    if (u.UserName == "admin" && u.Password == "admin")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public UserStatus GetUserValidity(UserDetails u)
        {
            if (u.UserName == "admin" && u.Password == "admin")
            {
                return UserStatus.AuthenticatedAdmin;
            }
            else if (u.UserName == "song" && u.Password == "song")
            {
                return UserStatus.AuthentucatedUser;
            }
            else
            {
                return UserStatus.NonAuthenticatedUser;
            }
        }
    }
}