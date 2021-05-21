using NeinteenFlower.Factory;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Repository
{
    public class TransactionRepository
    {
        public static string preorder(int memberId, int employeeId, DateTime curr, double discount, int flowerId, int quantity)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            TrHeader transaction = TransactionFactory.createTransaction(memberId, employeeId, curr, discount);
            db.TrHeaders.Add(transaction);
            db.SaveChanges();

            int transId = transaction.TransactionID;
            TrDetail detail = TransactionFactory.createDetail(transId, flowerId, quantity);
            db.TrDetails.Add(detail);

            db.SaveChanges();
            return "Success";
        }
    }
}