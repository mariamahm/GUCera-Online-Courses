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
    public partial class AddCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CardNumber_txt.Attributes.Add("maxlength","15");
            CVV_txt.Attributes.Add("maxlength", "3");
            CardHolder_txt.Attributes.Add("maxlength", "16");
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            if (CardNumber_txt.Text.Equals("") || CVV_txt.Text.Equals("") || CardHolder_txt.Text.Equals("") || expiryDate_txt.Text.Equals(""))
            {
                Response.Write("Please Enter Full information");
            }
            else
            {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand addcredit = new SqlCommand("addCreditCard", conn);
                addcredit.CommandType = System.Data.CommandType.StoredProcedure;
                Int16 id = Int16.Parse(Session["users"].ToString());
                String number = CardNumber_txt.Text;
                String HolderName = CardHolder_txt.Text;
                Int16 CVV = Int16.Parse(CVV_txt.Text.ToString());
                String ExpiryDate = expiryDate_txt.Text;
                addcredit.Parameters.Add(new SqlParameter("@sid", id));
                addcredit.Parameters.Add(new SqlParameter("@number", number));
                addcredit.Parameters.Add(new SqlParameter("@cardHolderName", HolderName));
                addcredit.Parameters.Add(new SqlParameter("@cvv", CVV));
                addcredit.Parameters.Add(new SqlParameter("@expiryDate", ExpiryDate));
                conn.Open();
                try
                {
                    addcredit.ExecuteNonQuery();
                }
                catch (Exception exception) {
                    Response.Write("Credit Card Already added Successfully");
                }
                    
                    conn.Close();
            }
        }
    }
}