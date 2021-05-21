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
            int employeeId = employeeRand.Next(1, employeeCount);

            return TransactionRepository.preorder(memberId, employeeId, curr, discount, flowerId, quantity);
        }
    }
}