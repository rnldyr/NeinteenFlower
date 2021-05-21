using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static int getEmployeeId(string name)
        {
            return EmployeeHandler.getEmployeeId(name);
        }
    }
}