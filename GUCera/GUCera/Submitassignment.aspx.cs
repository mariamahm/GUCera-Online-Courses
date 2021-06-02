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
    public partial class Submitassignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void backtohome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student.aspx");

        }

        protected void submitassign_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            if (courseid.Text == "" || assignnumber.Text == "" || assigntype.Text =="")
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
            int assignm = Int16.Parse(assignnumber.Text);
            String assignt = assigntype.Text;
            SqlCommand submitassign = new SqlCommand("submitAssign", conn);
            submitassign.CommandType = CommandType.StoredProcedure;
            submitassign.Parameters.Add(new SqlParameter("@cid", courseId));
            submitassign.Parameters.Add(new SqlParameter("@sid", studentid));
            submitassign.Parameters.Add(new SqlParameter("@assignType ", assignt));
            submitassign.Parameters.Add(new SqlParameter("@assignnumber", assignm));
            conn.InfoMessage += new SqlInfoMessageEventHandler(connection_InfoMessage);
                  void connection_InfoMessage(object send, SqlInfoMessageEventArgs ev){
                Response.Write(ev.Message);
            }
            conn.Open();

         submitassign.ExecuteNonQuery();
           
            conn.Close();
        }
    }
}