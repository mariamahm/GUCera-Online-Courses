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
    public partial class createPromocode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_btn_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String code = code_txt.Text;
            String issueDate = issueDate_txt.Text;
            String expiryDate = expiryDate_txt.Text;
            if (code == "" || issueDate == "" || expiryDate == "" || discount_txt.Text == ""){
                Response.Write("Error! Please fill all fields!");
                return;
            }
            float discount = float.Parse(discount_txt.Text);

            short adminID = -1;
            try
            {
                adminID = short.Parse(Session["users"].ToString());
            }
            catch (NullReferenceException exception) {
                Label n = new Label();
                n.Text = "User is not Registered or ID is not visible";
                form1.Controls.Add(n);
            }
            SqlCommand createPromo_proc = new SqlCommand("AdminCreatePromocode", conn);
            createPromo_proc.CommandType = System.Data.CommandType.StoredProcedure;

            createPromo_proc.Parameters.Add(new SqlParameter("@code", code));
            createPromo_proc.Parameters.Add(new SqlParameter("@isuueDate", issueDate));
            createPromo_proc.Parameters.Add(new SqlParameter("@expiryDate", expiryDate));
            createPromo_proc.Parameters.Add(new SqlParameter("@discount", discount));
            createPromo_proc.Parameters.Add(new SqlParameter("@adminId", adminID));

            conn.InfoMessage += new SqlInfoMessageEventHandler(connection_InfoMessage);

            void connection_InfoMessage(object send, SqlInfoMessageEventArgs ev)
            {
                Response.Write(ev.Message);
            }

            conn.Open();
            try
            {
                createPromo_proc.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
                Response.Write("Promocode Already Exists!");
            }
            conn.Close();
        }
    }
}