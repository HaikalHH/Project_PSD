using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Views
{
    public partial class GuestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null || Request.Cookies["user_cookie"] != null)
            {

                string id = Request.Cookies["user_cookie"].Value;
                MsUser userfromcookie = UserRepository.getUserById(id);
                if (userfromcookie.UserRole.Equals("Customer"))
                {
                    Response.Redirect("CustomerHomePage.aspx");
                }
                else if (userfromcookie.UserRole.Equals("Admin"))
                {
                    Response.Redirect("AdminHomePage.aspx");

                }
            }
        }

        protected void LoginBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void RegistBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void StationeryListBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("StationeryList.aspx");
        }
    }
}