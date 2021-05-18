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
    }
}