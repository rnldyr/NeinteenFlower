using NeinteenFlower.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Controller
{
    public class TransactionController
    {
        public static string preorder(int memberId, DateTime curr, double discount, int flowerId, int quantity)
        {
            if (quantity < 1 || quantity > 100)
            {
                return "Quantity must be between 1 to 100!";
            }
            return TransactionHandler.preorder(memberId, curr, discount, flowerId, quantity);
        }
    }
}