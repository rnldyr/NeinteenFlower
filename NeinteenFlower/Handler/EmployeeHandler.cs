using NeinteenFlower.Model;
using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Handler
{
    public class EmployeeHandler
    {
        public static List<MsEmployee> getListEmployee()
        {
            return EmployeeRepository.getListEmployee();
        }

        public static void DeleteEmployee(int id)
        {
            EmployeeRepository.DeleteEmployee(id);
            return;
        }
        public static MsEmployee getEmployee(int id)
        {
            return EmployeeRepository.getEmployee(id);
        }

        public static int getEmployeeId(string name)
        {
            return EmployeeRepository.getEmployeeId(name);
        }

        public static bool checkUniqueEmail(string email)
        {
            if (EmployeeRepository.checkUniqueEmail(email) && MemberRepository.checkUniqueEmail(email))
            {
                return true;
            }
            return false;
        }

        public static string register(string email, string password, string name, string DOB, string gender, string phoneNumber, string address, int salary)
        {
            return EmployeeRepository.register(email, password, name, DOB, gender, phoneNumber, address, salary);
        }

        public static string updateEmployee(int id, string email, string password, string name, string DOB, string gender, string phoneNumber, string address, int salary)
        {
            return EmployeeRepository.updateEmployee(id, email, password, name, DOB, gender, phoneNumber, address, salary);
        }
    }
}