using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class AdminHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void LogOutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            HttpCookie authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (authCookie != null)
            {
                authCookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(authCookie);
            }

            HttpCookieCollection cookies = HttpContext.Current.Request.Cookies;
            foreach (string cookieKey in cookies.AllKeys)
            {
                HttpCookie cookie = cookies[cookieKey];
                cookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }

            Response.Redirect("GuestPage.aspx");
        }

        protected void StationeryInsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertStationery.aspx");
        }

        protected void StationeryUpdateBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStationery.aspx");
        }

        protected void TransactionReportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}