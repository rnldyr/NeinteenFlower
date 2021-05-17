using NeinteenFlower.Model;
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

        public static string getMemberName(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return db.MsMembers.Find(id).MemberName;
        }
    }
}