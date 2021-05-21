using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Handler
{
    public class TransactionHandler
    {
        public static string preorder(int memberId, DateTime curr, double discount, int flowerId, int quantity)
        {
            int employeeCount = EmployeeRepository.countEmployee();

            Random employeeRand = new Random();
            var listEmployee = EmployeeRepository.getListEmployee();
            int employeeId = listEmployee.ElementAt(employeeRand.Next(0, employeeCount-1)).EmployeeID;

            return TransactionRepository.preorder(memberId, employeeId, curr, discount, flowerId, quantity);
        }
    }
}