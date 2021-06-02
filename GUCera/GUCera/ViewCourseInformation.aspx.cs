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
    public partial class ViewCourseInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand CourseInfo = new SqlCommand("CourseInfo", conn);
            CourseInfo.CommandType = System.Data.CommandType.StoredProcedure;
            String CourseName = Session["cid"].ToString();
            CourseInfo.Parameters.Add(new SqlParameter("@name", CourseName));
            conn.Open();
            SqlDataReader rdr = CourseInfo.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            int i = 0;
            while (rdr.Read()) {
                LinkButton lb = new LinkButton();
                lb.Text = "Course ID: " + rdr.GetInt32(rdr.GetOrdinal("id")) + "<br/>";
                lb.Text += "Course Name: " + rdr.GetString(rdr.GetOrdinal("name")) + "<br/>";
                lb.Text += "Credit Hours: " + rdr.GetInt32(rdr.GetOrdinal("creditHours")) + "<br/>";
                lb.Text += "Price: " + rdr.GetDecimal(rdr.GetOrdinal("price")) + "<br/>";
                try
                {
                    lb.Text += "Content: " + rdr.GetString(rdr.GetOrdinal("content")) + "<br/>";
                }
                catch (Exception exception) { 
                    
                }
                lb.Text += "Instructor id:" +rdr.GetInt32(rdr.GetOrdinal("insid")) + "<br/>";
                lb.Click += new EventHandler(LinkButton_Click);
                form1.Controls.Add(lb);
            }
            
        }
        void LinkButton_Click(Object sender, EventArgs e)
        {
            Response.Redirect("Enroll.aspx");
        }
    }
}