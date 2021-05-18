using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public static string register(string email, string password, string name, string DOB, string gender, string phoneNumber, string address)
        {
            if (email.Equals("") || password.Equals("") || name.Equals("") || DOB.Equals("") || gender.Equals("") || phoneNumber.Equals("") || address.Equals(""))
            {
                return "all field must be filled/chosen!";
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.Match(email).Success)
            {
                return "Please write your email with the email format e.g. abc@example.com!";
            }

            if (!AuthHandler.checkUniqueEmail(email))
            {
                return "Email has been used!";
            }

            if (password.Length < 3 || password.Length > 20)
            {
                return "Password must be 3 - 20 characters!";
            }

            regex = new Regex("^[a-zA-Z ]+$");
            if (name.Length < 3 || name.Length > 20 || !regex.Match(name).Success)
            {
                return "Name must be 3 - 20 characters and contains alphabet only!";
            }

            if (DateTime.Parse(DOB).Year > 2004)
            {
                return "You must be at least 17 years old!";
            }

            regex = new Regex("^(0|[1-9])+$");
            if (!regex.Match(phoneNumber).Success)
            {
                return "Phone number must be numerics!";
            }

            if (!address.Contains("Street"))
            {
                return "Address must contain the word \"Street\"";
            }

            return AuthHandler.register(email, password, name, DOB, gender, phoneNumber, address);
        }
    }
}