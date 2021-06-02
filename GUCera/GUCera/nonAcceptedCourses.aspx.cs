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
    public partial class nonAcceptedCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses_proc = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            courses_proc.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            //read row by row from database
            SqlDataReader rdr = courses_proc.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                LinkButton name = new LinkButton();
                name.Text = courseName+"<br/>";
                name.Click += new EventHandler(accept_btn_Click);
                form1.Controls.Add(name);
                
            }
        }

        protected void accept_btn_Click(object sender, EventArgs e) 
        {
            LinkButton clicked = (LinkButton)sender;

            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String course = clicked.Text.Substring(0,(clicked.Text.Length)-5);
            
            Int16 adminID = -1;
            try
            {
                adminID = Int16.Parse(Session["users"].ToString());
            }
            catch(NullReferenceException exception) {
                Label n = new Label();
                n.Text = "User is not Registered or ID is not visible";
                form1.Controls.Add(n);
            }

            SqlCommand accept_proc = new SqlCommand("accept", conn);
            accept_proc.CommandType = System.Data.CommandType.StoredProcedure;

            accept_proc.Parameters.Add(new SqlParameter("@course", course));
            accept_proc.Parameters.Add(new SqlParameter("@adminID", adminID));
            conn.InfoMessage += new SqlInfoMessageEventHandler(connection_InfoMessage);
            
            conn.Open();
            accept_proc.ExecuteNonQuery();
            conn.Close();
            Session["CourseAccepted"] = "Course Accepted";
            Response.Redirect("Admin.aspx");
           
        }
        void connection_InfoMessage(object send, SqlInfoMessageEventArgs ev)
        {
            Response.Write(ev.Message);
        }

    }
}