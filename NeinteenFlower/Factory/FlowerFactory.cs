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
            MsFlower mf = new MsFlower
            {
                FlowerName = name,
                FlowerImage = image,
                FlowerDescription = description,
                FlowerPrice = price
            };

            CreateFlowerType(flowerType);
            return mf;
        }

        public static MsFlowerType CreateFlowerType(String flowerType)
        {
            MsFlowerType mft = new MsFlowerType
            {
                FlowerTypeName = flowerType
            };

            return mft;
        }
    }
}