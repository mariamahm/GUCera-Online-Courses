using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class ViewPromocodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(@connStr);
            SqlCommand viewPromo = new SqlCommand("viewPromocode", conn);
            viewPromo.CommandType = System.Data.CommandType.StoredProcedure;
            Int16 id = Int16.Parse(Session["users"].ToString());
            viewPromo.Parameters.Add(new SqlParameter("@sid", id));
            conn.Open();
            SqlDataReader rdr = viewPromo.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (rdr.Read()) {
                Label a = new Label();
                a.Text = "Code: "+rdr.GetString(rdr.GetOrdinal("code"));
                a.Text += "<br/>"+"Issue Date: " + rdr.GetDateTime(rdr.GetOrdinal("isuueDate"));
                a.Text += "<br/>"+"Expiry Date: " + rdr.GetDateTime(rdr.GetOrdinal("expiryDate"));
                a.Text += "<br/>" +"Discount Amount: "+ rdr.GetDecimal(rdr.GetOrdinal("discount"))+"<br/>"+"<br/>";
                form1.Controls.Add(a);
            }


        }
    }
}