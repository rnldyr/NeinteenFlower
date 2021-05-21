using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Factory
{
    public class TransactionFactory
    {
        public static TrHeader createTransaction(int memberId, int employeeId, DateTime transactionDate, double discount)
        {
            TrHeader newTrans = new TrHeader
            {
                MemberID = memberId,
                EmployeeID = employeeId,
                TransactionDate = transactionDate,
                DiscountPercentage = discount
            };
            return newTrans;
        }

        public static TrDetail createDetail(int transId, int flowerId, int quantity)
        {
            TrDetail newDetail = new TrDetail
            {
                TransactionID = transId,
                FlowerID = flowerId,
                Quantity = quantity
            };
            return newDetail;
        }
    }
}