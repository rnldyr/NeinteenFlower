using NeinteenFlower.Model;
using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Handler
{
    public class FlowerHandler
    {
        public static string insert(string name, HttpPostedFile file, string desc, string type, int price)
        {
            return FlowerRepository.insert(name, file, desc, type, price);
        }

        public static string update(int id, string name, HttpPostedFile file, string desc, string type, int price)
        {
            return FlowerRepository.update(id, name, file, desc, type, price);
        }

        public static void delete(int id)
        {
            FlowerRepository.delete(id);
        }

        public static List<MsFlower> FlowerList()
        {
            return FlowerRepository.FlowerList();
        }

        public static MsFlower GetFlowerByName(String name)
        {
            return FlowerRepository.GetFlowerbyName(name);
        }

        public static void update()
        {

        }

        public static MsFlower GetFlower(int id)
        {
            return FlowerRepository.GetFlower(id);
        }
    }
}