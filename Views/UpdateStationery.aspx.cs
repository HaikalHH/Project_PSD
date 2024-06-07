using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public partial class UpdateStationery : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                Response.Redirect("LoginPage.aspx");
            }

            if (!IsPostBack)
            {
                BindStationeryData();
            }
        }

        private void BindStationeryData()
        {
            GridView1.DataSource = db.MsStationeries.ToList();
            GridView1.DataBind();
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

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindStationeryData();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindStationeryData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int stationeryId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);

            TextBox txtName = (TextBox)row.Cells[1].Controls[0];
            TextBox txtPrice = (TextBox)row.Cells[2].Controls[0];

            var stationery = db.MsStationeries.Find(stationeryId);

            if (stationery != null && txtName != null && txtPrice != null)
            {
                stationery.StationeryName = txtName.Text;
                stationery.StationeryPrice = int.Parse(txtPrice.Text);
                db.SaveChanges();

                GridView1.EditIndex = -1;
                BindStationeryData();
            }
            else
            {
                lblError.Text = "Error updating stationery. Please try again.";
            }
        }
    }
}