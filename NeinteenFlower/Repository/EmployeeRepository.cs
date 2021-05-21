using NeinteenFlower.Factory;
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

        public static List<MsEmployee> getListEmployee()
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return (from data in db.MsEmployees select data).ToList();
        }

        public static void DeleteEmployee(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsEmployee temp = (from data in db.MsEmployees where data.EmployeeID == id select data).FirstOrDefault();
            db.MsEmployees.Remove(temp);
            db.SaveChanges();
        }

        public static int getEmployeeId(string name)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return (from data in db.MsEmployees where data.EmployeeName.Equals(name) select data.EmployeeID).FirstOrDefault();
        }

        public static string register(string email, string password, string name, string DOB, string gender, string phoneNumber, string address, int salary)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsEmployee employee = EmployeeFactory.CreateEmployee(email, password, name, DOB, gender, phoneNumber, address, salary);
            db.MsEmployees.Add(employee);
            db.SaveChanges();
            return "Success";
        }

        public static int countEmployee()
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return (from data in db.MsEmployees select data).Count();
        }

        public static string updateEmployee(int id, string email, string password, string name, string DOB, string gender, string phoneNumber, string address, int salary)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsEmployee employee = db.MsEmployees.Find(id);
            employee.EmployeeEmail = email;
            employee.EmployeePassword = password;
            employee.EmployeeName = name;
            employee.EmployeeDOB = DateTime.Parse(DOB);
            employee.EmployeeGender = gender;
            employee.EmployeePhone = phoneNumber;
            employee.EmployeeAddress = address;
            employee.EmployeeSalary = salary;
            db.SaveChanges();
            return "Success";
        }
    }
}