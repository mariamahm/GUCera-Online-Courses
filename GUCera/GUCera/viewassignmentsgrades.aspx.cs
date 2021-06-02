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
    public partial class viewassignmentsgrades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void backtohome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student.aspx");
        }

        protected void viewgrades_Click(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            if (courseid.Text == "" || assignnumber.Text == "" || assigntype.Text == "")
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



            SqlCommand viewAssgrade = new SqlCommand("viewAssignGrades", conn);
            viewAssgrade.CommandType = CommandType.StoredProcedure;
            viewAssgrade.Parameters.Add(new SqlParameter("@cid", courseId));
            viewAssgrade.Parameters.Add(new SqlParameter("@sid", studentid));
            viewAssgrade.Parameters.Add(new SqlParameter("@assignType ", assignt));
            viewAssgrade.Parameters.Add(new SqlParameter("@assignnumber", assignm));
            SqlParameter assigng = viewAssgrade.Parameters.Add(new SqlParameter("@assignGrade", SqlDbType.Int));

            assigng.Direction = ParameterDirection.Output;

            conn.Open();
            //viewAssgrade.ExecuteNonQuery();
            SqlDataReader rdr = viewAssgrade.ExecuteReader(CommandBehavior.CloseConnection);
            Label grade = new Label();
            grade.Text = "grade:" + assigng.Value.ToString() + "<br>";
            form1.Controls.Add(grade);
            
            conn.Close();
        }
    }
}