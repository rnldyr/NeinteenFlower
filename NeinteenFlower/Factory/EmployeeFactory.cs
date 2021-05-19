using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Factory
{
    public class EmployeeFactory
    {
        public static MsEmployee CreateEmployee(string email, string password, string name, string DOB, string gender, string phoneNumber, string address, int salary)
        {
            MsEmployee data = new MsEmployee
            {
                EmployeeName = name,
                EmployeeDOB = DateTime.Parse(DOB),
                EmployeeGender = gender,
                EmployeeAddress = address,
                EmployeePhone = phoneNumber,
                EmployeeEmail = email,
                EmployeeSalary = salary,
                EmployeePassword = password
            };

            return data;
        }
    }
}