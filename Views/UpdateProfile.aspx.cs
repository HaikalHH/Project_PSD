using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUserProfile();
            }
        }

        private void LoadUserProfile()
        {
            if (Session["user"] != null)
            {
                MsUser user = (MsUser)Session["user"];
                txtName.Text = user.UserName;
                txtDOB.Text = user.UserDOB.ToString("yyyy-MM-dd");
                ddlGender.SelectedValue = user.UserGender;
                txtAddress.Text = user.UserAddress;
                txtPassword.Text = user.UserPassword;
                txtPhone.Text = user.UserPhone;
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void cvDOB_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime dob;
            if (DateTime.TryParse(args.Value, out dob))
            {
                args.IsValid = (DateTime.Now.Year - dob.Year) >= 1;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (Session["user"] != null)
                {
                    MsUser sessionUser = (MsUser)Session["user"];

                    using (var dbContext = new DatabaseEntities())
                    {
                        MsUser user = dbContext.MsUsers.FirstOrDefault(u => u.UserID == sessionUser.UserID);

                        if (user != null)
                        {
                            user.UserName = txtName.Text;
                            user.UserDOB = DateTime.Parse(txtDOB.Text);
                            user.UserGender = ddlGender.SelectedValue;
                            user.UserAddress = txtAddress.Text;
                            user.UserPassword = txtPassword.Text;
                            user.UserPhone = txtPhone.Text;

                            dbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                            dbContext.SaveChanges();

                            Session["user"] = user;

                            lblMessage.Text = "Update Successfully";
                            lblMessage.Visible = true;
                        }
                    }
                }
                else
                {
                    Response.Redirect("LoginPage.aspx");
                }
            }
        }

        protected void cvNameUnique_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string userName = args.Value;
            MsUser user = (MsUser)Session["user"];
            var existingUser = db.MsUsers.FirstOrDefault(u => u.UserName == userName && u.UserID != user.UserID);
            args.IsValid = existingUser == null;
        }
    }
}