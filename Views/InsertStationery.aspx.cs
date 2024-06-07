using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public partial class InsertStationery : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                Response.Redirect("LoginPage.aspx");
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

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string name = txtName.Text;
                int price = int.Parse(txtPrice.Text);

                var stationery = new MsStationery
                {
                    StationeryName = name,
                    StationeryPrice = price
                };

                db.MsStationeries.Add(stationery);
                db.SaveChanges();

                Response.Redirect("AdminHomePage.aspx");
            }
            else
            {
                lblError.Text = "Please fix the errors and try again.";
            }
        }
    }
}