using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace NeinteenFlower.Controller
{
    public class EmployeeController
    {
        public static List<MsEmployee> GetListEmployee()
        {
            return EmployeeHandler.getListEmployee();
        }

        public static void DeleteEmployee(int id)
        {
            EmployeeHandler.DeleteEmployee(id);
            return;
        }

        public static MsEmployee getEmployee(int id)
        {
            return EmployeeHandler.getEmployee(id);
        }

        public static int getEmployeeId(string name)
        {
            return EmployeeHandler.getEmployeeId(name);
        }

        public static string register(string email, string password, string name, string DOB, string gender, string phoneNumber, string address, int salary)
        {
            if (email.Equals("") || password.Equals("") || name.Equals("") || DOB.Equals("") || gender.Equals("") || phoneNumber.Equals("") || address.Equals(""))
            {
                return "All field must be filled/chosen!";
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.Match(email).Success)
            {
                return "Please write your email with the email format e.g. abc@example.com!";
            }

            if (!EmployeeHandler.checkUniqueEmail(email))
            {
                return "Email has been used!";
            }

            if (password.Length < 3 || password.Length > 20)
            {
                return "Password must be 3 - 20 characters!";
            }

            regex = new Regex("^[a-zA-Z ]+$");
            if (name.Length < 3 || name.Length > 20 || !regex.Match(name).Success)
            {
                return "Name must be 3 - 20 characters and contains alphabet only!";
            }

            if (DateTime.Parse(DOB).Year > 2004)
            {
                return "You must be at least 17 years old!";
            }

            regex = new Regex("^(0|[1-9])+$");
            if (!regex.Match(phoneNumber).Success)
            {
                return "Phone number must be numerics!";
            }

            if (!address.Contains("Street"))
            {
                return "Address must contain the word \"Street\"";
            }

            if (salary <= 100 || salary >= 1000)
            {
                return "Salary must be between 100 to 1000!";
            }

            return EmployeeHandler.register(email, password, name, DOB, gender, phoneNumber, address, salary);
        }

        public static string updateEmployee(int id, string email, string password, string name, string DOB, string gender, string phoneNumber, string address, int salary)
        {
            if (email.Equals("") || password.Equals("") || name.Equals("") || DOB.Equals("") || gender.Equals("") || phoneNumber.Equals("") || address.Equals(""))
            {
                return "All field must be filled/chosen!";
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.Match(email).Success)
            {
                return "Please write your email with the email format e.g. abc@example.com!";
            }

            if (!EmployeeHandler.checkUniqueEmail(email))
            {
                return "Email has been used!";
            }

            if (password.Length < 3 || password.Length > 20)
            {
                return "Password must be 3 - 20 characters!";
            }

            regex = new Regex("^[a-zA-Z ]+$");
            if (name.Length < 3 || name.Length > 20 || !regex.Match(name).Success)
            {
                return "Name must be 3 - 20 characters and contains alphabet only!";
            }

            if (DateTime.Parse(DOB).Year > 2004)
            {
                return "You must be at least 17 years old!";
            }

            regex = new Regex("^(0|[1-9])+$");
            if (!regex.Match(phoneNumber).Success)
            {
                return "Phone number must be numerics!";
            }

            if (!address.Contains("Street"))
            {
                return "Address must contain the word \"Street\"";
            }

            if (salary <= 100 || salary >= 1000)
            {
                return "Salary must be between 100 to 1000!";
            }
            return EmployeeHandler.updateEmployee(id, email, password, name, DOB, gender, phoneNumber, address, salary);
        }
    }
}