using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        private int transactionID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userId = GetUserIdFromSession();
                if (userId != -1)
                {
                    if (Session["TransactionID"] != null)
                    {
                        int transactionID;
                        if (int.TryParse(Session["TransactionID"].ToString(), out transactionID))
                        {
                            LoadTransactionDetails(userId, transactionID);
                        }
                        else
                        {
                            ShowErrorMessage("Invalid transaction ID in session.");
                        }
                    }
                    else
                    {
                        ShowErrorMessage("No transaction ID found in session.");
                    }
                }
                else
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
        }
        private void LoadTransactionDetails(int userId, int transactionID)
        {
            var transactionDetails = from td in db.TransactionDetails
                                     where td.TransactionID == transactionID && td.TransactionHeader.UserID == userId
                                     select new
                                     {
                                         td.MsStationery.StationeryName,
                                         td.MsStationery.StationeryPrice,
                                         td.Quantity
                                     };

            if (transactionDetails.Any())
            {
                gvTransactionDetail.DataSource = transactionDetails.ToList();
                gvTransactionDetail.DataBind();
            }
            else
            {
                ShowErrorMessage("No transaction details found.");
            }
        }
        private int GetUserIdFromSession()
        {
            if (Session["user"] != null)
            {
                MsUser user = (MsUser)Session["user"];
                return user.UserID;
            }
            return -1;
        }

        protected void gvTransactionDetail_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detail")
            {
                int newTransactionID;
                if (int.TryParse(e.CommandArgument.ToString(), out newTransactionID))
                {
                    Session["TransactionID"] = newTransactionID;
                    Response.Redirect("TransactionDetail.aspx");
                }
            }
        }
        private void ShowErrorMessage(string message)
        {
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
        }
    }
}