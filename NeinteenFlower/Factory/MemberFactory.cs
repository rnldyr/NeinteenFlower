using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Factory
{
    public class MemberFactory
    {
        public static MsMember createMember(string name, string gender, string address, string phone, string email, string password)
        {
            MsMember data = new MsMember
            {
                MemberName = name,
                MemberGender = gender,
                MemberAddress = address,
                MemberPhone = phone,
                MemberEmail = email,
                MemberPassword = password
            };

            return data;
        }
    }
}