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
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand AvailableCourses = new SqlCommand("availableCourses", conn);
            AvailableCourses.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = AvailableCourses.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Label av = new Label();
            av.Text = "Available Courses are: " + "<br/>";
            form1.Controls.Add(av);
            while (rdr.Read()) {
                LinkButton lb = new LinkButton();
                lb.ID = rdr.GetString(rdr.GetOrdinal("name"));
                lb.Click += new EventHandler(LinkButton_Click);
                lb.Text = "Course Name: " + rdr.GetString(rdr.GetOrdinal("name"))+
                    " Course ID: "+rdr.GetInt32(rdr.GetOrdinal("id"))+"<br/>";
                form1.Controls.Add(lb);
            }
        }
        void LinkButton_Click(Object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)(sender);
            Session["cid"] = btn.ID;
            Response.Redirect("ViewCourseInformation.aspx");
        }
    }
}