using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTransactionHistory();
            }
        }
        private void LoadTransactionHistory()
        {
            int userId = GetUserIdFromSession();
            if (userId != -1)
            {
                var transactions = from th in db.TransactionHeaders
                                   where th.UserID == userId
                                   select new
                                   {
                                       th.TransactionID,
                                       th.TransactionDate,
                                       CustomerName = th.MsUser.UserName,
                                   };

                gvTransactionHistory.DataSource = transactions.ToList();
                gvTransactionHistory.DataBind();
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
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

        protected void gvTransactionHistory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detail")
            {
                int transactionID = Convert.ToInt32(e.CommandArgument);
                Session["TransactionID"] = transactionID;
                Response.Redirect("TransactionDetail.aspx");
            }
        }
    }
}