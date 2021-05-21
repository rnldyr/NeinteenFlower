using NeinteenFlower.Factory;
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

        public static string insert(string name, HttpPostedFile file, string desc, string type, int price)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            string path = "~/FlowerImages/" + file.FileName;
            MsFlower mf = FlowerFactory.CreateFlower(name, path, desc, type, price);
            db.MsFlowers.Add(mf);
            db.SaveChanges();
            return "Insert Flower Success";
        }

        public static string update(int id, string name, HttpPostedFile file, string desc, string type, int price)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlower mf = (from msf in db.MsFlowers where msf.FlowerID == id select msf).FirstOrDefault();
            mf.FlowerName = name;
            mf.FlowerImage = file.ToString();
            mf.FlowerDescription = desc;
            MsFlowerType mft = FlowerFactory.CheckFlowerType(type);
            mf.FlowerTypeID = mft.FlowerTypeID;
            mf.FlowerPrice = price;
            db.SaveChanges();
            return "Update Flower Success";
        }

        public static MsFlower GetFlower(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlower mf = (from msf in db.MsFlowers where msf.FlowerID == id select msf).FirstOrDefault();
            return mf;
        }
    }
}