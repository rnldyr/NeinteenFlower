using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Handler
{
    public class AuthHandler
    {
        public static string getLoginInfo(string email, string password)
        {
            if(email.Equals("admin") && password.Equals("admin"))
            {
                return "Admin";
            }

            int employeeID = EmployeeRepository.getLoginInfo(email, password);
            if(employeeID > 0)
            {
                return "Employee-" + employeeID.ToString() + "-" + EmployeeRepository.getEmployeeName(employeeID);
            }

            int memberID = MemberRepository.getLoginInfo(email, password);
            if(memberID > 0)
            {
                return "Member-" + memberID.ToString() + "-" + MemberRepository.getMemberName(memberID);
            }

            return "Fail";
        }
    }
}