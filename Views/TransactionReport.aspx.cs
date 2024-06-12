using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Web;
using System;
using System.Collections.Generic;
using System.Web.UI;
using WebApplication1.Dataset;
using WebApplication1.Handlers;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                Response.Redirect("~/AdminHomePage.aspx");
                return;
            }

            if (!IsPostBack)
            {
                ReportDocument report = new ReportDocument();
                report.Load(Server.MapPath("~/Report/CrystalReport1.rpt"));
                CrystalReportViewer1.ReportSource = report;

                DataSet1 data = getData(TransactionHeaderHandler.GetListTransactionHeaders());
                report.SetDataSource(data);
            }
        }

        private bool IsAdmin()
        {
            if (Session["user"] != null)
            {
                MsUser user = (MsUser)Session["user"];
                return user.UserRole == "Admin";
            }
            return false;
        }

        private DataSet1 getData(List<TransactionHeader> transactionHeaders)
        {
            DataSet1 data = new DataSet1();
            var headerTable = data.transaction_headers;
            var detailTable = data.TransactionDetail;

            foreach (TransactionHeader t in transactionHeaders)
            {
                int total = 0;
                var hrow = headerTable.NewRow();
                hrow["transaction_id"] = t.TransactionID;
                hrow["user_id"] = t.UserID;
                hrow["transaction_date"] = t.TransactionDate.ToString("dd/MM/yyyy");

                foreach (WebApplication1.Models.TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["transaction_id"] = d.TransactionID;
                    drow["stationery_name"] = d.MsStationery.StationeryName;
                    drow["quantity"] = d.Quantity;
                    drow["stationery_price"] = d.MsStationery.StationeryPrice;
                    drow["sub_total_value"] = d.Quantity * d.MsStationery.StationeryPrice;
                    total += d.Quantity * d.MsStationery.StationeryPrice;
                    detailTable.Rows.Add(drow);
                }

                hrow["grand_total_value"] = total;
                headerTable.Rows.Add(hrow);
            }

            return data;
        }
    }
}
