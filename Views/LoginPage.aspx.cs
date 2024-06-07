using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Controllers;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Views
{
    public partial class LoginPage : System.Web.UI.Page
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
            string Username = TXTUsername.Text;
            string Password = TXTPassword.Text;
            bool RememberME = CBRememberME.Checked;

            LBLERROR.Text = UserController.DoLogin(Username, Password);
            LBLERROR.ForeColor = System.Drawing.Color.Red;


            if (LBLERROR.Text == "")
            {
                var us = UserRepository.getUserByUsername(Username);
                if (RememberME)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = us.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                Session["user"] = us;
                if (us.UserRole.Equals("Admin"))
                {
                    Response.Redirect("AdminHomePage.aspx");
                }
                else if (us.UserRole.Equals("Customer"))
                {
                    Response.Redirect("CustomerHomePage.aspx");
                }

            }

        }
    }
}