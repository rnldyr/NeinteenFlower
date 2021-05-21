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
        
        public static MsMember getMember(int id)
        {
            return MemberRepository.getMember(id);
        }

        public static int getMemberId(string name)
        {
            return MemberRepository.getMemberId(name);
        }

        public static bool checkUniqueEmail(string email)
        {
            if (EmployeeRepository.checkUniqueEmail(email) && MemberRepository.checkUniqueEmail(email))
            {
                return true;
            }
            return false;
        }

        public static string register(string email, string password, string name, string DOB, string gender, string phoneNumber, string address)
        {
            return MemberRepository.register(email, password, name, DOB, gender, phoneNumber, address);
        }

        public static string updateMember(int id, string email, string password, string name, string DOB, string gender, string phoneNumber, string address)
        {
            return MemberRepository.updateMember(id, email, password, name, DOB, gender, phoneNumber, address);
        }
    }
}