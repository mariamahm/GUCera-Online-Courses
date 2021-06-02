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
    public partial class Viewassignmentscontent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }


        protected void viewassigncontentt_Click(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            if (Courseid.Text == "") {
                Response.Write("Please enter a course id");
                return;
            }

            int courseId = Int16.Parse(Courseid.Text);
            Int16 studentid = -1;
            conn.InfoMessage += new SqlInfoMessageEventHandler(myConnection_InfoMessage);
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

            SqlCommand viewAss = new SqlCommand("viewAssign", conn);
            viewAss.CommandType = CommandType.StoredProcedure;
            viewAss.Parameters.Add(new SqlParameter("@CourseId", courseId));
            viewAss.Parameters.Add(new SqlParameter("@Sid", studentid));
            
            conn.Open();


            SqlDataReader rdr = viewAss.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String Content = rdr.GetString(rdr.GetOrdinal("content"));
                Label content = new Label();
                content.Text = "Assignment content:"+ Content + "<br>";
                form1.Controls.Add(content);

                int assNumber = rdr.GetInt32(rdr.GetOrdinal("number"));
                Label assignmentNumber = new Label();
                assignmentNumber.Text = "Assignment number:" + assNumber.ToString()+ "<br>";
                form1.Controls.Add(assignmentNumber);

                String asstype = rdr.GetString(rdr.GetOrdinal("type"));
                Label assignmenttype = new Label();
                assignmenttype.Text = "Assignment type:" + asstype.ToString()+ "<br>";
                form1.Controls.Add(assignmenttype);


            }
            conn.Close();

        }

        private void myConnection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void backtohome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student.aspx");
        }
    }
}