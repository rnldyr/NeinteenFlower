﻿using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Repository
{
    public class MemberRepository
    {
        public static int getLoginInfo(string email, string password)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            int memberId = (from m in db.MsMembers
                              where m.MemberEmail == email && m.MemberPassword == password
                              select m.MemberID).FirstOrDefault();
            return memberId;
        }

        public static MsMember getMember(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return db.MsMembers.Find(id);
        }

        public static string changePassword(string email, string newPassword)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsMember member = (from m in db.MsMembers
                               where m.MemberEmail == email
                               select m).FirstOrDefault();

            if (member == null)
            {
                return "Fail";
            }

            member.MemberPassword = newPassword;
            db.SaveChanges();
            return "Success";
        }

        public static bool checkUniqueEmail(string email)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            var result = (from m in db.MsMembers
                          where m.MemberEmail == email
                          select m).FirstOrDefault();
            if (result == null) return true;
            return false;
        }

        public static string register(string email, string password, string name, string DOB, string gender, string phoneNumber, string address)
        {
            return "Success";
        }
    }
}