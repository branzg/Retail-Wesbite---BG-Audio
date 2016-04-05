using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using RetailSite.Models;
using System.Web.ModelBinding;
using System.Data;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.Web.Configuration;

namespace RetailSite.Admin
{
    public partial class TransactionLog : System.Web.UI.Page
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["WingtipToys"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Order> GetOrders([QueryString("Username")] string Username)
        {
            var _db = new RetailSite.Models.ProductContext();
            IQueryable<Order> query = _db.Orders;

            //query = query.Where(p => p.Username == "branzg@hotmail.com");
            //show the data to the GridView
            return query;
        }

        protected void CheckBox1_OnCheckedChanged(object sender, EventArgs e)
        {

            //Determine which CheckBox in The grid fired the event
            CheckBox chk = (CheckBox)sender;

            //Get the current GridView Row
            GridViewRow row = (GridViewRow)chk.NamingContainer;
            HiddenField hiddenID = (HiddenField)row.FindControl("HiddenID");

            string sql = "UPDATE dbo.Orders SET HasBeenShipped=@HasBeenShipped WHERE OrderId=@OrderId";
            using (var con = new SqlConnection(connectionString))
            using (var updateCommand = new SqlCommand(sql, con))
            {
                updateCommand.Parameters.AddWithValue("@OrderId", int.Parse(hiddenID.Value));
                // assuming the type of the column is bit(boolean)
                updateCommand.Parameters.AddWithValue("@HasBeenShipped", chk.Checked);
                con.Open();
                int updated = updateCommand.ExecuteNonQuery();
            }
        }
    }
}