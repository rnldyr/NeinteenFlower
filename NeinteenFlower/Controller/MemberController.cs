using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Controller
{
    public class MemberController
    {
        public static List<MsMember> getListMembers()
        {
            return MemberHandler.getListMembers();
        }

        public static void DeleteMember(int id)
        {
            MemberHandler.DeleteMember(id);
            return;
        }

        public static int getMemberId(string name)
        {
            return MemberHandler.getMemberId(name);
        }
    }
}