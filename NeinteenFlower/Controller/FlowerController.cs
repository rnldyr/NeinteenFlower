using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Controller
{
    public class FlowerController
    {
        public static string insert(string name, HttpPostedFile file, string desc, string type, int price)
        {
            if (name == null || name.Length < 5 || file == null || desc.Length < 50 || type != "Daisies" || type != "Lilies" || type != "Roses" || price.GetType() != typeof(int) || price < 20 || price > 100)
            {
                return "invalid data";
            }
            else
            {
                return FlowerHandler.insert(name, file, desc, type, price);
            }
        }

        public static string update(int id, string name, HttpPostedFile file, string desc, string type, int price)
        {
            if (name == null || name.Length < 5 || file == null || desc.Length < 50 || type != "Daisies" || type != "Lilies" || type != "Roses" || price.GetType() != typeof(int) || price < 20 || price > 100)
            {
                return "invalid data";
            }
            else
            {
                return FlowerHandler.update(id, name, file, desc, type, price);
            }
        }
        public static List<MsFlower> FlowerList()
        {
            return FlowerHandler.FlowerList();
        }

        public static MsFlower GetFlowerByName(String name)
        {
            return FlowerHandler.GetFlowerByName(name);
        }

        public static void delete(int id)
        {
            FlowerHandler.delete(id);
        }

        public static void update()
        {

        }

        public static MsFlower GetFlower(int id)
        {
            return FlowerHandler.GetFlower(id);
        }
    }
}