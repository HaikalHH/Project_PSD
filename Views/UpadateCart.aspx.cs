using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public partial class UpadateCart : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int stationeryID = Convert.ToInt32(Request.QueryString["id"]);
                LoadCartItem(stationeryID);
            }
        }
        private void LoadCartItem(int stationeryID)
        {
            int userId = GetUserIdFromSession();
            if (userId != -1)
            {
                var cartItem = (from c in db.Carts
                                join s in db.MsStationeries on c.StationeryID equals s.StationeryID
                                where c.StationeryID == stationeryID && c.UserID == userId
                                select new
                                {
                                    s.StationeryName,
                                    s.StationeryPrice,
                                    c.Quantity
                                }).FirstOrDefault();

                if (cartItem != null)
                {
                    lblName.Text = cartItem.StationeryName;
                    lblPrice.Text = cartItem.StationeryPrice.ToString();
                    txtQuantity.Text = cartItem.Quantity.ToString();
                }
                else
                {
                    Response.Redirect("Cart.aspx");
                }
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


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int userId = GetUserIdFromSession();
            if (userId != -1)
            {
                int stationeryID = Convert.ToInt32(Request.QueryString["id"]);
                var cartItem = db.Carts.FirstOrDefault(c => c.StationeryID == stationeryID && c.UserID == userId);
                if (cartItem != null)
                {
                    int newQuantity;
                    if (int.TryParse(txtQuantity.Text, out newQuantity) && newQuantity > 0)
                    {
                        cartItem.Quantity = newQuantity;
                        db.SaveChanges();
                        Response.Redirect("Cart.aspx");
                    }
                    else
                    {
                        lblError.Text = "Quantity must be filled and must be more than 0.";
                    }
                }
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}