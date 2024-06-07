using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public partial class StationeryList : System.Web.UI.Page
    {
        private DatabaseEntities db = new DatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
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
    }
}