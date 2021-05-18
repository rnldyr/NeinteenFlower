using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Controller
{
    public class AuthController
    {
        public static string getLoginInfo(string email, string password)
        {
            if(email.Equals("") || password.Equals(""))
            {
                return "Fail";
            }
            return AuthHandler.getLoginInfo(email, password);
        }

        public static MsEmployee getEmployee(int id)
        {
            return AuthHandler.getEmployee(id);
        }

        public static MsMember GetMember(int id)
        {
            return AuthHandler.getMember(id);

        }

        public static string changePassword(string email, string captcha, string newPassword)
        {
            if(email.Equals("") || captcha.Equals("") || newPassword.Equals(""))
            {
                return "Fail";
            }

            if (!newPassword.Equals(captcha))
            {
                return "Fail";
            }

            return AuthHandler.changePassword(email, newPassword);
        }
    }
}