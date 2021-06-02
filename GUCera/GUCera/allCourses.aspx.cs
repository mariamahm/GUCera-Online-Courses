using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class allCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand all_courses_proc = new SqlCommand("AdminViewAllCourses", conn);
            all_courses_proc.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            //read row by row from database
            SqlDataReader rdr = all_courses_proc.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName + "<br>";
                form1.Controls.Add(name);
            }
        }
    }
}