using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Factory
{
    public class FlowerFactory
    {
        public static MsFlower CreateFlower(String name, String image, String description, String flowerType, int price)
        {
            MsFlowerType mft = CheckFlowerType(flowerType);
            MsFlower mf = new MsFlower
            {
                FlowerName = name,
                FlowerImage = image,
                FlowerDescription = description,
                FlowerTypeID = mft.FlowerTypeID,
                FlowerPrice = price
            };

            return mf;
        }

        public static MsFlowerType CheckFlowerType(String flowerType)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlowerType mft = (from msft in db.MsFlowerTypes where msft.FlowerTypeName == flowerType select msft).FirstOrDefault();

            return mft;
        }
    }
}