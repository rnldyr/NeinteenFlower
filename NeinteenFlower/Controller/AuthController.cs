using NeinteenFlower.Handler;
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
    }
}