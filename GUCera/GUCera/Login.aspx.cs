using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection connection = new SqlConnection(@connStr);
            int id = Int16.Parse(username_txt.Text);
            string password = password_txt.Text;
            


            SqlCommand Loginproc = new SqlCommand("userLogin", connection);
            Loginproc.CommandType = System.Data.CommandType.StoredProcedure;
            Loginproc.Parameters.Add(new SqlParameter("@id", id));
            Loginproc.Parameters.Add(new SqlParameter("@password", password));
            SqlParameter success = Loginproc.Parameters.Add("@success", System.Data.SqlDbType.Int);
            SqlParameter type = Loginproc.Parameters.Add("@type", System.Data.SqlDbType.Int);
            
            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;
            
            
            connection.Open();
            Loginproc.ExecuteNonQuery();
            connection.Close();

            if (success.Value.ToString() == "1")
            {
                Session["users"] = id;
                Int16 type2 = Int16.Parse(type.Value.ToString());
                if (type2 == 0)
                {
                    Response.Redirect("Instructor.aspx");
                }
                else if (type2 == 1)
                {
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    Response.Redirect("Student.aspx");
                }

            }
            else {
                Response.Write("User not Registered");
            }


        }

        protected void addmobile_Click(object sender, EventArgs e)
        {
            if (uidmobile.Text.Equals("") || mobile.Text.Equals(""))
            {
                Response.Write("Please Enter The Full Information To add Mobile Number");
            }
            else {
                string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection connection = new SqlConnection(@connStr);
                int id = Int16.Parse(uidmobile.Text);
                string mobileNumber = mobile.Text;
                SqlCommand Addmobile = new SqlCommand("addMobile", connection);
                Addmobile.CommandType = System.Data.CommandType.StoredProcedure;
                Addmobile.Parameters.Add(new SqlParameter("@id", id));
                Addmobile.Parameters.Add(new SqlParameter("@mobile_number", mobileNumber));
                connection.Open();
                try
                {
                    Addmobile.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException exception)
                {
                    Response.Write("Already Added Successfully");
                    connection.Close();
                }
            }
        }
    }
}