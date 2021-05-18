using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Repository
{
    public class EmployeeRepository
    {
        public static int getLoginInfo(string email, string password)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            int employeeId = (from e in db.MsEmployees
                              where e.EmployeeEmail == email && e.EmployeePassword == password
                              select e.EmployeeID).FirstOrDefault();
            return employeeId;
        }

        public static MsEmployee getEmployee(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return db.MsEmployees.Find(id);
        }

        public static string changePassword(string email, string newPassword)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsEmployee employee = (from e in db.MsEmployees
             where e.EmployeeEmail == email
             select e).FirstOrDefault();

            if(employee == null)
            {
                return "Fail";
            }

            employee.EmployeePassword = newPassword;
            db.SaveChanges();
            return "Success";
        }

        public static bool checkUniqueEmail(string email)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            var result = (from e in db.MsEmployees
                          where e.EmployeeEmail == email
                          select e).FirstOrDefault();
            if (result == null) return true;
            return false;
        }
    }
}