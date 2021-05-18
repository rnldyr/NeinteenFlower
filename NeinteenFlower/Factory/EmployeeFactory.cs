using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Factory
{
    public class EmployeeFactory
    {
        public static MsEmployee CreateEmployee(string name, string gender, string address, string phone, string email, int salary, string password)
        {
            MsEmployee data = new MsEmployee
            {
                EmployeeName = name,
                EmployeeGender = gender,
                EmployeeAddress = address,
                EmployeePhone = phone,
                EmployeeEmail = email,
                EmployeeSalary = salary,
                EmployeePassword = password
            };

            return data;
        }
    }
}