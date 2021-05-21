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

        public static int getEmployeeId(string name)
        {
            return EmployeeRepository.getEmployeeId(name);
        }
    }
}