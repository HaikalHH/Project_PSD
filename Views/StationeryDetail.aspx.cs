using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public partial class StationeryDetail : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStationeryDetail();
                if (IsCustomer())
                {
                    pnlAddToCart.Visible = true;
                }
            }
        }
        private void LoadStationeryDetail()
        {
            var stationeries = db.MsStationeries.ToList();
            if (stationeries.Any())
            {
                ddlStationery.DataSource = stationeries;
                ddlStationery.DataTextField = "StationeryName";
                ddlStationery.DataValueField = "StationeryID";
                ddlStationery.DataBind();

                var firstStationery = stationeries.First();
                lblStationeryName.Text = firstStationery.StationeryName;
                lblStationeryPrice.Text = firstStationery.StationeryPrice.ToString("C");
                pnlAddToCart.Visible = true;
            }
            else
            {
                lblErrorMessage.Text = "No stationery items found.";
                pnlAddToCart.Visible = false;
            }
        }

        private bool IsCustomer()
        {
            if (Session["user"] != null)
            {
                MsUser user = (MsUser)Session["user"];
                return user.UserRole == "Customer";
            }
            return false;
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null && ddlStationery.SelectedItem != null)
            {
                int userId = ((MsUser)Session["user"]).UserID;
                int stationeryId = int.Parse(ddlStationery.SelectedValue);

                var existingCartItem = db.Carts.FirstOrDefault(c => c.UserID == userId && c.StationeryID == stationeryId);

                if (existingCartItem != null)
                {
                    if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
                    {
                        existingCartItem.Quantity += quantity;
                        db.SaveChanges();
                        Response.Redirect("Cart.aspx");
                    }
                    else
                    {
                        lblErrorMessage.Text = "Invalid quantity.";
                    }
                }
                else
                {
                    if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
                    {
                        var cartItem = new WebApplication1.Models.Cart
                        {
                            UserID = userId,
                            StationeryID = stationeryId,
                            Quantity = quantity
                        };

                        db.Carts.Add(cartItem);
                        db.SaveChanges();
                        Response.Redirect("Cart.aspx");
                    }
                    else
                    {
                        lblErrorMessage.Text = "Invalid quantity.";
                    }
                }
            }
            else
            {
                lblErrorMessage.Text = "Error adding to cart. Please try again.";
            }
        }
    }
}