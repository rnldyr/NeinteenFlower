using NeinteenFlower.Model;
using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Handler
{
    public class MemberHandler
    {
        public static List<MsMember> getListMembers()
        {
            return MemberRepository.getListMembers();
        }

        public static void DeleteMember(int id)
        {
            MemberRepository.DeleteMember(id);
            return;
        }

        public static int getMemberId(string name)
        {
            return MemberRepository.getMemberId(name);
        }
    }
}