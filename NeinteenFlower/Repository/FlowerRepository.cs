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
            string path = "~/FlowerImages/" + name + ".jpg";
            int typeId = 0;
            switch (type)
            {
                case "Daisies":
                    typeId = 1;
                    break;
                case "Roses":
                    typeId = 2;
                    break;
                case "Lilies":
                    typeId = 3;
                    break;
            }
            MsFlower mf = FlowerFactory.CreateFlower(name, path, desc, typeId, price);
            db.MsFlowers.Add(mf);
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            return "Insert Flower Success";
        }

        public static string update(int id, string name, HttpPostedFile file, string desc, string type, int price)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlower mf = db.MsFlowers.Find(id);
            mf.FlowerName = name;
            string path = "~/FlowerImages/" + name + ".jpg";
            mf.FlowerImage = path;
            mf.FlowerDescription = desc;
            int typeId = 0;
            switch (type)
            {
                case "Daisies":
                    typeId = 1;
                    break;
                case "Roses":
                    typeId = 2;
                    break;
                case "Lilies":
                    typeId = 3;
                    break;
            }
            mf.FlowerTypeID = typeId;
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

        public static int getFlowerId(string name)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            var flowerID = (from f in db.MsFlowers where f.FlowerName == name select f.FlowerID).FirstOrDefault();
            return flowerID;
        }
    }
}