using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gucera
{
    public partial class viewmycertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewcertificate_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            if (courseid.Text == "" )
            {
                Response.Write("Error! Please fill all fields!");
                return;
            }
            int courseId = Int16.Parse(courseid.Text);
            int studentid = -1;
            try
            {
                studentid = Int16.Parse(Session["users"].ToString());
            }
            catch (NullReferenceException)
            {
                Label n = new Label();
                n.Text = "User is not registered or ID is not visible";
                form1.Controls.Add(n);
            }
            SqlCommand viewcer = new SqlCommand("viewCertificate", conn);
            viewcer.CommandType = CommandType.StoredProcedure;
            viewcer.Parameters.Add(new SqlParameter("@cid", courseId));
            viewcer.Parameters.Add(new SqlParameter("@sid", studentid));
            conn.Open();
           

            SqlDataReader rdr = viewcer.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int sid = rdr.GetInt32(rdr.GetOrdinal("sid"));
                Label StudentID = new Label();
                StudentID.Text = "student id:" +sid.ToString() +"<br>";
                form1.Controls.Add(StudentID);


                int cid = rdr.GetInt32(rdr.GetOrdinal("cid"));
                Label CourseID = new Label();
                CourseID.Text = "course id:"+cid.ToString()+"<br>";
                form1.Controls.Add(CourseID);

                DateTime issueDate= rdr.GetDateTime(rdr.GetOrdinal("issueDate"));
                Label issuedate = new Label();
               issuedate.Text = "issueDate:"+issueDate.ToString()+"<br>";
                form1.Controls.Add(issuedate);

            }
            

        }

        protected void backtohome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student.aspx");
        }
    }
}