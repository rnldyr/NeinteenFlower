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

        public static string getEmployeeName(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return db.MsEmployees.Find(id).EmployeeName;
        }
    }
}