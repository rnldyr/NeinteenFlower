using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Factory
{
    public class FlowerFactory
    {
        public static MsFlower CreateFlower(String name, String image, String description, int flowerTypeId, int price)
        {
            MsFlower mf = new MsFlower
            {
                FlowerName = name,
                FlowerImage = image,
                FlowerDescription = description,
                FlowerTypeID = flowerTypeId,
                FlowerPrice = price
            };

            return mf;
        }
    }
}