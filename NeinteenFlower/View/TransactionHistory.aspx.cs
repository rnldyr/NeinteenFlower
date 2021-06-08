using NeinteenFlower.Dataset;
using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using NeinteenFlower.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
                return;
            }

            if (!Session["role"].Equals("Member"))
            {
                Response.Redirect("~/View/Home.aspx");
            }

            TransactionReport trReport = new TransactionReport();
            transactionHistory.ReportSource = trReport;

            TransactionDataSet newData = getData(TransactionHandler.getTransaction());
            trReport.SetDataSource(newData);
        }

        private TransactionDataSet getData(List<TrHeader> header)
        {
            TransactionDataSet data = new TransactionDataSet();
            var headTable = data.trHeader;
            var detailTable = data.trDetail;
            var flowerTable = data.MsFlower;

            MsMember member = (MsMember)Session["user"];
            int memberId = member.MemberID;

            foreach (TrHeader t in header)
            {
                if(memberId == t.MemberID)
                {
                    var hRow = headTable.NewRow();
                    hRow["TransactionID"] = t.TransactionID;
                    hRow["MemberID"] = t.MemberID;
                    hRow["EmployeeID"] = t.EmployeeID;
                    hRow["TransactionDate"] = t.TransactionDate.ToString().Split()[0];
                    hRow["DiscountPercentage"] = Math.Round(t.DiscountPercentage, 2);

                    double grandtotal = 0;
                    foreach (TrDetail td in t.TrDetails)
                    {
                        var dRow = detailTable.NewRow();
                        dRow["TransactionID"] = td.TransactionID;
                        dRow["FlowerID"] = td.FlowerID;

                        var thisFlower = FlowerHandler.GetFlower(td.FlowerID);
                        var fRow = flowerTable.NewRow();
                        fRow["FlowerID"] = td.FlowerID;
                        fRow["FlowerName"] = thisFlower.FlowerName;
                        fRow["FlowerPrice"] = thisFlower.FlowerPrice;
                        flowerTable.Rows.Add(fRow);

                        dRow["Quantity"] = td.Quantity;

                        var subtotal = thisFlower.FlowerPrice * td.Quantity;
                        dRow["Subtotal"] = subtotal;
                        detailTable.Rows.Add(dRow);

                        grandtotal += subtotal;
                    }

                    grandtotal *= (100 - t.DiscountPercentage) / 100;
                    hRow["GrandTotal"] = Math.Round(grandtotal, 2);
                    headTable.Rows.Add(hRow);
                }
            }

            return data;
        }
    }
}