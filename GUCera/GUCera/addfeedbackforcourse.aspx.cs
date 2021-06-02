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
    public partial class addfeedbackforcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void feedback_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (courseid.Text == "" || comment.Text == "") {
                Response.Write("Error! Please fill all fields!");
                return;
            }

            int courseId = Int16.Parse(courseid.Text);

            Int16 studentid = -1;
            try
            {
                studentid = Int16.Parse(Session["users"].ToString());
            }
            catch (NullReferenceException exception)
            {
                Label n = new Label();
                n.Text = "User is not registered or ID is not visible";
                form1.Controls.Add(n);
            }
            String comm = comment.Text;
            SqlCommand addfeedbackcourse = new SqlCommand("addFeedback", conn);
            addfeedbackcourse.CommandType = CommandType.StoredProcedure;
            addfeedbackcourse.Parameters.Add(new SqlParameter("@cid", courseId));
            addfeedbackcourse.Parameters.Add(new SqlParameter("@sid", studentid));
            addfeedbackcourse.Parameters.Add(new SqlParameter("@comment", comm));

            conn.InfoMessage += new SqlInfoMessageEventHandler(connection_InfoMessage);

            void connection_InfoMessage(object send, SqlInfoMessageEventArgs ev)
            {
                Response.Write(ev.Message);
            }

            conn.Open();
            addfeedbackcourse.ExecuteNonQuery();
            conn.Close();
        }

        protected void backtohome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student.aspx");

        }
    }
}