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
    public partial class Enroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Enroll_btn_Click(object sender, EventArgs e)
        {
            if (UserID_txt.Text.Equals(""))
            {
                Response.Write("Please Enter UserID");
            }
            else if (InstructorID_txt.Text.Equals(""))
            {
                Response.Write("Please Enter Instructor ID");

            }
            else if (CourseID_txt.Text.Equals(""))
            {
                Response.Write("Please Enter Course ID");
            }
            else {
                String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand enroll = new SqlCommand("enrollInCourse", conn);
                enroll.CommandType = System.Data.CommandType.StoredProcedure;
                Int16 sid= Int16.Parse(UserID_txt.Text);
                Int16 cid= Int16.Parse(CourseID_txt.Text);
                Int16 inst= Int16.Parse(InstructorID_txt.Text);
                enroll.Parameters.Add(new SqlParameter("@sid", sid));
                enroll.Parameters.Add(new SqlParameter("@cid", cid));
                enroll.Parameters.Add(new SqlParameter("@instr", inst));
                conn.InfoMessage += new SqlInfoMessageEventHandler(myConnection_InfoMessage);
                conn.Open();
                try
                {
                    enroll.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException exception) {
                    Response.Write("Already Enrolled successfully");
                }
                conn.Close();





            }
        }
        void myConnection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            Response.Write(e.Message);
        }
    }
}