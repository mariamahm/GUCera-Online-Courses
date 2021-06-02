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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            Int16 id = -1;
            try
            {
                id = Int16.Parse(Session["users"].ToString());
            }
            catch (NullReferenceException exception) {
                Label n = new Label();
                n.Text = "User is not Registered or ID is not visible";
                form1.Controls.Add(n);
            }
            SqlCommand ViewProfile = new SqlCommand("ViewMyProfile", conn);
            ViewProfile.CommandType = System.Data.CommandType.StoredProcedure;
            ViewProfile.Parameters.Add(new SqlParameter("@id", id));
            conn.Open();
            SqlDataReader rdr = ViewProfile.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (rdr.Read()) {

                String firstname = rdr.GetString(rdr.GetOrdinal("firstName"));
                Label fn = new Label();
                fn.Text = "FirstName: "+firstname + "<br/>";

                String lastName = rdr.GetString(rdr.GetOrdinal("lastName"));
                Label ln = new Label();
                ln.Text = "LastName: "+lastName + "<br/>";


                String password = rdr.GetString(rdr.GetOrdinal("password"));
                Label pass = new Label();
                pass.Text = "Password: "+password+ "<br/>";

                

                String email= rdr.GetString(rdr.GetOrdinal("email"));
                Label em = new Label();
                em.Text = "Email: "+email+ "<br/>";

                String address = rdr.GetString(rdr.GetOrdinal("address"));
                Label add = new Label();
                add.Text ="Address : " +address+"<br/>";
                form1.Controls.Add(fn);
                form1.Controls.Add(ln);
                form1.Controls.Add(pass);
                form1.Controls.Add(em);
                form1.Controls.Add(add);
              

            }

        }
    }
}