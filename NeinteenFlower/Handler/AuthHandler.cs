using NeinteenFlower.Model;
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
                return "Admin-1";
            }

            int employeeID = EmployeeRepository.getLoginInfo(email, password);
            if(employeeID > 0)
            {
                return "Employee-" + employeeID.ToString();
            }

            int memberID = MemberRepository.getLoginInfo(email, password);
            if(memberID > 0)
            {
                return "Member-" + memberID.ToString();
            }

            return "Fail";
        }

        public static MsEmployee getEmployee(int id)
        {
            return EmployeeRepository.getEmployee(id);
        }

        public static MsMember getMember(int id)
        {
            return MemberRepository.getMember(id);

        }

    }
}