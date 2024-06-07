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
    public partial class RegisterPage : System.Web.UI.Page
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

        protected void RegistBTN_Click(object sender, EventArgs e)
        {
            string UserName = TXTUsername.Text;
            string UserGender = DDLGender.SelectedValue;
            DateTime UserDOB;
            bool isParsed = DateTime.TryParse(TXTDOB.Text, out UserDOB);
            string UserAddress = TXTAddress.Text;
            string Password = TXTPassword.Text;
            string UserPhone = TXTPhone.Text;

            LBLERROR.Text = UserController.DoRegist(UserName, UserGender, UserDOB, UserPhone, UserAddress, Password);
            LBLERROR.ForeColor = System.Drawing.Color.Red;

            if (LBLERROR.Text == "")
            {
                Response.Redirect("LoginPage.aspx");
            }

        }
    }
}