using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Factory
{
    public class MemberFactory
    {
        public static MsMember createMember(string email, string password, string name, string DOB, string gender, string phoneNumber, string address)
        {
            MsMember data = new MsMember
            {
                MemberName = name,
                MemberDOB = DateTime.Parse(DOB),
                MemberGender = gender,
                MemberAddress = address,
                MemberPhone = phoneNumber,
                MemberEmail = email,
                MemberPassword = password
            };

            return data;
        }
    }
}