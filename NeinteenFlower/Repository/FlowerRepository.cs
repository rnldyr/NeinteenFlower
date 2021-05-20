using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Repository
{
    public class FlowerRepository
    {
        public static List<MsFlower> FlowerList()
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return (from x in db.MsFlowers select x).ToList();
        }

        public static MsFlower GetFlowerbyName(string name)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlower mf = (from msf in db.MsFlowers where msf.FlowerName == name select msf).FirstOrDefault();
            return mf;
        }

        public static void delete(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlower mf = db.MsFlowers.Find(id);
            db.MsFlowers.Remove(mf);
            db.SaveChanges();

        }

        public static void insert(string name, var file, string desc, string type, int price)
        {

        }

        public static void update()
        {

        }

        public static MsFlower GetFlower(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlower mf = (from msf in db.MsFlowers where msf.FlowerID == id select msf).FirstOrDefault();
            return mf;
        }
    }
}